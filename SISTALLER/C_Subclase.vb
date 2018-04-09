Public Class C_Subclase

    Private _id_clase As Integer
    Private _id_subclase As Integer
    Private _nom_subclase As String
    Private _estado_subclase As Boolean


    Public Property id_clase() As Integer
        Get
            Return _id_clase
        End Get
        Set(ByVal value As Integer)
            _id_clase = value
        End Set
    End Property
    Public Property id_subclase() As Integer
        Get
            Return _id_subclase
        End Get
        Set(ByVal value As Integer)
            _id_subclase = value
        End Set
    End Property
    Public Property nom_subclase() As String
        Get
            Return _nom_subclase
        End Get
        Set(ByVal value As String)
            _nom_subclase = value
        End Set
    End Property
    Public Property estado_subclase() As Boolean
        Get
            Return _estado_subclase
        End Get
        Set(ByVal value As Boolean)
            _estado_subclase = value
        End Set
    End Property
End Class


