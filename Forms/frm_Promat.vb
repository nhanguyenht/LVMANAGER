Public Class frm_Promat
#Region "Khai báo biến"
    Dim mvCls_ItemUpdate As New cls_Item_Update
    Dim mvCls_MaterialUpdate As New cls_Material_Update
    Dim mvCls_Promat As New cls_Promat
    Dim mvCls_PromatUpdate As New cls_Promat_Update
    Dim mvCls_UnitUpdate As New cls_Unit_Update
    Dim mvBool_Search As Boolean = False
    Dim mvCls_InventoryUpdate As New cls_Inventory_Update
    Dim loc_id As String = "001"
#End Region
#Region "Hàm khởi tạo"
    Private Sub SubM_InitializeForm()
        SubM_LoadDataIntoGrid()
        SubM_LoadPromat()
        SubM_LoadUnit()
        EnableLefRigh()
    End Sub

    Private Sub EnableLefRigh()
        If Convert.ToDouble(txtItem.Tag) = gvInt_StartItem Then
            Me.cmdLeft.Enabled = False
            Me.cmdRight.Enabled = True
        ElseIf Convert.ToDouble(txtItem.Tag) = gvInt_EndItem Then
            Me.cmdLeft.Enabled = True
            Me.cmdRight.Enabled = False
        Else
            Me.cmdLeft.Enabled = True
            Me.cmdRight.Enabled = True
        End If
    End Sub
#End Region
#Region "Load data"
    Public Sub SubM_LoadDataIntoGrid()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_MaterialUpdate.FuncG_GetAllData()
            Me.GridControl1.DataSource = mvObj_DataTable
            Me.GridView1.PopulateColumns()

            'Me.GridView1.Columns("LOC_ID").Visible = False

            Me.GridView1.Columns("MaterialID").Caption = "Mã"
            Me.GridView1.Columns("MaterialName").Caption = "Tên"
            Me.GridView1.Columns("ImportUnit").Caption = "ĐV Nhập"
            Me.GridView1.Columns("ImportToInvRate").Caption = "Tỷ lệ Nhập/Tồn"
            Me.GridView1.Columns("ExportUnit").Caption = "ĐV Xuất"
            Me.GridView1.Columns("ExportToInvRate").Caption = "Tỷ lệ Xuất/Tồn"
            Me.GridView1.Columns("InventoryUnit").Caption = "ĐV Tồn"

            Me.GridView1.BestFitColumns()



        Catch ex As Exception

        End Try
    End Sub
    Private Sub SubM_LoadPromat()
        Dim mvObj_DataTable As New DataTable
        Try
            If Me.txtItem.Tag IsNot Nothing Then
                mvObj_DataTable = mvCls_PromatUpdate.FuncG_GetData(Me.txtItem.Tag)
                Me.GridControl2.DataSource = mvObj_DataTable
                Me.GridView2.PopulateColumns()

                Me.GridView2.Columns("MaterialID").Caption = "Mã"
                Me.GridView2.Columns("MaterialName").Caption = "Nguyên liệu"
                Me.GridView2.Columns("QTY").Caption = "Định lượng"
                Me.GridView2.Columns("ExportUnit").Caption = "Đơn vị"
                Me.GridView2.Columns("InventoryName").Caption = "Kho"

                Me.GridView2.BestFitColumns()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SubM_LoadUnit()
        Dim mvObj_DataTable As New DataTable
        Dim mvObj_DataTable2 As New DataTable
        Try
            If Me.txtItem.Tag IsNot Nothing Then
                mvObj_DataTable = mvCls_UnitUpdate.FuncG_GetAllData()
                Me.lkpExportUnit.Properties.DataSource = mvObj_DataTable
                Me.lkpExportUnit.Properties.DisplayMember = "UnitName"
                Me.lkpExportUnit.Properties.ValueMember = "UnitID"
                Me.lkpExportUnit.EditValue = Nothing

                Me.lkpImportUnit.Properties.DataSource = mvObj_DataTable
                Me.lkpImportUnit.Properties.DisplayMember = "UnitName"
                Me.lkpImportUnit.Properties.ValueMember = "UnitID"
                Me.lkpImportUnit.EditValue = Nothing

                Me.lkpInvenUnit.Properties.DataSource = mvObj_DataTable
                Me.lkpInvenUnit.Properties.DisplayMember = "UnitName"
                Me.lkpInvenUnit.Properties.ValueMember = "UnitID"
                Me.lkpInvenUnit.EditValue = Nothing

                mvObj_DataTable2 = mvCls_InventoryUpdate.FuncG_GetAllData()
                Me.lkpInventory.Properties.DataSource = mvObj_DataTable2
                Me.lkpInventory.Properties.DisplayMember = "InventoryName"
                Me.lkpInventory.Properties.ValueMember = "InventoryID"
                Me.lkpInventory.EditValue = "001"
                Me.lkpInventory.Properties.ShowHeader = False

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
#Region "Textchange"
    Private Sub txtInput_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        
    End Sub
