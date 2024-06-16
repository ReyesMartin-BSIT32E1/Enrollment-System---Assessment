Imports System.Security.Principal

Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text
        Dim account = QueryData("Select * From tblUsers where Username = '" & username & "' And Password = '" & password & "'")
        If account.Read Then
            frmAssessment.ShowDialog()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection("CES_Database")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
