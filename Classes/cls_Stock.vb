Public Class cls_Stock
    Dim mvStr_ID As String
    Dim mvStr_InventoryID As String
    Dim mvStr_Unit As String
    Dim mvDbl_Quantity As Double
    Dim mvDbl_Price As Double
    Dim mvByte_UpdatedType As Byte
    Property ID() As String
        Get
            Return mvStr_ID
        End Get
        Set(ByVal value As String)
            mvStr_ID = value
        End Set
    End Property
    Property InventoryID() As String
        Get
            Return mvStr_InventoryID
        End Get
        Set(ByVal value As String)
            mvStr_InventoryID = value
        End Set
    End Property
    Property Unit() As String
        Get
            Return mvStr_Unit
        End Get
        Set(ByVal value As String)
            mvStr_Unit = value
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
    Property Price() As Double
        Get
            Return mvDbl_Price
        End Get
        Set(ByVal value As Double)
            mvDbl_Price = value
        End Set
    End Property
    Property UpdatedType() As Byte
        Get
            Return mvByte_UpdatedType
        End Get
        Set(ByVal value As Byte)
            mvByte_UpdatedType = value
        End Set
    End Property
End Class
