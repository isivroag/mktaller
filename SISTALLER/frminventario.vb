Imports MySql.Data.MySqlClient

Public Class frminventario
    Dim conn As New mysqlconn
    Dim texto As String
    Public producto As New C_Item
    Public medida As String
    Public movimiento As New C_Movimiento
    Dim tabla As New DataTable

    Public Sub consulta()
        grdatos.Columns.Clear()

        conn.consulta(grdatos, "select movimiento.id_tipomov,tipomov.tipomov,movimiento.fecha_mov,movimiento.ini_mov,movimiento.cant_mov,movimiento.id_umed,umedida.corto_umed,movimiento.fin_mov,movimiento.obs_mov from movimiento join umedida on movimiento.id_umed=umedida.id_umed join tipomov on movimiento.id_tipomov=tipomov.id_tipomov where movimiento.id_item='" & producto.id_item.ToString & "' order by movimiento.id_mov")


        formatogrid()
    End Sub
    Private Sub frminventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ExtendedMethods.DoubleBuffered(grdatos, True)

    End Sub
    Public Sub mostrarp(ByVal dato As C_Item)
        producto = dato
        tid.Text = dato.id_item
        tclave.Text = dato.clave_item
        tnombre.Text = dato.nombre_item
        tcant.Text = dato.stock_item
        tmin.Text = dato.min_item
        tmax.Text = dato.max_item
        lmedida.Text = medida
        consulta()

    End Sub
    Private Sub formatogrid()

        grdatos.Columns(0).HeaderText = "ID_TIPOMOV"
        grdatos.Columns(1).HeaderText = "TIPO"
        grdatos.Columns(2).HeaderText = "FECHA"

        grdatos.Columns(3).HeaderText = "INV INI"
        grdatos.Columns(4).HeaderText = "CANTIDAD"
        grdatos.Columns(5).HeaderText = "ID UMED"
        grdatos.Columns(6).HeaderText = "UNIDAD"
        grdatos.Columns(7).HeaderText = "INV FIN"
        grdatos.Columns(8).HeaderText = "OBSERVACIONES"

        grdatos.AutoResizeColumns()
        'grdatos.Columns(0).Width = 50
        'grdatos.Columns(1).Width = 300
        grdatos.Columns(0).Visible = False
        grdatos.Columns(5).Visible = False


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmconsultaitem.Show()
        frmconsultaitem.flag = 2

    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmauxinventario.Show()
        frmauxinventario.producto = producto
        frmauxinventario.medida = medida
        frmauxinventario.tunidad.Text = producto.id_umed & " " & medida
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub menuclientes_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menuclientes.ItemClicked

    End Sub
End Class