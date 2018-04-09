Public Class C_Orden
    Private _id_ord As Double
    Private _id_veh As Double
    Private _fecha_ord As Date
    Private _km_ord As Double
    Private _tipo_ord As String
    Private _edo_ord As String
    Private _recepcion_ord As Date
    Private _entrega_ord As Date
    Private _des_ord As String
    Private _notas_ord As String
    Private _subtotal As Double
    Private _iva As Double
    Private _total As Double
    Private _saldo As Double
    Private _estado_ord As Boolean


    Public Property id_ord() As Double
        Get
            Return _id_ord
        End Get
        Set(ByVal value As Double)
            _id_ord = value
        End Set
    End Property

    Public Property id_veh() As Double
        Get
            Return _id_veh
        End Get
        Set(ByVal value As Double)
            _id_veh = value
        End Set
    End Property

    Public Property fecha_ord() As Date
        Get
            Return _fecha_ord
        End Get
        Set(ByVal value As Date)
            _fecha_ord = value
        End Set
    End Property


    Public Property km_ord() As Double
        Get
            Return _km_ord
        End Get
        Set(ByVal value As Double)
            _km_ord = value
        End Set
    End Property

    Public Property tipo_ord() As String
        Get
            Return _tipo_ord
        End Get
        Set(ByVal value As String)
            _tipo_ord = value
        End Set
    End Property


    Public Property edo_ord() As String
        Get
            Return _edo_ord
        End Get
        Set(ByVal value As String)
            _edo_ord = value
        End Set
    End Property

    Public Property recepcion_ord() As Date
        Get
            Return _recepcion_ord
        End Get
        Set(ByVal value As Date)
            _recepcion_ord = value
        End Set
    End Property


    Public Property entrega_ord() As Date
        Get
            Return _entrega_ord
        End Get
        Set(ByVal value As Date)
            _entrega_ord = value
        End Set
    End Property


    Public Property des_ord() As String
        Get
            Return _des_ord
        End Get
        Set(ByVal value As String)
            _des_ord = value
        End Set
    End Property

    Public Property notas_ord() As String
        Get
            Return _notas_ord
        End Get
        Set(ByVal value As String)
            _notas_ord = value
        End Set
    End Property

    Public Property subtotal() As Double
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Double)
            _subtotal = value
        End Set
    End Property


    Public Property iva() As Double
        Get
            Return _iva
        End Get
        Set(ByVal value As Double)
            _iva = value
        End Set
    End Property

    Public Property total() As String
        Get
            Return _total
        End Get
        Set(ByVal value As String)
            _total = value
        End Set
    End Property

    Public Property saldo() As String
        Get
            Return _saldo
        End Get
        Set(ByVal value As String)
            _saldo = value
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
