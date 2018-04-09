Imports MySql.Data.MySqlClient

Public Class frmitems
    Dim conn As New mysqlconn
    Dim texto As String
    Dim datos As New C_Item
    Dim tabla As New DataTable
    Public flag As Integer

    Private Sub combos()
        tabla.Clear()
        tabla = conn.consulta("select * from clase order by id_clase")

        For Each row As DataRow In tabla.Rows
            tclase.Items.Add(row("id_clase") & " " & row("nom_clase"))
        Next row

        tabla.Clear()
        tabla = conn.consulta("select * from marca order by id_marca")

        For Each row As DataRow In tabla.Rows
            tmarca.Items.Add(row("id_marca") & " " & row("nom_marca"))
        Next row

        tabla.Clear()
        tabla = conn.consulta("select * from linea order by id_linea")

        For Each row As DataRow In tabla.Rows
            tlinea.Items.Add(row("id_linea") & " " & row("nom_linea"))
        Next row

        tabla.Clear()
        tabla = conn.consulta("select * from umedida order by id_umed")

        For Each row As DataRow In tabla.Rows
            tmedida.Items.Add(row("id_umed") & " " & row("corto_umed"))
        Next row
    End Sub

    Private Sub combosubclase()
        tabla.Clear()
        tabla = conn.consulta("select * from subclase where id_clase='" & sacarclave(tclase.Text) & "' order by id_clase,id_subclase")

        tsubclase.Items.Clear()

        For Each row As DataRow In tabla.Rows
            tsubclase.Items.Add(row("id_subclase") & " " & row("nom_subclase"))
        Next row
    End Sub

    Private Sub combosubmarca()
        tabla.Clear()
        tabla = conn.consulta("select * from submarca where id_marca='" & sacarclave(tmarca.Text) & "' order by id_marca,id_submarca")
        tsubmarca.Items.Clear()
        tmotor.Items.Clear()

        For Each row As DataRow In tabla.Rows
            tsubmarca.Items.Add(row("id_submarca") & " " & row("nom_submarca"))
        Next row
    End Sub

    Private Sub combomotor()
        tabla.Clear()
        tabla = conn.consulta("select * from motor where id_marca='" & sacarclave(tmarca.Text) & "' and id_submarca='" & sacarclave(tsubmarca.Text) & "' order by id_marca,id_submarca,id_motor")
        tmotor.Items.Clear()
        For Each row As DataRow In tabla.Rows
            tmotor.Items.Add(row("id_motor") & " " & row("tipom"))
        Next row
    End Sub
    Public Sub mostrar(ByVal item As C_Item)
        datos = item
        tid.Text = item.id_item
        tclave.Text = item.clave_item
        tnombre.Text = item.nombre_item
        ttipo.Text = item.tipo_item

        tstock.Text = item.stock_item
        tmin.Text = item.min_item
        tmax.Text = item.max_item
        tgarantia.Text = item.garantia_item
        tcosto.Text = item.costo_item
        tprecio.Text = item.precio_item

    End Sub
    Private Sub limpiar()
        tid.Text = ""
        tclave.Text = ""
        tnombre.Text = ""
        ttipo.Text = ""
        tlinea.Text = ""
        tclase.Text = ""
        tsubclase.Text = ""
        tmarca.Text = ""
        tsubmarca.Text = ""
        tmotor.Text = ""
        tmedida.Text = ""

        tstock.Text = "0"
        tmin.Text = ""
        tmax.Text = ""
        tgarantia.Text = ""
        tcosto.Text = ""
        tprecio.Text = ""
    End Sub

    Private Sub frmitems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        combos
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click


        If conn.buscarclave("select * from item where clave_item='" & tclave.Text & "'", "clave_item", tclave.Text) = True Then
            MessageBox.Show("La Clave del Item ya existe", "Clave Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else


            datos.clave_item = tclave.Text
            datos.nombre_item = tnombre.Text
            datos.tipo_item = ttipo.Text
            datos.id_linea = sacarclave(tlinea.Text)
            datos.id_clase = sacarclave(tclase.Text)
            datos.id_subclase = sacarclave(tsubclase.Text)
            datos.id_marca = sacarclave(tmarca.Text)
            datos.id_submarca = sacarclave(tsubmarca.Text)
            datos.id_motor = sacarclave(tmotor.Text)
            datos.id_umed = sacarclave(tmedida.Text)
            datos.stock_item = tstock.Text
            datos.min_item = tmin.Text
            datos.max_item = tmax.Text
            datos.garantia_item = tgarantia.Text
            datos.costo_item = tcosto.Text
            datos.precio_item = tprecio.Text


            If flag = 1 Then
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados")
                    frmconsultaitem.consulta()
                    Me.Dispose()

                Else
                    MessageBox.Show("Datos No Guardados")
                End If
            Else
                If conn.modificar(datos, datos.id_item.ToString) Then
                    MessageBox.Show("Datos Guardados")
                    frmconsultaitem.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados")
                End If
            End If
        End If
    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub tclase_Click(sender As Object, e As EventArgs) Handles tclase.Click
        combosubclase()
    End Sub

    Private Sub tclase_MouseClick(sender As Object, e As MouseEventArgs) Handles tclase.MouseClick
        combosubclase()
    End Sub

    Private Sub tclase_TextChanged(sender As Object, e As EventArgs) Handles tclase.TextChanged
        combosubclase()
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
    'motor
    Private Sub tsubmarca_Click(sender As Object, e As EventArgs) Handles tsubmarca.Click
        combomotor()
    End Sub

    Private Sub tsubmarca_MouseClick(sender As Object, e As MouseEventArgs) Handles tsubmarca.MouseClick
        combomotor()
    End Sub

    Private Sub tsubmarca_TextChanged(sender As Object, e As EventArgs) Handles tsubmarca.TextChanged
        combomotor()
    End Sub

    Private Sub tmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tmin.KeyPress
        solonumeros(sender, e)
    End Sub

    Private Sub tmax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tmax.KeyPress
        solonumeros(sender, e)
    End Sub
    Private Sub tcosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcosto.KeyPress
        solonumeros(sender, e)
    End Sub

    Private Sub tprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tprecio.KeyPress
        solonumeros(sender, e)
    End Sub

    Private Sub tgarantia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tgarantia.KeyPress
        solonumeros(sender, e)
    End Sub


    Private Sub ttipo_Click(sender As Object, e As EventArgs) Handles ttipo.Click
        If ttipo.Text = "SERVICIO" Then
            tstock.Text = "0"
            tmin.Text = "0"
            tmax.Text = "0"
            tmin.Enabled = False
            tmax.Enabled = False
        Else
            tmin.Enabled = True
            tmax.Enabled = True
        End If
    End Sub

    Private Sub ttipo_MouseClick(sender As Object, e As MouseEventArgs) Handles ttipo.MouseClick
        If ttipo.Text = "SERVICIO" Then
            tstock.Text = "0"
            tmin.Text = "0"
            tmax.Text = "0"
            tmin.Enabled = False
            tmax.Enabled = False
        Else
            tmin.Enabled = True
            tmax.Enabled = True
        End If
    End Sub

    Private Sub ttipo_TextChanged(sender As Object, e As EventArgs) Handles ttipo.TextChanged
        If ttipo.Text = "SERVICIO" Then
            tstock.Text = "0"
            tmin.Text = "0"
            tmax.Text = "0"
            tmin.Enabled = False
            tmax.Enabled = False
        Else
            tmin.Enabled = True
            tmax.Enabled = True
        End If
    End Sub


End Class