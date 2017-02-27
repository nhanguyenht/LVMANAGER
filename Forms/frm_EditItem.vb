Public Class frm_EditItem 
#Region "Khai báo biến"
    Public gvStr_ID As String
    Dim mvCls_Item As New cls_Item
    Dim mvCls_ItemUpdate As New cls_Item_Update
    Dim mvCls_GroupItemUpdate As New cls_GroupItem_Update
    Dim mvCls_PrinterUpdate As New cls_Printer_Update
    Dim _path_Image As String = Application.StartupPath + "\\Insert_Picture.PNG"
    Dim mvCls_PromatUpdate As New cls_Promat_Update
#End Region
#Region "Hàm khởi tạo"
    Private Sub SubM_InitializeForm()
        Dim mvObj_DataTable As New DataTable
        Try
            SubM_LoadData()
            If gvStr_ID <> "" Then
                mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetDataInfo(gvStr_ID)
                If mvObj_DataTable.Rows.Count <> 0 Then
                    Me.txtID.Text = mvObj_DataTable.Rows(0)("ID")
                    Me.lkpNhomHang.EditValue = mvObj_DataTable.Rows(0)("GROUP_ID")
                    Me.txtName.Text = mvObj_DataTable.Rows(0)("NAME")
                    Me.txtPrice1.Text = mvObj_DataTable.Rows(0)("PRICE1")
                    Me.txtPrice2.Text = mvObj_DataTable.Rows(0)("PRICE2")
                    Me.txtPrice3.Text = mvObj_DataTable.Rows(0)("PRICE3")
                    Me.txtPrice4.Text = mvObj_DataTable.Rows(0)("PRICE4")
                    Me.txtPrice5.Text = mvObj_DataTable.Rows(0)("PRICE5")
                    If gvByte_Language = 1 Then
                        SubG_FormatNumberDigit(Me.txtPrice1, 0)
                        SubG_FormatNumberDigit(Me.txtPrice2, 0)
                    Else
                        SubG_FormatNumberDigit(Me.txtPrice1, 2)
                        SubG_FormatNumberDigit(Me.txtPrice2, 2)
                    End If
                    Me.txtUnit.Text = mvObj_DataTable.Rows(0)("UNIT")
                    Me.txtUnit.Tag = mvObj_DataTable.Rows(0)("PROMAT")
                    Me.lkpPrinter.EditValue = mvObj_DataTable.Rows(0)("PRINTER")
                    Me.chePrint.Checked = mvObj_DataTable.Rows(0)("PRINTORDER")
                    Me.cheStatus.Checked = mvObj_DataTable.Rows(0)("STATUS")
                    Me.ColorEdit1.Color = Color.FromArgb(mvObj_DataTable.Rows(0)("COLOR"))
                    Me.rgpCombo.SelectedIndex = mvObj_DataTable.Rows(0)("Type")
                    Dim DataTB As New DataTable
                    DataTB = mvCls_PromatUpdate.FuncG_GetDataByID(txtID.Text)
                    If DataTB.Rows.Count > 0 Then
                        If DataTB.Rows(0)("InventoryID") = "101" Then
                            cheShifts.Checked = True
                        Else
                            cheShifts.Checked = False
                        End If
                    Else
                        cheShifts.Checked = False
                    End If
                    If Convert.ToDouble(gvStr_ID) = gvInt_StartItem Then
                        Me.cmdLeft.Enabled = False
                        Me.cmdRight.Enabled = True
                    ElseIf Convert.ToDouble(gvStr_ID) = gvInt_EndItem Then
                        Me.cmdLeft.Enabled = True
                        Me.cmdRight.Enabled = False
                    Else
                        Me.cmdLeft.Enabled = True
                        Me.cmdRight.Enabled = True
                    End If
                    If gvByte_Language = 1 Then
                        Me.Text = "Sửa mặt hàng"
                        gpcHeader.Text = "Thông tin mặt hàng"
                        LabelControl1.Text = "Mã hàng"
                        LabelControl2.Text = "Giá 2"
                        LabelControl3.Text = "Máy in"
                        LabelControl4.Text = "Nhóm giảm giá"
                        LabelControl5.Text = "Giá 4"
                        LabelControl6.Text = "Giá 3"
                        LabelControl7.Text = "Giá 5"
                        lblGroupItem.Text = "Nhóm hàng"
                        lblItem.Text = "Tên hàng"
                        lblPrice1.Text = "Giá 1"
                        lblUnit.Text = "ĐVT"
                        chePrint.Text = "In bếp"
                        cheShifts.Text = "Kho 1-1"
                        cheStatus.Text = "Hiển thị"
                        rgpCombo.Properties.Items.Item(0).Description = "Không"
                        rgpCombo.Properties.Items.Item(0).Description = "Combo"
                        cmdMonPhu.Text = "Món phụ"
                    Else
                        Me.Text = "Edit Item"
                        gpcHeader.Text = "Item information"
                        LabelControl1.Text = "ID"
                        LabelControl2.Text = "Price 2"
                        LabelControl3.Text = "Printer"
                        LabelControl4.Text = "Group Discount"
                        LabelControl5.Text = "Price 4"
                        LabelControl6.Text = "Price 3"
                        LabelControl7.Text = "Price 5"
                        lblGroupItem.Text = "Group item"
                        lblItem.Text = "Item name"
                        lblPrice1.Text = "Price 1"
                        lblUnit.Text = "Unit"
                        chePrint.Text = "Print"
                        cheShifts.Text = "Inv 1-1"
                        cheStatus.Text = "Show"
                        rgpCombo.Properties.Items.Item(0).Description = "Not"
                        rgpCombo.Properties.Items.Item(0).Description = "Combo"
                        cmdMonPhu.Text = "Combo item"
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Load Data"
    Private Sub SubM_LoadData()
        Dim mvObj_DataTable As New DataTable
        Dim mvObj_DataTable1 As New DataTable
        Dim mvObj_DataTable2 As New DataTable
        Try
            mvObj_DataTable = mvCls_PrinterUpdate.FuncG_GetAllData1
            Me.lkpPrinter.Properties.DataSource = mvObj_DataTable
            Me.lkpPrinter.Properties.DisplayMember = "Tên máy"
            Me.lkpPrinter.Properties.ValueMember = "Mã"
            Me.lkpPrinter.EditValue = Nothing

            mvObj_DataTable1 = mvCls_GroupItemUpdate.FuncG_GetAllData1
            Me.lkpNhomHang.Properties.DataSource = mvObj_DataTable1
            Me.lkpNhomHang.Properties.DisplayMember = "Nhóm hàng"
            Me.lkpNhomHang.Properties.ValueMember = "Mã nhóm"
            Me.lkpNhomHang.EditValue = Nothing

        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form events"
    Private Sub frm_EditItem_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_TableMap.SubM_InitializeForm()
    End Sub
    Private Sub frm_EditItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region
