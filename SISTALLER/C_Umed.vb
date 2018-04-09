Public Class C_Umed
    Private _id_umed As Integer
    Private _nom_umed As String
    Private _corto_umed As String
    Private _estado_umed As Boolean


    Public Property id_umed() As Integer
        Get
            Return _id_umed
        End Get
        Set(ByVal value As Integer)
            _id_umed = value
        End Set
    End Property
    Public Property nom_umed() As String
        Get
            Return _nom_umed
        End Get
        Set(ByVal value As String)
            _nom_umed = value
        End Set
    End Property

    Public Property corto_umed() As String
        Get
            Return _corto_umed
        End Get
        Set(ByVal value As String)
            _corto_umed = value
        End Set
    End Property

    Public Property estado_umed() As Boolean
        Get
            Return _estado_umed
        End Get
        Set(ByVal value As Boolean)
            _estado_umed = value
        End Set
    End Property

End Class
