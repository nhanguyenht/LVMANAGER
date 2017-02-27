Public Class frm_StockReports

    Dim mvCls_InventoryUpdate As New cls_Inventory_Update
    Private Sub frm_StockReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_InventoryUpdate.FuncG_GetAllData2()

            Dim dr As DataRow = mvObj_DataTable.NewRow()

            dr("InventoryID") = "000"
            dr("InventoryName") = "Tất cả"
            mvObj_DataTable.Rows.Add(dr)

            Me.lkpInventory.Properties.DataSource = mvObj_DataTable
            Me.lkpInventory.Properties.DisplayMember = "InventoryName"
            Me.lkpInventory.Properties.ValueMember = "InventoryID"
            Me.lkpInventory.EditValue = "001"
            Me.lkpInventory.Properties.ShowHeader = False
            If gvByte_Language = 1 Then
                gpcArea.Text = "Chọn ngày cần lập báo cáo"
                lblID.Text = "Chọn khos"
               
                cmdConfirm.Text = "Xác nhận"
                cmdExit.Text = "Thoát"
            Else
                cmdConfirm.Text = "Confirm"
                cmdExit.Text = "Exit"
                gpcArea.Text = "Choose date need create report"
                lblID.Text = "From date"

                lblID.Text = "Choose inventory"
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click

        Try
            Dim mvRpt_Report As New rpt_ReportNewStockInHands

            mvRpt_Report.SetParameterValue("LocID", gvStr_LocID)
            mvRpt_Report.SetParameterValue("Inventory", lkpInventory.EditValue)

            Dim mvFrm_LoadReport As New frm_LoadReport(mvRpt_Report)
            mvFrm_LoadReport.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub
End Class