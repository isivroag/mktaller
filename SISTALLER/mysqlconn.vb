Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient


Public Class mysqlconn
    Public _sql As String
    Public _conexion As New MySqlConnection
    Private adaptador As New MySqlDataAdapter
    Private ta As New DataTable


    Public dtsdatos As New DataSet
    Public dtvdatos As New DataView
    Private Sub conexion()
        _sql = "server=" & My.Settings.sever & "; Uid=" & My.Settings.user & "; Pwd=" & My.Settings.pwd & ";database=" & My.Settings.db & ""
        _conexion = New MySqlConnection(_sql)
    End Sub

    Public Function Obtener_ID(ByVal sqlcons As String) As String
        Try
            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)

            If ta.Rows.Count = 1 Then
                Return Convert.ToString(ta.Rows(0).Item("max_id"))
            Else
                Return 1
            End If

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
        Finally
            desconectar()
        End Try
    End Function
    Public Function Obtener_Inicial(ByVal sqlcons As String) As String
        Try
            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)

            If ta.Rows.Count = 1 Then
                Return Convert.ToString(ta.Rows(0).Item("cantidad"))
            Else
                Return 1
            End If

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
        Finally
            desconectar()
        End Try
    End Function
    Public Function consultar_reg(ByVal sqlcons As String) As DataTable
        Try
            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
        Finally
            desconectar()
        End Try
        Return ta
    End Function


    Public Function buscarclave(ByVal sqlcons As String, ByVal campo As String, ByVal valor As String) As Boolean
        Dim estado As Boolean = True

        Try
            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(dtsdatos, "registro")

            If dtsdatos.Tables("registro").Rows.Count <> 0 Then
                estado = True
            Else
                estado = False
            End If

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function consulta(ByVal sqlcons As String) As DataTable
        Dim estado As Boolean = True
        Try

            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)


        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
            estado = False
        Finally
            desconectar()
        End Try

        Return ta
    End Function
    Public Function consulta(ByVal Tabla As DataGridView, ByVal sqlcons As String) As DataTable
        Dim estado As Boolean = True
        Try
            Tabla.DataSource = Nothing

            conexion()
            ta.Clear()

            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)
            Tabla.DataSource = ta
        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
            estado = False
        Finally
            desconectar()
        End Try
        Return ta
    End Function

    Public Function consulta_datos(ByVal Tabla As DataGridView, ByVal sqlcons As String) As DataTable
        Dim estado As Boolean = True
        Try
            Tabla.DataSource = Nothing
            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)
            Tabla.DataSource = ta
        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa" & ex.Message.ToString)
        Finally
            desconectar()
        End Try


        Return ta
    End Function

    Public Function insertarnuevo(ByVal datos As C_Cliente) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into cliente (rfc_clie, nombre_clie, dir_clie, col_clie, cp_clie, cd_clie, edo_clie, cel_clie, tel_clie, email_clie) values(@rfc_clie,@nombre_clie,@dir_clie,@col_clie,@cp_clie,@cd_clie,@edo_clie,@cel_clie,@tel_clie,@email_clie)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@rfc_clie", MySqlDbType.VarChar, 15).Value = datos.rfc_clie
            adaptador.InsertCommand.Parameters.Add("@nombre_clie", MySqlDbType.VarChar, 600).Value = datos.nombre_clie
            adaptador.InsertCommand.Parameters.Add("@dir_clie", MySqlDbType.VarChar, 800).Value = datos.dir_clie
            adaptador.InsertCommand.Parameters.Add("@col_clie", MySqlDbType.VarChar, 150).Value = datos.col_clie
            adaptador.InsertCommand.Parameters.Add("@cp_clie", MySqlDbType.VarChar, 5).Value = datos.cp_clie
            adaptador.InsertCommand.Parameters.Add("@cd_clie", MySqlDbType.VarChar, 150).Value = datos.cd_clie
            adaptador.InsertCommand.Parameters.Add("@edo_clie", MySqlDbType.VarChar, 150).Value = datos.edo_clie
            adaptador.InsertCommand.Parameters.Add("@cel_clie", MySqlDbType.VarChar, 45).Value = datos.cel_clie
            adaptador.InsertCommand.Parameters.Add("@tel_clie", MySqlDbType.VarChar, 45).Value = datos.tel_clie
            adaptador.InsertCommand.Parameters.Add("@email_clie", MySqlDbType.VarChar, 100).Value = datos.email_clie
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertarnuevo(ByVal datos As C_Vehiculo) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into vehiculo (placa_veh,id_marca,marca_veh,id_submarca,submarca_veh,serie_veh,id_motor,tipom_veh,año_veh,color_veh,motor_veh,gasolina_veh,obs_veh,id_tipo_veh,tipo_veh,cliente_id_clie) values (@placa_veh,@id_marca,@marca_veh,@id_submarca,@submarca_veh,@serie_veh,@id_motor,@tipom_veh,@año_veh,@color_veh,@motor_Veh,@gasolina_veh,@obs_veh,@id_tipo_veh,@tipo_veh,@cliente_id_clie)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@placa_veh", MySqlDbType.VarChar, 100).Value = datos.placa_veh
            adaptador.InsertCommand.Parameters.Add("@id_marca", MySqlDbType.Int64, 20).Value = datos.id_marca
            adaptador.InsertCommand.Parameters.Add("@marca_Veh", MySqlDbType.VarChar, 100).Value = datos.marca_veh
            adaptador.InsertCommand.Parameters.Add("@id_submarca", MySqlDbType.Int64, 20).Value = datos.id_submarca
            adaptador.InsertCommand.Parameters.Add("@submarca_veh", MySqlDbType.VarChar, 100).Value = datos.submarca_veh
            adaptador.InsertCommand.Parameters.Add("@serie_veh", MySqlDbType.VarChar, 100).Value = datos.serie_veh
            adaptador.InsertCommand.Parameters.Add("@id_motor", MySqlDbType.Int32, 11).Value = datos.id_motor
            adaptador.InsertCommand.Parameters.Add("@tipom_veh", MySqlDbType.VarChar, 100).Value = datos.tipom_veh
            adaptador.InsertCommand.Parameters.Add("@año_veh", MySqlDbType.VarChar, 45).Value = datos.año_veh
            adaptador.InsertCommand.Parameters.Add("@color_veh", MySqlDbType.VarChar, 100).Value = datos.color_veh
            adaptador.InsertCommand.Parameters.Add("@motor_veh", MySqlDbType.VarChar, 100).Value = datos.motor_veh
            adaptador.InsertCommand.Parameters.Add("@gasolina_veh", MySqlDbType.VarChar, 45).Value = datos.gasolina_veh
            adaptador.InsertCommand.Parameters.Add("@obs_veh", MySqlDbType.VarChar, 5000).Value = datos.obs_veh
            adaptador.InsertCommand.Parameters.Add("@id_tipo_veh", MySqlDbType.Int32, 11).Value = datos.id_tipo_veh
            adaptador.InsertCommand.Parameters.Add("@tipo_veh", MySqlDbType.VarChar, 150).Value = datos.tipo_veh
            adaptador.InsertCommand.Parameters.Add("@cliente_id_clie", MySqlDbType.Int64, 20).Value = datos.cliente_id_clie
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertarnuevo(ByVal datos As C_Item) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into item (clave_item,nombre_item,id_umed,tipo_item,id_linea,id_clase,id_subclase,id_marca,id_submarca,id_motor,stock_item,min_item,max_item,garantia_item,costo_item,precio_item) values (@clave_item,@nombre_item,@id_umed,@tipo_item,@id_linea,@id_clase,@id_subclase,@id_marca,@id_submarca,@id_motor,@stock_item,@min_item,@max_item,@garantia_item,@costo_item,@precio_item)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@clave_item", MySqlDbType.VarChar, 50).Value = datos.clave_item
            adaptador.InsertCommand.Parameters.Add("@nombre_item", MySqlDbType.VarChar, 1500).Value = datos.nombre_item
            adaptador.InsertCommand.Parameters.Add("@id_umed", MySqlDbType.Int32, 11).Value = datos.id_umed
            adaptador.InsertCommand.Parameters.Add("@tipo_item", MySqlDbType.VarChar, 500).Value = datos.tipo_item

            adaptador.InsertCommand.Parameters.Add("@id_linea", MySqlDbType.Int32, 11).Value = datos.id_linea
            adaptador.InsertCommand.Parameters.Add("@id_clase", MySqlDbType.Int32, 11).Value = datos.id_clase
            adaptador.InsertCommand.Parameters.Add("@id_subclase", MySqlDbType.Int32, 11).Value = datos.id_subclase
            adaptador.InsertCommand.Parameters.Add("@id_marca", MySqlDbType.Int32, 11).Value = datos.id_marca
            adaptador.InsertCommand.Parameters.Add("@id_submarca", MySqlDbType.Int32, 11).Value = datos.id_submarca
            adaptador.InsertCommand.Parameters.Add("@id_motor", MySqlDbType.Int32, 11).Value = datos.id_motor

            adaptador.InsertCommand.Parameters.Add("@stock_item", MySqlDbType.Decimal, 10.2).Value = datos.stock_item
            adaptador.InsertCommand.Parameters.Add("@min_item", MySqlDbType.Decimal, 10.2).Value = datos.min_item
            adaptador.InsertCommand.Parameters.Add("@max_item", MySqlDbType.Decimal, 10.2).Value = datos.max_item
            adaptador.InsertCommand.Parameters.Add("@garantia_item", MySqlDbType.Int32, 11).Value = datos.garantia_item
            adaptador.InsertCommand.Parameters.Add("@costo_item", MySqlDbType.Decimal, 10.2).Value = datos.costo_item
            adaptador.InsertCommand.Parameters.Add("@precio_item", MySqlDbType.Decimal, 10.2).Value = datos.precio_item

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertarnuevo(ByVal datos As C_Marca) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into marca(nom_marca) values (@nom_marca)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_marca", MySqlDbType.VarChar, 500).Value = datos.nom_marca
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function insertarnuevo(ByVal datos As C_Submarca) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into submarca(id_marca,nom_submarca) values (@id_marca,@nom_submarca)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@id_marca", MySqlDbType.Int64, 20).Value = datos.id_marca
            adaptador.InsertCommand.Parameters.Add("@nom_submarca", MySqlDbType.VarChar, 500).Value = datos.nom_submarca
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertarnuevo(ByVal datos As C_Tipo_Veh) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into tipo_veh(nombre_tipo_veh) values (@nombre_tipo_veh)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nombre_tipo_veh", MySqlDbType.VarChar, 500).Value = datos.nombre_tipo_veh
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertarnuevo(ByVal datos As C_Motor) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into motor(id_marca,id_submarca,tipom) values (@id_marca,@id_submarca,@tipom)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@id_marca", MySqlDbType.Int64, 20).Value = datos.id_marca
            adaptador.InsertCommand.Parameters.Add("@id_submarca", MySqlDbType.Int64, 20).Value = datos.id_submarca
            adaptador.InsertCommand.Parameters.Add("@tipom", MySqlDbType.VarChar, 50).Value = datos.tipom
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertarnuevo(ByVal datos As C_Linea) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into linea(nom_linea) values (@nom_linea)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_linea", MySqlDbType.VarChar, 500).Value = datos.nom_linea
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertarnuevo(ByVal datos As C_Clase) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into clase(nom_clase) values (@nom_clase)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_clase", MySqlDbType.VarChar, 500).Value = datos.nom_clase
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertarnuevo(ByVal datos As C_Subclase) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into subclase(nom_subclase,id_clase) values (@nom_subclase,@id_clase)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@id_clase", MySqlDbType.Int32, 11).Value = datos.id_clase
            adaptador.InsertCommand.Parameters.Add("@nom_subclase", MySqlDbType.VarChar, 500).Value = datos.nom_subclase
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function insertarnuevo(ByVal datos As C_Umed) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into umedida(nom_umed,corto_umed) values (@nom_umed,@corto_umed)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_umed", MySqlDbType.VarChar, 50).Value = datos.nom_umed
            adaptador.InsertCommand.Parameters.Add("@corto_umed", MySqlDbType.VarChar, 10).Value = datos.corto_umed
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function insertarnuevo(ByVal datos As C_Auxorden) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into auxorden(id_ord,encendedor,estereo,cenicero,esprcentral,esprderecho,herramienta,tapetes,eqseguridad,tapongas,llantarep,esprizquierdo,limpiadores,molduras,tapones,antena,documentos,imagen,imagen2) values (@id_ord,@encendedor,@estereo,@cenicero,@esprcentral,@esprderecho,@herramienta,@tapetes,@eqseguridad,@tapongas,@llantarep,@esprizquierdo,@limpiadores,@molduras,@tapones,@antena,@documentos,@imagen,@imagen2)", _conexion)

            adaptador.InsertCommand.Parameters.Add("@id_ord", MySqlDbType.Double, 50).Value = datos.id_ord
            adaptador.InsertCommand.Parameters.Add("@encendedor", MySqlDbType.Int16, 1).Value = datos.encendedor
            adaptador.InsertCommand.Parameters.Add("@estereo", MySqlDbType.Int16, 1).Value = datos.estereo
            adaptador.InsertCommand.Parameters.Add("@cenicero", MySqlDbType.Int16, 1).Value = datos.cenicero
            adaptador.InsertCommand.Parameters.Add("@esprcentral", MySqlDbType.Int16, 1).Value = datos.esprcentral
            adaptador.InsertCommand.Parameters.Add("@esprderecho", MySqlDbType.Int16, 1).Value = datos.esprrerecho
            adaptador.InsertCommand.Parameters.Add("@herramienta", MySqlDbType.Int16, 1).Value = datos.herramienta
            adaptador.InsertCommand.Parameters.Add("@tapetes", MySqlDbType.Int16, 1).Value = datos.tapetes
            adaptador.InsertCommand.Parameters.Add("@eqseguridad", MySqlDbType.Int16, 1).Value = datos.eqseguridad
            adaptador.InsertCommand.Parameters.Add("@tapongas", MySqlDbType.Int16, 1).Value = datos.tapongas
            adaptador.InsertCommand.Parameters.Add("@llantarep", MySqlDbType.Int16, 1).Value = datos.llantaref
            adaptador.InsertCommand.Parameters.Add("@esprizquierdo", MySqlDbType.Int16, 1).Value = datos.esprizquierdo
            adaptador.InsertCommand.Parameters.Add("@limpiadores", MySqlDbType.Int16, 1).Value = datos.limpiadores
            adaptador.InsertCommand.Parameters.Add("@molduras", MySqlDbType.Int16, 1).Value = datos.molduras
            adaptador.InsertCommand.Parameters.Add("@tapones", MySqlDbType.Int16, 1).Value = datos.tapones
            adaptador.InsertCommand.Parameters.Add("@antena", MySqlDbType.Int16, 1).Value = datos.antena
            adaptador.InsertCommand.Parameters.Add("@documentos", MySqlDbType.Int16, 1).Value = datos.documentos
            adaptador.InsertCommand.Parameters.Add("@imagen", MySqlDbType.Blob, 1).Value = datos.imagen
            adaptador.InsertCommand.Parameters.Add("@imagen2", MySqlDbType.Blob, 1).Value = datos.imagen2

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function insertarnuevo(ByVal datos As C_Orden) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into orden(id_veh,fecha_ord,km_ord,tipo_ord,edo_ord,recepcion_ord,entrega_ord,des_ord,notas_ord,subtotal,iva,total,saldo) values (@id_veh,@fecha_ord,@km_ord,@tipo_ord,@edo_ord,@recepcion_ord,@entrega_ord,@des_ord,@notas_ord,@subtotal,@iva,@total,@saldo)", _conexion)

            adaptador.InsertCommand.Parameters.Add("@id_veh", MySqlDbType.Double, 50).Value = datos.id_veh
            adaptador.InsertCommand.Parameters.Add("@fecha_ord", MySqlDbType.Date).Value = datos.fecha_ord
            adaptador.InsertCommand.Parameters.Add("@km_ord", MySqlDbType.Double, 1).Value = datos.km_ord
            adaptador.InsertCommand.Parameters.Add("@tipo_ord", MySqlDbType.String).Value = datos.tipo_ord
            adaptador.InsertCommand.Parameters.Add("@edo_ord", MySqlDbType.String).Value = datos.edo_ord
            adaptador.InsertCommand.Parameters.Add("@recepcion_ord", MySqlDbType.Date).Value = datos.recepcion_ord
            adaptador.InsertCommand.Parameters.Add("@entrega_ord", MySqlDbType.Date).Value = datos.entrega_ord
            adaptador.InsertCommand.Parameters.Add("@des_ord", MySqlDbType.String).Value = datos.des_ord
            adaptador.InsertCommand.Parameters.Add("@notas_ord", MySqlDbType.String).Value = datos.notas_ord
            adaptador.InsertCommand.Parameters.Add("@subtotal", MySqlDbType.Decimal).Value = datos.subtotal
            adaptador.InsertCommand.Parameters.Add("@iva", MySqlDbType.Decimal).Value = datos.iva
            adaptador.InsertCommand.Parameters.Add("@total", MySqlDbType.Decimal).Value = datos.total
            adaptador.InsertCommand.Parameters.Add("@saldo", MySqlDbType.Decimal).Value = datos.saldo


            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function insertarnuevo(ByVal datos As C_Detalleorden) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into detalleorden (id_ord,id_item,cant_item,id_umed,total,tipo) values (@id_ord,@id_item,@cant_item,@id_umed,@total,@tipo)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@id_ord", MySqlDbType.Int64, 20).Value = datos.id_ord
            adaptador.InsertCommand.Parameters.Add("@id_item", MySqlDbType.Int64, 20).Value = datos.id_item
            adaptador.InsertCommand.Parameters.Add("@cant_item", MySqlDbType.Double, 22).Value = datos.cant_item
            adaptador.InsertCommand.Parameters.Add("@id_umed", MySqlDbType.Int32, 11).Value = datos.id_umed
            adaptador.InsertCommand.Parameters.Add("@total", MySqlDbType.Double, 22).Value = datos.total_detalle
            adaptador.InsertCommand.Parameters.Add("@tipo", MySqlDbType.String, 50).Value = datos.tipo

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function modificar(ByVal datos As C_Cliente, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update cliente Set rfc_clie=@rfc_clie,nombre_clie=@nombre_clie,dir_clie=@dir_clie,col_clie=@col_clie,cp_clie=@cp_clie,cd_clie=@cd_clie,edo_clie=@edo_clie,cel_clie=@cel_clie,tel_clie=@tel_clie,email_clie=@email_clie where id_clie=@id_clie", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_clie", MySqlDbType.Int64, 20).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@rfc_clie", MySqlDbType.VarChar, 15).Value = datos.rfc_clie
            adaptador.UpdateCommand.Parameters.Add("@nombre_clie", MySqlDbType.VarChar, 600).Value = datos.nombre_clie
            adaptador.UpdateCommand.Parameters.Add("@dir_clie", MySqlDbType.VarChar, 800).Value = datos.dir_clie
            adaptador.UpdateCommand.Parameters.Add("@col_clie", MySqlDbType.VarChar, 150).Value = datos.col_clie
            adaptador.UpdateCommand.Parameters.Add("@cp_clie", MySqlDbType.VarChar, 5).Value = datos.cp_clie
            adaptador.UpdateCommand.Parameters.Add("@cd_clie", MySqlDbType.VarChar, 150).Value = datos.cd_clie
            adaptador.UpdateCommand.Parameters.Add("@edo_clie", MySqlDbType.VarChar, 150).Value = datos.edo_clie
            adaptador.UpdateCommand.Parameters.Add("@cel_clie", MySqlDbType.VarChar, 45).Value = datos.cel_clie
            adaptador.UpdateCommand.Parameters.Add("@tel_clie", MySqlDbType.VarChar, 45).Value = datos.tel_clie
            adaptador.UpdateCommand.Parameters.Add("@email_clie", MySqlDbType.VarChar, 100).Value = datos.email_clie
            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function modificar(ByVal datos As C_Vehiculo, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update vehiculo Set placa_veh=@placa_veh,id_marca=@id_marca,marca_veh=@marca_Veh,id_submarca=@id_submarca,submarca_veh=@submarca_veh,serie_veh=@serie_veh,id_motor=@id_motor,tipom_veh=@tipom_veh,año_veh=@año_veh,color_veh=@color_veh,motor_veh=@motor_veh,gasolina_veh=@gasolina_veh,obs_veh=@obs_veh,id_tipo_veh=@id_tipo_veh,tipo_veh=@tipo_veh,cliente_id_clie=@cliente_id_clie where id_veh=@id_veh", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_veh", MySqlDbType.Int64, 20).Value = datos.id_veh
            adaptador.UpdateCommand.Parameters.Add("@placa_veh", MySqlDbType.VarChar, 100).Value = datos.placa_veh
            adaptador.UpdateCommand.Parameters.Add("@id_marca", MySqlDbType.Int64, 20).Value = datos.id_marca
            adaptador.UpdateCommand.Parameters.Add("@marca_Veh", MySqlDbType.VarChar, 100).Value = datos.marca_veh
            adaptador.UpdateCommand.Parameters.Add("@id_submarca", MySqlDbType.Int64, 20).Value = datos.id_submarca
            adaptador.UpdateCommand.Parameters.Add("@submarca_veh", MySqlDbType.VarChar, 100).Value = datos.submarca_veh
            adaptador.UpdateCommand.Parameters.Add("@serie_veh", MySqlDbType.VarChar, 100).Value = datos.serie_veh
            adaptador.UpdateCommand.Parameters.Add("@id_motor", MySqlDbType.Int32, 11).Value = datos.id_motor
            adaptador.UpdateCommand.Parameters.Add("@tipom_veh", MySqlDbType.VarChar, 100).Value = datos.tipom_veh
            adaptador.UpdateCommand.Parameters.Add("@año_veh", MySqlDbType.VarChar, 45).Value = datos.año_veh
            adaptador.UpdateCommand.Parameters.Add("@color_veh", MySqlDbType.VarChar, 100).Value = datos.color_veh
            adaptador.UpdateCommand.Parameters.Add("@motor_veh", MySqlDbType.VarChar, 100).Value = datos.motor_veh
            adaptador.UpdateCommand.Parameters.Add("@gasolina_veh", MySqlDbType.VarChar, 45).Value = datos.gasolina_veh
            adaptador.UpdateCommand.Parameters.Add("@obs_veh", MySqlDbType.VarChar, 5000).Value = datos.obs_veh
            adaptador.UpdateCommand.Parameters.Add("@id_tipo_veh", MySqlDbType.Int32, 11).Value = datos.id_tipo_veh
            adaptador.UpdateCommand.Parameters.Add("@tipo_veh", MySqlDbType.VarChar, 150).Value = datos.tipo_veh
            adaptador.UpdateCommand.Parameters.Add("@cliente_id_clie", MySqlDbType.Int64, 20).Value = datos.cliente_id_clie
            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function modificar(ByVal datos As C_Item, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update item Set clave_item=@clave_item,nombre_item=@nombre_item,id_umed=@id_umed,tipo_item=@tipo_item,id_linea=@id_linea,id_clase=@id_clase,id_subclase=@id_subclase,id_marca=@id_marca,id_submarca=@id_submarca,id_motor=@id_motor,stock_item=@stock_item,min_item=@min_item,max_item=@max_item,garantia_item=@garantia_item,costo_item=@costo_item,precio_item=@precio_item where id_item=@id_item", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_item", MySqlDbType.Int64, 20).Value = datos.id_item
            adaptador.UpdateCommand.Parameters.Add("@clave_item", MySqlDbType.VarChar, 50).Value = datos.clave_item
            adaptador.UpdateCommand.Parameters.Add("@nombre_item", MySqlDbType.VarChar, 1500).Value = datos.nombre_item
            adaptador.UpdateCommand.Parameters.Add("@id_umed", MySqlDbType.Int32, 11).Value = datos.id_umed
            adaptador.UpdateCommand.Parameters.Add("@tipo_item", MySqlDbType.VarChar, 500).Value = datos.tipo_item

            adaptador.UpdateCommand.Parameters.Add("@id_linea", MySqlDbType.Int32, 11).Value = datos.id_linea
            adaptador.UpdateCommand.Parameters.Add("@id_clase", MySqlDbType.Int32, 11).Value = datos.id_clase
            adaptador.UpdateCommand.Parameters.Add("@id_subclase", MySqlDbType.Int32, 11).Value = datos.id_subclase
            adaptador.UpdateCommand.Parameters.Add("@id_marca", MySqlDbType.Int32, 11).Value = datos.id_marca
            adaptador.UpdateCommand.Parameters.Add("@id_submarca", MySqlDbType.Int32, 11).Value = datos.id_submarca
            adaptador.UpdateCommand.Parameters.Add("@id_motor", MySqlDbType.Int32, 11).Value = datos.id_motor

            adaptador.UpdateCommand.Parameters.Add("@stock_item", MySqlDbType.Decimal, 10.2).Value = datos.stock_item
            adaptador.UpdateCommand.Parameters.Add("@min_item", MySqlDbType.Decimal, 10.2).Value = datos.min_item
            adaptador.UpdateCommand.Parameters.Add("@max_item", MySqlDbType.Decimal, 10.2).Value = datos.max_item
            adaptador.UpdateCommand.Parameters.Add("@garantia_item", MySqlDbType.Int32, 11).Value = datos.garantia_item
            adaptador.UpdateCommand.Parameters.Add("@costo_item", MySqlDbType.Decimal, 10.2).Value = datos.costo_item
            adaptador.UpdateCommand.Parameters.Add("@precio_item", MySqlDbType.Decimal, 10.2).Value = datos.precio_item


            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function modificar(ByVal datos As C_Marca, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update marca Set nom_marca=@nom_marca where id_marca=@id_marca", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_marca", MySqlDbType.Int64, 20).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_marca", MySqlDbType.VarChar, 500).Value = datos.nom_marca

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function modificar(ByVal datos As C_Submarca, ByVal clave As String, ByVal subclave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update submarca Set nom_submarca=@nom_marca where id_marca=@id_marca And id_submarca=@id_submarca", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_marca", MySqlDbType.Int64, 20).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@id_submarca", MySqlDbType.Int64, 20).Value = subclave
            adaptador.UpdateCommand.Parameters.Add("@nom_marca", MySqlDbType.VarChar, 500).Value = datos.nom_submarca

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function modificar(ByVal datos As C_Tipo_Veh, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update tipo_veh Set nombre_tipo_veh=@nombre_tipo_veh where id_tipo_veh=@id_tipo_veh", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_tipo_veh", MySqlDbType.Int64, 20).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nombre_tipo_veh", MySqlDbType.VarChar, 500).Value = datos.nombre_tipo_veh

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function modificar(ByVal datos As C_Motor, ByVal marca As String, ByVal submarca As String, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update motor Set tipom=@tipom where id_marca=@id_marca And id_submarca=@id_submarca And id_motor=@id_motor", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_marca", MySqlDbType.Int64, 20).Value = marca
            adaptador.UpdateCommand.Parameters.Add("@id_submarca", MySqlDbType.Int64, 20).Value = submarca
            adaptador.UpdateCommand.Parameters.Add("@id_motor", MySqlDbType.Int32, 11).Value = submarca
            adaptador.UpdateCommand.Parameters.Add("@tipom", MySqlDbType.VarChar, 50).Value = datos.tipom

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function modificar(ByVal datos As C_Linea, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update linea Set nom_linea=@nom_linea where id_linea=@id_linea", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_linea", MySqlDbType.Int64, 20).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_linea", MySqlDbType.VarChar, 500).Value = datos.nom_linea

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function modificar(ByVal datos As C_Clase, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update clase Set nom_clase=@nom_clase where id_clase=@id_clase", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_clase", MySqlDbType.Int32, 11).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_clase", MySqlDbType.VarChar, 500).Value = datos.nom_clase

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function modificar(ByVal datos As C_Subclase, ByVal clave As String, ByVal subclave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update subclase Set nom_subclase=@nom_subclase where id_clase=@id_clase And id_subclase=@id_subclase", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_clase", MySqlDbType.Int32, 11).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@id_subclase", MySqlDbType.Int32, 11).Value = subclave
            adaptador.UpdateCommand.Parameters.Add("@nom_subclase", MySqlDbType.VarChar, 500).Value = datos.nom_subclase

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function modificar(ByVal datos As C_Umed, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update umedida Set nom_umed=@nom_umdad,corto_umed=@corto_umed where id_umed=@id_umed", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_umed", MySqlDbType.Int64, 20).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_umed", MySqlDbType.VarChar, 50).Value = datos.nom_umed
            adaptador.UpdateCommand.Parameters.Add("@corto_umed", MySqlDbType.VarChar, 50).Value = datos.corto_umed

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function eliminar(ByVal datos As C_Cliente, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update cliente Set estado_clie=0 where id_clie=@id_clie", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_clie", MySqlDbType.Int64, 20).Value = clave

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function eliminar(ByVal datos As C_Vehiculo, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update vehiculo Set estado_vehi=0 where id_veh=@id_veh", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_veh", MySqlDbType.Int64, 20).Value = clave

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function eliminar(ByVal datos As C_Item, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update item Set estado_item=0 where id_item=@id_item", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_item", MySqlDbType.Int64, 20).Value = clave

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function eliminar(ByVal datos As C_Marca, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update marca Set estado_marca=0 where id_marca=@id_marca", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_marca", MySqlDbType.Int64, 20).Value = clave

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function eliminar(ByVal datos As C_Submarca, ByVal clave As String, ByVal subclave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update submarca Set estado_submarca=0 where id_marca=@id_marca And id_submarca=@id_submarca", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_marca", MySqlDbType.Int64, 20).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@id_submarca", MySqlDbType.Int64, 20).Value = subclave

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function eliminar(ByVal datos As C_Tipo_Veh, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update tipo_veh Set estado_tipo_veh=0 where id_tipo_veh=@id_tipo_veh", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_tipo_veh", MySqlDbType.Int64, 20).Value = clave

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function eliminar(ByVal datos As C_Motor, ByVal marca As String, ByVal submarca As String, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update motor Set estado_motor=0 where id_marca=@id_marca And id_submarca=@id_submarca And id_motor=@id_motor", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_marca", MySqlDbType.Int64, 20).Value = marca
            adaptador.UpdateCommand.Parameters.Add("@id_submarca", MySqlDbType.Int64, 20).Value = submarca
            adaptador.UpdateCommand.Parameters.Add("@id_motor", MySqlDbType.Int32, 11).Value = clave

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function eliminar(ByVal datos As C_Clase, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update clase Set estado_clase=0 where id_clase=@id_clase", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_clase", MySqlDbType.Int32, 11).Value = clave

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function eliminar(ByVal datos As C_Linea, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update linea Set estado_linea=0 where id_linea=@id_linea", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_linea", MySqlDbType.Int32, 11).Value = clave

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function eliminar(ByVal datos As C_Subclase, ByVal clave As String, ByVal subclave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update subclase Set estado_subclase=0 where id_clase=@id_clase And id_subclase=@id_subclase", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_clase", MySqlDbType.Int32, 11).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@id_subclase", MySqlDbType.Int32, 11).Value = subclave

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function eliminar(ByVal datos As C_Umed, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update umedida Set estado_umed=0 where id_umed=@id_umed", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_umed", MySqlDbType.Int32, 11).Value = clave

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Sub desconectar()
        _conexion.Close()




    End Sub
    Public Function actualizaritem(ByVal clave As String, ByVal final As Double) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update item Set stock_item=@final where id_item=@id_item", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_item", MySqlDbType.Int32, 11).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@final", MySqlDbType.Double, 22).Value = final

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function insertarmov(ByVal datos As C_Movimiento) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into movimiento (id_item,id_tipomov,fecha_mov,ini_mov,cant_mov,id_umed,fin_mov,obs_mov) values (@id_item,@tipo_mov,@fecha_mov,@ini_mov,@cant_mov,@id_umed,@fin_mov,@obs_mov)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@id_item", MySqlDbType.Int64, 20).Value = datos.id_item
            adaptador.InsertCommand.Parameters.Add("@tipo_mov", MySqlDbType.Int32, 11).Value = datos.tipo_mov
            adaptador.InsertCommand.Parameters.Add("@fecha_mov", MySqlDbType.VarChar, 10).Value = datos.fecha_mov.ToString("yyyy'-'MM'-'dd")
            adaptador.InsertCommand.Parameters.Add("@ini_mov", MySqlDbType.Double, 12).Value = datos.ini_mov
            adaptador.InsertCommand.Parameters.Add("@cant_mov", MySqlDbType.Double, 12).Value = datos.cant_mov
            adaptador.InsertCommand.Parameters.Add("@id_umed", MySqlDbType.Int32, 11).Value = datos.id_umed
            adaptador.InsertCommand.Parameters.Add("@fin_mov", MySqlDbType.Double, 12).Value = datos.fin_mov
            adaptador.InsertCommand.Parameters.Add("@obs_mov", MySqlDbType.String, 5000).Value = datos.obs_mov
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
End Class
