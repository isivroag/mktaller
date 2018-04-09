Imports MySql.Data.MySqlClient

Public Class frmsubmarca

    Dim conn As New mysqlconn

    Dim texto As String
    Dim datos As New C_Submarca
    Dim tabla As New DataTable
    Public flag As Integer
    Public Sub mostrar(ByVal submarca As C_Submarca)
        datos = submarca
        tidsub.Text = submarca.id_submarca

        tnombre.Text = submarca.nom_submarca


    End Sub


    Private Sub limpiar()
        cmarca.Text = ""
        tidsub.Text = ""
        tnombre.Text = ""

    End Sub
    Private Sub frmsubmarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        tabla = conn.consulta("select * from marca where estado_marca=1 order by id_marca")

        For Each row As DataRow In tabla.Rows
            cmarca.Items.Add(row("id_marca") & " " & row("nom_marca"))
        Next row




    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bguardar.Click

        If Strings.Len(tnombre.Text) > 0 And Strings.Len(cmarca.Text) Then
            datos.id_marca = sacarclave(cmarca.Text)

            datos.nom_submarca = tnombre.Text


            If flag = 1 Then
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmconsultasubmarca.consulta()
                    Me.Dispose()

                Else
                    MessageBox.Show("Datos No Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If conn.modificar(datos, datos.id_marca.ToString, datos.id_submarca.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmconsultasubmarca.consulta()
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