#Region "Cập nhật mặt hàng"
    Private Sub SubM_UpdateItem()
        Try
            Dim mvCls_Material As New cls_Material_Update
            Dim mvMaterial As New cls_Material
            Dim mvPromat As New cls_Promat
            Dim mvCls_PromatUpdate As New cls_Promat_Update

            If Me.lkpNhomHang.EditValue Is Nothing Then
                SubG_Alert(81)
                'FunG_Alert("Annonce lỗi", "Chưa chọn nhóm hàng!", frm_Alert.WTYPE.ERROR)
            ElseIf Me.txtPrice1.Text = "" Then
                SubG_Alert(82)
                'FunG_Alert("Annonce lỗi", "Chưa nhập giá bán cho món ăn!", frm_Alert.WTYPE.ERROR)
            ElseIf (Not IsNumeric(Me.txtPrice1.Text)) Then
                SubG_Alert(83) 'FunG_Alert("Annonce lỗi", "Đơn giá bán phải là số!", frm_Alert.WTYPE.ERROR)
            Else
                If String.IsNullOrEmpty(txtPrice3.Text) Then
                    txtPrice3.Text = "0"
                End If
                If String.IsNullOrEmpty(txtPrice4.Text) Then
                    txtPrice4.Text = "0"
                End If
                If String.IsNullOrEmpty(txtPrice5.Text) Then
                    txtPrice5.Text = "0"
                End If
                mvCls_Item.ID = Me.txtID.Text
                mvCls_Item.Name = Me.txtName.Text
                mvCls_Item.Price1 = Me.txtPrice1.Text
                mvCls_Item.Price2 = Me.txtPrice2.Text
                mvCls_Item.Price3 = Me.txtPrice3.Text
                mvCls_Item.Price4 = Me.txtPrice4.Text
                mvCls_Item.Price5 = Me.txtPrice5.Text
                mvCls_Item.Unit = Me.txtUnit.Text
                mvCls_Item.Printer = Me.lkpPrinter.EditValue
                mvCls_Item.Color = Me.ColorEdit1.Color.ToArgb

                'Chưa cập nhật hình ảnh và mô tả

                mvCls_Item.Image1 = ReadFile(_path_Image)
                mvCls_Item.Image2 = ReadFile(_path_Image)
                mvCls_Item.Image3 = ReadFile(_path_Image)
                mvCls_Item.Image4 = ReadFile(_path_Image)
                mvCls_Item.Image5 = ReadFile(_path_Image)
                mvCls_Item.Description = ""
                mvCls_Item.TYPE = rgpCombo.SelectedIndex

                If Me.chePrint.Checked Then
                    mvCls_Item.Print = 1
                Else
                    mvCls_Item.Print = 0
                End If
                If Me.cheStatus.Checked Then
                    mvCls_Item.Status = 1
                Else
                    mvCls_Item.Status = 0
                End If
                mvCls_Item.Promat = Me.txtUnit.Tag

                mvCls_ItemUpdate.FuncG_UpdateItem(mvCls_Item, 2)
                If cheShifts.Checked = True Then

                    Dim datatb As New DataTable
                    datatb = mvCls_PromatUpdate.FuncG_GetDataByID(txtID.Text)
                    If datatb.Rows.Count > 0 Then

                        GoTo ThoatInsert
                    Else
                        Dim loc_id As String = "01"
                        mvMaterial.MaterialID = "-1"
                        mvMaterial.MaterialName = txtName.Text
                        mvMaterial.ExportUnit = txtUnit.Text
                        mvMaterial.ExportToInvRate = 1
                        mvMaterial.ImportUnit = txtUnit.Text
                        mvMaterial.ImportToInvRate = 1
                        mvMaterial.InventoryUnit = txtUnit.Text
                        If loc_id = "00" Then
                            loc_id = "01"
                        End If

                        mvMaterial.LOC_ID = loc_id
                        Dim DATAMATERIAL As New DataTable
                        DATAMATERIAL = mvCls_Material.FuncG_GetMaterialByName(mvMaterial.MaterialName)
                        If DATAMATERIAL.Rows.Count > 0 Then

                            mvPromat.ID = mvCls_Item.ID
                            mvPromat.ItemID = DATAMATERIAL.Rows(0)("MaterialID")
                            mvPromat.Quantity = 1
                            mvPromat.InventoryID = "101"
                            mvPromat.LOC_ID = loc_id
                            mvPromat.Status = 0
                            mvCls_PromatUpdate.FuncG_InsertUpdateDelete(mvPromat)
                        Else
                            Dim errorMsg As String = mvCls_Material.FuncG_Insert(mvMaterial, False)
                            If String.IsNullOrEmpty(errorMsg) Then
                                Dim DATAMATERIALE As New DataTable
                                DATAMATERIALE = mvCls_Material.FuncG_GetMaterialByName(mvMaterial.MaterialName)
                                mvPromat.ID = mvCls_Item.ID
                                mvPromat.ItemID = DATAMATERIALE.Rows(0)("MaterialID")
                                mvPromat.Quantity = 1
                                mvPromat.InventoryID = "101"
                                mvPromat.LOC_ID = loc_id
                                mvPromat.Status = 0
                                mvCls_PromatUpdate.FuncG_InsertUpdateDelete(mvPromat)


                            End If
                        End If


                    End If
                ElseIf cheShifts.Checked = False Then
                    Dim DATATB As New DataTable
                    Dim mvCls_Import_Update As New cls_ImportExport_Update

                    Dim DATAPROMAT As New DataTable
                    DATAPROMAT = mvCls_PromatUpdate.FuncG_GetDataByID(mvCls_Item.ID)
                    If DATAPROMAT.Rows.Count > 0 Then

                        DATATB = mvCls_Import_Update.FuncG_GetDataByID(DATAPROMAT.Rows(0)("Item_ID").ToString)
                        If DATATB.Rows.Count > 0 Then
                            If gvByte_Language = 1 Then
                                FunG_Alert("Thông báo", "Món này đã nhập nguyên liệu, không thể thay đổi kho", frm_Alert.WTYPE.ERROR)
                            Else
                                FunG_Alert("Message", "This dish was imported materials, can not change the repository", frm_Alert.WTYPE.ERROR)
                            End If

                        Else
                            'XÓA ĐỊNH LƯỢNG MÓN HÀNG'
                            mvPromat.Status = 1
                            mvPromat.LOC_ID = "01"
                            mvPromat.ID = mvCls_Item.ID
                            mvPromat.ItemID = DATAPROMAT.Rows(0)("Item_ID").ToString
                            mvPromat.InventoryID = "101"
                            mvCls_PromatUpdate.FuncG_InsertUpdateDelete(mvPromat)
                            'XÓA NGUYÊN LIỆU'
                            mvCls_Material.FuncG_DeleteMaterial(DATAPROMAT.Rows(0)("Item_ID").ToString)
                        End If
                    End If


                End If

