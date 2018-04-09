Public Class C_Marca
    Private _id_marca As Double
    Private _nom_marca As String
    Private _estado_marca As Boolean


    Public Property id_marca() As Double
        Get
            Return _id_marca
        End Get
        Set(ByVal value As Double)
            _id_marca = value
        End Set
    End Property

    Public Property nom_marca() As String
        Get
            Return _nom_marca
        End Get
        Set(ByVal value As String)
            _nom_marca = value
        End Set
    End Property

    Public Property estado_marca() As Boolean
        Get
            Return _estado_marca
        End Get
        Set(ByVal value As Boolean)
            _estado_marca = value
        End Set
    End Property
End Class
