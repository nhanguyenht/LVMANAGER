Public Class frm_StockInHand
#Region "Khai báo biến"
    Dim mvCls_Stock As New cls_Stock
    Dim mvCls_StockUpdate As New cls_Stock_Update
    Dim mvCls_ItemUpdate As New cls_Item_Update
    Dim mvCls_InventoryUpdate As New cls_Inventory_Update
    Dim mvCls_MaterialUpdate As New cls_Material_Update
    Dim mvCls_ImportExportUpdate As New cls_ImportExport_Update
#End Region
#Region "Hàm khởi tạo"
    Public Sub SubM_InitializeForm()
        Try
            ' mod_LoadLanguageForm.SubG_CashForm()
            SubM_LoadDataIntoGrid()
            SubG_StockInHand()
            Me.txtID.Text = ""
            Me.txtQty.Text = ""
            Me.txtPrice.Text = ""
            Me.txtTotal.Text = ""
            Me.cmdDelete.Enabled = False
            If gvByte_Language = 1 Then
                Me.Text = "TỒN ĐẦU KỲ"
                GroupControl1.Text = "NHẬP TỒN ĐẦU KỲ"
                lblOrderNo.Text = "Mã hàng"
                LabelControl1.Text = "Tên hàng"
                LabelControl2.Text = "Đơn giá"
                LabelControl3.Text = "Số lượng"
                'LabelControl4.Text = "Số lượng"
                LabelControl5.Text = "Kho"
            Else
                Me.Text = "BEGINNING INVENTORY"
                GroupControl1.Text = "IMPORT BEGIN"
                lblOrderNo.Text = "Item Id"
                LabelControl1.Text = "Item Name"
                LabelControl2.Text = "Price"
                LabelControl3.Text = "Qty"
                'LabelControl4.Text = "Số lượng"
                LabelControl5.Text = "Inventory"
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Lấy dữ liệu lên lưới"
    Private Sub SubM_LoadDataIntoGrid()
        Dim mvObj_DataTable As New DataTable
        Dim mvObj_DataTable1 As New DataTable
        Try
            mvObj_DataTable = mvCls_StockUpdate.FuncG_GetAllData
            Me.GridControl1.DataSource = Nothing
            Me.GridControl1.DataSource = mvObj_DataTable
            Me.GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridView1.Columns(3).DisplayFormat.FormatString = "#,##"
            Me.GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridView1.Columns(4).DisplayFormat.FormatString = "#,##"
            Me.GridView1.BestFitColumns()
            If gvByte_Language = 1 Then
                Me.GridView1.Columns("Mã hàng").Caption = "Mã hàng"
                Me.GridView1.Columns("Tên hàng").Caption = "Tên hàng"
                Me.GridView1.Columns("Số lượng").Caption = "Số lượng"
                Me.GridView1.Columns("Đơn giá").Caption = "Đơn giá"
                Me.GridView1.Columns("Thành tiền").Caption = "Thành tiền"
                Me.GridView1.Columns("Kho").Caption = "Kho"
                Me.GridView1.Columns("DVT").Caption = "ĐVT"
            ElseIf gvByte_Language = 2 Then
                Me.GridView1.Columns("Mã hàng").Caption = "Item ID"
                Me.GridView1.Columns("Tên hàng").Caption = "Item Name"
                Me.GridView1.Columns("Số lượng").Caption = "Qty"
                Me.GridView1.Columns("Đơn giá").Caption = "Price"
                Me.GridView1.Columns("Thành tiền").Caption = "Amount"
                Me.GridView1.Columns("Kho").Caption = "Inventory"
                Me.GridView1.Columns("DVT").Caption = "Unit"
            End If
            'mvObj_DataTable1 = mvCls_ItemUpdate.FuncG_GetAllMaterial1
            'Me.lkpName.Properties.DataSource = mvObj_DataTable1
            'Me.lkpName.Properties.DisplayMember = "Tên hàng"
            'Me.lkpName.Properties.ValueMember = "Mã hàng"
            'Me.lkpName.EditValue = Nothing
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form events"
    Private Sub frm_StockInHand_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
        LoadInventoryData()
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
#Region "Click lên girdview"
    Private Sub GridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.Click
        Try
            If Me.GridView1.FocusedRowHandle >= 0 Then
                Me.txtID.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(0)
                Me.txtQty.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(2)
                SubG_FormatNumberDigit(Me.txtQty, 0)
                Me.txtPrice.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(3)
                SubG_FormatNumberDigit(Me.txtPrice, 0)
                Me.lkpName.EditValue = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)(0)

                Me.cmdDelete.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Chọn tên hàng"
    Private Sub lkpName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkpName.EditValueChanged
        Try
            If Me.lkpName.EditValue IsNot Nothing Then
                Me.txtID.Text = Me.lkpName.EditValue
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Xử lí nhập - Leave, GotFocus, TextChanged, CheckedChanged, EnableChanged"
#Region "TextChanged"
    Private Sub txtGhiChu_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged, txtPrice.TextChanged
        SubM_Math()
    End Sub
