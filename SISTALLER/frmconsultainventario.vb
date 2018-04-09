Imports MySql.Data.MySqlClient
Public Class frmconsultainventario
    Dim conn As New mysqlconn
    Dim sql As String
    Dim tabla As New DataTable
    Public flag As Integer
    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        sql = "select item.id_item,item.clave_item,item.nombre_item,item.tipo_item,item.stock_item, " _
                & "item.id_umed,umedida.corto_umed,item.costo_item,item.precio_item, (item.stock_item * item.costo_item) as totcosto, " _
                & "(item.stock_item * item.precio_item) as totvta, " _
                & "(item.stock_item * item.precio_item)-(item.stock_item * item.costo_item)  as totutilidad " _
                & "from item join umedida on item.id_umed = umedida.id_umed " _
                & "where item.estado_item=1 and item.tipo_item='PRODUCTO' order by item.id_item"

        conn.consulta(grdatos, sql)
        formatogrid()
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

            exHoja.Range("a1:J1").Merge()
            exHoja.Range("a1:J1").HorizontalAlignment = xlcenter
            exHoja.Range("a2:J2").Merge()
            exHoja.Range("a2:J2").HorizontalAlignment = xlcenter
            exHoja.Range("a3:J3").Merge()
            exHoja.Range("a3:J3").HorizontalAlignment = xlcenter
            exHoja.Range("a1:J3").BorderAround()

            exHoja.Cells.Item(1) = "SISTEMA MK-TALLER"


            'exHoja.Cells.Item(1, 4) = "Sistema de Cobranza"
            exHoja.Cells.Item(2, 1) = "INVENTARIO"
            exHoja.Cells.Item(3, 1) = "FECHA:" & DateString

            exHoja.Cells.Item(4, 1) = "ID"
            exHoja.Cells.Item(4, 2) = "CLAVE"
            exHoja.Cells.Item(4, 3) = "PRODUCTO"
            exHoja.Cells.Item(4, 4) = "CANTIDAD"
            exHoja.Cells.Item(4, 5) = "U MEDIDA"
            exHoja.Cells.Item(4, 6) = "COSTO UNIT."
            exHoja.Cells.Item(4, 7) = "PRECIO UNIT."
            exHoja.Cells.Item(4, 8) = "COSTO TOTAL"
            exHoja.Cells.Item(4, 9) = "VENTA PROYECTADA"
            exHoja.Cells.Item(4, 10) = "UTILIDAD PROYECTADA"


            Dim cn As Integer = 1, tiposinformes As Integer = 0
            Dim posicion As Integer = 3
            Dim AUX As Integer
            Dim fila As Integer
            For fila = 0 To NRow - 1
                AUX = 0
                For col As Integer = 0 To NCol - 1
                    If grdatos.Columns(col).Visible = True Then
                        exHoja.Cells.Item(fila + 5, col + cn - AUX) = grdatos.Rows(fila).Cells(col).Value
                    Else
                        AUX = AUX + 1
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
            exHoja.Range("A1:J" & fila).EntireColumn.AutoFit()

            exHoja.Columns("F").NumberFormat = "$#,##0.00_);[Red]($#,##0.00)"
            exHoja.Columns("G").NumberFormat = "$#,##0.00_);[Red]($#,##0.00)"
            exHoja.Columns("H").NumberFormat = "$#,##0.00_);[Red]($#,##0.00)"
            exHoja.Columns("I").NumberFormat = "$#,##0.00_);[Red]($#,##0.00)"
            exHoja.Columns("J").NumberFormat = "$#,##0.00_);[Red]($#,##0.00)"

            exHoja.Rows.Item(4).font.bold = 6
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al Exportar a Excel")

        End Try
    End Sub


    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID"
        grdatos.Columns(1).HeaderText = "CLAVE"
        grdatos.Columns(2).HeaderText = "PRODUCTO"
        grdatos.Columns(3).HeaderText = "TIPO"
        grdatos.Columns(4).HeaderText = "CANTIDAD"
        grdatos.Columns(5).HeaderText = "ID UNIDAD"
        grdatos.Columns(6).HeaderText = "UNIDAD"
        grdatos.Columns(7).HeaderText = "COSTO U"
        grdatos.Columns(8).HeaderText = "PRECIO U"
        grdatos.Columns(9).HeaderText = "COSTO TOTAL"
        grdatos.Columns(10).HeaderText = "VENTAS PROYECTADA"
        grdatos.Columns(11).HeaderText = "UTILIDAD PROYECTADA"


        'grdatos.Columns(11).Visible = False
        grdatos.Columns(3).Visible = False
        grdatos.Columns(5).Visible = False

        formatomoneda(grdatos, 4, False)
        formatomoneda(grdatos, 7, True)
        formatomoneda(grdatos, 8, True)
        formatomoneda(grdatos, 9, True)
        formatomoneda(grdatos, 10, True)
        formatomoneda(grdatos, 11, True)
        grdatos.AutoResizeColumns()

    End Sub
    Private Sub frmconsultainventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta()
    End Sub

    Private Sub mncIMPRIMIR_Click(sender As Object, e As EventArgs) Handles mncIMPRIMIR.Click
        exportarexcel()
    End Sub
End Class