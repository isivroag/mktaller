Imports MySql.Data.MySqlClient

Public Class frmconsultaorden
    Dim conn As New mysqlconn
    Dim texto As String

    Dim tabla As New DataTable
    Public flag As Integer
    Public orden As String
    Dim sql As String

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn.consulta(grdatos, "select * from vresumenorden order by recepcion_ord")
        formatogrid()
    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ORDEN"
        grdatos.Columns(1).HeaderText = "FECHA INGRESO"
        grdatos.Columns(2).HeaderText = "ID_VEHICULO"
        grdatos.Columns(3).HeaderText = "PLACA"
        grdatos.Columns(4).HeaderText = "VEHICULO"
        grdatos.Columns(5).HeaderText = "ID_CLIENTE"
        grdatos.Columns(6).HeaderText = "CLIENTE"
        grdatos.Columns(7).HeaderText = "DESCRIPCION"
        grdatos.Columns(8).HeaderText = "TOTAL"
        grdatos.Columns(9).HeaderText = "SALDO"
        grdatos.Columns(10).HeaderText = "ESTADO"
        grdatos.Columns(11).HeaderText = "FECHA DE ENTREGA"

        grdatos.AutoResizeColumns()

        grdatos.Columns(2).Visible = False
        grdatos.Columns(5).Visible = False


    End Sub
    Private Sub frmconsultaorden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)
    End Sub

    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmordenser.Show()
        frmordenser.nuevo()

    End Sub

    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click

    End Sub

    Private Sub mncELIMINAR_Click(sender As Object, e As EventArgs) Handles mncELIMINAR.Click

    End Sub
    Sub exportarexcel()
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            Dim NCol As Integer = grdatos.ColumnCount
            Dim NRow As Integer = grdatos.RowCount
            Dim xlcenter As Integer = -4108

            exHoja.Range("a1:k1").Merge()
            exHoja.Range("a1:k1").HorizontalAlignment = xlcenter
            exHoja.Range("a2:k2").Merge()
            exHoja.Range("a2:k2").HorizontalAlignment = xlcenter
            exHoja.Range("a3:k3").Merge()
            exHoja.Range("a3:k3").HorizontalAlignment = xlcenter
            exHoja.Range("a1:k3").BorderAround()

            exHoja.Cells.Item(1) = "SISTEMA MK-TALLER"


            'exHoja.Cells.Item(1, 4) = "Sistema de Cobranza"
            exHoja.Cells.Item(2, 1) = "LISTAD DE VEHICULOS"
            exHoja.Cells.Item(3, 1) = "FECHA:" & DateString

            exHoja.Cells.Item(4, 1) = "ID"
            exHoja.Cells.Item(4, 2) = "PLACA"
            exHoja.Cells.Item(4, 3) = "MARCA"
            exHoja.Cells.Item(4, 4) = "SUBMARCA / MODELO"
            exHoja.Cells.Item(4, 5) = "No.SERIE"
            exHoja.Cells.Item(4, 6) = "No.CHASIS"
            exHoja.Cells.Item(4, 7) = "AÑO"
            exHoja.Cells.Item(4, 8) = "COLOR"
            exHoja.Cells.Item(4, 9) = "No.MOTOR"
            exHoja.Cells.Item(4, 10) = "GASOLINA"
            exHoja.Cells.Item(4, 11) = "OBSERVACIONES"
            exHoja.Cells.Item(4, 12) = "TIPO"


            Dim cn As Integer = 1, tiposinformes As Integer = 0
            Dim posicion As Integer = 3
            Dim fila As Integer
            For fila = 0 To NRow - 1
                For col As Integer = 0 To NCol - 1
                    If col <> 11 And col <> 12 Then
                        exHoja.Cells.Item(fila + 5, col + cn) = grdatos.Rows(fila).Cells(col).Value
                    End If
                Next
            Next
            exHoja.Rows.Item(1).font.bold = 1
            exHoja.Rows.Item(2).font.bold = 1
            exHoja.Rows.Item(3).font.bold = 1
            exHoja.Rows.Item(1).font.size = 16
            exHoja.Rows.Item(2).font.size = 10
            exHoja.Rows.Item(3).font.size = 10
            exHoja.Rows.Item(4).font.size = 12
            exHoja.Range("A1:K" & fila).EntireColumn.AutoFit()





            exHoja.Rows.Item(4).font.bold = 6
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al Exportar a Excel")

        End Try
    End Sub
    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        exportarexcel()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Select Case clista.Text
            Case "PLACA"
                sql = "select vehiculo.*,cliente.nombre_clie from vehiculo join cliente on vehiculo.cliente_id_clie= cliente.id_clie where vehiculo.estado_veh =1 and vehiculo.placa_veh Like '%" & tdato.Text & "%' order by vehiculo.id_veh"
            Case "MARCA"
                sql = "select vehiculo.*,cliente.nombre_clie from vehiculo join cliente on vehiculo.cliente_id_clie= cliente.id_clie where vehiculo.estado_veh =1 and vehiculo.marca_veh Like '%" & tdato.Text & "%' order by vehiculo.id_veh"
            Case "SUBMARCA"
                sql = "select vehiculo.*,cliente.nombre_clie from vehiculo join cliente on vehiculo.cliente_id_clie= cliente.id_clie where vehiculo.estado_veh =1 and vehiculo.submarca_veh Like '%" & tdato.Text & "%' order by vehiculo.id_veh"
            Case "SERIE"
                sql = "select vehiculo.*,cliente.nombre_clie from vehiculo join cliente on vehiculo.cliente_id_clie= cliente.id_clie where vehiculo.estado_veh =1 and vehiculo.serie_veh Like '%" & tdato.Text & "%' order by vehiculo.id_veh"
            Case "CHAIS"
                sql = "select vehiculo.*,cliente.nombre_clie from vehiculo join cliente on vehiculo.cliente_id_clie= cliente.id_clie where vehiculo.estado_veh =1 and vehiculo.chasis_veh Like '%" & tdato.Text & "%' order by vehiculo.id_veh"
            Case "AÑO"
                sql = "select vehiculo.*,cliente.nombre_clie from vehiculo join cliente on vehiculo.cliente_id_clie= cliente.id_clie where vehiculo.estado_veh =1 and vehiculo.año_veh Like '%" & tdato.Text & "%' order by vehiculo.id_veh"
            Case "COLOR"
                sql = "select vehiculo.*,cliente.nombre_clie from vehiculo join cliente on vehiculo.cliente_id_clie= cliente.id_clie where vehiculo.estado_veh =1 and vehiculo.color_veh Like '%" & tdato.Text & "%' order by vehiculo.id_veh"
            Case "MOTOR"
                sql = "select vehiculo.*,cliente.nombre_clie from vehiculo join cliente on vehiculo.cliente_id_clie= cliente.id_clie where vehiculo.estado_veh =1 and vehiculo.motor_veh Like '%" & tdato.Text & "%' order by vehiculo.id_veh"
            Case "CLIENTE"
                sql = "select vehiculo.*,cliente.nombre_clie from vehiculo join cliente on vehiculo.cliente_id_clie= cliente.id_clie where vehiculo.estado_veh =1 and cliente.nombre_clie Like '%" & tdato.Text & "%' order by vehiculo.id_veh"
            Case Else
                sql = "select vehiculo.*,cliente.nombre_clie from vehiculo join cliente on vehiculo.cliente_id_clie= cliente.id_clie where vehiculo.estado_veh =1 order by vehiculo.id_veh"


        End Select
        conn.consulta(grdatos, sql)
        formatogrid()
    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub

    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick
        frmordenser.StartPosition = FormStartPosition.CenterScreen
        frmordenser.Show()
        frmordenser.folio = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(0).Value)
        frmordenser.buscarorden


    End Sub
End Class