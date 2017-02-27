Public Class frm_StockReportsNXT

    Dim mvCls_InventoryUpdate As New cls_Inventory_Update
    Private Sub frm_StockReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_InventoryUpdate.FuncG_GetAllData2()

            Dim dr As DataRow = mvObj_DataTable.NewRow()

            Me.lkpInventory.Properties.DataSource = mvObj_DataTable
            Me.lkpInventory.Properties.DisplayMember = "InventoryName"
            Me.lkpInventory.Properties.ValueMember = "InventoryID"
            Me.lkpInventory.EditValue = "001"
            Me.lkpInventory.Properties.ShowHeader = False

            DateEdit1.EditValue = Now
            DateEdit2.EditValue = Now
            If gvByte_Language = 1 Then
                gpcArea.Text = "Chọn ngày cần lập báo cáo"
                lblID.Text = "Từ ngày"
                LabelControl1.Text = "Đến ngày"
                LabelControl2.Text = "Chọn kho"
                cmdConfirm.Text = "Xác nhận"
                cmdExit.Text = "Thoát"
            Else
                cmdConfirm.Text = "Confirm"
                cmdExit.Text = "Exit"
                gpcArea.Text = "Choose date need create report"
                lblID.Text = "From date"
                LabelControl1.Text = "To date"
                LabelControl2.Text = "Choose inventory"
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click

        Try
            Dim mvRpt_Report As New rpt_ReportNXT
            Dim dt As New DataTable
            Dim mvCls_ReportUpdate As New cls_Report_Update
            Dim mvDate_FromDate, FromdayTondau As DateTime
            Dim mvDate_ToDate As DateTime
            FromdayTondau = New DateTime(2012, 12, 21, 21, 21, 21) 'DateAdd(DateInterval.Hour, -gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date)
            'todaytondau = DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date)
            mvDate_FromDate = DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date)
            mvDate_ToDate = DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date)

            dt = mvCls_ReportUpdate.FuncG_GetNXT(lkpInventory.EditValue, mvDate_FromDate, mvDate_ToDate, FromdayTondau)

            mvRpt_Report.SetDataSource(dt)

            mvRpt_Report.SetParameterValue("TuNgay", mvDate_FromDate)
            mvRpt_Report.SetParameterValue("DenNgay", mvDate_ToDate)

            SubM_LoadInfoInReport(mvRpt_Report)
            Dim mvFrm_LoadReport As New frm_LoadReport(mvRpt_Report)
            mvFrm_LoadReport.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub
End Class