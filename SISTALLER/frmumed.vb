Imports MySql.Data.MySqlClient
Public Class frmumed
    Dim conn As New mysqlconn
    Dim texto As String
    Dim datos As New C_Umed
    Dim tabla As New DataTable
    Public flag As Integer
    Public Sub mostrar(ByVal medida As C_Umed)
        datos = medida
        tid.Text = medida.id_umed
        tnombre.Text = medida.nom_umed
        tcorto.Text = medida.corto_umed


    End Sub


    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""
        tcorto.Text = ""

    End Sub
    Private Sub frmumed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 And Strings.Len(tcorto.Text) > 0 Then
            datos.nom_umed = tnombre.Text
            datos.corto_umed = tcorto.Text


            If flag = 1 Then
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmconsultaumed.consulta()
                    Me.Dispose()

                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                If conn.modificar(datos, datos.id_umed.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmconsultaumed.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Private Sub tcorto_LostFocus(sender As Object, e As EventArgs) Handles tcorto.LostFocus
        tcorto.Text = UCase(tcorto.Text)
    End Sub
End Class