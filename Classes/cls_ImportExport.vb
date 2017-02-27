Public Class cls_ImportExport
    Dim mvStr_ID As String
    Dim mvStr_Invoice As String
    Dim mvDate_CreateDate As Date
    Dim mvStr_User As String
    Dim mvStr_Suppliers As String
    Dim mvDbl_Total As Double
    Dim mvByte_Type As Byte
    Dim mvStr_Note As String
    Dim mvByte_Status As Byte
    Dim mvStr_InventoryID As String
    Dim mvStr_ToInventoryID As String
    Property ID() As String
        Get
            Return mvStr_ID
        End Get
        Set(ByVal value As String)
            mvStr_ID = value
        End Set
    End Property
    Property Invoice() As String
        Get
            Return mvStr_Invoice
        End Get
        Set(ByVal value As String)
            mvStr_Invoice = value
        End Set
    End Property
    Property CreateDay() As Date
        Get
            Return mvDate_CreateDate
        End Get
        Set(ByVal value As Date)
            mvDate_CreateDate = value
        End Set
    End Property
    Property User() As String
        Get
            Return mvStr_User
        End Get
        Set(ByVal value As String)
            mvStr_User = value
        End Set
    End Property
    Property Suppliers() As String
        Get
            Return mvStr_Suppliers
        End Get
        Set(ByVal value As String)
            mvStr_Suppliers = value
        End Set
    End Property
    Property Total() As Double
        Get
            Return mvDbl_Total
        End Get
        Set(ByVal value As Double)
            mvDbl_Total = value
        End Set
    End Property
    Property Type() As Byte
        Get
            Return mvByte_Type
        End Get
        Set(ByVal value As Byte)
            mvByte_Type = value
        End Set
    End Property
    Property Note() As String
        Get
            Return mvStr_Note
        End Get
        Set(ByVal value As String)
            mvStr_Note = value
        End Set
    End Property
    Property Status() As Byte
        Get
            Return mvByte_Status
        End Get
        Set(ByVal value As Byte)
            mvByte_Status = value
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
    Property ToInventoryID() As String
        Get
            Return mvStr_ToInventoryID
        End Get
        Set(ByVal value As String)
            mvStr_ToInventoryID = value
        End Set
    End Property
End Class
