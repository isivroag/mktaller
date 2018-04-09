Imports MySql.Data.MySqlClient

Public Class frmvehiculo
    Dim conn As New mysqlconn
    Dim texto As String
    Dim datos As New C_Vehiculo
    Dim tabla As New DataTable
    Dim tablatipo As New DataTable
    Dim tablaclie As New DataTable
    Dim tablamarca As New DataTable
    Dim tablasubmarca As New DataTable
    Public flagnveh As Integer
    Public flag As Integer
    Public id_clie As String
    Public nombre_clie As String
    Public Sub buscar_clie()

        tcliente.Text = id_clie.ToString & " " & nombre_clie.ToString

    End Sub
    Public Sub mostrar(ByVal veh As C_Vehiculo)
        datos = veh
        tid.Text = datos.id_veh
        tplaca.Text = datos.placa_veh
        tmarca.Text = datos.id_marca & " " & datos.marca_veh
        tsubmarca.Text = datos.id_submarca & " " & datos.submarca_veh
        tserie.Text = datos.serie_veh
        taño.Text = datos.año_veh
        tcolor.Text = datos.color_veh
        tmotor.Text = datos.motor_veh
        tgasolina.Text = datos.gasolina_veh
        tobs.Text = datos.obs_veh
        ttipom.Text = datos.id_motor & " " & datos.tipom_veh
        'ttipo.ValueMember = datos.tipo_veh.ToString

        ttipo.Text = datos.id_tipo_veh & " " & datos.tipo_veh

    End Sub
    Public Sub limpiar()

        tid.Text = ""
        tplaca.Text = ""
        tmarca.Text = ""
        tsubmarca.Text = ""
        tserie.Text = ""
        taño.Text = ""
        tcolor.Text = ""
        tmotor.Text = ""
        tgasolina.Text = ""
        tobs.Text = ""
        ttipo.Text = ""
        tcliente.Text = ""
        ttipom.Text = ""

    End Sub
    Private Sub combos()
        tablatipo = conn.consulta("select * from tipo_veh order by id_tipo_veh")

        For Each row As DataRow In tablatipo.Rows
            ttipo.Items.Add(row("id_tipo_veh") & " " & row("nombre_tipo_veh"))
        Next row



        tablamarca = conn.consulta("select * from marca where estado_marca=1 order by id_marca")

        For Each row As DataRow In tablamarca.Rows
            tmarca.Items.Add(row("id_marca") & " " & row("nom_marca"))
        Next row
        comboclie()
    End Sub
    Public Sub comboclie()
        tablaclie.Clear()
        tablaclie = conn.consulta("select * from cliente order by id_clie")
        tcliente.Items.Clear()
        For Each row As DataRow In tablaclie.Rows
            tcliente.Items.Add(row("id_clie") & " " & row("nombre_clie"))
        Next row
    End Sub

    Public Sub agregarcombo()
        tcliente.Items.Add(id_clie.ToString & " " & nombre_clie.ToString)
        tcliente.Text = id_clie.ToString & " " & nombre_clie.ToString
    End Sub
    Private Sub combosubmarca()
        tsubmarca.Items.Clear()
        tablasubmarca.Clear()
        tablasubmarca = conn.consulta("select * from submarca where id_marca='" & sacarclave(tmarca.Text) & "'and estado_submarca=1 order by id_submarca")

        For Each row As DataRow In tablasubmarca.Rows
            tsubmarca.Items.Add(row("id_submarca") & " " & row("nom_submarca"))
        Next row
    End Sub

    Private Sub combomotor()
        ttipom.Items.Clear()
        tabla.Clear()
        tabla = conn.consulta("select * from motor where id_marca='" & sacarclave(tmarca.Text) & "'and id_submarca='" & sacarclave(tsubmarca.Text) & "' and estado_motor=1 order by id_motor")

        For Each row As DataRow In tabla.Rows
            ttipom.Items.Add(row("id_motor") & " " & row("tipom"))
        Next row
    End Sub
    Private Sub frmvehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        combos()
        'ttipo.DataSource = tablatipo
        'ttipo.DisplayMember = tablatipo.Columns("nombre_tipo_veh").Caption.ToString
        'ttipo.ValueMember = tablatipo.Columns("id_tipo_veh").Caption.ToString
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tplaca.Text) > 0 And Strings.Len(tmarca.Text) > 0 And Strings.Len(tsubmarca.Text) > 0 And Strings.Len(ttipom.Text) > 0 And
                Strings.Len(taño.Text) > 0 And Strings.Len(tcolor.Text) > 0 And Strings.Len(ttipo.Text) > 0 And Strings.Len(tcliente.Text) > 0 And Strings.Len(tserie.Text) > 0 Then

            If Strings.Len(tserie.Text) <> 17 Then
                MessageBox.Show("El Numero de Serie debe ser de 17 caracteres, favor de verificarlo", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
            datos.placa_veh = tplaca.Text
            datos.id_marca = sacarclave(tmarca.Text)

            datos.marca_veh = Mid(tmarca.Text, Len(sacarclave(tmarca.Text)) + 2, Len(tmarca.Text) - Len(sacarclave(tmarca.Text)) + 1)
            datos.id_submarca = sacarclave(tsubmarca.Text)

            datos.submarca_veh = Mid(tsubmarca.Text, Len(sacarclave(tsubmarca.Text)) + 2, Len(tsubmarca.Text) - Len(sacarclave(tsubmarca.Text)) + 1)

            datos.serie_veh = tserie.Text
            datos.año_veh = taño.Text
            datos.color_veh = tcolor.Text
            datos.motor_veh = tmotor.Text
            datos.gasolina_veh = tgasolina.Text
            datos.obs_veh = tobs.Text

            datos.id_tipo_veh = sacarclave(ttipo.Text)

            datos.tipo_veh = Mid(ttipo.Text, Len(sacarclave(ttipo.Text)) + 2, Len(ttipo.Text) - Len(sacarclave(ttipo.Text)) + 1)
            If Strings.Len(ttipom.Text) > 0 Then
                datos.id_motor = sacarclave(ttipom.Text)
                datos.tipom_veh = Mid(ttipom.Text, Len(sacarclave(ttipom.Text)) + 2, Len(ttipom.Text) - Len(sacarclave(ttipom.Text)) + 1)
            End If

            datos.cliente_id_clie = sacarclave(tcliente.Text)


            If flag = 1 Then

                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Select Case flagnveh
                        Case 1
                            frmconsultavehiculo.consulta()

                        Case 2
                            tid.Text = conn.Obtener_ID("select MAX(id_veh) as max_id FROM vehiculo")
                            frmordenser.vehiculo = tid.Text
                            frmordenser.buscarvehiculoid()

                    End Select
                    Me.Dispose()

                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                If conn.modificar(datos, datos.id_veh.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmconsultavehiculo.consulta()
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmconsultacliente.Show()
        frmconsultacliente.flag = 2
    End Sub

    Private Sub tmarca_Click(sender As Object, e As EventArgs) Handles tmarca.Click
        combosubmarca()
    End Sub

    Private Sub tmarca_MouseClick(sender As Object, e As MouseEventArgs) Handles tmarca.MouseClick
        combosubmarca()
    End Sub
    Private Sub tmarca_TextChanged(sender As Object, e As EventArgs) Handles tmarca.TextChanged
        combosubmarca()
    End Sub

    Private Sub tsubmarca_Click(sender As Object, e As EventArgs) Handles tsubmarca.Click
        combomotor()
    End Sub

    Private Sub tsubmarca_MouseClick(sender As Object, e As MouseEventArgs) Handles tsubmarca.MouseClick
        combomotor()
    End Sub

    Private Sub tsubmarca_TextChanged(sender As Object, e As EventArgs) Handles tsubmarca.TextChanged
        combomotor()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub tserie_TextChanged(sender As Object, e As EventArgs) Handles tserie.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub tmarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tmarca.SelectedIndexChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub tsubmarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tsubmarca.SelectedIndexChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmcliente.Show()
        frmcliente.flag = 3

    End Sub

    Private Sub tcliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcliente.SelectedIndexChanged

    End Sub
End Class
