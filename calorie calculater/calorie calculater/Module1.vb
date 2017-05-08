Imports System.Data.OleDb
Module Module1

    Public con As New OleDbConnection
    Public cmd As New OleDbCommand
    Public dr As OleDbDataReader
    Sub connect()
        con.Close()

        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\calorie calculater\calorie calculater.mdb;Persist Security Info=True;Jet OLEDB:Database Password=calorie"
    End Sub
End Module
