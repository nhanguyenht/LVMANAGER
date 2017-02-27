Public Class cls_Item
    Dim mvStr_GroupID As String
    Dim mvStr_ID As String
    Dim mvStr_Name As String
    Dim mvDbl_Price1 As Double
    Dim mvDbl_Price2 As Double
    Dim mvDbl_Price3 As Double
    Dim mvDbl_Price4 As Double
    Dim mvDbl_Price5 As Double
    Dim mvStr_Unit As String
    Dim mvStr_Printer As String
    Dim mvByte_Print As Byte
    Dim mvByte_Status As Byte
    Dim mvByte_Promat As Byte
    Dim mvInt_Color As Integer
    Dim mvIMG_IMAGE1 As Byte()
    Dim mvIMG_IMAGE2 As Byte()
    Dim mvIMG_IMAGE3 As Byte()
    Dim mvIMG_IMAGE4 As Byte()
    Dim mvIMG_IMAGE5 As Byte()
    Dim mvStr_DESCRIPTION As String
    Dim mvByte_TYPE As Byte

    Property GroupID() As String
        Get
            Return mvStr_GroupID
        End Get
        Set(ByVal value As String)
            mvStr_GroupID = value
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
    Property Price1() As Double
        Get
            Return mvDbl_Price1
        End Get
        Set(ByVal value As Double)
            mvDbl_Price1 = value
        End Set
    End Property
    Property Price2() As Double
        Get
            Return mvDbl_Price2
        End Get
        Set(ByVal value As Double)
            mvDbl_Price2 = value
        End Set
    End Property
    Property Price3() As Double
        Get
            Return mvDbl_Price3
        End Get
        Set(ByVal value As Double)
            mvDbl_Price3 = value
        End Set
    End Property
    Property Price4() As Double
        Get
            Return mvDbl_Price4
        End Get
        Set(ByVal value As Double)
            mvDbl_Price4 = value
        End Set
    End Property
    Property Price5() As Double
        Get
            Return mvDbl_Price5
        End Get
        Set(ByVal value As Double)
            mvDbl_Price5 = value
        End Set
    End Property
    Property Unit() As String
        Get
            Return mvStr_Unit
        End Get
        Set(ByVal value As String)
            mvStr_Unit = value
        End Set
    End Property
    Property Printer() As String
        Get
            Return mvStr_Printer
        End Get
        Set(ByVal value As String)
            mvStr_Printer = value
        End Set
    End Property
    Property Print() As Byte
        Get
            Return mvByte_Print
        End Get
        Set(ByVal value As Byte)
            mvByte_Print = value
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
    Property Promat() As Byte
        Get
            Return mvByte_Promat
        End Get
        Set(ByVal value As Byte)
            mvByte_Promat = value
        End Set
    End Property
    Property Color() As Integer
        Get
            Return mvInt_Color
        End Get
        Set(ByVal value As Integer)
            mvInt_Color = value
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

    Property Image3() As Byte()
        Get
            Return mvIMG_IMAGE3
        End Get
        Set(ByVal value As Byte())
            mvIMG_IMAGE3 = value
        End Set
    End Property

    Property Image4() As Byte()
        Get
            Return mvIMG_IMAGE4
        End Get
        Set(ByVal value As Byte())
            mvIMG_IMAGE4 = value
        End Set
    End Property

    Property Image5() As Byte()
        Get
            Return mvIMG_IMAGE5
        End Get
        Set(ByVal value As Byte())
            mvIMG_IMAGE5 = value
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

    Property TYPE() As Byte
        Get
            Return mvByte_TYPE
        End Get
        Set(ByVal value As Byte)
            mvByte_TYPE = value
        End Set
    End Property

End Class
