Imports MySql.Data.MySqlClient

Public Class frmmarca
    Dim conn As New mysqlconn
    Dim texto As String
    Dim datos As New C_Marca
    Dim tabla As New DataTable
    Public flag As Integer
    Public Sub mostrar(ByVal marca As C_Marca)
        datos = marca
        tid.Text = marca.id_marca
        tnombre.Text = marca.nom_marca


    End Sub


    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""

    End Sub
    Private Sub frmmarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        limpiar()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 Then
            datos.nom_marca = tnombre.Text


            If flag = 1 Then
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmconsultamarca.consulta()
                    Me.Dispose()

                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                If conn.modificar(datos, datos.id_marca.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmconsultamarca.consulta()
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