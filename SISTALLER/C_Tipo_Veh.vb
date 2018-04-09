Public Class C_Tipo_Veh
    Private _id_tipo_veh As Integer
    Private _nombre_tipo_veh As String
    Private _estado_tipo_veh As Boolean

    Public Property id_tipo_veh() As Integer
        Get
            Return _id_tipo_veh
        End Get
        Set(ByVal value As Integer)
            _id_tipo_veh = value
        End Set
    End Property

    Public Property nombre_tipo_veh() As String
        Get
            Return _nombre_tipo_veh
        End Get
        Set(ByVal value As String)
            _nombre_tipo_veh = value
        End Set
    End Property

    Public Property estado_tipo_veh() As Boolean
        Get
            Return _estado_tipo_veh
        End Get
        Set(ByVal value As Boolean)
            _estado_tipo_veh = value
        End Set
    End Property
End Class
