Public Class cls_Customer
    Private wStr_ID As String
    Private wStr_Name As String
    Private wStr_Address As String
    Private wStr_Tel As String
    Private wStr_Email As String
    Private wByte_Type As Byte

    Private wStr_Mathegiamgia As String
    Private wByte_Phantram As Byte
    Private wStr_Note As String

    Private wByte_Loaithe As Byte
    Private wByte_Soluonggiam As Integer
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
    Public Property Tel() As String
        Get
            Return Me.wStr_Tel
        End Get
        Set(ByVal Value As String)
            Me.wStr_Tel = Value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return Me.wStr_Email
        End Get
        Set(ByVal Value As String)
            Me.wStr_Email = Value
        End Set
    End Property
    Property Type() As Byte
        Get
            Return wByte_Type
        End Get
        Set(ByVal value As Byte)
            wByte_Type = value
        End Set
    End Property
    Public Property Mathegiamgia() As String
        Get
            Return Me.wStr_Mathegiamgia
        End Get
        Set(ByVal Value As String)
            Me.wStr_Mathegiamgia = Value
        End Set
    End Property
    Property Phantram() As Byte
        Get
            Return wByte_Phantram
        End Get
        Set(ByVal value As Byte)
            wByte_Phantram = value
        End Set
    End Property
    Public Property Note() As String
        Get
            Return Me.wStr_Note
        End Get
        Set(ByVal Value As String)
            Me.wStr_Note = Value
        End Set
    End Property
    Property Loaithe() As Byte
        Get
            Return wByte_Loaithe
        End Get
        Set(ByVal value As Byte)
            wByte_Loaithe = value
        End Set
    End Property
    Property Soluonggiam() As Integer
        Get
            Return wByte_Soluonggiam
        End Get
        Set(ByVal value As Integer)
            wByte_Soluonggiam = value
        End Set
    End Property
End Class
