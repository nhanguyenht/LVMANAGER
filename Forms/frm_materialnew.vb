Public Class frm_materialnew 
#Region "KHAI BÁO BIẾN"
    Dim mvCls_MaterialUpdate As New cls_Material_Update
    Dim mvCls_Promat As New cls_Promat
    Dim mvCls_PromatUpdate As New cls_Promat_Update
    Dim mvCls_UnitUpdate As New cls_Unit_Update
    Dim mvBool_Search As Boolean = False
    Dim mvCls_InventoryUpdate As New cls_Inventory_Update
    Dim loc_id As String = "00"
#End Region
    Private Sub frm_materialnew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SubM_LoadUnit()
        If gvByte_Language = 1 Then
            Me.Text = "TẠO MỚI NGUYÊN LIỆU"
            LabelControl1.Text = "TẠO MỚI NGUYÊN LIỆU"
            LabelControl2.Text = "TÊN NGUYÊN LIỆU"
            LabelControl5.Text = "ĐV NHẬP"
            LabelControl7.Text = "ĐV TỒN"
            LabelControl6.Text = "ĐV XUẤT"
            cmdAddNew.Text = "Tạo mới"
        Else
            Me.Text = "CREATE NEW MATERIAL"
            LabelControl1.Text = "CREATE NEW MATERIAL"
            LabelControl2.Text = "MATERIAL NAME"
            LabelControl5.Text = "UNIT IMPORT"
            LabelControl7.Text = "UNIT STOCK"
            LabelControl6.Text = "UNIT EXPORT"
            cmdAddNew.Text = "Create New"
        End If
    End Sub

    Private Sub SubM_LoadUnit()
        Dim mvObj_DataTable As New DataTable
        Dim mvObj_DataTable2 As New DataTable
        
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


        
    End Sub

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
                    loc_id = "01"
                End If

                mvMaterial.LOC_ID = loc_id
                Dim errorMsg As String = mvCls_MaterialUpdate.FuncG_Insert(mvMaterial, False)
                If String.IsNullOrEmpty(errorMsg) Then
                    frm_ImportInvoice.LOAD_MATERIAL()
                    Me.Close()

                Else
                    FunG_Alert("Error", errorMsg, frm_Alert.WTYPE.ERROR)
                End If
            End If
        Catch ex As Exception
            FunG_Alert("Error", ex.Message, frm_Alert.WTYPE.ERROR)
        End Try

    End Sub

    Private Sub lkpImportUnit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkpImportUnit.EditValueChanged
        lkpInvenUnit.EditValue = lkpImportUnit.EditValue
        lkpExportUnit.EditValue = lkpInvenUnit.EditValue
    End Sub
End Class