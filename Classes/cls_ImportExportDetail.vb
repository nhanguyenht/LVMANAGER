Public Class cls_ImportExportDetail
    Dim mvStr_ID As String
    Dim mvStr_ItemID As String
    Dim mvDbl_Quantity As Double
    Dim mvDbl_Price As Double
    Dim mvInt_Vat As Integer
    Dim mvByte_Status As Byte
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
    Property Vat() As Integer
        Get
            Return mvInt_Vat
        End Get
        Set(ByVal value As Integer)
            mvInt_Vat = value
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
End Class
