Public Class cls_HistoryEditBill
     Private wStr_ID As String
    Private wStr_INVOICE_ID As String
    Private wStr_CREATEDATE As String
    Private wStr_USERNAME As String
    Private wStr_DESCRIPTION As String
    Public Property ID() As String
        Get
            Return wStr_ID
        End Get
        Set(ByVal value As String)
            If wStr_ID = value Then
                Return
            End If
            wStr_ID = value
        End Set
    End Property
    Public Property UserName() As String
        Get
            Return Me.wStr_USERNAME
        End Get
        Set(ByVal Value As String)
            Me.wStr_USERNAME = Value
        End Set
    End Property
    Public Property INVOICE_ID() As String
        Get
            Return Me.wStr_ID
        End Get
        Set(ByVal Value As String)
            Me.wStr_ID = Value
        End Set
    End Property
    Public Property DESCRIPTION() As String
        Get
            Return Me.wStr_DESCRIPTION
        End Get
        Set(ByVal Value As String)
            Me.wStr_DESCRIPTION = Value
        End Set
    End Property
    Public Property CREATEDATE() As DateTime
        Get
            Return Me.wStr_CREATEDATE
        End Get
        Set(ByVal Value As DateTime)
            Me.wStr_CREATEDATE = Value
        End Set
    End Property
End Class
