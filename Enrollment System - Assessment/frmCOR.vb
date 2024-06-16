Imports System.Collections.Specialized.BitVector32
Imports System.Drawing.Printing

Public Class frmCOR
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmCOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection("CES_Database")
        txtStudentNo.Text = frmEnrolledStudent.selected_student.Cells(1).Value
        txtFullname.Text = frmEnrolledStudent.selected_student.Cells(2).Value
        txtDepartment.Text = frmEnrolledStudent.selected_student.Cells(8).Value
        txtCourse.Text = frmEnrolledStudent.selected_student.Cells(7).Value
        txtSY.Text = frmEnrolledStudent.selected_student.Cells(5).Value
        txtSemester.Text = frmEnrolledStudent.selected_student.Cells(6).Value
        txtSection.Text = frmEnrolledStudent.selected_student.Cells(9).Value
        load_numbers()
        load_table()
        dgvFee_Changed()
    End Sub
    Private Sub load_table()
        Dim subjects = QueryData("Select * From qrySubject Where [Section] = '" & txtSection.Text & "'")
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
        dgvAssessment.ClearSelection()
        Dim assessment_info = QueryData("Select AssessmentID from tblAssessment Where StudentID = '" & frmEnrolledStudent.selected_student.Cells(0).Value & "'")
        assessment_info.Read()
        Dim fees = QueryData("Select * from tblFee where AssessmentID = '" & assessment_info("AssessmentID").ToString & "'")
        dgvFee.Rows.Clear()
        While fees.Read()
            Dim row = New DataGridViewRow
            row.CreateCells(dgvFee)
            row.Cells(0).Value = fees("Fee").ToString
            row.Cells(1).Value = fees("FeeAmount").ToString
            dgvFee.Rows.Add(row)
        End While
        dgvFee.ClearSelection()
    End Sub
    Private Sub load_numbers()
        Dim assessment_info = QueryData("Select * from tblAssessment Where StudentID = '" & frmEnrolledStudent.selected_student.Cells(0).Value & "'")
        assessment_info.Read()
        Dim transaction_info = QueryData("Select * from tblTransactions Where StudentID = '" & frmEnrolledStudent.selected_student.Cells(0).Value & "' Order By DateTime Desc")
        transaction_info.Read()
        Dim payment_method = transaction_info("PaymentMethod").ToString
        Dim payment_amount = transaction_info("PaymentAmount").ToString
        Dim discount = assessment_info("Discount").ToString
        Dim final_price = Convert.ToDouble(assessment_info("FullPayment").ToString)
        lblTuitionFee.Text = final_price - Convert.ToDouble(lblMiscFee.Text) - Convert.ToDouble(lblInstallmentFee.Text)
        lblDiscount.Text = discount
        lblPaymentMethod.Text = payment_method
        lblAmountPaid.Text = payment_amount
        Dim undiscounted_total = IIf(lblPaymentMethod.Text = "Full Payment", final_price - Convert.ToDouble(lblInstallmentFee.Text), final_price)
        lblTotal.Text = undiscounted_total - undiscounted_total * (Convert.ToDouble(lblDiscount.Text) / 100)
    End Sub
    Private Sub dgvFee_Changed()
        Dim total = 0
        For Each row As DataGridViewRow In dgvFee.Rows
            total += row.Cells(1).Value
        Next
        lblMiscFee.Text = total
    End Sub
    Dim g, mg As Graphics
    Dim bmp As Bitmap

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
        e.Graphics.FillRectangle(SystemBrushes.Control, 760, 290, 130, 50)
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        g = CreateGraphics()
        bmp = New Bitmap(Size.Width, Size.Height, g)
        mg = Graphics.FromImage(bmp)
        mg.CopyFromScreen(Location.X + 10, Location.Y + 85, 0, 0, New Drawing.Size(Size.Width - 20, Size.Height - 95))
        bmp = New Bitmap(bmp, New Size(bmp.Size.Width * 0.75, bmp.Size.Height * 0.75))
        Dim paper = New PaperSize("form_size", bmp.Size.Width + 25, bmp.Size.Height - 50)
        PrintDocument1.DefaultPageSettings.PaperSize = paper
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class