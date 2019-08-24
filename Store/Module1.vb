Imports System.Data.Odbc
Module Module1
    Public conn As OdbcConnection = New OdbcConnection
    Public cmd As OdbcCommand = New OdbcCommand
    Public dr As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public str As String
    Sub koneksi()
        str = "driver={MySQL ODBC 3.51 Driver};database=lks;server=localhost;uid=root"
        conn = New OdbcConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
