Public Class C_Movimiento

    Private _id_mov As Int64
    Private _id_item As Int64
    Private _tipo_mov As Integer
    Private _fecha_mov As Date
    Private _ini_mov As Double
    Private _cant_mov As Double
    Private _id_umed As Integer
    Private _fin_mov As Double
    Private _obs_mov As String

    Public Property id_mov() As Int64
        Get
            Return _id_mov
        End Get
        Set(ByVal value As Int64)
            _id_mov = value
        End Set
    End Property

    Public Property id_item() As Int64
        Get
            Return _id_item
        End Get
        Set(ByVal value As Int64)
            _id_item = value
        End Set
    End Property
    Public Property tipo_mov() As Integer
        Get
            Return _tipo_mov
        End Get
        Set(ByVal value As Integer)
            _tipo_mov = value
        End Set
    End Property

    Public Property fecha_mov() As Date
        Get
            Return _fecha_mov
        End Get
        Set(ByVal value As Date)
            _fecha_mov = value
        End Set
    End Property

    Public Property ini_mov() As Double
        Get
            Return _ini_mov
        End Get
        Set(ByVal value As Double)
            _ini_mov = value
        End Set
    End Property

    Public Property cant_mov() As Double
        Get
            Return _cant_mov
        End Get
        Set(ByVal value As Double)
            _cant_mov = value
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

    Public Property fin_mov() As Double
        Get
            Return _fin_mov
        End Get
        Set(ByVal value As Double)
            _fin_mov = value
        End Set
    End Property
    Public Property obs_mov() As String
        Get
            Return _obs_mov
        End Get
        Set(ByVal value As String)
            _obs_mov = value
        End Set
    End Property

End Class
