Public Class cls_CompanyInfo
    Dim mvStr_Name As String
    Dim mvStr_Address As String
    Dim mvStr_Phone As String
    Dim mvStr_Fax As String
    Dim mvStr_Tax As String
    Dim mvStr_Email As String
    Dim mvStr_ContactPerson As String
    Property Name() As String
        Get
            Return mvStr_Name
        End Get
        Set(ByVal value As String)
            mvStr_Name = value
        End Set
    End Property
    Property Address() As String
        Get
            Return mvStr_Address
        End Get
        Set(ByVal value As String)
            mvStr_Address = value
        End Set
    End Property
    Property Phone() As String
        Get
            Return mvStr_Phone
        End Get
        Set(ByVal value As String)
            mvStr_Phone = value
        End Set
    End Property
    Property Fax() As String
        Get
            Return mvStr_Fax
        End Get
        Set(ByVal value As String)
            mvStr_Fax = value
        End Set
    End Property
    Property Tax() As String
        Get
            Return mvStr_Tax
        End Get
        Set(ByVal value As String)
            mvStr_Tax = value
        End Set
    End Property
    Property Email() As String
        Get
            Return mvStr_Email
        End Get
        Set(ByVal value As String)
            mvStr_Email = value
        End Set
    End Property
    Property ContactPerson() As String
        Get
            Return mvStr_ContactPerson
        End Get
        Set(ByVal value As String)
            mvStr_ContactPerson = value
        End Set
    End Property
End Class
