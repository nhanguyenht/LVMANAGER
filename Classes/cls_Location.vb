Public Class cls_Location
    Private wStr_UserName As String
    Private wStr_Password As String
    Private wStr_ID As String
    Private wStr_Name As String
    Private wStr_Address As String
    Private wStr_IPAddress As String
    Public Property UserName() As String
        Get
            Return Me.wStr_UserName
        End Get
        Set(ByVal Value As String)
            Me.wStr_UserName = Value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return Me.wStr_Password
        End Get
        Set(ByVal Value As String)
            Me.wStr_Password = Value
        End Set
    End Property
    Public Property ID() As String
        Get
            Return Me.wStr_ID
        End Get
        Set(ByVal Value As String)
            Me.wStr_ID = Value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return Me.wStr_Name
        End Get
        Set(ByVal Value As String)
            Me.wStr_Name = Value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return Me.wStr_Address
        End Get
        Set(ByVal Value As String)
            Me.wStr_Address = Value
        End Set
    End Property
    Public Property IPAddress() As String
        Get
            Return Me.wStr_IPAddress
        End Get
        Set(ByVal Value As String)
            Me.wStr_IPAddress = Value
        End Set
    End Property
End Class
