Public Class cls_Rate
    Dim mvStr_Code As String
    Dim mvStr_Name As String
    Dim mvDbl_Rate As Double
    Property Code() As String
        Get
            Return mvStr_Code
        End Get
        Set(ByVal value As String)
            mvStr_Code = value
        End Set
    End Property
    Property Name() As String
        Get
            Return mvStr_Name
        End Get
        Set(ByVal value As String)
            mvStr_Name = value
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
End Class
