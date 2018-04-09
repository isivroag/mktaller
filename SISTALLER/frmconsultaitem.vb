Imports MySql.Data.MySqlClient
Public Class frmconsultaitem
    Dim conn As New mysqlconn
    Dim texto As String
    Dim datos As New C_Item
    Dim tabla As New DataTable

    Public flag As Integer
    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        texto = "select item.id_item,item.clave_item,item.nombre_item,item.id_umed,umedida.corto_umed,item.tipo_item,item.id_linea,linea.nom_linea,item.id_clase,clase.nom_clase, " _
                & "item.id_subclase,subclase.nom_subclase,item.id_marca,marca.nom_marca,item.id_submarca,submarca.nom_submarca, " _
                & "item.id_motor,motor.tipom,item.stock_item,item.min_item,item.max_item,item.garantia_item,item.costo_item, " _
                & "item.precio_item,item.estado_item " _
                & "from item join linea on item.id_linea=linea.id_linea join clase on item.id_clase=clase.id_clase " _
                & "join subclase on item.id_clase=subclase.id_clase and item.id_subclase =subclase.id_subclase " _
                & "join marca on item.id_marca=marca.id_marca " _
                & "join submarca on item.id_marca =submarca.id_marca and item.id_submarca=submarca.id_submarca " _
                & "join motor on item.id_marca = motor.id_marca and item.id_submarca =motor.id_submarca and item.id_motor=motor.id_motor " _
                & "join umedida on item.id_umed=umedida.id_umed " _
                & "order by item.id_item "

        conn.consulta(grdatos, texto)
        formatogrid()
    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID"
        grdatos.Columns(1).HeaderText = "CLAVE"
        grdatos.Columns(2).HeaderText = "DESCRIPCION"

        grdatos.Columns(3).HeaderText = "ID MEDIDA"
        grdatos.Columns(4).HeaderText = "UNIDAD"

        grdatos.Columns(5).HeaderText = "TIPO"

        grdatos.Columns(6).HeaderText = "ID LINEA"
        grdatos.Columns(7).HeaderText = "LINEA"
        grdatos.Columns(8).HeaderText = "ID CLASE"
        grdatos.Columns(9).HeaderText = "CLASE"
        grdatos.Columns(10).HeaderText = "ID SUBCLASE"
        grdatos.Columns(11).HeaderText = "SUBCLASE"
        grdatos.Columns(12).HeaderText = "ID MARCA"
        grdatos.Columns(13).HeaderText = "MARCA"
        grdatos.Columns(14).HeaderText = "ID SUBMARCA"
        grdatos.Columns(15).HeaderText = "SUBMARCA"
        grdatos.Columns(16).HeaderText = "ID MOTOR"
        grdatos.Columns(17).HeaderText = "MOTOR"

        grdatos.Columns(18).HeaderText = "STOCK"
        grdatos.Columns(19).HeaderText = "STOCK MINIMO"
        grdatos.Columns(20).HeaderText = "STOCK MAXIMO"
        grdatos.Columns(21).HeaderText = "GARANTIA (MESES)"
        grdatos.Columns(22).HeaderText = "COSTO"
        grdatos.Columns(23).HeaderText = "PRECIO"
        grdatos.Columns(24).HeaderText = "ESTADO"

        grdatos.AutoResizeColumns()

        grdatos.Columns(3).Visible = False


        grdatos.Columns(6).Visible = False
        grdatos.Columns(8).Visible = False
        grdatos.Columns(10).Visible = False
        grdatos.Columns(12).Visible = False
        grdatos.Columns(14).Visible = False
        grdatos.Columns(16).Visible = False
        grdatos.Columns(24).Visible = False




    End Sub

    Private Sub frmconsultaitem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick
        datos.id_item = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(0).Value)
        datos.clave_item = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
        datos.nombre_item = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)

        datos.id_umed = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(3).Value)

        datos.tipo_item = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(5).Value)

        datos.id_linea = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(6).Value)
        datos.id_clase = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(8).Value)
        datos.id_subclase = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(10).Value)
        datos.id_marca = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(12).Value)
        datos.id_submarca = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(14).Value)
        datos.id_motor = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(16).Value)


        datos.stock_item = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(18).Value)
        datos.min_item = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(19).Value)
        datos.max_item = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(20).Value)
        datos.garantia_item = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(21).Value)
        datos.costo_item = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(22).Value)
        datos.precio_item = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(23).Value)
        datos.estado_item = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(24).Value)

        Select Case flag
            Case 1

                frmitems.Show()
                frmitems.mostrar(datos)
                frmitems.flag = 2

                frmitems.tmedida.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(3).Value) & " " & Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value)
                frmitems.tlinea.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(6).Value) & " " & Convert.ToString(grdatos.Rows(e.RowIndex).Cells(7).Value)
                frmitems.tclase.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(8).Value) & " " & Convert.ToString(grdatos.Rows(e.RowIndex).Cells(9).Value)
                frmitems.tsubclase.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(10).Value) & " " & Convert.ToString(grdatos.Rows(e.RowIndex).Cells(11).Value)
                frmitems.tmarca.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(12).Value) & " " & Convert.ToString(grdatos.Rows(e.RowIndex).Cells(13).Value)
                frmitems.tsubmarca.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(14).Value) & " " & Convert.ToString(grdatos.Rows(e.RowIndex).Cells(15).Value)
                frmitems.tmotor.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(16).Value) & " " & Convert.ToString(grdatos.Rows(e.RowIndex).Cells(17).Value)

            Case 2
                frminventario.medida = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value)
                frminventario.mostrarp(datos)
                Dispose()
            Case 3
                frmdetalleord.Show()
                frmdetalleord.medida = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value)
                frmdetalleord.tipo = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(5).Value)
                frmdetalleord.mostrarp(datos)

                Dispose()

        End Select

    End Sub



    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmitems.Show()
        frmitems.flag = 1
    End Sub

    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click

        datos.id_item = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
        datos.clave_item = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        datos.nombre_item = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)

        datos.id_umed = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)
        datos.tipo_item = Convert.ToString(grdatos.CurrentRow().Cells(5).Value)

        datos.id_linea = Convert.ToString(grdatos.CurrentRow().Cells(6).Value)
        datos.id_clase = Convert.ToString(grdatos.CurrentRow().Cells(8).Value)
        datos.id_subclase = Convert.ToString(grdatos.CurrentRow().Cells(10).Value)
        datos.id_marca = Convert.ToString(grdatos.CurrentRow().Cells(12).Value)
        datos.id_submarca = Convert.ToString(grdatos.CurrentRow().Cells(14).Value)
        datos.id_motor = Convert.ToString(grdatos.CurrentRow().Cells(16).Value)


        datos.stock_item = Convert.ToString(grdatos.CurrentRow().Cells(18).Value)
        datos.min_item = Convert.ToString(grdatos.CurrentRow().Cells(19).Value)
        datos.max_item = Convert.ToString(grdatos.CurrentRow().Cells(20).Value)
        datos.garantia_item = Convert.ToString(grdatos.CurrentRow().Cells(21).Value)
        datos.costo_item = Convert.ToString(grdatos.CurrentRow().Cells(22).Value)
        datos.precio_item = Convert.ToString(grdatos.CurrentRow().Cells(23).Value)
        datos.estado_item = Convert.ToString(grdatos.CurrentRow().Cells(24).Value)


        frmitems.Show()
        frmitems.mostrar(datos)
        frmitems.flag = 2

        frmitems.tmedida.Text = Convert.ToString(grdatos.CurrentRow().Cells(3).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(4).Value)
        frmitems.tlinea.Text = Convert.ToString(grdatos.CurrentRow().Cells(6).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(7).Value)
        frmitems.tclase.Text = Convert.ToString(grdatos.CurrentRow().Cells(8).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(9).Value)
        frmitems.tsubclase.Text = Convert.ToString(grdatos.CurrentRow().Cells(10).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(11).Value)
        frmitems.tmarca.Text = Convert.ToString(grdatos.CurrentRow().Cells(12).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(13).Value)
        frmitems.tsubmarca.Text = Convert.ToString(grdatos.CurrentRow().Cells(14).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(15).Value)
        frmitems.tmotor.Text = Convert.ToString(grdatos.CurrentRow().Cells(16).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(17).Value)

    End Sub

    Private Sub mncELIMINAR_Click(sender As Object, e As EventArgs) Handles mncELIMINAR.Click
        If MsgBox("Desea Eliminar este Vehiculo", vbYesNo + vbQuestion,) = vbYes Then
            Dim vehiculo As New C_Vehiculo
            vehiculo.id_veh = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
            conn.eliminar(vehiculo, vehiculo.id_veh.ToString)
            consulta()
        End If
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
        Dim sql As String
        Select Case clista.Text

            Case Else
                sql = "select * from item order by id_item"


        End Select
        conn.consulta(grdatos, sql)
        formatogrid()
    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub
End Class