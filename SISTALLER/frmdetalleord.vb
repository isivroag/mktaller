Imports MySql.Data.MySqlClient
Public Class frmdetalleord
    Dim conn As New mysqlconn
    Dim texto As String
    Public producto As New C_Item
    Public detalle As New C_Detalleorden
    Public medida As String
    Dim tabla As New DataTable

    Public tipo As String
    Public Sub mostrarp(ByVal dato As C_Item)
        producto = dato
        tid.Text = dato.id_item
        tclave.Text = dato.clave_item
        tnombre.Text = dato.nombre_item
        texistencias.Text = dato.stock_item
        tprecio.Text = dato.precio_item
        tcant.Text = "0.00"
        ttotal.Text = "0.00"

        lmedida.Text = medida
        lmedida2.Text = medida



    End Sub



    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub


    Private Sub tcant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcant.KeyPress
        solonumeros(sender, e)

    End Sub
    Private Sub calcular()
        ttotal.Text = Convert.ToDouble(tcant.Text) * Convert.ToDouble(tprecio.Text)
    End Sub



    Private Sub tprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tprecio.KeyPress
        solonumeros(sender, e)
    End Sub

    Private Sub tcant_LostFocus(sender As Object, e As EventArgs) Handles tcant.LostFocus
        calcular()
    End Sub

    Private Sub tprecio_LostFocus(sender As Object, e As EventArgs) Handles tprecio.LostFocus
        calcular()
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If tipo = "PRODUCTO" Then
            If tcant.Text > texistencias.Text Then
                MessageBox.Show("No Existen Suficientes Productos", "Inventario Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        detalle.id_item = tid.Text
        detalle.clave_item = tclave.Text
        detalle.item = tnombre.Text
        detalle.id_umed = producto.id_umed
        detalle.medida = medida
        detalle.cant_item = tcant.Text
        detalle.total_detalle = ttotal.Text
        detalle.tipo = tipo

        frmordenser.agregar(detalle)
        Dispose()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class