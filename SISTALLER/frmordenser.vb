Imports MySql.Data.MySqlClient
Imports System.Math

Public Class frmordenser
    Dim conn As New mysqlconn
    Dim conn2 As New mysqlconn
    Dim texto As String
    Dim auxorden As C_Auxorden
    Dim orden As C_Orden
    Public vehiculo As String
    Dim cliente As String
    Dim detalle As New C_Detalleorden

    'Dim orden As New C_Orden

    Dim tabla As New DataTable
    Dim tablagrid As New DataTable

    Public flag As Integer

    Dim BANDERA As Boolean = False
    Dim BANDERA2 As Boolean = False

    Dim g As Graphics
    Dim ph As New Drawing2D.GraphicsPath(Drawing2D.FillMode.Alternate)
    Dim p As New Pen(Brushes.Red, 5)

    Dim g2 As Graphics
    Dim ph2 As New Drawing2D.GraphicsPath(Drawing2D.FillMode.Alternate)
    Dim p2 As New Pen(Brushes.Red, 5)

    Public folio As String
    Dim fila As Integer
    Dim registro As New C_Detalleorden
    Dim detcont As Integer



    Public Sub buscarorden()
        tabla.Clear()
        conn = New mysqlconn
        tabla = conn.consulta("select * from orden where id_ord='" & folio & "'")

        If tabla.Rows.Count > 0 Then
            tfolio.Text = Convert.ToString(tabla.Rows(0).Item("id_ord"))
            vehiculo = Convert.ToString(tabla.Rows(0).Item("id_veh"))
            tkm.Text = Convert.ToString(tabla.Rows(0).Item("km_ord"))
            ttipo.Text = Convert.ToString(tabla.Rows(0).Item("tipo_ord"))
            testado.Text = Convert.ToString(tabla.Rows(0).Item("edo_ord"))
            trecepcion.Value = Convert.ToString(tabla.Rows(0).Item("recepcion_ord"))
            tentrega.Value = Convert.ToString(tabla.Rows(0).Item("entrega_ord"))
            tdes.Text = Convert.ToString(tabla.Rows(0).Item("des_ord"))
            tnotas.Text = Convert.ToString(tabla.Rows(0).Item("notas_ord"))
            tsubtotal.Text = Convert.ToString(tabla.Rows(0).Item("subtotal"))
            tiva.Text = Convert.ToString(tabla.Rows(0).Item("iva"))
            ttotal.Text = Convert.ToString(tabla.Rows(0).Item("total"))
            tletras.Text = EnLetras(Convert.ToDecimal(ttotal.Text))
            ttotal.Text = FormatCurrency(ttotal.Text, 2)
            tiva.Text = FormatCurrency(tiva.Text, 2)
            tsubtotal.Text = FormatCurrency(tsubtotal.Text, 2)
        End If
        buscarvehiculoid()

        conn = New mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from auxorden where id_ord='" & folio & "'")
        If tabla.Rows.Count > 0 Then
            tencendedor.Checked = tabla.Rows(0).Item("encendedor")
            testereo.Checked = tabla.Rows(0).Item("estereo")
            tcenicero.Checked = tabla.Rows(0).Item("cenicero")
            tcentral.Checked = tabla.Rows(0).Item("esprcentral")
            tderecho.Checked = tabla.Rows(0).Item("esprderecho")
            therramienta.Checked = tabla.Rows(0).Item("herramienta")
            ttapete.Checked = tabla.Rows(0).Item("tapetes")
            teqseguridad.Checked = tabla.Rows(0).Item("eqseguridad")
            ttapongas.Checked = tabla.Rows(0).Item("tapongas")
            tllanta.Checked = tabla.Rows(0).Item("llantarep")
            tizquierdo.Checked = tabla.Rows(0).Item("esprizquierdo")
            tlimpiadores.Checked = tabla.Rows(0).Item("limpiadores")
            tmolduras.Checked = tabla.Rows(0).Item("molduras")
            ttapones.Checked = tabla.Rows(0).Item("tapones")
            tantena.Checked = tabla.Rows(0).Item("antena")
            tdocumento.Checked = tabla.Rows(0).Item("documentos")
            imagen.Image = Bytes_Imagen(tabla.Rows(0).Item("imagen"))
            imagen2.Image = Bytes_Imagen(tabla.Rows(0).Item("imagen2"))
        End If



        grdatos.Columns.Clear()

        Dim sql As String
        sql = "select detalleorden.id_ord,detalleorden.id_item,item.clave_item,item.nombre_item,detalleorden.cant_item,detalleorden.id_umed ,umedida.nom_umed,detalleorden.total,detalleorden.tipo from detalleorden join item on detalleorden.id_item =item.id_item join umedida on detalleorden.id_umed = umedida.id_umed where detalleorden.id_ord='" & folio & "'order by detalleorden.id_reg "
        conn = New mysqlconn
        conn.consulta(grdatos, sql)
        formato()
    End Sub
    Public Sub buscarvehiculoid()
        tabla.Clear()
        conn = New mysqlconn
        tabla = conn.consultar_reg("Select vehiculo.*, cliente.nombre_clie from vehiculo join cliente on vehiculo.cliente_id_clie= cliente.id_clie where vehiculo.estado_veh =1 And vehiculo.id_veh='" & vehiculo & "' order by vehiculo.id_veh")
        If tabla.Rows.Count > 0 Then
            tcliente.Text = Convert.ToString(tabla.Rows(0).Item("nombre_clie"))

            tplaca.Text = Convert.ToString(tabla.Rows(0).Item("placa_veh"))
            tvehiculo.Text = Convert.ToString(tabla.Rows(0).Item("marca_veh")) & "-" & Convert.ToString(tabla.Rows(0).Item("submarca_veh")) & "-MOTOR-" & Convert.ToString(tabla.Rows(0).Item("tipom_veh")) & "-" & Convert.ToString(tabla.Rows(0).Item("año_veh")) & "-" & Convert.ToString(tabla.Rows(0).Item("color_veh"))
            cliente = Convert.ToString(tabla.Rows(0).Item("cliente_id_clie"))


        Else
            MessageBox.Show("Vehiculo No encontrado", "DATOS NO ENCONTRADOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tplaca.Text = ""
            tvehiculo.Text = ""
            tcliente.Text = ""
            cliente = ""
            vehiculo = ""
        End If
    End Sub
    Public Sub buscarvehiculo()
        tabla.Clear()
        tabla = conn.consultar_reg("select vehiculo.*,cliente.nombre_clie from vehiculo join cliente on vehiculo.cliente_id_clie= cliente.id_clie where vehiculo.estado_veh =1 and vehiculo.placa_veh='" & tplaca.Text & "' order by vehiculo.id_veh")
        If tabla.Rows.Count > 0 Then
            tcliente.Text = Convert.ToString(tabla.Rows(0).Item("nombre_clie"))

            tplaca.Text = Convert.ToString(tabla.Rows(0).Item("placa_veh"))
            tvehiculo.Text = Convert.ToString(tabla.Rows(0).Item("marca_veh")) & "-" & Convert.ToString(tabla.Rows(0).Item("submarca_veh")) & "-MOTOR-" & Convert.ToString(tabla.Rows(0).Item("tipom_veh")) & "-" & Convert.ToString(tabla.Rows(0).Item("año_veh")) & "-" & Convert.ToString(tabla.Rows(0).Item("color_veh"))
            cliente = Convert.ToString(tabla.Rows(0).Item("cliente_id_clie"))
            vehiculo = Convert.ToString(tabla.Rows(0).Item("id_veh"))

        Else
            MessageBox.Show("Vehiculo No encontrado", "DATOS NO ENCONTRADOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tplaca.Text = ""
            tvehiculo.Text = ""
            tcliente.Text = ""
            cliente = ""
            vehiculo = ""
        End If
    End Sub


    Private Sub imagen_MouseMove(sender As Object, e As MouseEventArgs) Handles imagen.MouseMove
        If BANDERA = True Then
            ph.AddEllipse(e.X, e.Y, 2, 2)
            g.DrawPath(p, ph)
            imagen.Refresh()
        End If
    End Sub


    Private Sub imagen2_MouseMove(sender As Object, e As MouseEventArgs) Handles imagen2.MouseMove
        If BANDERA2 = True Then
            ph2.AddEllipse(e.X, e.Y, 2, 2)
            g2.DrawPath(p2, ph2)
            imagen2.Refresh()
        End If
    End Sub
    Private Sub imagen2_MouseUp(sender As Object, e As MouseEventArgs) Handles imagen2.MouseUp

        BANDERA2 = False
    End Sub

    Private Sub imagen2_MouseDown(sender As Object, e As MouseEventArgs) Handles imagen2.MouseDown
        BANDERA2 = True
    End Sub
    Private Sub imagen_MouseUp(sender As Object, e As MouseEventArgs) Handles imagen.MouseUp
        BANDERA = False
    End Sub

    Private Sub imagen_MouseDown(sender As Object, e As MouseEventArgs) Handles imagen.MouseDown
        BANDERA = True
    End Sub

    Private Sub tplaca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tplaca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            buscarvehiculo()
        End If
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tplaca.Text) = 0 Or Strings.Len(ttipo.Text) = 0 Or Strings.Len(testado.Text) = 0 Or Strings.Len(tkm.Text) = 0 Or grdatos.RowCount = 0 Then
            MessageBox.Show("Faltan Datos, Registre los Datos Obligatorios", "informacion Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If flag = 1 Then
            guardarorden()
            If conn.insertarnuevo(orden) Then
                tfolio.Text = conn.Obtener_ID("select MAX(id_ord) as max_id FROM orden")
                guardarauxorden()
                If conn.insertarnuevo(auxorden) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Los Detalles No Fueron Registados", "Detalle No Registrado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
                guardardetalle
            Else
                MessageBox.Show("La Orden No Fue Registrada", "Orden No Registrada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        End If

    End Sub
    Private Sub guardarorden()
        orden = New C_Orden
        orden.id_veh = vehiculo
        orden.fecha_ord = Format(Now.Date, "yyyy-MM-dd")
        orden.km_ord = tkm.Text
        orden.tipo_ord = ttipo.Text
        orden.edo_ord = testado.Text
        orden.recepcion_ord = trecepcion.Value
        orden.entrega_ord = tentrega.Value
        orden.des_ord = tdes.Text
        orden.notas_ord = tnotas.Text
        orden.subtotal = tsubtotal.Text
        orden.iva = tiva.Text
        orden.total = ttotal.Text
        orden.saldo = ttotal.Text
    End Sub
    Private Sub guardarauxorden()
        auxorden = New C_Auxorden

        auxorden.id_ord = tfolio.Text
        auxorden.encendedor = tencendedor.Checked
        auxorden.estereo = testereo.Checked
        auxorden.cenicero = tcenicero.Checked
        auxorden.esprcentral = tcentral.Checked
        auxorden.esprrerecho = tderecho.Checked
        auxorden.herramienta = therramienta.Checked
        auxorden.tapetes = ttapete.Checked
        auxorden.eqseguridad = teqseguridad.Checked
        auxorden.tapongas = ttapongas.Checked
        auxorden.llantaref = tllanta.Checked
        auxorden.esprizquierdo = tizquierdo.Checked
        auxorden.limpiadores = tlimpiadores.Checked
        auxorden.molduras = tmolduras.Checked
        auxorden.tapones = ttapones.Checked
        auxorden.antena = tantena.Checked
        auxorden.documentos = tdocumento.Checked
        auxorden.imagen = Imagen_Bytes(imagen.Image)
        auxorden.imagen2 = Imagen_Bytes(imagen2.Image)

    End Sub

    Private Sub frmordenser_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        g = Graphics.FromImage(Me.imagen.Image)
        g2 = Graphics.FromImage(Me.imagen2.Image)
        ExtendedMethods.DoubleBuffered(grdatos, True)
        formato()
    End Sub

    Private Sub formato()

        grdatos.Columns(0).HeaderText = "ID_ORDEN"
        grdatos.Columns(1).HeaderText = "ID_ITEM"
        grdatos.Columns(2).HeaderText = "CLAVE"
        grdatos.Columns(3).HeaderText = "PRODUCTO/SERVICIO"
        grdatos.Columns(4).HeaderText = "CANT"
        grdatos.Columns(5).HeaderText = "ID_UMED"
        grdatos.Columns(6).HeaderText = "UNIDAD"
        grdatos.Columns(7).HeaderText = "TOTAL"
        grdatos.Columns(8).HeaderText = "TIPO"

        grdatos.AutoResizeColumns()

        grdatos.Columns(0).Visible = False
        grdatos.Columns(1).Visible = False
        grdatos.Columns(5).Visible = False
        grdatos.Columns(8).Visible = False

        With grdatos.ColumnHeadersDefaultCellStyle
            '.BackColor = Color.Navy
            '.ForeColor = Color.White
            '.Font = New Font(dataGridView1.Font, FontStyle.Bold)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With


    End Sub

    Public Sub agregar(ByVal detalle As C_Detalleorden)
        Dim valor As String = Convert.ToString(detalle.id_item)
        Dim UltimaFila As Integer
        UltimaFila = grdatos.Rows.Count - 1

        For Each row As DataGridViewRow In grdatos.Rows

            If Convert.ToString(row.Cells(1).Value) = valor Then
                MessageBox.Show("El Item ya ha sido agregado al detalle", "Datos duplicados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
        Next

        grdatos.VirtualMode = False
        grdatos.Rows.Add("0", detalle.id_item.ToString, detalle.clave_item, detalle.item.ToString, detalle.cant_item.ToString, detalle.id_umed.ToString, detalle.medida.ToString, detalle.total_detalle.ToString, detalle.tipo)

        'grdatos.Rows.Add()
        'fila = grdatos.Rows.Count - 1
        'grdatos.Item(fila, 1).Value = detalle.id_item

        'grdatos.Item(1, fila).Value = detalle.item
        'grdatos.Item(1, fila).Value = detalle.cant_item
        'grdatos.Item(1, fila).Value = detalle.id_umed
        'grdatos.Item(1, fila).Value = detalle.medida
        'grdatos.Item(1, fila).Value = detalle.total_detalle
        formato()
        sumartotal()
    End Sub



    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        nuevo()
    End Sub
    Public Sub nuevo()
        flag = 1
        limpiar()

        f1.Enabled = True
        f2.Enabled = True
        f3.Enabled = True
        f4.Enabled = True
    End Sub
    Private Sub limpiar()
        imagen.Image = My.Resources.orden
        imagen2.Image = My.Resources.Gasolina
        ph2.Reset()
        ph.Reset()
        g = Graphics.FromImage(Me.imagen.Image)
        g2 = Graphics.FromImage(Me.imagen2.Image)

        tfolio.Text = ""
        tplaca.Text = ""
        tvehiculo.Text = ""
        tcliente.Text = ""
        tkm.Text = ""
        ttipo.Text = ""
        testado.Text = ""

        trecepcion.Value = Date.Now
        tentrega.Value = Date.Now
        tnotas.Text = ""
        tdes.Text = ""
        tletras.Text = ""
        tsubtotal.Text = "0.00"
        tiva.Text = "0.00"
        ttotal.Text = "0.00"


        tencendedor.Checked = False
        testereo.Checked = False
        tcenicero.Checked = False
        tcentral.Checked = False
        tderecho.Checked = False
        therramienta.Checked = False
        ttapete.Checked = False
        teqseguridad.Checked = False
        ttapongas.Checked = False
        tllanta.Checked = False
        tizquierdo.Checked = False
        tlimpiadores.Checked = False
        tmolduras.Checked = False
        ttapones.Checked = False
        tantena.Checked = False
        tdocumento.Checked = False

        grdatos.DataSource = Nothing
        grdatos.ColumnCount = 9
        formato()



    End Sub


    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        imagen.Image = My.Resources.orden

        ph.Reset()

        g = Graphics.FromImage(Me.imagen.Image)


    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        imagen2.Image = My.Resources.Gasolina
        ph2.Reset()

        g2 = Graphics.FromImage(Me.imagen2.Image)
    End Sub

    Private Sub tfolio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tfolio.KeyPress
        If Asc(e.KeyChar) = 13 Then
            folio = tfolio.Text
            buscarorden()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmconsultaitem.Show()
        frmconsultaitem.flag = 3
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If grdatos.Rows.Count > 0 Then
            grdatos.Rows.Remove(grdatos.CurrentRow())
        End If
        sumartotal()
    End Sub
    Private Sub sumartotal()
        Dim suma As Double = 0
        For Each row As DataGridViewRow In grdatos.Rows

            suma += Convert.ToDouble(row.Cells(7).Value)

        Next
        ttotal.Text = suma
        tsubtotal.Text = round(suma / 1.16, 2)
        tiva.Text = Convert.ToDouble(ttotal.Text) - Convert.ToDouble(tsubtotal.Text)
        tletras.Text = EnLetras(ttotal.Text)
        ttotal.Text = FormatCurrency(ttotal.Text, 2)
        tiva.Text = FormatCurrency(tiva.Text, 2)
        tsubtotal.Text = FormatCurrency(tsubtotal.Text, 2)


    End Sub

    Private Sub guardardetalle()

        detcont = 0
        For Each row As DataGridViewRow In grdatos.Rows

            registro.id_ord = tfolio.Text
            registro.id_item = row.Cells(1).Value
            registro.cant_item = row.Cells(4).Value
            registro.id_umed = row.Cells(5).Value
            registro.total_detalle = row.Cells(7).Value
            registro.tipo = row.Cells(8).Value

            If conn.insertarnuevo(registro) = True Then
                detcont += 1
            End If

            If row.Cells(8).Value = "PRODUCTO" Then
                Dim movimiento As New C_Movimiento
                Dim final As Double
                Dim inicial As Double

                inicial = conn.Obtener_Inicial("select stock_item as cantidad from item where id_item='" & row.Cells(1).Value & "'")
                final = inicial - row.Cells(4).Value

                movimiento.id_item = row.Cells(1).Value
                movimiento.id_umed = row.Cells(5).Value
                movimiento.ini_mov = inicial
                movimiento.fin_mov = final
                movimiento.cant_mov = row.Cells(4).Value
                movimiento.fecha_mov = Format(Now.Date, "yyyy-MM-dd")
                movimiento.tipo_mov = 4
                movimiento.obs_mov = "VENTA EN LA ORDEN CON FOLIO " & tfolio.Text
                conn.insertarmov(movimiento)
                conn.actualizaritem(row.Cells(1).Value, final)
            End If


        Next
        MessageBox.Show(detcont.ToString & " Registros fueron guardados", "Detalle de Orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmconsultavehiculo.Show()
        frmconsultavehiculo.flag = 2

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmconsultacliente.Show()
        frmconsultacliente.flag = 3

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmvehiculo.Show()
        frmvehiculo.flag = 1
        frmvehiculo.flagnveh = 2
    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub

    Private Sub tfolio_TextChanged(sender As Object, e As EventArgs) Handles tfolio.TextChanged

    End Sub

    Private Sub tplaca_TextChanged(sender As Object, e As EventArgs) Handles tplaca.TextChanged

    End Sub
End Class