Imports MySql.Data.MySqlClient
Public Class frmconsultamotor

    Dim conn As New mysqlconn
    Dim texto As String
    Dim datos As New C_Motor
    Dim tabla As New DataTable
    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn.consulta(grdatos, "select motor.id_motor,motor.tipom,motor.id_marca,marca.nom_marca,motor.id_submarca,submarca.nom_submarca from motor join submarca on motor.id_marca=submarca.id_marca and motor.id_submarca=submarca.id_submarca join marca on motor.id_marca=marca.id_marca where motor.estado_motor=1 order by motor.id_marca,motor.id_submarca,motor.id_motor")
        formatogrid()
    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID MOTOR"
        grdatos.Columns(1).HeaderText = "TIPO DE MOTOR"
        grdatos.Columns(2).HeaderText = "ID MARCA"
        grdatos.Columns(3).HeaderText = "MARCA"
        grdatos.Columns(4).HeaderText = "ID SUBMARCA"
        grdatos.Columns(5).HeaderText = "SUBMARCA"
        grdatos.AutoResizeColumns()
        'grdatos.Columns(0).Width = 50
        'grdatos.Columns(1).Width = 300
        ' grdatos.Columns(2).Visible = False


    End Sub
    Private Sub frmconsultamotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta()
        ExtendedMethods.DoubleBuffered(grdatos, True)
    End Sub
    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick
        If e.RowIndex >= 0 Then
            datos.id_marca = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value)
            datos.id_submarca = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value)
            datos.id_motor = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(0).Value)
            datos.tipom = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(1).Value)

            frmmotor.Show()
            frmmotor.cmarca.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(2).Value) & " " & Convert.ToString(grdatos.Rows(e.RowIndex).Cells(3).Value)
            frmmotor.csubmarca.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(4).Value) & " " & Convert.ToString(grdatos.Rows(e.RowIndex).Cells(5).Value)
            frmmotor.mostrar(datos)
            frmmotor.flag = 2
        End If

    End Sub



    Private Sub mncSALIR_Click(sender As Object, e As EventArgs) Handles mncSALIR.Click
        Dispose()
    End Sub

    Private Sub mncNUEVO_Click(sender As Object, e As EventArgs) Handles mncNUEVO.Click
        frmmotor.Show()
        frmmotor.flag = 1
    End Sub

    Private Sub mncEDITAR_Click(sender As Object, e As EventArgs) Handles mncEDITAR.Click


        datos.id_marca = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        datos.id_submarca = Convert.ToString(grdatos.CurrentRow().Cells(4).Value)
        datos.id_motor = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
        datos.tipom = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)



        frmmotor.Show()
        frmmotor.cmarca.Text = Convert.ToString(grdatos.CurrentRow().Cells(2).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(3).Value)
        frmmotor.csubmarca.Text = Convert.ToString(grdatos.CurrentRow().Cells(4).Value) & " " & Convert.ToString(grdatos.CurrentRow().Cells(5).Value)
        frmmotor.mostrar(datos)
        frmmotor.flag = 2
    End Sub

    Private Sub mncELIMINAR_Click(sender As Object, e As EventArgs) Handles mncELIMINAR.Click
        If MsgBox("Desea Eliminar este registro", vbYesNo + vbQuestion,) = vbYes Then
            Dim motor As New C_Motor
            motor.id_marca = Convert.ToDouble(grdatos.CurrentRow().Cells(2).Value)
            motor.id_submarca = Convert.ToDouble(grdatos.CurrentRow().Cells(4).Value)
            motor.id_motor = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
            conn.eliminar(motor, motor.id_marca.ToString, motor.id_submarca.ToString, motor.id_motor.ToString)
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

End Class