Public Class cls_Table
    Dim mvInt_ID As Integer
    Dim mvStr_Name As String
    Dim mvByte_Status As Byte '0 : inactive, 1 : active, 2 : used, 3 : used in red status
    Dim mvStr_Style As String
    Property ID() As Integer
        Get
            Return mvInt_ID
        End Get
        Set(ByVal value As Integer)
            mvInt_ID = value
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
    Property Style() As String
        Get
            Return mvStr_Style
        End Get
        Set(ByVal value As String)
            mvStr_Style = value
        End Set
    End Property
End Class
