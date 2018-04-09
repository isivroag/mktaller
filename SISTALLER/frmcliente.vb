Imports MySql.Data.MySqlClient

Public Class frmcliente
    Dim conn As New mysqlconn
    Dim texto As String
    Dim datos As New C_Cliente
    Dim tabla As New DataTable
    Public flag As Integer


    Public Sub mostrar(ByVal clie As C_Cliente)
        datos = clie
        tid.Text = clie.id_clie
        trfc.Text = clie.rfc_clie
        tnombre.Text = clie.nombre_clie
        tdir.Text = clie.dir_clie
        tcol.Text = clie.col_clie
        tcp.Text = clie.cp_clie
        tcd.Text = clie.cd_clie
        tedo.Text = clie.edo_clie
        tcel.Text = clie.cel_clie
        ttel.Text = clie.tel_clie
        temail.Text = clie.email_clie

    End Sub


    Private Sub limpiar()
        tid.Text = ""
        trfc.Text = ""
        tnombre.Text = ""
        tdir.Text = ""
        tcol.Text = ""
        tcp.Text = ""
        tcd.Text = ""
        tedo.Text = ""
        tcel.Text = ""
        ttel.Text = ""
        temail.Text = ""
    End Sub
    Private Sub frmcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' consulta()
        limpiar()
    End Sub

    Private Sub Tbuscar_TextChanged(sender As Object, e As EventArgs)
        '     For i As Integer = 0 To Me.grdatos.Rows.Count - 2
        '      For x As Integer = 0 To grdatos.ColumnCount - 1
        '    If grdatos.Rows(i).Cells(x).Value.ToString.Contains(Me.Tbuscar.Text) Then
        '                 Me.grdatos.CurrentCell = grdatos.Rows(i).Cells(x)
        '    Exit Sub
        '   End If
        '  Next x
        '  Next i
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bguardar.Click

        If Strings.Len(tnombre.Text) > 0 And Strings.Len(tcel.Text) > 0 Then

            datos.rfc_clie = trfc.Text
            datos.nombre_clie = tnombre.Text
            datos.dir_clie = tdir.Text
            datos.col_clie = tcol.Text
            datos.cp_clie = tcp.Text
            datos.cd_clie = tcd.Text
            datos.edo_clie = tedo.Text
            datos.cel_clie = tcel.Text
            datos.tel_clie = ttel.Text
            datos.email_clie = temail.Text

            If flag = 1 Or flag = 3 Then
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If flag = 1 Then
                        frmconsultacliente.consulta()
                        Me.Dispose()
                    Else
                        tid.Text = conn.Obtener_ID("select MAX(id_clie) as max_id FROM cliente")
                        frmvehiculo.id_clie = tid.Text
                        frmvehiculo.nombre_clie = tnombre.Text
                        frmvehiculo.agregarcombo()
                        Me.Dispose()
                    End If

                Else
                        MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                If conn.modificar(datos, datos.id_clie.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmconsultacliente.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        Else
            MessageBox.Show("¡Verifique Sus Datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        ' Dim clave As String
        '  clave = grdatos.Rows(grdatos.CurrentRow.Index).Cells(0).Value.ToString
        '  tabla = conn.consulta_datos("select * from cliente where id_cliente='" & clave & "' order by id_cliente")
        '  If tabla.Rows.Count > 0 Then
        ' Dim row As DataRow = tabla.Rows(0)
        ' tid.Text = row("id_cliente").ToString
        ' trfc.Text = row("rfc_cliente").ToString
        ' tnombre.Text = row("nombre_cliente").ToString

        'End If
        ' If e.RowIndex >= 0 Then
        '   tid.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(0).Value)
        '  trfc.Text = Convert.ToString(grdatos.CurrentRow.Cells(1).Value)
        '  tnombre.Text = Convert.ToString(grdatos.CurrentRow.Cells(2).Value)
        ' End If
    End Sub



    Private Sub grdatos_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        '     If e.RowIndex >= 0 Then
        '     tid.Text = Convert.ToString(grdatos.Rows(e.RowIndex).Cells(0).Value)
        '     trfc.Text = Convert.ToString(grdatos.CurrentRow.Cells(1).Value)
        '     tnombre.Text = Convert.ToString(grdatos.CurrentRow.Cells(2).Value)
        '    End If
    End Sub


    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        Dispose()
    End Sub

    Private Sub trfc_LostFocus(sender As Object, e As EventArgs) Handles trfc.LostFocus
        trfc.Text = UCase(trfc.Text)
    End Sub


    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs) Handles tnombre.LostFocus
        tnombre.Text = UCase(tnombre.Text)
    End Sub


    Private Sub tdir_LostFocus(sender As Object, e As EventArgs) Handles tdir.LostFocus
        tdir.Text = UCase(tdir.Text)
    End Sub


    Private Sub tcol_LostFocus(sender As Object, e As EventArgs) Handles tcol.LostFocus
        tcol.Text = UCase(tcol.Text)
    End Sub

    Private Sub tcd_LostFocus(sender As Object, e As EventArgs) Handles tcd.LostFocus
        tcd.Text = UCase(tcd.Text)
    End Sub


    Private Sub tedo_LostFocus(sender As Object, e As EventArgs) Handles tedo.LostFocus
        tedo.Text = UCase(tedo.Text)
    End Sub



End Class