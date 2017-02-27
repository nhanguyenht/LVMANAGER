Public Class cls_Inventory
    Dim mvStr_InventoryID As String
    Dim mvStr_InventoryName As String
    Dim mvBol_Status As Boolean
    Property InventoryID() As String
        Get
            Return mvStr_InventoryID
        End Get
        Set(ByVal value As String)
            mvStr_InventoryID = value
        End Set
    End Property
    Property InventoryName() As String
        Get
            Return mvStr_InventoryName
        End Get
        Set(ByVal value As String)
            mvStr_InventoryName = value
        End Set
    End Property
    Property Status() As Byte
        Get
            Return mvBol_Status
        End Get
        Set(ByVal value As Byte)
            mvBol_Status = value
        End Set
    End Property
End Class