#End Region
#Region "Leave"
    Private Sub txtDuaTruoc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.Leave, txtPrice.Leave
        SubG_FormatNumberDigit(sender, 3)
    End Sub
#End Region
#Region "KeyPress"
    Private Sub txtNang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress, txtPrice.KeyPress
        SubG_OnlyInputDigit(sender, e, False)
    End Sub
#End Region
#End Region
#Region "Nhập mã hàng"
    'Private Sub TextEdit1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged
    '    Dim mvObj_DataTable As New DataTable
    '    Try
    '        mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetDataInfo(Me.txtID.Text.Trim)
    '        If mvObj_DataTable.Rows.Count <> 0 Then
    '            Me.lkpName.EditValue = Me.txtID.Text.Trim
    '            Me.txtPrice.Text = mvObj_DataTable.Rows(0)("PRICE1")
    '        Else
    '            Me.lkpName.EditValue = Nothing
    '            Me.txtPrice.Text = ""
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub
#End Region
#Region "Tính tiền"
    Private Sub SubM_Math()
        Dim mvDbl_Price As Double = 0
        Dim mvDbl_Qty As Double = 0
        Try
            If String.IsNullOrEmpty(Me.txtPrice.Text) Then
                mvDbl_Price = 0
            Else
                mvDbl_Price = Convert.ToDouble(Me.txtPrice.Text)
            End If
            If String.IsNullOrEmpty(Me.txtQty.Text) Then
                mvDbl_Qty = 0
            Else
                mvDbl_Qty = Convert.ToDouble(Me.txtQty.Text)
            End If
            Me.txtTotal.Text = mvDbl_Price * mvDbl_Qty
            SubG_FormatNumberDigit(Me.txtTotal, 0)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút xóa"
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Me.DxValidationProvider1.Validate Then
            If gvByte_Language = 1 Then
                If FunG_Alert("Xác nhận", String.Format("Bạn có chắc muốn xóa mặt hàng: <{0}> không?", Me.lkpName.Text), frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                    mvCls_Stock.ID = Me.txtID.Text.Trim
                    mvCls_Stock.InventoryID = GridView1.GetFocusedRowCellValue("Kho")
                    mvCls_Stock.Unit = " "
                    mvCls_Stock.Price = Me.txtPrice.Text.Trim
                    mvCls_Stock.Quantity = Me.txtQty.Text.Trim

                    mvCls_StockUpdate.FuncG_UpdateDelete(mvCls_Stock, 3)
                    Me.SubM_InitializeForm()
                End If
            Else
                If FunG_Alert("Confirm", String.Format("Are you sure you want to delete items: <{0}> not?", Me.lkpName.Text), frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                    mvCls_Stock.ID = Me.txtID.Text.Trim
                    mvCls_Stock.InventoryID = GridView1.GetFocusedRowCellValue("Kho")
                    mvCls_Stock.Unit = " "
                    mvCls_Stock.Price = Me.txtPrice.Text.Trim
                    mvCls_Stock.Quantity = Me.txtQty.Text.Trim

                    mvCls_StockUpdate.FuncG_UpdateDelete(mvCls_Stock, 3)
                    Me.SubM_InitializeForm()
                End If
            End If
        End If
    End Sub
#End Region
#Region "Nút lưu"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Me.DxValidationProvider1.Validate Then
            mvCls_Stock.ID = Me.txtID.Text.Trim
            mvCls_Stock.InventoryID = Me.lkpInventory.EditValue
            Dim row As DataRowView = CType(lkpName.Properties.GetDataSourceRowByKeyValue(lkpName.EditValue), DataRowView)
            mvCls_Stock.Unit = row("InventoryUnit").ToString()
            mvCls_Stock.Price = Me.txtPrice.Text.Trim
            mvCls_Stock.Quantity = Me.txtQty.Text.Trim
            mvCls_Stock.UpdatedType = 3

            mvCls_StockUpdate.FuncG_UpdateDelete(mvCls_Stock, 2)

            Me.SubM_InitializeForm()
        End If
    End Sub
#End Region
#Region "Nút thoát"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
#End Region

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If Me.DxValidationProvider1.Validate Then
            If lkpInventory.EditValue = "999" Then
                If gvByte_Language = 1 Then
                    FunG_Alert("Lỗi", "Không thể thực hiện thao tác này với " + lkpInventory.Text, frm_Alert.WTYPE.ERROR)
                Else
                    FunG_Alert("Error", "Can not perform this operation with " + lkpInventory.Text, frm_Alert.WTYPE.ERROR)
                End If

                lkpInventory.ItemIndex = 0
            Else

                If Double.Parse(txtPrice.Text.Trim) > 0 And Double.Parse(txtPrice.Text.Trim) > 0 Then
                    mvCls_Stock.ID = Me.txtID.Text.Trim
                    mvCls_Stock.InventoryID = Me.lkpInventory.EditValue
                    Dim row As DataRowView = CType(lkpName.Properties.GetDataSourceRowByKeyValue(lkpName.EditValue), DataRowView)

                    mvCls_Stock.Unit = row("InventoryUnit").ToString()
                    mvCls_Stock.Price = Me.txtPrice.Text.Trim
                    mvCls_Stock.Quantity = Me.txtQty.Text.Trim
                    mvCls_Stock.UpdatedType = 2
                    mvCls_StockUpdate.FuncG_UpdateDelete(mvCls_Stock, 1)
                    Me.SubM_InitializeForm()
                Else
                    SubG_Alert(113) 'FunG_Alert("Lỗi", "Số lượng hoặc đơn giá phải > 0", frm_Alert.WTYPE.ERROR)
                End If
            End If

        Else
            SubG_Alert(113) 'FunG_Alert("Lỗi", "Vui lòng nhập dữ liệu", frm_Alert.WTYPE.ERROR)
        End If


    End Sub

    Private Sub LoadInventoryData()
        Dim mvObj_DataTable As New DataTable
        Dim mvObj_DataTable2 As New DataTable
        Try
            mvObj_DataTable = mvCls_InventoryUpdate.FuncG_GetAllData2()
            Me.lkpInventory.Properties.DataSource = mvObj_DataTable
            Me.lkpInventory.Properties.DisplayMember = "InventoryName"
            Me.lkpInventory.Properties.ValueMember = "InventoryID"
            Me.lkpInventory.EditValue = "001"
            Me.lkpInventory.Properties.ShowHeader = False

            mvObj_DataTable2 = mvCls_MaterialUpdate.FuncG_GetAllData()
            Me.lkpName.Properties.DataSource = mvObj_DataTable2
            Me.lkpName.Properties.DisplayMember = "MaterialName"
            Me.lkpName.Properties.ValueMember = "MaterialID"
            Me.lkpName.EditValue = Nothing

            Me.lkpName.Properties.PopulateColumns()
            Me.lkpName.Properties.Columns("LOC_ID").Visible = False
            Me.lkpName.Properties.Columns("ExportUnit").Visible = False
            Me.lkpName.Properties.Columns("ExportToInvRate").Visible = False
            Me.lkpName.Properties.Columns("ImportToInvRate").Visible = False

            
            Me.lkpName.Properties.Columns("ImportUnit").Visible = False
            Me.lkpName.Properties.Columns("ImportToInvRate").Visible = False
            'Me.lkpName.Properties.Columns("ExportUnit").Caption = "ĐV Xuất"
            'Me.lkpName.Properties.Columns("ExportToInvRate").Caption = "Tỷ lệ Xuất/Tồn"

            If gvByte_Language = 1 Then
                Me.lkpName.Properties.Columns("MaterialID").Caption = "Mã"
                Me.lkpName.Properties.Columns("MaterialName").Caption = "Tên"
                Me.lkpName.Properties.Columns("InventoryUnit").Caption = "ĐVT"
            Else
                Me.lkpName.Properties.Columns("MaterialID").Caption = "ID"
                Me.lkpName.Properties.Columns("MaterialName").Caption = "NAME"
                Me.lkpName.Properties.Columns("InventoryUnit").Caption = "UNIT"
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frm_StockInHand_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Ghi du lieu vao kho
        Try
            mvCls_ImportExportUpdate.FuncG_InsertUpdateFirsPeriod()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lkpInventory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkpInventory.EditValueChanged
        If lkpInventory.EditValue = "999" Then
            If gvByte_Language = 1 Then
                FunG_Alert("Lỗi", "Không thể chọn KHO này", frm_Alert.WTYPE.ERROR)
            Else
                FunG_Alert("Error", "Can not choose this inventory", frm_Alert.WTYPE.ERROR)
            End If

            lkpInventory.ItemIndex = 0
        End If
    End Sub
End Class