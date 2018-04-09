Public Class C_Item
    Private _id_item As Double
    Private _clave_item As String
    Private _nombre_item As String
    Private _id_umed As Integer

    Private _tipo_item As String
    Private _id_linea As Integer
    Private _id_clase As Integer
    Private _id_subclase As Integer
    Private _id_marca As Double
    Private _id_submarca As Double
    Private _id_motor As Double

    Private _stock_item As Double
    Private _min_item As Double
    Private _max_item As Double
    Private _garantia_item As Integer
    Private _costo_item As Decimal
    Private _precio_item As Decimal
    Private _estado_item As Integer


    Public Property id_item() As Double
        Get
            Return _id_item
        End Get
        Set(ByVal value As Double)
            _id_item = value
        End Set
    End Property
    Public Property clave_item() As String
        Get
            Return _clave_item
        End Get
        Set(ByVal value As String)
            _clave_item = value
        End Set
    End Property
    Public Property nombre_item() As String
        Get
            Return _nombre_item
        End Get
        Set(ByVal value As String)
            _nombre_item = value
        End Set
    End Property
    Public Property id_umed() As Integer
        Get
            Return _id_umed
        End Get
        Set(ByVal value As Integer)
            _id_umed = value
        End Set
    End Property

    Public Property tipo_item() As String
        Get
            Return _tipo_item
        End Get
        Set(ByVal value As String)
            _tipo_item = value
        End Set
    End Property

    Public Property id_linea() As Integer
        Get
            Return _id_linea
        End Get
        Set(ByVal value As Integer)
            _id_linea = value
        End Set
    End Property

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
    Public Property stock_item() As Double
        Get
            Return _stock_item
        End Get
        Set(ByVal value As Double)
            _stock_item = value
        End Set
    End Property
    Public Property min_item() As Double
        Get
            Return _min_item
        End Get
        Set(ByVal value As Double)
            _min_item = value
        End Set
    End Property

    Public Property max_item() As Double
        Get
            Return _max_item
        End Get
        Set(ByVal value As Double)
            _max_item = value
        End Set
    End Property

    Public Property garantia_item() As Integer
        Get
            Return _garantia_item
        End Get
        Set(ByVal value As Integer)
            _garantia_item = value
        End Set
    End Property
    Public Property costo_item() As Decimal
        Get
            Return _costo_item
        End Get
        Set(ByVal value As Decimal)
            _costo_item = value
        End Set
    End Property
    Public Property precio_item() As Decimal
        Get
            Return _precio_item
        End Get
        Set(ByVal value As Decimal)
            _precio_item = value
        End Set
    End Property
    Public Property estado_item() As Boolean
        Get
            Return _estado_item
        End Get
        Set(ByVal value As Boolean)
            _estado_item = value
        End Set
    End Property
End Class
