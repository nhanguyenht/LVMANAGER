Public Class cls_Promat
    Dim mvStr_ID As String
    Dim mvStr_ItemID As String
    Dim mvDbl_Quantity As Double
    Dim mvByt_Status As Byte
    Dim mvStr_InventoryID As String
    Dim mvStr_LOC_ID As String
    Property LOC_ID() As String
        Get
            Return mvStr_LOC_ID
        End Get
        Set(ByVal value As String)
            mvStr_LOC_ID = value
        End Set
    End Property
    Property ID() As String
        Get
            Return mvStr_ID
        End Get
        Set(ByVal value As String)
            mvStr_ID = value
        End Set
    End Property
    Property ItemID() As String
        Get
            Return mvStr_ItemID
        End Get
        Set(ByVal value As String)
            mvStr_ItemID = value
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
    Property Status() As Byte
        Get
            Return mvByt_Status
        End Get
        Set(ByVal value As Byte)
            mvByt_Status = value
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
End Class
