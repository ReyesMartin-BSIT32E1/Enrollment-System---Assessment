Imports System.Data.OleDb

Module Database
    Public cn As New OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader


    Public da As OleDbDataAdapter
    Public ds As DataSet

    Public sql As String

    Public Sub connection(database_name)
        cn.Close()
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\" & database_name & ".accdb"
        cn.Open()
    End Sub
    Public Function QueryData(line) As OleDbDataReader
        cmd = New OleDbCommand(line, cn)
        Return cmd.ExecuteReader
    End Function
    Public Sub ManipulateData(line)
        cmd = New OleDbCommand(line, cn)
        cmd.ExecuteNonQuery()
    End Sub


End Module
