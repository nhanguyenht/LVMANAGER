Public Class cls_Return
    Dim mvStr_ID As String
    Dim mvStr_Item As String
    Dim mvDbl_Quantity As Double
    Dim mvDbl_ReturnQty As Double
    Dim mvStr_Cashier As String
    Property ID() As String
        Get
            Return mvStr_ID
        End Get
        Set(ByVal value As String)
            mvStr_ID = value
        End Set
    End Property
    Property Item() As String
        Get
            Return mvStr_Item
        End Get
        Set(ByVal value As String)
            mvStr_Item = value
        End Set
    End Property
    Property Quantity() As Double
        Get
            Return mvDbl_Quantity
        End Get
        Set(ByVal value As Double)
            mvDbl_Quantity = value
        End Set
    End Property
    Property ReturnQty() As Double
        Get
            Return mvDbl_ReturnQty
        End Get
        Set(ByVal value As Double)
            mvDbl_ReturnQty = value
        End Set
    End Property
    Property Cashier() As String
        Get
            Return mvStr_Cashier
        End Get
        Set(ByVal value As String)
            mvStr_Cashier = value
        End Set
    End Property
End Class
