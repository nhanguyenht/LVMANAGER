Public Class cls_Account
    Private wStr_UserName As String
    Private wStr_Password As String
    Private wStr_Permit As String
    Private wStr_EmployeeCode As String
    Private wByte_Status As Boolean
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
    Public Property Permit() As String
        Get
            Return Me.wStr_Permit
        End Get
        Set(ByVal Value As String)
            Me.wStr_Permit = Value
        End Set
    End Property
    Public Property Employee() As String
        Get
            Return Me.wStr_EmployeeCode
        End Get
        Set(ByVal Value As String)
            Me.wStr_EmployeeCode = Value
        End Set
    End Property
    Public Property Status() As Boolean
        Get
            Return Me.wByte_Status
        End Get
        Set(ByVal Value As Boolean)
            Me.wByte_Status = Value
        End Set
    End Property
End Class
