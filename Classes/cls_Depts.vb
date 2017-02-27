Public Class cls_Depts
    Private mvStr_InvoiceID As String
    Private mvStr_CustomerID As String
    Private mvDbl_Dept As Double
    Private mvByte_Type As Byte
    Public Property InvoiceID() As String
        Get
            Return Me.mvStr_InvoiceID
        End Get
        Set(ByVal Value As String)
            Me.mvStr_InvoiceID = Value
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
    Public Property Dept() As Double
        Get
            Return Me.mvDbl_Dept
        End Get
        Set(ByVal Value As Double)
            Me.mvDbl_Dept = Value
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
End Class
