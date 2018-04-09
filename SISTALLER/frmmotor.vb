Imports MySql.Data.MySqlClient

Public Class frmmotor
    Dim conn As New mysqlconn

    Dim texto As String
    Dim datos As New C_Motor
    Dim tabla As New DataTable
    Public flag As Integer

    Private Sub combosubmarca()
        csubmarca.Items.Clear()
        tabla.Clear()
        tabla = conn.consulta("select * from submarca where id_marca='" & sacarclave(cmarca.Text) & "'and estado_submarca=1 order by id_submarca")

        For Each row As DataRow In tabla.Rows
            csubmarca.Items.Add(row("id_submarca") & " " & row("nom_submarca"))
        Next row
    End Sub



    Public Sub mostrar(ByVal motor As C_Motor)
        datos = motor
        tid.Text = motor.id_motor

        tnombre.Text = motor.tipom

    End Sub
    Private Sub limpiar()
        cmarca.Text = ""
        csubmarca.Text = ""
        tid.Text = ""
        tnombre.Text = ""

    End Sub
    Private Sub frmmotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        tabla.Clear()
        tabla = conn.consulta("select * from marca where estado_marca=1 order by id_marca")

        For Each row As DataRow In tabla.Rows
            cmarca.Items.Add(row("id_marca") & " " & row("nom_marca"))
        Next row


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 And Strings.Len(cmarca.Text) And Strings.Len(csubmarca.Text) Then

            datos.id_marca = sacarclave(cmarca.Text)
            datos.id_submarca = sacarclave(csubmarca.Text)

            datos.tipom = tnombre.Text


            If flag = 1 Then
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmconsultamotor.consulta()
                    Me.Dispose()

                Else
                    MessageBox.Show("Datos No Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If conn.modificar(datos, datos.id_marca.ToString, datos.id_submarca.ToString, datos.id_motor.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmconsultamotor.consulta()
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

    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs) 
        tnombre.Text = UCase(tnombre.Text)
    End Sub

    Private Sub cmarca_Click(sender As Object, e As EventArgs) Handles cmarca.Click
        combosubmarca()
    End Sub

    Private Sub cmarca_MouseClick(sender As Object, e As MouseEventArgs) Handles cmarca.MouseClick
        combosubmarca()
    End Sub

    Private Sub cmarca_Paint(sender As Object, e As PaintEventArgs) Handles cmarca.Paint
        combosubmarca()
    End Sub

    Private Sub cmarca_TextChanged(sender As Object, e As EventArgs) Handles cmarca.TextChanged
        combosubmarca()
    End Sub
End Class