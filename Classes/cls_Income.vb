Public Class cls_Income
    Private mvStr_ID As String
    Private mvStr_CurrencyID As String
    Private mvDbl_Quantity As Double
    Private mvDbl_Rate As Double
    Private mvStr_People As String
    Private mvStr_Description As String
    Private mvStr_CreateDate As DateTime
    Property ID() As String
        Get
            Return mvStr_ID
        End Get
        Set(ByVal value As String)
            mvStr_ID = value
        End Set
    End Property
    Property CreateDate() As DateTime
        Get
            Return mvStr_CreateDate
        End Get
        Set(ByVal value As DateTime)
            mvStr_CreateDate = value
        End Set
    End Property
    Property People() As String
        Get
            Return mvStr_People
        End Get
        Set(ByVal value As String)
            mvStr_People = value
        End Set
    End Property
    Property CurrencyID() As String
        Get
            Return mvStr_CurrencyID
        End Get
        Set(ByVal value As String)
            mvStr_CurrencyID = value
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
    Property Rate() As Double
        Get
            Return mvDbl_Rate
        End Get
        Set(ByVal value As Double)
            mvDbl_Rate = value
        End Set
    End Property
    Property Description() As String
        Get
            Return mvStr_Description
        End Get
        Set(ByVal value As String)
            mvStr_Description = value
        End Set
    End Property
End Class
