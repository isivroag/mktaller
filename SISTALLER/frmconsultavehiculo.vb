Imports MySql.Data.MySqlClient
Public Class frmconsultavehiculo
    Dim conn As New mysqlconn
    Dim texto As String
    Dim datos As New C_Vehiculo
    Dim tabla As New DataTable
    Public flag As Integer
    Public cliente As String
    Dim sql As String

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn.consulta(grdatos, "select vehiculo.*,cliente.nombre_clie from vehiculo join cliente on vehiculo.cliente_id_clie= cliente.id_clie where vehiculo.estado_veh =1 order by vehiculo.id_veh")
        formatogrid()
    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "CLAVE"
        grdatos.Columns(1).HeaderText = "PLACA"
        grdatos.Columns(2).HeaderText = "ID MARCA"
        grdatos.Columns(3).HeaderText = "MARCA"
        grdatos.Columns(4).HeaderText = "ID SUBMARCA"
        grdatos.Columns(5).HeaderText = "SUBMARCA"
        grdatos.Columns(6).HeaderText = "SERIE"
        grdatos.Columns(7).HeaderText = "ID MOTOR"
        grdatos.Columns(8).HeaderText = "TIPO DE MOTOR"
        grdatos.Columns(9).HeaderText = "AÑO"
        grdatos.Columns(10).HeaderText = "COLOR"
        grdatos.Columns(11).HeaderText = "No.MOTOR"
        grdatos.Columns(12).HeaderText = "GASOLINA"
        grdatos.Columns(13).HeaderText = "ID_TIPO"
        grdatos.Columns(14).HeaderText = "TIPO"
        grdatos.Columns(15).HeaderText = "OBSERVACIONES"
        grdatos.Columns(16).HeaderText = "STATUS"
        grdatos.Columns(17).HeaderText = "ID CLIENTE"
        grdatos.Columns(18).HeaderText = "NOMBRE CLIENTE"
        grdatos.AutoResizeColumns()

        grdatos.Columns(16).Visible = False



    End Sub
    Private Sub frmconsultavehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick
        Dim vehiculo As New C_Vehiculo
        vehiculo.id_veh = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(0).Value)
        vehiculo.placa_veh = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
        If Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value) <> "" Then
            vehiculo.id_marca = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
        End If

        vehiculo.marca_veh = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(3).Value)

        If Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value) <> "" Then
            vehiculo.id_submarca = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value)
        End If
        vehiculo.submarca_veh = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(5).Value)
        vehiculo.serie_veh = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(6).Value)

        If Convert.ToString(grdatos.Rows(e.RowIndex).Cells(7).Value) <> "" Then
            vehiculo.id_motor = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(7).Value)
        End If

        vehiculo.tipom_veh = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(8).Value)
        vehiculo.año_veh = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(9).Value)
        vehiculo.color_veh = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(10).Value)
        vehiculo.motor_veh = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(11).Value)
        vehiculo.gasolina_veh = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(12).Value)

        If Convert.ToString(grdatos.Rows(e.RowIndex).Cells(13).Value) <> "" Then
            vehiculo.id_tipo_veh = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(13).Value)
        End If

        vehiculo.tipo_veh = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(14).Value)
        vehiculo.obs_veh = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(15).Value)

        vehiculo.cliente_id_clie = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(17).Value)

        Select Case flag
            Case 1
                frmvehiculo.Show()
                frmvehiculo.mostrar(vehiculo)
                frmvehiculo.flag = 2

                frmvehiculo.tmarca.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value) & " " & Convert.ToString(grdatos.Rows(e.RowIndex).Cells(3).Value)
                frmvehiculo.tsubmarca.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value) & " " & Convert.ToString(grdatos.Rows(e.RowIndex).Cells(5).Value)
                frmvehiculo.ttipom.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value) & " " & Convert.ToString(grdatos.Rows(e.RowIndex).Cells(5).Value)

                frmvehiculo.ttipo.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(7).Value) & " " & Convert.ToString(grdatos.Rows(e.RowIndex).Cells(8).Value)

                frmvehiculo.tcliente.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(17).Value) & " " & Convert.ToString(grdatos.Rows(e.RowIndex).Cells(18).Value)
            Case 2, 3
                frmordenser.tplaca.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)
                frmordenser.buscarvehiculo()
                Dispose()


        End Select




    End Sub



    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmvehiculo.Show()
        frmvehiculo.flag = 1
        frmvehiculo.flagnveh = 1
    End Sub

    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click
        Dim vehiculo As New C_Vehiculo

        vehiculo.id_veh = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
        vehiculo.placa_veh = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        If Convert.ToString(grdatos.CurrentRow().Cells(2).Value) <> "" Then
            vehiculo.id_marca = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        End If

        vehiculo.marca_veh = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)

        If Convert.ToString(grdatos.CurrentRow().Cells(4).Value) <> "" Then
            vehiculo.id_submarca = Convert.ToString(grdatos.CurrentRow().Cells(4).Value)
        End If
        vehiculo.submarca_veh = Convert.ToString(grdatos.CurrentRow().Cells(5).Value)
        vehiculo.serie_veh = Convert.ToString(grdatos.CurrentRow().Cells(6).Value)

        If Convert.ToString(grdatos.CurrentRow().Cells(7).Value) <> "" Then
            vehiculo.id_motor = Convert.ToString(grdatos.CurrentRow().Cells(7).Value)
        End If

        vehiculo.tipom_veh = Convert.ToString(grdatos.CurrentRow().Cells(8).Value)
        vehiculo.año_veh = Convert.ToString(grdatos.CurrentRow().Cells(9).Value)
        vehiculo.color_veh = Convert.ToString(grdatos.CurrentRow().Cells(10).Value)
        vehiculo.motor_veh = Convert.ToString(grdatos.CurrentRow().Cells(11).Value)
        vehiculo.gasolina_veh = Convert.ToString(grdatos.CurrentRow().Cells(12).Value)

        If Convert.ToString(grdatos.CurrentRow().Cells(13).Value) <> "" Then
            vehiculo.id_tipo_veh = Convert.ToString(grdatos.CurrentRow().Cells(13).Value)
        End If

        vehiculo.tipo_veh = Convert.ToString(grdatos.CurrentRow().Cells(14).Value)
        vehiculo.obs_veh = Convert.ToString(grdatos.CurrentRow().Cells(15).Value)

        vehiculo.cliente_id_clie = Convert.ToString(grdatos.CurrentRow().Cells(17).Value)




        vehiculo.cliente_id_clie = Convert.ToString(grdatos.CurrentRow().Cells(13).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(14).Value)

        frmvehiculo.tmarca.Text = Convert.ToString(grdatos.CurrentRow().Cells(2).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(3).Value)
        frmvehiculo.tsubmarca.Text = Convert.ToString(grdatos.CurrentRow().Cells(4).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(5).Value)
        frmvehiculo.ttipom.Text = Convert.ToString(grdatos.CurrentRow().Cells(4).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(5).Value)

        frmvehiculo.ttipo.Text = Convert.ToString(grdatos.CurrentRow().Cells(7).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(8).Value)

        frmvehiculo.tcliente.Text = Convert.ToString(grdatos.CurrentRow().Cells(17).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(18).Value)

        frmvehiculo.Show()
        frmvehiculo.mostrar(vehiculo)
        frmvehiculo.flag = 2
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
    Public Sub buscardet()
        sql = "select vehiculo.*,cliente.nombre_clie from vehiculo join cliente on vehiculo.cliente_id_clie= cliente.id_clie where vehiculo.estado_veh =1 and cliente.id_clie = '" & cliente & "' order by vehiculo.id_veh"
        conn.consulta(grdatos, Sql)
        formatogrid()
    End Sub
    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub

    Private Sub clista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clista.SelectedIndexChanged

    End Sub
End Class