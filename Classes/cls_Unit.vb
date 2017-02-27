Public Class cls_Unit
    Dim mvStr_UnitID As String
    Dim mvStr_UnitName As String

    Property UnitID() As String
        Get
            Return mvStr_UnitID
        End Get
        Set(ByVal value As String)
            mvStr_UnitID = value
        End Set
    End Property

    Property UnitName() As String
        Get
            Return mvStr_UnitName
        End Get
        Set(ByVal value As String)
            mvStr_UnitName = value
        End Set
    End Property
End Class