ThoatInsert:    SubM_InitializeForm()

            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Change item"
    Private Sub SubM_ChangeItem(ByVal iBol_Flag As Boolean)
        Try
            If iBol_Flag Then
                If Convert.ToDouble(gvStr_ID) > gvInt_StartItem Then
                    gvStr_ID = Convert.ToDouble(gvStr_ID) - 1
                End If
            Else
                If Convert.ToDouble(gvStr_ID) < gvInt_EndItem Then
                    gvStr_ID = Convert.ToDouble(gvStr_ID) + 1
                End If
            End If
            If gvStr_ID < 10 Then
                gvStr_ID = gvStr_ID.Insert(0, "0")
            End If
            SubM_InitializeForm()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút left"
    Private Sub cmdLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLeft.Click
        SubM_ChangeItem(True)
    End Sub
#End Region
#Region "Nút right"
    Private Sub cmdRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRight.Click
        SubM_ChangeItem(False)
    End Sub
#End Region
#Region "Nút apply"
    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        SubM_UpdateItem()
        'Me.Close()
    End Sub
#End Region
#Region "Nút OK"
    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        SubM_UpdateItem()
        Me.Close()
    End Sub
#End Region
#Region "Nút cancel"
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
#End Region

    ''' <summary>
    ''' ReadFile - Dùng để đọc một file ảnh trên đĩa và convert sang mảng byte
    ''' </summary>
    ''' <Author>Van Long</Author>
    ''' <Date>2013/12/19</Date>
    ''' <param name="sFileName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReadFile(ByVal sFileName As String) As Byte()
        Dim fs As System.IO.FileStream = New System.IO.FileStream(sFileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read)
        Dim rs() As Byte = New Byte(fs.Length) {}
        fs.Read(rs, 0, System.Convert.ToInt32(fs.Length))
        fs.Close()
        Return rs
    End Function

    Private Sub rgpCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgpCombo.SelectedIndexChanged
        If rgpCombo.SelectedIndex = 0 Then
            cmdMonPhu.Enabled = False
        Else
            cmdMonPhu.Enabled = True
            chePrint.Checked = False
        End If
    End Sub

    Private Sub cmdMonPhu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMonPhu.Click
        If Me.txtID.Text <> "" Then
            frm_Item_Ex.txtGroupItem.Text = Me.lkpNhomHang.Text
            frm_Item_Ex.txtItem.Tag = Me.txtID.Text
            frm_Item_Ex.txtItem.Text = Me.txtName.Text
            frm_Item_Ex.txtPrice1.Text = Me.txtPrice1.Text
            frm_Item_Ex.txtPrice2.Text = Me.txtPrice2.Text

            frm_Item_Ex.GridControl1.DataSource = mvCls_ItemUpdate.FuncG_GetAllData_Item()
            frm_Item_Ex.GridView1.Columns("ID").Visible = False
            frm_Item_Ex.GridView1.Columns("Tên món").Width = 300
            frm_Item_Ex.GridView1.Columns("Nhóm món").Width = 100

            frm_Item_Ex.GridControl2.DataSource = mvCls_ItemUpdate.FuncG_GetAllData_Item_Item(frm_Item_Ex.txtItem.Tag)
            frm_Item_Ex.GridView2.Columns("ID").Visible = False
            frm_Item_Ex.GridView2.Columns("Tên món").Width = 300
            frm_Item_Ex.GridView2.Columns("Nhóm món").Width = 100

            frm_Item_Ex.ShowDialog()
            Me.Hide()
        End If
    End Sub
End Class