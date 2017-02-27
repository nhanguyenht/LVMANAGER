Public Class cls_History
    Dim mvStr_Code As String
    Dim mvDate_InvoiceDay As Date
    Dim mvStr_MoneyType As String
    Dim mvDbl_Balance As Double
    Dim mvDbl_Amount As Double
    Dim mvByte_Status As Byte
    Property Code() As String
        Get
            Return mvStr_Code
        End Get
        Set(ByVal value As String)
            mvStr_Code = value
        End Set
    End Property
    Property InvoiceDay() As Date
        Get
            Return mvDate_InvoiceDay
        End Get
        Set(ByVal value As Date)
            mvDate_InvoiceDay = value
        End Set
    End Property
    Property MoneyType() As String
        Get
            Return mvStr_MoneyType
        End Get
        Set(ByVal value As String)
            mvStr_MoneyType = value
        End Set
    End Property
    Property Balance() As Double
        Get
            Return mvDbl_Balance
        End Get
        Set(ByVal value As Double)
            mvDbl_Balance = value
        End Set
    End Property
    Property Amount() As Double
        Get
            Return mvDbl_Amount
        End Get
        Set(ByVal value As Double)
            mvDbl_Amount = value
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
