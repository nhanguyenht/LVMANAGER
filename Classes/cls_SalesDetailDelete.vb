Public Class cls_SalesDetailDelete
    Private wStr_ID As String
    Private wStr_Item_ID As String
    Private wStr_Qty As Double
    Private wStr_OldQty As Double
    Private wStr_Price As Double
    Private wStr_Name As String
    Private wStr_CreateDate As DateTime
    Private wStr_Cashier As String
    Public Property ID() As String
        Get
            Return Me.wStr_ID
        End Get
        Set(ByVal Value As String)
            Me.wStr_ID = Value
        End Set
    End Property
    Public Property Item_ID() As String
        Get
            Return Me.wStr_Item_ID
        End Get
        Set(ByVal Value As String)
            Me.wStr_Item_ID = Value
        End Set
    End Property

    Public Property Quantity() As Double
        Get
            Return Me.wStr_Qty
        End Get
        Set(ByVal Value As Double)
            Me.wStr_Qty = Value
        End Set
    End Property
    Public Property OldQuantity() As Double
        Get
            Return Me.wStr_OldQty
        End Get
        Set(ByVal Value As Double)
            Me.wStr_OldQty = Value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return Me.wStr_Name
        End Get
        Set(ByVal Value As String)
            Me.wStr_Name = Value
        End Set
    End Property
    Public Property Price() As Double
        Get
            Return Me.wStr_Price
        End Get
        Set(ByVal Value As Double)
            Me.wStr_Price = Value
        End Set
    End Property
    Public Property CreateDate() As DateTime
        Get
            Return Me.wStr_CreateDate
        End Get
        Set(ByVal Value As DateTime)
            Me.wStr_CreateDate = Value
        End Set
    End Property
    Public Property Cashier() As String
        Get
            Return Me.wStr_Cashier
        End Get
        Set(ByVal Value As String)
            Me.wStr_Cashier = Value
        End Set
    End Property
End Class
