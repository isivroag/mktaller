Public Class C_Detalleorden
    Private _id_ord As Double
    Private _id_item As Double
    Private _clave_item As String
    Private _item As String
    Private _cant_item As Double
    Private _id_umed As Integer
    Private _medida As String
    Private _total_detalle As Double
    Private _tipo As String


    Public Property id_ord() As Double
        Get
            Return _id_ord
        End Get
        Set(ByVal value As Double)
            _id_ord = value
        End Set
    End Property

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

    Public Property item() As String
        Get
            Return _item
        End Get
        Set(ByVal value As String)
            _item = value
        End Set
    End Property

    Public Property cant_item() As Double
        Get
            Return _cant_item
        End Get
        Set(ByVal value As Double)
            _cant_item = value
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


    Public Property medida() As String
        Get
            Return _medida
        End Get
        Set(ByVal value As String)
            _medida = value
        End Set
    End Property

    Public Property total_detalle() As Double
        Get
            Return _total_detalle
        End Get
        Set(ByVal value As Double)
            _total_detalle = value
        End Set
    End Property

    Public Property tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property
End Class
