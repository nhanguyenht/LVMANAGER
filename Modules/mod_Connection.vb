Module mod_Connection
#Region "Khai Báo Biến"
    Public gvStr_Server, gvStr_Database, gvStr_User, gvStr_Pass As String
    Public gvStr_AccUser, gvStr_AccPass, gvStr_AccPermit, gvStr_Location As String
#End Region
#Region "Định nghĩa Properties Kết Nối CSDL"
    Property gvProp_Server() As String
        Get
            Return gvStr_Server
        End Get
        Set(ByVal Giatri As String)
            gvStr_Server = Giatri
        End Set
    End Property
    Property gvProp_DataBase() As String
        Get
            Return gvStr_Database
        End Get
        Set(ByVal Giatri As String)
            gvStr_Database = Giatri
        End Set
    End Property
    Property gvProp_User() As String
        Get
            Return gvStr_User
        End Get
        Set(ByVal Giatri As String)
            gvStr_User = Giatri
        End Set
    End Property
    Property gvProp_PassWord() As String
        Get
            Return gvStr_Pass
        End Get
        Set(ByVal Giatri As String)
            gvStr_Pass = Giatri
        End Set
    End Property
#End Region
#Region "Định nghĩa Properties Kết nối VB"
    Property gvProp_AccUser() As String
        Get
            Return gvStr_AccUser
        End Get
        Set(ByVal Giatri As String)
            gvStr_AccUser = Giatri
        End Set
    End Property
    Property gvProp_AccPass() As String
        Get
            Return gvStr_AccPass
        End Get
        Set(ByVal Giatri As String)
            gvStr_AccPass = Giatri
        End Set
    End Property
    Property gvProp_AccPermit() As String
        Get
            Return gvStr_AccPermit
        End Get
        Set(ByVal Giatri As String)
            gvStr_AccPermit = Giatri
        End Set
    End Property
#End Region
End Module
