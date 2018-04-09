Imports MySql.Data.MySqlClient
Public Class frmlinea
    Dim conn As New mysqlconn
    Dim texto As String
    Dim datos As New C_Linea
    Dim tabla As New DataTable
    Public flag As Integer
    Public Sub mostrar(ByVal linea As C_Linea)
        datos = linea
        tid.Text = linea.id_linea
        tnombre.Text = linea.nom_linea


    End Sub


    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""

    End Sub
    Private Sub frmlinea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bguardar.Click

        If Strings.Len(tnombre.Text) > 0 Then
            datos.nom_linea = tnombre.Text


            If flag = 1 Then
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmconsultalinea.consulta()
                    Me.Dispose()

                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                If conn.modificar(datos, datos.id_linea.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmconsultalinea.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("¡Verifique Sus Datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs) Handles tnombre.LostFocus
        tnombre.Text = UCase(tnombre.Text)
    End Sub
End Class