Imports MySql.Data.MySqlClient
Public Class frmauxinventario

    Dim conn As New mysqlconn
    Dim texto As String
    Public producto As New C_Item
    Public medida As String
    Public movimiento As New C_Movimiento
    Dim tabla As New DataTable

    Private Sub combo()
        tabla = conn.consulta("select * from umedida order by id_umed")

        For Each row As DataRow In tabla.Rows
            tunidad.Items.Add(row("id_umed") & " " & row("corto_umed"))
        Next row
    End Sub
    Private Sub frmauxinventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combo()
    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        movimiento.id_item = producto.id_item
        movimiento.fecha_mov = Date.Today.Date.ToString
        movimiento.tipo_mov = sacarclave(ttipo.Text)
        movimiento.ini_mov = producto.stock_item
        movimiento.id_umed = producto.id_umed
        movimiento.cant_mov = Convert.ToDouble(tcant.Text)
        Select Case sacarclave(ttipo.Text)
            Case 1
                movimiento.fin_mov = Convert.ToDouble(producto.stock_item) + Convert.ToDouble(tcant.Text)
            Case 2
                movimiento.fin_mov = Convert.ToDouble(producto.stock_item) + Convert.ToDouble(tcant.Text)
            Case 3
                movimiento.fin_mov = Convert.ToDouble(producto.stock_item) - Convert.ToDouble(tcant.Text)
        End Select

        movimiento.obs_mov = tobs.Text
        producto.stock_item = movimiento.fin_mov


        If conn.insertarmov(movimiento) And conn.modificar(producto, producto.id_item) Then
            MessageBox.Show("Datos Guardados")
            frminventario.mostrarp(producto)


            Me.Dispose()

        Else
            MessageBox.Show("Datos No Guardados")
        End If


    End Sub

    Private Sub tcant_TextChanged(sender As Object, e As EventArgs) Handles tcant.TextChanged

    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tcant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcant.KeyPress



        solonumeros(sender, e)

        'Dim cadena As String
        'Dim i As Integer
        'Dim at As Integer

        'cadena = "0123456789." + Chr(8)
        'If Strings.InStr(cadena, e.KeyChar.ToString) = 0 Then
        ' e.KeyChar = ""
        'End If

        'Do While i < Strings.Len(tcant.Text)
        ' If Mid(tcant.Text, i + 1, 1) = "." Then
        'at = 1
        'End If
        'i = i + 1
        'Loop

        'If at = 1 And e.KeyChar = Chr(46) Then
        ' e.KeyChar = ""
        'End If
    End Sub
End Class