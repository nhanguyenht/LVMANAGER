Public Class frm_ReportsFromToNL
#Region "Khai báo biến"
    Public gvStr_ReportType As String
    Dim mvCls_CustomerSupplierUpdate As New cls_Customer_Update
    Dim mvCls_ReportUpdate As New cls_Report_Update
    Dim mvCls_ItemUpdate As New cls_Item_Update
    Dim mvCls_UpdateAccount As New cls_Account_Update
#End Region
#Region "Hàm khởi tạo"
    Private Sub SubM_InitializeForm()
        Dim mvCls_InventoryUpdate As New cls_Inventory_Update
        Dim mvObj_DataTable As New DataTable
        Try
            Me.DateEdit1.DateTime = Today
            Me.DateEdit2.DateTime = Today
            'Me.cheShifts.Checked = False

            Try
                mvObj_DataTable = mvCls_InventoryUpdate.FuncG_GetAllData()

                'Dim dr As DataRow = mvObj_DataTable.NewRow()

                'dr("InventoryID") = "000"
                'dr("InventoryName") = "Tất cả"
                '  mvObj_DataTable.Rows.Add(dr)

                Me.lkpInventory.Properties.DataSource = mvObj_DataTable
                Me.lkpInventory.Properties.DisplayMember = "InventoryName"
                Me.lkpInventory.Properties.ValueMember = "InventoryID"
                Me.lkpInventory.EditValue = "001"
                Me.lkpInventory.Properties.ShowHeader = False
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


        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form events"
    Private Sub frm_DiscountServiceVat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region

#Region "Hàm tạo gọi form để xem report"
    Private Sub SubM_CreateReportForm(ByVal iRpt_Obj As Object)
        'MOC 6 GIO SANG KET THUC NGAY
        Dim mvDate_FromDate As DateTime
        Dim mvDate_ToDate As DateTime
        Try
            mvDate_FromDate = DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date)
            mvDate_ToDate = DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date)
            iRpt_Obj.SetParameterValue("TuNgay", mvDate_FromDate)
            iRpt_Obj.SetParameterValue("DenNgay", mvDate_ToDate)
            Dim mvFrm_LoadReport As New frm_LoadReport(iRpt_Obj)
            'Me.Close()
            mvFrm_LoadReport.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Nút Confirm"
    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        Try
            
            If Me.gvStr_ReportType = "NguyenLieu" Then
                Dim mvRpt_Report As New rpt_ReportMaterial
                'Thêm tham số nếu cần thiết

                Dim dt As New DataTable
                Dim mvCls_ReportUpdate As New cls_Report_Update

                dt = mvCls_ReportUpdate.FuncG_GetMaterial(DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date), DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date), lkpInventory.EditValue)

                mvRpt_Report.SetDataSource(dt)

                'mvRpt_Report.SetParameterValue("TuNgay", DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date))
                'mvRpt_Report.SetParameterValue("DenNgay", DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date))
                mvRpt_Report.SetParameterValue("Language", 1)
                'mvRpt_Report.SetParameterValue("@LOC_ID", gvStr_LocID)
                SubM_CreateReportForm(mvRpt_Report)
           
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "Nút exit"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

#End Region

   
End Class