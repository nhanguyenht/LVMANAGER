Public Class cls_Material
    Dim mvStr_LOC_ID As String
    Dim mvInt_MaterialID As String
    Dim mvStr_MaterialName As String
    Dim mvStr_ImportUnit As String
    Dim mvDec_ImportToInvRate As Decimal
    Dim mvStr_ExportUnit As String
    Dim mvDec_ExportToInvRate As Decimal
    Dim mvStr_InventoryUnit As String

    Property LOC_ID() As String
        Get
            Return mvStr_LOC_ID
        End Get
        Set(ByVal value As String)
            mvStr_LOC_ID = value
        End Set
    End Property
    Property MaterialID() As String
        Get
            Return mvInt_MaterialID
        End Get
        Set(ByVal value As String)
            mvInt_MaterialID = value
        End Set
    End Property
    Property MaterialName() As String
        Get
            Return mvStr_MaterialName
        End Get
        Set(ByVal value As String)
            mvStr_MaterialName = value
        End Set
    End Property
    Property ImportUnit() As String
        Get
            Return mvStr_ImportUnit
        End Get
        Set(ByVal value As String)
            mvStr_ImportUnit = value
        End Set
    End Property
    Property ImportToInvRate() As Decimal
        Get
            Return mvDec_ImportToInvRate
        End Get
        Set(ByVal value As Decimal)
            mvDec_ImportToInvRate = value
        End Set
    End Property
    Property ExportUnit() As String
        Get
            Return mvStr_ExportUnit
        End Get
        Set(ByVal value As String)
            mvStr_ExportUnit = value
        End Set
    End Property
    Property ExportToInvRate() As Decimal
        Get
            Return mvDec_ExportToInvRate
        End Get
        Set(ByVal value As Decimal)
            mvDec_ExportToInvRate = value
        End Set
    End Property
    Property InventoryUnit() As String
        Get
            Return mvStr_InventoryUnit
        End Get
        Set(ByVal value As String)
            mvStr_InventoryUnit = value
        End Set
    End Property
End Class