#End Region
#Region "Nút Add new"
    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        Try
            Dim mvMaterial As New cls_Material
            If lkpExportUnit.EditValue <> Nothing And lkpImportUnit.EditValue <> Nothing And lkpInvenUnit.EditValue <> Nothing And Not String.IsNullOrEmpty(txtMaterialName.Text) And spiExportRate.Value > 0 And spiImportRate.Value > 0 Then
                mvMaterial.MaterialID = "-1"
                mvMaterial.MaterialName = txtMaterialName.Text.Trim()
                mvMaterial.ExportUnit = lkpExportUnit.EditValue
                mvMaterial.ExportToInvRate = spiExportRate.Value
                mvMaterial.ImportUnit = lkpImportUnit.EditValue
                mvMaterial.ImportToInvRate = spiImportRate.Value
                mvMaterial.InventoryUnit = lkpInvenUnit.EditValue

                If loc_id = "00" Then
                    loc_id = lkpInventory.EditValue
                End If

                mvMaterial.LOC_ID = loc_id
                Dim errorMsg As String = mvCls_MaterialUpdate.FuncG_Insert(mvMaterial, False)
                If String.IsNullOrEmpty(errorMsg) Then
                    SubM_LoadDataIntoGrid()
                Else
                    FunG_Alert("Error", errorMsg, frm_Alert.WTYPE.ERROR)
                End If
            End If
        Catch ex As Exception
            FunG_Alert("Error", ex.Message, frm_Alert.WTYPE.ERROR)
        End Try
        

    End Sub
#End Region
#Region "Nút Edit"
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
            Dim mvMaterial As New cls_Material
            If lkpExportUnit.EditValue <> Nothing And lkpImportUnit.EditValue <> Nothing And lkpInvenUnit.EditValue <> Nothing And Not String.IsNullOrEmpty(txtMaterialName.Text) And spiExportRate.Value > 0 And spiImportRate.Value > 0 Then
                mvMaterial.MaterialID = Me.txtMaterialID.Tag
                mvMaterial.MaterialName = txtMaterialName.Text.Trim()
                mvMaterial.ExportUnit = lkpExportUnit.EditValue
                mvMaterial.ExportToInvRate = spiExportRate.Value
                mvMaterial.ImportUnit = lkpImportUnit.EditValue
                mvMaterial.ImportToInvRate = spiImportRate.Value
                mvMaterial.InventoryUnit = lkpInvenUnit.EditValue
                mvMaterial.LOC_ID = loc_id
                Dim errorMsg As String = mvCls_MaterialUpdate.FuncG_Insert(mvMaterial, True)
                If String.IsNullOrEmpty(errorMsg) Then
                    SubM_LoadDataIntoGrid()
                Else
                    FunG_Alert("Error", errorMsg, frm_Alert.WTYPE.ERROR)
                End If


            End If
        Catch ex As Exception
            FunG_Alert("Error", ex.Message, frm_Alert.WTYPE.ERROR)
        End Try
        
    End Sub
#End Region
#Region "Nút Insert"
    Private Sub cmdInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsert.Click
        Try
            If Me.GridView1.FocusedRowHandle > -1 Then
                If Me.txtQty.Text = "" OrElse Convert.ToDouble(Me.txtQty.Text) = 0 Then
                    SubG_Alert(104) 'FunG_Alert("Thông báo", "Chưa có giá trị định lượng!", frm_Alert.WTYPE.ERROR)
                Else
                    mvCls_Promat.ID = Me.txtItem.Tag
                    mvCls_Promat.ItemID = Me.txtMaterialID.Tag
                    mvCls_Promat.Quantity = Me.txtQty.Text
                    mvCls_Promat.Status = 0
                    mvCls_Promat.InventoryID = lkpInventory.EditValue
                    mvCls_Promat.LOC_ID = loc_id
                    mvCls_PromatUpdate.FuncG_InsertUpdateDelete(mvCls_Promat)

                    Me.txtQty.Text = ""
                    SubM_LoadPromat()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Search"
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim mvObj_DataTable As New DataTable
        Try
            If mvBool_Search = False Then
                cmdSearch.Text = "Bỏ tìm"
                LoadDataSearch()
            Else
                cmdSearch.Text = "Tìm kiếm"
                SubM_LoadDataIntoGrid()
            End If
            mvBool_Search = Not mvBool_Search
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDataSearch()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_MaterialUpdate.FuncG_GetMaterialByName(txtMaterialName.Text.Trim())
            If mvObj_DataTable.Rows.Count <> 0 Then
                Me.GridControl1.DataSource = Nothing
                Me.GridControl1.DataSource = mvObj_DataTable
                Me.GridView1.PopulateColumns()

                Me.GridView1.Columns("LOC_ID").Visible = False

                Me.GridView1.Columns("MaterialID").Caption = "Mã"
                Me.GridView1.Columns("MaterialName").Caption = "Tên"
                Me.GridView1.Columns("ImportUnit").Caption = "ĐV Nhập"
                Me.GridView1.Columns("ImportToInvRate").Caption = "Tỷ lệ Nhập/Tồn"
                Me.GridView1.Columns("ExportUnit").Caption = "ĐV Xuất"
                Me.GridView1.Columns("ExportToInvRate").Caption = "Tỷ lệ Xuất/Tồn"
                Me.GridView1.Columns("InventoryUnit").Caption = "ĐV Tồn"

                Me.GridView1.BestFitColumns()
            End If
        Catch ex As Exception

        End Try
        
    End Sub
