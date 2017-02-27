Public Class frm_DateFromTo
#Region "Khai báo biến"
    Public gvStr_ReportType As String
    Dim mvCls_CustomerSupplierUpdate As New cls_Customer_Update
    Dim mvCls_ReportUpdate As New cls_Report_Update
    Dim mvCls_ItemUpdate As New cls_Item_Update
    Dim mvCls_UpdateAccount As New cls_Account_Update
#End Region
#Region "Hàm khởi tạo"
    Private Sub SubM_InitializeForm()
        Dim mvObj_DataTable As New DataTable
        Try
            Me.DateEdit1.DateTime = Today
            Me.DateEdit2.DateTime = Today
           
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form events"
    Private Sub frm_DiscountServiceVat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region


#Region "Nút Confirm"
    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        Dim mvDate_FromDate As DateTime
        Dim mvDate_ToDate As DateTime
        Try
            mvDate_FromDate = DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date)
            mvDate_ToDate = DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date)
            frm_PromatOpenItem.tungay = mvDate_FromDate
            frm_PromatOpenItem.denngay = mvDate_ToDate
            frm_PromatOpenItem.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub
#End Region
    
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class