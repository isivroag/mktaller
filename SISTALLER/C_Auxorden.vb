Public Class C_Auxorden

    Private _id_ord As Double
    Private _encendedor As Boolean
    Private _estereo As Boolean
    Private _cenicero As Boolean
    Private _esprcentral As Boolean
    Private _esprrerecho As Boolean
    Private _herramienta As Boolean
    Private _tapetes As Boolean
    Private _eqseguridad As Boolean
    Private _tapongas As Boolean
    Private _llantaref As Boolean
    Private _esprizquierdo As Boolean
    Private _limpiadores As Boolean
    Private _molduras As Boolean
    Private _tapones As Boolean
    Private _antena As Boolean
    Private _documentos As Boolean
    Private _imagen As Byte()
    Private _imagen2 As Byte()
    Private _estado_ord As Boolean

    Public Property id_ord() As Double
        Get
            Return _id_ord
        End Get
        Set(ByVal value As Double)
            _id_ord = value
        End Set
    End Property

    Public Property encendedor() As Boolean
        Get
            Return _encendedor
        End Get
        Set(ByVal value As Boolean)
            _encendedor = value
        End Set
    End Property

    Public Property estereo() As Boolean
        Get
            Return _estereo
        End Get
        Set(ByVal value As Boolean)
            _estereo = value
        End Set
    End Property

    Public Property cenicero() As Boolean
        Get
            Return _cenicero
        End Get
        Set(ByVal value As Boolean)
            _cenicero = value
        End Set
    End Property
    Public Property esprcentral() As Boolean
        Get
            Return _esprcentral
        End Get
        Set(ByVal value As Boolean)
            _esprcentral = value
        End Set
    End Property
    Public Property esprrerecho() As Boolean
        Get
            Return _esprrerecho
        End Get
        Set(ByVal value As Boolean)
            _esprrerecho = value
        End Set
    End Property
    Public Property herramienta() As Boolean
        Get
            Return _herramienta
        End Get
        Set(ByVal value As Boolean)
            _herramienta = value
        End Set
    End Property
    Public Property tapetes() As Boolean
        Get
            Return _tapetes
        End Get
        Set(ByVal value As Boolean)
            _tapetes = value
        End Set
    End Property
    Public Property eqseguridad() As Boolean
        Get
            Return _eqseguridad
        End Get
        Set(ByVal value As Boolean)
            _eqseguridad = value
        End Set
    End Property
    Public Property tapongas() As Boolean
        Get
            Return _tapongas
        End Get
        Set(ByVal value As Boolean)
            _tapongas = value
        End Set
    End Property
    Public Property llantaref() As Boolean
        Get
            Return _llantaref
        End Get
        Set(ByVal value As Boolean)
            _llantaref = value
        End Set
    End Property
    Public Property esprizquierdo() As Boolean
        Get
            Return _esprizquierdo
        End Get
        Set(ByVal value As Boolean)
            _esprizquierdo = value
        End Set
    End Property

    Public Property limpiadores() As Boolean
        Get
            Return _limpiadores
        End Get
        Set(ByVal value As Boolean)
            _limpiadores = value
        End Set
    End Property
    Public Property molduras() As Boolean
        Get
            Return _molduras
        End Get
        Set(ByVal value As Boolean)
            _molduras = value
        End Set
    End Property
    Public Property tapones() As Boolean
        Get
            Return _tapones
        End Get
        Set(ByVal value As Boolean)
            _tapones = value
        End Set
    End Property
    Public Property antena() As Boolean
        Get
            Return _antena
        End Get
        Set(ByVal value As Boolean)
            _antena = value
        End Set
    End Property
    Public Property documentos() As Boolean
        Get
            Return _documentos
        End Get
        Set(ByVal value As Boolean)
            _documentos = value
        End Set
    End Property

    Public Property imagen() As Byte()
        Get
            Return _imagen
        End Get
        Set(ByVal value As Byte())
            _imagen = value
        End Set
    End Property

    Public Property imagen2() As Byte()
        Get
            Return _imagen2
        End Get
        Set(ByVal value As Byte())
            _imagen2 = value
        End Set
    End Property
    Public Property estado_ord() As Boolean
        Get
            Return _estado_ord
        End Get
        Set(ByVal value As Boolean)
            _estado_ord = value
        End Set
    End Property
End Class