#End Region
#Region "Nút Delete"
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If Me.GridView2.FocusedRowHandle > -1 Then
                If gvByte_Language = 1 Then
                    If FunG_Alert("Cảnh báo", "Bạn có muốn xóa không?", frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                        mvCls_Promat.ID = Me.txtItem.Tag
                        mvCls_Promat.ItemID = Me.GridView2.GetDataRow(Me.GridView2.FocusedRowHandle)("MaterialID")
                        mvCls_Promat.Quantity = 0
                        mvCls_Promat.InventoryID = " "
                        mvCls_Promat.Status = 1
                        mvCls_Promat.LOC_ID = loc_id
                        mvCls_PromatUpdate.FuncG_InsertUpdateDelete(mvCls_Promat)
                        SubM_LoadPromat()
                    End If
                Else
                    If FunG_Alert("Warning", "Do you want to delete?", frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                        mvCls_Promat.ID = Me.txtItem.Tag
                        mvCls_Promat.ItemID = Me.GridView2.GetDataRow(Me.GridView2.FocusedRowHandle)("MaterialID")
                        mvCls_Promat.Quantity = 0
                        mvCls_Promat.InventoryID = " "
                        mvCls_Promat.Status = 1
                        mvCls_Promat.LOC_ID = loc_id
                        mvCls_PromatUpdate.FuncG_InsertUpdateDelete(mvCls_Promat)
                        SubM_LoadPromat()
                    End If
                End If
               
            End If
        Catch ex As Exception
            FunG_Alert("Error", ex.Message, frm_Alert.WTYPE.ERROR)
        End Try
    End Sub
#End Region
#Region "Nút exit"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
#End Region

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        Dim mvObj_DataTable As New DataTable
        Try
            If mvBool_Search = True Then
                mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetMaterialByName(txtName.Text.Trim())
                If mvObj_DataTable.Rows.Count <> 0 Then
                    Me.GridControl1.DataSource = Nothing
                    Me.GridControl1.DataSource = mvObj_DataTable
                    Me.GridView1.PopulateColumns()
                    Me.GridView1.BestFitColumns()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Try
            If Me.GridView1.FocusedRowHandle > -1 Then
                Me.txtMaterialID.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("MaterialID")
                Me.txtMaterialID.Tag = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("MaterialID")
                Me.txtMaterialName.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("MaterialName")

                Me.lkpExportUnit.EditValue = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("ExportUnit")
                Me.spiExportRate.Value = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("ExportToInvRate")

                Me.lkpImportUnit.EditValue = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("ImportUnit")
                Me.spiImportRate.Value = 1 ' Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("ImportToInvRate")

                Me.lkpInvenUnit.EditValue = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("InventoryUnit")
                loc_id = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("LOC_ID")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMaterialName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaterialName.TextChanged
        If mvBool_Search Then
            LoadDataSearch()
        End If
    End Sub

    Private Sub SubM_ChangeItem(ByVal iBol_Flag As Boolean, ByVal mvStr_ID As String)
        Try
            If iBol_Flag Then
                If Convert.ToDouble(mvStr_ID) > gvInt_StartItem Then
                    mvStr_ID = Convert.ToDouble(mvStr_ID) - 1
                End If
            Else
                If Convert.ToDouble(mvStr_ID) < gvInt_EndItem Then
                    mvStr_ID = Convert.ToDouble(mvStr_ID) + 1
                End If
            End If
            If mvStr_ID < 10 Then
                mvStr_ID = mvStr_ID.Insert(0, "0")
            End If

            txtItem.Tag = mvStr_ID
            txtItemID.Text = mvStr_ID
            txtItem.Text = frm_SetMenu.GridView1.GetDataRow(Convert.ToInt16(mvStr_ID) - 1)("Tên hàng")

            SubM_LoadPromat()
            EnableLefRigh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRight.Click
        SubM_ChangeItem(False, txtItem.Tag)
    End Sub

    Private Sub cmdLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLeft.Click
        SubM_ChangeItem(True, txtItem.Tag)
    End Sub

    Private Sub lkpInvenUnit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkpInvenUnit.EditValueChanged
        lkpExportUnit.EditValue = lkpInvenUnit.EditValue
    End Sub

    Private Sub lkpImportUnit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkpImportUnit.EditValueChanged
        lkpInvenUnit.EditValue = lkpImportUnit.EditValue
    End Sub
End Class