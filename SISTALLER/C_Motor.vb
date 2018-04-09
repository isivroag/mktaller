Public Class C_Motor
    Private _id_marca As Double
    Private _id_submarca As Double
    Private _id_motor As Integer
    Private _tipom As String
    Private _estado_motor As Boolean


    Public Property id_marca() As Double
        Get
            Return _id_marca
        End Get
        Set(ByVal value As Double)
            _id_marca = value
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
    Public Property id_motor() As Integer
        Get
            Return _id_motor
        End Get
        Set(ByVal value As Integer)
            _id_motor = value
        End Set
    End Property
    Public Property tipom() As String
        Get
            Return _tipom
        End Get
        Set(ByVal value As String)
            _tipom = value
        End Set
    End Property
    Public Property estado_motor() As Boolean
        Get
            Return _estado_motor
        End Get
        Set(ByVal value As Boolean)
            _estado_motor = value
        End Set
    End Property
End Class
