Public Class cls_Sales
    Private mvStr_ID As String
    Private mvStr_CustomerID As String
    Private mvStr_CashierID As String
    Private mvInt_TableID As Integer
    Private mvStr_Waiter As String
    Private mvDate_CheckIn As Date
    Private mvDate_CheckOut As Date
    Private mvVoucher As Double
    Private mvByte_Vat As Byte
    Private mvByte_Status As Byte
    Private mvInt_CustomerNumber As Integer
    Property ID() As String
        Get
            Return mvStr_ID
        End Get
        Set(ByVal value As String)
            mvStr_ID = value
        End Set
    End Property
    Property CustomerID() As String
        Get
            Return mvStr_CustomerID
        End Get
        Set(ByVal value As String)
            mvStr_CustomerID = value
        End Set
    End Property
    Property CashierID() As String
        Get
            Return mvStr_CashierID
        End Get
        Set(ByVal value As String)
            mvStr_CashierID = value
        End Set
    End Property
    Property TableID() As Integer
        Get
            Return mvInt_TableID
        End Get
        Set(ByVal value As Integer)
            mvInt_TableID = value
        End Set
    End Property
    Property WaiterID() As String
        Get
            Return mvStr_Waiter
        End Get
        Set(ByVal value As String)
            mvStr_Waiter = value
        End Set
    End Property
    Property CheckIn() As Date
        Get
            Return mvDate_CheckIn
        End Get
        Set(ByVal value As Date)
            mvDate_CheckIn = value
        End Set
    End Property
    Property CheckOut() As Date
        Get
            Return mvDate_CheckOut
        End Get
        Set(ByVal value As Date)
            mvDate_CheckOut = value
        End Set
    End Property
    Property VAT() As Byte
        Get
            Return mvByte_Vat
        End Get
        Set(ByVal value As Byte)
            mvByte_Vat = value
        End Set
    End Property
    Property Voucher() As Double
        Get
            Return mvVoucher
        End Get
        Set(ByVal value As Double)
            mvVoucher = value
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
    Property CustomerNumber() As Integer
        Get
            Return mvInt_CustomerNumber
        End Get
        Set(ByVal value As Integer)
            mvInt_CustomerNumber = value
        End Set
    End Property
End Class
