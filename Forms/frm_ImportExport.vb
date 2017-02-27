Public Class frm_ImportExport
#Region "Khai báo biến"
    Dim mvCls_ImportExport As New cls_ImportExport
    Dim mvCls_ImportExportUpdate As New cls_ImportExport_Update
    Dim mvCls_DeptUpdate As New cls_Dept_Update
    Public gvStr_Status As String
#End Region
#Region "Hàm khởi tạo"
    Public Sub SubM_InitializeForm()
        SubM_LoadDataIntoGrid()
        mod_LoadLanguageForm.SubG_ImportExport()
        If gvByte_Language = 1 Then
            If Me.gvStr_Status = "PN" Then
                Me.Text = "Phiếu nhập kho"
                Me.lblHeader.Text = "Phiếu nhập kho"
                Me.cmdPrint.Text = "In"
            Else
                Me.Text = "Phiếu xuất kho"
                Me.lblHeader.Text = "Phiếu xuất kho"
                Me.cmdPrint.Text = "In"
            End If
        Else
            If Me.gvStr_Status = "PN" Then
                Me.Text = "Import Inventory"
                Me.lblHeader.Text = "Import Inventory"
                Me.cmdPrint.Text = "Print"
            Else
                Me.Text = "Export Inventory"
                Me.lblHeader.Text = "Export Inventory"
                Me.cmdPrint.Text = "Print"
            End If
        End If
       
    End Sub
#End Region
#Region "Form events"
    Private Sub SubM_LoadDataIntoGrid()
        Dim mvObj_DataTable As New DataTable
        Try
            If Me.gvStr_Status = "PN" Then
                mvObj_DataTable = mvCls_ImportExportUpdate.FuncG_GetAllData(0)
            Else
                mvObj_DataTable = mvCls_ImportExportUpdate.FuncG_GetAllData(1)
            End If
            Me.GridControl1.DataSource = mvObj_DataTable

            Me.GridView1.BestFitColumns()

            If Me.gvStr_Status = "PN" Then
                GridView1.Columns("Đến Kho").Visible = False
            Else
                GridView1.Columns("Đến Kho").Visible = True
            End If
            If gvByte_Language = 1 Then
                GridView1.Columns("Mã phiếu").Caption = "Mã phiếu"
                GridView1.Columns("Ngày nhập").Caption = "Ngày nhập"
                GridView1.Columns("Số HĐ").Caption = "Số HĐ"
                GridView1.Columns("Nhà cung cấp").Caption = "Nhà cung cấp"
                GridView1.Columns("Kho").Caption = "Kho"
                GridView1.Columns("Đến Kho").Caption = "Đến Kho"
            Else
                GridView1.Columns("Mã phiếu").Caption = "Invoice Id"
                GridView1.Columns("Ngày nhập").Caption = "Create date"
                GridView1.Columns("Số HĐ").Caption = "Invoice No"
                GridView1.Columns("Nhà cung cấp").Caption = "Providers"
                GridView1.Columns("Kho").Caption = "Inventory"
                GridView1.Columns("Đến Kho").Caption = "To Inventory"
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form events"
    Private Sub frm_DiscountServiceVat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region
#Region "Đánh số thứ tự cho girdview"
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        Try
            Dim mvInt_RowIndex As Integer = e.RowHandle
            If mvInt_RowIndex >= 0 Then
                mvInt_RowIndex += 1
                e.Info.DisplayText = mvInt_RowIndex.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Add"
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If Me.gvStr_Status = "PN" Then
            frm_ImportInvoice.gvStr_Status = "Add"
            frm_ImportInvoice.ShowDialog()
        Else
            frm_ExportInvoice.gvStr_Status = "Add"
            frm_ExportInvoice.ShowDialog()
        End If
    End Sub
#End Region
#Region "Nút Edit"
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If Me.gvStr_Status = "PN" Then
            If Me.GridView1.FocusedRowHandle > -1 Then
                'Kiểm tra công nợ
                If mvCls_DeptUpdate.FuncG_CheckAlreadyDept(Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã phiếu")) Then
                    SubG_Alert(60) 'FunG_Alert("Lỗi", "Hóa đơn này đã thanh toán công nợ!", frm_Alert.WTYPE.ERROR)
                Else
                    frm_ImportInvoice.gvStr_Status = "Edit"
                    frm_ImportInvoice.txtInvoiceID.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã phiếu")
                    frm_ImportInvoice.ShowDialog()
                End If
            Else
                SubG_Alert(61) 'FunG_Alert("Lỗi", "Chưa chọn hóa đơn cần cập nhật!", frm_Alert.WTYPE.ERROR)
            End If
        Else
            If Me.GridView1.FocusedRowHandle > -1 Then
                frm_ExportInvoice.gvStr_Status = "Edit"
                frm_ExportInvoice.txtInvoiceID.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã phiếu")
                frm_ExportInvoice.ShowDialog()
            Else
                SubG_Alert(61) ' FunG_Alert("Lỗi", "Chưa chọn hóa đơn cần cập nhật!", frm_Alert.WTYPE.ERROR)
            End If
        End If
    End Sub
#End Region
#Region "Nút Delete"
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If gvByte_Language = 1 Then
            If Me.GridView1.FocusedRowHandle > -1 Then
                Dim invoice As String = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã phiếu")
                Dim isImport As Boolean = IIf(gvStr_Status = "PN", True, False)
                If FunG_Alert("Xác nhận", String.Format("Bạn có muốn xóa phiếu <{0}> không?", invoice), frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                    mvCls_ImportExportUpdate.FuncG_DeleteImportExport(invoice, isImport)
                    mvCls_ImportExportUpdate.FuncG_Delete(Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã phiếu"))
                    SubM_InitializeForm()
                End If
            Else
                FunG_Alert("Lỗi", "Chưa chọn hóa đơn cần xóa!", frm_Alert.WTYPE.ERROR)
            End If
        Else
            If Me.GridView1.FocusedRowHandle > -1 Then
                Dim invoice As String = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã phiếu")
                Dim isImport As Boolean = IIf(gvStr_Status = "PN", True, False)
                If FunG_Alert("Confirm", String.Format("Do you want to delete patterns <{0}> not?", invoice), frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                    mvCls_ImportExportUpdate.FuncG_DeleteImportExport(invoice, isImport)
                    mvCls_ImportExportUpdate.FuncG_Delete(Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã phiếu"))
                    SubM_InitializeForm()
                End If
            Else
                FunG_Alert("Error", "Not selected item need removed", frm_Alert.WTYPE.ERROR)
            End If
        End If
       
    End Sub
#End Region
#Region "Nút exit"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
#End Region

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If Me.GridView1.FocusedRowHandle > -1 Then
            If Me.gvStr_Status = "PN" Then
                Dim RPT As New rpt_ReportImport
                Dim ID As String = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã phiếu")
                RPT.SetParameterValue("MaPhieu", ID)
                Dim mvFrm_LoadReport As New frm_LoadReport(RPT)
                mvFrm_LoadReport.ShowDialog()
            Else
                Dim RPT As New rpt_ReportExport
                Dim ID As String = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã phiếu")
                RPT.SetParameterValue("MaPhieu", ID)
                Dim mvFrm_LoadReport As New frm_LoadReport(RPT)
                mvFrm_LoadReport.ShowDialog()
            End If

               

            End If
    End Sub
End Class