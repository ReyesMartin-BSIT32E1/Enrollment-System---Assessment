Public Class frmAssessment
    Private Sub btnAssessStudent_Click(sender As Object, e As EventArgs) Handles btnAssessStudent.Click
        frmStudents.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnEnrolledStudent_Click(sender As Object, e As EventArgs) Handles btnEnrolledStudent.Click
        frmEnrolledStudent.ShowDialog()
    End Sub

    Private Sub frmAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection("CES_Database")
    End Sub
End Class