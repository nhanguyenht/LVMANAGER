Public Class cls_HistoryBalance
    Dim mvInt_ID As Integer
    Dim mvStr_USER As String
    Dim mvDate_CreateDate As Date
    Dim mvDouble_QTYOLD As Double
    Dim mvDouble_QTYNEW As Double
    Dim mvDecimal_Price As Decimal
    Dim mvStr_Material_ID As String
    Property Material_ID() As String
        Get
            Return mvStr_Material_ID
        End Get
        Set(ByVal value As String)
            mvStr_Material_ID = value
        End Set
    End Property
    Property ID() As Integer
        Get
            Return mvInt_ID
        End Get
        Set(ByVal value As Integer)
            mvInt_ID = value
        End Set
    End Property
    Property USER() As String
        Get
            Return mvStr_USER
        End Get
        Set(ByVal value As String)
            mvStr_USER = value
        End Set
    End Property
    Property CreateDate() As Date
        Get
            Return mvDate_CreateDate
        End Get
        Set(ByVal value As Date)
            mvDate_CreateDate = value
        End Set
    End Property
    Property QTYOLD() As Double
        Get
            Return mvDouble_QTYOLD
        End Get
        Set(ByVal value As Double)
            mvDouble_QTYOLD = value
        End Set
    End Property
    Property QTYNEW() As Double
        Get
            Return mvDouble_QTYNEW
        End Get
        Set(ByVal value As Double)
            mvDouble_QTYNEW = value
        End Set
    End Property
    Property PRICE() As Decimal
        Get
            Return mvDecimal_Price
        End Get
        Set(ByVal value As Decimal)
            mvDecimal_Price = value
        End Set
    End Property
End Class
