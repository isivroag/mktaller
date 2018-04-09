Public Class C_Submarca
    Private _id_marca As Double
    Private _id_submarca As Double
    Private _nom_submarca As String
    Private _estado_submarca As Boolean


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
    Public Property nom_submarca() As String
        Get
            Return _nom_submarca
        End Get
        Set(ByVal value As String)
            _nom_submarca = value
        End Set
    End Property
    Public Property estado_submarca() As Boolean
        Get
            Return _estado_submarca
        End Get
        Set(ByVal value As Boolean)
            _estado_submarca = value
        End Set
    End Property
End Class

