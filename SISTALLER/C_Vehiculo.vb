Public Class C_Vehiculo
    Private _id_veh As Double
    Private _placa_veh As String
    Private _id_marca As Double
    Private _marca_veh As String
    Private _id_submarca As Double
    Private _submarca_veh As String
    Private _serie_veh As String
    Private _id_motor As Integer
    Private _tipom_veh As String
    Private _año_veh As String
    Private _color_veh As String
    Private _motor_veh As String
    Private _gasolina_veh As String
    Private _obs_veh As String
    Private _id_tipo_veh As Integer
    Private _tipo_veh As String
    Private _cliente_id_clie As String
    Private _estado_veh As Boolean

    Public Property id_veh As String
        Get
            Return _id_veh
        End Get
        Set(value As String)
            _id_veh = value
        End Set
    End Property

    Public Property placa_veh() As String
        Get
            Return _placa_veh
        End Get
        Set(ByVal value As String)
            _placa_veh = value
        End Set
    End Property
    Public Property id_marca() As Double
        Get
            Return _id_marca
        End Get
        Set(ByVal value As Double)
            _id_marca = value
        End Set
    End Property
    Public Property marca_veh() As String
        Get
            Return _marca_veh
        End Get
        Set(ByVal value As String)
            _marca_veh = value
        End Set
    End Property

    Public Property id_submarca() As Double
        Get
            Return _id_submarca
        End Get
        Set(ByVal value As Double)
            _id_submarca = value
        End Set
    End Property
    Public Property submarca_veh() As String
        Get
            Return _submarca_veh
        End Get
        Set(ByVal value As String)
            _submarca_veh = value
        End Set
    End Property
    Public Property serie_veh() As String
        Get
            Return _serie_veh
        End Get
        Set(ByVal value As String)
            _serie_veh = value
        End Set
    End Property

    Public Property id_motor() As Integer
        Get
            Return _id_motor
        End Get
        Set(ByVal value As Integer)
            _id_motor = value
        End Set
    End Property
    Public Property tipom_veh() As String
        Get
            Return _tipom_veh
        End Get
        Set(ByVal value As String)
            _tipom_veh = value
        End Set
    End Property

    Public Property año_veh() As String
        Get
            Return _año_veh
        End Get
        Set(ByVal value As String)
            _año_veh = value
        End Set
    End Property
    Public Property color_veh() As String
        Get
            Return _color_veh
        End Get
        Set(ByVal value As String)
            _color_veh = value
        End Set
    End Property

    Public Property motor_veh() As String
        Get
            Return _motor_veh
        End Get
        Set(ByVal value As String)
            _motor_veh = value
        End Set
    End Property


    Public Property gasolina_veh() As String
        Get
            Return _gasolina_veh
        End Get
        Set(ByVal value As String)
            _gasolina_veh = value
        End Set
    End Property

    Public Property obs_veh() As String
        Get
            Return _obs_veh
        End Get
        Set(ByVal value As String)
            _obs_veh = value
        End Set
    End Property

    Public Property id_tipo_veh() As Integer
        Get
            Return _id_tipo_veh
        End Get
        Set(ByVal value As Integer)
            _id_tipo_veh = value
        End Set
    End Property
    Public Property tipo_veh() As String
        Get
            Return _tipo_veh
        End Get
        Set(ByVal value As String)
            _tipo_veh = value
        End Set
    End Property

    Public Property cliente_id_clie() As String
        Get
            Return _cliente_id_clie
        End Get
        Set(ByVal value As String)
            _cliente_id_clie = value
        End Set
    End Property

    Public Property estado_veh() As Boolean
        Get
            Return _estado_veh
        End Get
        Set(ByVal value As Boolean)
            _estado_veh = value
        End Set
    End Property
End Class
