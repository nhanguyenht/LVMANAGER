Public Class cls_Area
    Dim mvStr_ID As String
    Dim mvStr_Name As String
    Dim mvByte_Status As Byte
    Dim mvByte_Type As Byte
    Dim mvByte_PriceLevel As Byte
    Dim mvDat_Time_Begin As Integer
    Dim mvDat_Time_End As Integer
    Dim mvFlt_Bill_Service As Double
    Dim mvFlt_Karaoke_Service As Double
    Dim mvByte_Type_Service As Byte
    Dim mvByte_Status_Service As Byte

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
    Property Type() As Byte
        Get
            Return mvByte_Type
        End Get
        Set(ByVal value As Byte)
            mvByte_Type = value
        End Set
    End Property
    Property PriceLevel() As Byte
        Get
            Return mvByte_PriceLevel
        End Get
        Set(ByVal value As Byte)
            mvByte_PriceLevel = value
        End Set
    End Property

    Property Time_Begin() As Integer
        Get
            Return mvDat_Time_Begin
        End Get
        Set(ByVal value As Integer)
            mvDat_Time_Begin = value
        End Set
    End Property
    Property Time_End() As Integer
        Get
            Return mvDat_Time_End
        End Get
        Set(ByVal value As Integer)
            mvDat_Time_End = value
        End Set
    End Property
    Property Bill_Service() As Double
        Get
            Return mvFlt_Bill_Service
        End Get
        Set(ByVal value As Double)
            mvFlt_Bill_Service = value
        End Set
    End Property
    Property Karaoke_Service() As Double
        Get
            Return mvFlt_Karaoke_Service
        End Get
        Set(ByVal value As Double)
            mvFlt_Karaoke_Service = value
        End Set
    End Property
    Property Type_Service() As Byte
        Get
            Return mvByte_Type_Service
        End Get
        Set(ByVal value As Byte)
            mvByte_Type_Service = value
        End Set
    End Property
    Property Status_Service() As Byte
        Get
            Return mvByte_Status_Service
        End Get
        Set(ByVal value As Byte)
            mvByte_Status_Service = value
        End Set
    End Property
End Class
