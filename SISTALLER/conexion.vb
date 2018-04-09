Imports MySql.Data.MySqlClient
Imports System.Data
Public Class conexion
    Private MysqlCommand As New MySqlCommand
    Dim MysqlConnString As String = "server=localhost; Uid=root; Pwd=tecniem;database=mktaller"
    Public conn As MySqlConnection = New MySqlConnection(MysqlConnString)

    Public Sub Probarconexion()
        Try
            conn.Open()
            MsgBox("La conexión fue exitosa")
            conn.Close()
        Catch ex As Exception
            MsgBox("La conexión no fue exitosa")
        End Try
    End Sub

    Public Function consulta(ByVal Tabla As DataGridView, ByVal Sql As String) As DataTable
        Tabla.DataSource = Nothing
        Dim da As New MySqlDataAdapter(Sql, conn)
        Dim ta As New DataTable
        Try
            conn.Open()
            da.Fill(ta)
            Tabla.DataSource = ta
            conn.Close()
        Catch ex As Exception
            MsgBox("La conexión no fue exitosa")
        End Try
        Return ta
    End Function


End Class
