Imports MySql.Data.MySqlClient

Public Class frmsubclase
    Dim conn As New mysqlconn

    Dim texto As String
    Dim datos As New C_Subclase
    Dim tabla As New DataTable
    Public flag As Integer
    Public Sub mostrar(ByVal subclase As C_Subclase)
        datos = subclase
        tidsub.Text = subclase.id_subclase

        tnombre.Text = subclase.nom_subclase


    End Sub


    Private Sub limpiar()
        cclase.Text = ""
        tidsub.Text = ""
        tnombre.Text = ""

    End Sub
    Private Sub frmsubclase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        tabla = conn.consulta("select * from clase where estado_clase=1 order by id_clase")

        For Each row As DataRow In tabla.Rows
            cclase.Items.Add(row("id_clase") & " " & row("nom_clase"))
        Next row
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 And Strings.Len(cclase.Text) Then

            datos.id_clase = sacarclave(cclase.Text)

            datos.nom_subclase = tnombre.Text


            If flag = 1 Then
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmconsultasubclase.consulta()
                    Me.Dispose()

                Else
                    MessageBox.Show("Datos No Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If conn.modificar(datos, datos.id_clase.ToString, datos.id_subclase.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmconsultasubclase.consulta()
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