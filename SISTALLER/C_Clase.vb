Public Class C_Clase
    Private _id_clase As Integer
    Private _nom_clase As String
    Private _estado_clase As Boolean


    Public Property id_clase() As Integer
        Get
            Return _id_clase
        End Get
        Set(ByVal value As Integer)
            _id_clase = value
        End Set
    End Property


    Public Property nom_clase() As String
        Get
            Return _nom_clase
        End Get
        Set(ByVal value As String)
            _nom_clase = value
        End Set
    End Property


    Public Property estado_clase() As Boolean
        Get
            Return _estado_clase
        End Get
        Set(ByVal value As Boolean)
            _estado_clase = value
        End Set
    End Property
End Class