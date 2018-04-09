Imports MySql.Data.MySqlClient

Public Class frmconsultacliente
    Dim conn As New mysqlconn
    Dim texto As String
    Dim datos As New C_Cliente
    Dim tabla As New DataTable
    Public flag As Integer

    Dim MEDIDA As Double
    Dim MEDIDAF As Double
    Dim TOTAL As Double
    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn.consulta(grdatos, "select * from cliente where estado_clie =1 order by id_clie")
        formatogrid()
    End Sub




    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "CLAVE"
        grdatos.Columns(1).HeaderText = "RFC"
        grdatos.Columns(2).HeaderText = "NOMBRE"
        grdatos.Columns(3).HeaderText = "DIRECCION"
        grdatos.Columns(4).HeaderText = "COLONIA"
        grdatos.Columns(5).HeaderText = "CP"
        grdatos.Columns(6).HeaderText = "CIUDAD"
        grdatos.Columns(7).HeaderText = "ESTADO"
        grdatos.Columns(8).HeaderText = "TELEFONO MOVIL"
        grdatos.Columns(9).HeaderText = "TELEFONO FIJO"
        grdatos.Columns(10).HeaderText = "CORREO ELECRONICO"
        grdatos.Columns(11).HeaderText = "STATUS"
        grdatos.AutoResizeColumns()

        grdatos.Columns(11).Visible = False


    End Sub
    Private Sub frmconsultacliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)

        MEDIDA = Label1.Width

        MEDIDAF = Me.Width

        TOTAL = (MEDIDAF - MEDIDA) / 2
        Label1.Location = New Point(TOTAL, 46)


    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub

    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick

        Dim cliente As New C_Cliente
        cliente.id_clie = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
        cliente.rfc_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
        cliente.nombre_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
        cliente.dir_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(3).Value)
        cliente.col_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value)
        cliente.cp_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(5).Value)
        cliente.cd_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(6).Value)
        cliente.edo_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(7).Value)
        cliente.cel_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(8).Value)
        cliente.tel_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(9).Value)
        cliente.email_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(10).Value)
        cliente.estado_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(11).Value)

        Select Case flag
            Case 1


                frmcliente.Show()
                frmcliente.mostrar(cliente)
                frmcliente.flag = 2
            Case 2
                frmvehiculo.id_clie = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmvehiculo.nombre_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
                frmvehiculo.buscar_clie()
                Dispose()
            Case 3
                frmconsultavehiculo.Show()
                frmconsultavehiculo.cliente = Convert.ToDouble(grdatos.Rows(e.RowIndex).Cells(0).Value)
                frmconsultavehiculo.buscardet()
                frmconsultavehiculo.flag = 3
                Dispose()


        End Select

    End Sub



    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmcliente.Show()
        frmcliente.flag = 1
    End Sub

    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click
        Dim cliente As New C_Cliente
        cliente.id_clie = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
        cliente.rfc_clie = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        cliente.nombre_clie = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        cliente.dir_clie = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)
        cliente.col_clie = Convert.ToString(grdatos.CurrentRow().Cells(4).Value)
        cliente.cp_clie = Convert.ToString(grdatos.CurrentRow().Cells(5).Value)
        cliente.cd_clie = Convert.ToString(grdatos.CurrentRow().Cells(6).Value)
        cliente.edo_clie = Convert.ToString(grdatos.CurrentRow().Cells(7).Value)
        cliente.cel_clie = Convert.ToString(grdatos.CurrentRow().Cells(8).Value)
        cliente.tel_clie = Convert.ToString(grdatos.CurrentRow().Cells(9).Value)
        cliente.email_clie = Convert.ToString(grdatos.CurrentRow().Cells(10).Value)
        cliente.estado_clie = Convert.ToString(grdatos.CurrentRow().Cells(11).Value)

        frmcliente.Show()
        frmcliente.mostrar(cliente)
        frmcliente.flag = 2
    End Sub

    Private Sub mncELIMINAR_Click(sender As Object, e As EventArgs) Handles mncELIMINAR.Click
        If MsgBox("Desea Eliminar este cliente", vbYesNo + vbQuestion,) = vbYes Then
            Dim cliente As New C_Cliente
            cliente.id_clie = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
            conn.eliminar(cliente, cliente.id_clie.ToString)
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
            exHoja.Cells.Item(2, 1) = "LISTAD DE CLIENTES"
            exHoja.Cells.Item(3, 1) = "FECHA:" & DateString

            exHoja.Cells.Item(4, 1) = "ID"
            exHoja.Cells.Item(4, 2) = "RFC"
            exHoja.Cells.Item(4, 3) = "NOMBRE"
            exHoja.Cells.Item(4, 4) = "DIRECCION"
            exHoja.Cells.Item(4, 5) = "COLONIA"
            exHoja.Cells.Item(4, 6) = "CP"
            exHoja.Cells.Item(4, 7) = "CIUDAD"
            exHoja.Cells.Item(4, 8) = "ESTADO"
            exHoja.Cells.Item(4, 9) = "TEL MOVIL"
            exHoja.Cells.Item(4, 10) = "TEL FIJO"
            exHoja.Cells.Item(4, 11) = "CORREO ELECTRONICO"

            Dim cn As Integer = 1, tiposinformes As Integer = 0
            Dim posicion As Integer = 3
            Dim fila As Integer
            For fila = 0 To NRow - 1
                For col As Integer = 0 To NCol - 1
                    If col <> 11 Then
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
        exportarexcel
    End Sub

    Private Sub frmconsultacliente_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        MEDIDA = Label1.Width

        MEDIDAF = Me.Width

        TOTAL = (MEDIDAF - MEDIDA) / 2
        Label1.Location = New Point(TOTAL, 46)
    End Sub


End Class