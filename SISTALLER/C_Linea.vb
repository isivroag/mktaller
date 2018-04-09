Public Class C_Linea
    Private _id_linea As Integer
    Private _nom_linea As String
    Private _estado_linea As Boolean


    Public Property id_linea() As Integer
        Get
            Return _id_linea
        End Get
        Set(ByVal value As Integer)
            _id_linea = value
        End Set
    End Property


    Public Property nom_linea() As String
        Get
            Return _nom_linea
        End Get
        Set(ByVal value As String)
            _nom_linea = value
        End Set
    End Property


    Public Property estado_linea() As Boolean
        Get
            Return _estado_linea
        End Get
        Set(ByVal value As Boolean)
            _estado_linea = value
        End Set
    End Property
End Class
