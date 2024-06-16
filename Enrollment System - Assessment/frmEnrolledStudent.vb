Public Class frmEnrolledStudent
    Public selected_student As DataGridViewRow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub dgvListofStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListofStudents.CellClick
        If dgvListofStudents.Rows.Count = 0 Then Return
        selected_student = dgvListofStudents.Rows(dgvListofStudents.SelectedCells(0).RowIndex)
        frmCOR.ShowDialog()
    End Sub
    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection("CES_Database")
        load_table("")
    End Sub
    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        load_table(txtSearch.Text)
    End Sub
    Private Sub load_table(filter As String)
        dgvListofStudents.Rows.Clear()
        Dim students = QueryData("Select * From qryStudent Where Status = 'Enrolled'")
        While students.Read()
            Dim name = students("LName").ToString & " " & students("FName").ToString & " " & students("MI").ToString
            If Not String.IsNullOrWhiteSpace(filter) And Not name.ToLower().Contains(filter.ToLower) Then
                Continue While
            End If
            Dim row = New DataGridViewRow
            row.CreateCells(dgvListofStudents)
            row.Cells(0).Value = students("StudentID").ToString
            row.Cells(1).Value = students("StudentNo").ToString
            row.Cells(2).Value = name
            row.Cells(3).Value = students("ContactNo").ToString
            row.Cells(4).Value = students("BDate").ToString
            row.Cells(5).Value = students("SchoolYear").ToString
            row.Cells(6).Value = students("Semester").ToString
            row.Cells(7).Value = students("Course").ToString
            row.Cells(8).Value = students("Department").ToString
            row.Cells(9).Value = students("Section").ToString
            row.Cells(10).Value = students("Status").ToString
            dgvListofStudents.Rows.Add(row)
        End While
    End Sub
End Class