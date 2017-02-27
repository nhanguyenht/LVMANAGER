Public Class cls_SalesDetail
    Private mvStr_ID As String
    Private mvStr_ItemID As String
    Private mvDbl_Quantity As Double
    Private mvDbl_Price As Double
    Private mvByte_Discount As Byte
    Private mvByte_Vat As Byte
    Private mvByte_Service As Byte
    Private mvStr_Note As String
    Private mvStr_ChargeID As String
    Private mvDat_CheckOut As Date
    Private mvByte_Active As Byte
    Private mvDat_CreateDate As Date

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
    Property Price() As Double
        Get
            Return mvDbl_Price
        End Get
        Set(ByVal value As Double)
            mvDbl_Price = value
        End Set
    End Property
    Property Discount() As Byte
        Get
            Return mvByte_Discount
        End Get
        Set(ByVal value As Byte)
            mvByte_Discount = value
        End Set
    End Property
    Property Vat() As Byte
        Get
            Return mvByte_Vat
        End Get
        Set(ByVal value As Byte)
            mvByte_Vat = value
        End Set
    End Property
    Property Service() As Byte
        Get
            Return mvByte_Service
        End Get
        Set(ByVal value As Byte)
            mvByte_Service = value
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
    Property ChargeID() As String
        Get
            Return mvStr_ChargeID
        End Get
        Set(ByVal value As String)
            mvStr_ChargeID = value
        End Set
    End Property
    Property Active()
        Get
            Return mvByte_Active
        End Get
        Set(ByVal value)
            mvByte_Active = value
        End Set
    End Property
    Property CheckOut()
        Get
            Return mvDat_CheckOut
        End Get
        Set(ByVal value)
            mvDat_CheckOut = value
        End Set
    End Property
    Property CreateDate()
        Get
            Return mvDat_CreateDate
        End Get
        Set(ByVal value)
            mvDat_CreateDate = value
        End Set
    End Property
End Class