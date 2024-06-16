Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.Text.RegularExpressions

Public Class frmStudentAssessment
    Private discount As Double = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub frmStudentAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection("CES_Database")
        txtStudentNo.Text = frmStudents.selected_student.Cells(1).Value
        txtFullname.Text = frmStudents.selected_student.Cells(2).Value
        load_dropbox()
    End Sub
    Private Sub load_dropbox()
        dpDepartment.Clear()
        Dim departments = QueryData("Select Department From tblDepartment")
        While departments.Read
            If departments(0).ToString = "" Then Continue While
            dpDepartment.AddItem(departments(0).ToString)
        End While
        dpSY.Clear()
        Dim school_year = QueryData("Select SchoolYear From tblSY")
        While school_year.Read
            If school_year(0).ToString = "" Then Continue While
            dpSY.AddItem(school_year(0).ToString)
        End While
    End Sub
    Private Sub dpDepartment_onItemSelected(sender As Object, e As EventArgs) Handles dpDepartment.onItemSelected
        dpCourse.Clear()
        Dim course = QueryData("Select Course From qryCourse Where Department = '" & dpDepartment.selectedValue & "'")
        While course.Read
            If course(0).ToString = "" Then Continue While
            dpCourse.AddItem(course(0).ToString)
        End While
        dpSection.Clear()
        dgvAssessment.Rows.Clear()
        lblTuitionFee.Text = 0
    End Sub
    Private Sub dpCourse_onItemSelected(sender As Object, e As EventArgs) Handles dpCourse.onItemSelected
        dpSection.Clear()
        Dim section = QueryData("Select [Section] From qrySections Where [Course] = '" & dpCourse.selectedValue & "'")
        While section.Read
            If section(0).ToString = "" Then Continue While
            dpSection.AddItem(section(0).ToString)
        End While
        dgvAssessment.Rows.Clear()
        lblTuitionFee.Text = 0
    End Sub
    Private Sub dpSection_onItemSelected(sender As Object, e As EventArgs) Handles dpSection.onItemSelected
        Dim subjects = QueryData("Select * From qrySubject Where [Section] = '" & dpSection.selectedValue & "'")
        dgvAssessment.Rows.Clear()
        While subjects.Read()
            Dim row = New DataGridViewRow
            row.CreateCells(dgvAssessment)
            row.Cells(0).Value = subjects("SectionID").ToString
            row.Cells(1).Value = subjects("Section").ToString
            row.Cells(2).Value = subjects("SubjectCode").ToString
            row.Cells(3).Value = subjects("Subject").ToString
            row.Cells(4).Value = subjects("Units").ToString
            dgvAssessment.Rows.Add(row)
        End While
        lblTuitionFee.Text = 2400 * dgvAssessment.Rows.Count
    End Sub
    Private Sub dgvFee_Changed(sender As Object, e As EventArgs) Handles dgvFee.RowsAdded, dgvFee.RowsRemoved, dgvFee.CellValueChanged
        Dim total = 0
        For Each row As DataGridViewRow In dgvFee.Rows
            total += row.Cells(1).Value
        Next
        lblMiscFee.Text = total
        Call lblTuitionFee_TextChanged(e, e)
    End Sub
    Private Sub lblTuitionFee_TextChanged(sender As Object, e As EventArgs) Handles lblTuitionFee.TextChanged
        Dim discount = IIf(rb0.Checked, 1, IIf(rb20.Checked, 0.8, IIf(rb30.Checked, 0.7, IIf(rb40.Checked, 0.6, IIf(rb50.Checked, 0.5, 0)))))
        lblTotal.Text = (((Convert.ToDouble(lblTuitionFee.Text) * discount) + Convert.ToDouble(lblMiscFee.Text) + Convert.ToDouble(lblInstallmentFee.Text)))
        lblFullpayment.Text = (((Convert.ToDouble(lblTuitionFee.Text) * discount) + Convert.ToDouble(lblMiscFee.Text)))
        lblUponEnrollment.Text = 5000
        If Convert.ToDouble(lblUponEnrollment.Text) < 5000 Then
            set_quarter_fee(0)
        Else
            set_quarter_fee((Convert.ToDouble(lblTotal.Text) - Convert.ToDouble(lblUponEnrollment.Text)) / 4)
        End If
    End Sub

    Private Sub set_quarter_fee(fee)
        If fee < 0 Then fee = 0
        lblPrelim.Text = fee
        lblMidterm.Text = fee
        lblPreFinal.Text = fee
        lblFinal.Text = fee
    End Sub

    Private Sub rb_CheckedChanged(sender As Object, e As EventArgs) Handles rb0.CheckedChanged, rb20.CheckedChanged, rb30.CheckedChanged, rb40.CheckedChanged, rb50.CheckedChanged, rb100.CheckedChanged
        If lblTuitionFee.Text = "" Or lblMiscFee.Text = "" Or lblInstallmentFee.Text = "" Then Return
        Call lblTuitionFee_TextChanged(e, e)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If (dpDepartment.selectedIndex = -1 Or dpCourse.selectedIndex = -1 Or dpSY.selectedIndex = -1 Or dpSection.selectedIndex = -1) Then
            MsgBox("Missing Input Fields")
            Return
        End If
        assess_student()
        assessment()
        frmStudents.load_table("")
        print()
        Me.Close()
    End Sub
    Private Sub assess_student()
        Dim getter = QueryData("Select SYID from tblSY where SchoolYear = '" & dpSY.selectedValue & "'")
        getter.Read()
        Dim school_year_id = getter(0).ToString
        getter = QueryData("Select CourseID from tblCourse where Course = '" & dpCourse.selectedValue & "'")
        getter.Read()
        Dim course_id = getter(0).ToString
        getter = QueryData("Select [SectionID] from tblSection where [Section] = '" & dpSection.selectedValue & "'")
        getter.Read()
        Dim section_id = getter(0).ToString
        ManipulateData("Update tblStudents Set SYID = '" & school_year_id & "', CourseID = '" & course_id & "', SectionID = '" & section_id & "', Status = 'To Pay' Where StudentNo = '" & txtStudentNo.Text & "'")
    End Sub
    Private Sub assessment()
        Dim assessment_id = generate_id("tblAssessment", "AssessmentID", "A")
        Dim student_id = frmStudents.selected_student.Cells(0).Value
        Dim final_price = Convert.ToDouble(lblTuitionFee.Text) + Convert.ToDouble(lblMiscFee.Text) + Convert.ToDouble(lblInstallmentFee.Text)
        Dim discount = IIf(rb0.Checked, 0, IIf(rb20.Checked, 20, IIf(rb30.Checked, 30, IIf(rb40.Checked, 40, IIf(rb50.Checked, 50, 100)))))
        Dim prelim = lblPrelim.Text
        Dim midterm = lblMidterm.Text
        Dim prefinal = lblPreFinal.Text
        Dim final = lblFinal.Text
        ManipulateData("Insert Into tblAssessment Values ('" & assessment_id & "','" & student_id & "','" & final_price & "','" & discount & "','" & final_price & "','" & prelim & "','" & midterm & "','" & prefinal & "','" & final & "',false,false,false,false,false)")
        fees(assessment_id)
    End Sub
    Private Sub fees(assessment_id)
        For Each fee As DataGridViewRow In dgvFee.Rows
            Dim fee_id = generate_id("tblFee", "FeeID", "F")
            ManipulateData("Insert Into tblFee Values ('" & fee_id & "','" & assessment_id & "','" & fee.Cells(0).Value & "','" & fee.Cells(1).Value & "')")
        Next
    End Sub
    Private Function generate_id(table, id, text)
        Dim getter = QueryData("Select " & id & " From " & table & " Order By " & id)
        Dim gen_id = 0
        While getter.Read()
            If gen_id = RemoveNonNumeric(getter(0).ToString) - 1000 Then
                gen_id += 1
            End If
        End While
        gen_id += 1000
        Return text & gen_id
    End Function
    Function RemoveNonNumeric(input As String) As String
        Dim regex As New Regex("[^0-9]")
        Dim numericString As String = regex.Replace(input, "")
        numericString = numericString.TrimStart("0"c)
        Return numericString
    End Function
    Dim g, mg As Graphics
    Dim bmp As Bitmap
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
        e.Graphics.FillRectangle(SystemBrushes.Control, 720, 450, 210, 50)
    End Sub

    Private Sub btnAddFee_Click(sender As Object, e As EventArgs) Handles btnAddFee.Click
        frmMiscFee.ShowDialog()
    End Sub

    Private Sub dgvFee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFee.CellClick
        If dgvFee.Rows.Count = 0 Then Return
        Dim result As MsgBoxResult = MsgBox("Delete Fee?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            dgvFee.Rows.Remove(dgvFee.Rows(dgvFee.SelectedCells(0).RowIndex))
        End If
    End Sub

    Private Sub print()
        g = CreateGraphics()
        bmp = New Bitmap(Size.Width, Size.Height, g)
        mg = Graphics.FromImage(bmp)
        mg.CopyFromScreen(Location.X + 10, Location.Y + 95, 0, 0, New Drawing.Size(Size.Width - 20, Size.Height - 95))
        bmp = New Bitmap(bmp, New Size(bmp.Size.Width * 0.75, bmp.Size.Height * 0.75))
        Dim paper = New PaperSize("form_size", bmp.Size.Width + 25, bmp.Size.Height - 50)
        PrintDocument1.DefaultPageSettings.PaperSize = paper
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class