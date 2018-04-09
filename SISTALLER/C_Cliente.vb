
Public Class C_Cliente
    Private _id_clie As Double
    Private _rfc_clie As String
    Private _nombre_clie As String
    Private _dir_clie As String
    Private _cp_clie As String
    Private _col_clie As String
    Private _edo_clie As String
    Private _cd_clie As String
    Private _cel_clie As String
    Private _tel_clie As String
    Private _email_clie As String
    Private _estado_clie As Boolean

    Public Property id_clie() As Double
        Get
            Return _id_clie
        End Get
        Set(ByVal value As Double)
            _id_clie = value
        End Set
    End Property
    Public Property rfc_clie() As String
        Get
            Return _rfc_clie
        End Get
        Set(ByVal value As String)
            _rfc_clie = value
        End Set
    End Property
    Public Property nombre_clie() As String
        Get
            Return _nombre_clie
        End Get
        Set(ByVal value As String)
            _nombre_clie = value
        End Set
    End Property

    Public Property dir_clie() As String
        Get
            Return _dir_clie
        End Get
        Set(value As String)
            _dir_clie = value
        End Set
    End Property
    Public Property cp_clie() As String
        Get
            Return _cp_clie
        End Get
        Set(value As String)
            _cp_clie = value
        End Set
    End Property

    Public Property col_clie() As String
        Get
            Return _col_clie
        End Get
        Set(ByVal value As String)
            _col_clie = value
        End Set
    End Property

    Public Property edo_clie() As String
        Get
            Return _edo_clie
        End Get
        Set(ByVal value As String)
            _edo_clie = value
        End Set
    End Property

    Public Property cd_clie() As String
        Get
            Return _cd_clie
        End Get
        Set(ByVal value As String)
            _cd_clie = value
        End Set
    End Property

    Public Property cel_clie() As String
        Get
            Return _cel_clie
        End Get
        Set(ByVal value As String)
            _cel_clie = value
        End Set
    End Property


    Public Property tel_clie() As String
        Get
            Return _tel_clie
        End Get
        Set(ByVal value As String)
            _tel_clie = value
        End Set
    End Property
    Public Property email_clie() As String
        Get
            Return _email_clie
        End Get
        Set(ByVal value As String)
            _email_clie = value
        End Set
    End Property


    Public Property estado_clie() As Boolean
        Get
            Return _estado_clie
        End Get
        Set(ByVal value As Boolean)
            _estado_clie = value
        End Set
    End Property
End Class
