Public Class cls_GroupItem
    Dim mvStr_ID As String
    Dim mvStr_Name As String
    Dim mvByte_Status As Byte
    Dim mvIMG_IMAGE1 As Byte()
    Dim mvIMG_IMAGE2 As Byte()
    Dim mvStr_DESCRIPTION As String
    Private _Type As Integer

    Public Property Type() As Integer
        Get
            Return _Type
        End Get
        Set(ByVal value As Integer)
            If _Type = Value Then
                Return
            End If
            _Type = Value
        End Set
    End Property
    Property ID() As String
        Get
            Return mvStr_ID
        End Get
        Set(ByVal value As String)
            mvStr_ID = value
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
    Property Status() As Byte
        Get
            Return mvByte_Status
        End Get
        Set(ByVal value As Byte)
            mvByte_Status = value
        End Set
    End Property

    Property Image1() As Byte()
        Get
            Return mvIMG_IMAGE1
        End Get
        Set(ByVal value As Byte())
            mvIMG_IMAGE1 = value
        End Set
    End Property

    Property Image2() As Byte()
        Get
            Return mvIMG_IMAGE2
        End Get
        Set(ByVal value As Byte())
            mvIMG_IMAGE2 = value
        End Set
    End Property

    Property Description() As String
        Get
            Return mvStr_DESCRIPTION
        End Get
        Set(ByVal value As String)
            mvStr_DESCRIPTION = value
        End Set
    End Property

End Class
