Public Class frm_PromatOpenItem
#Region "Khai báo biến"

    Dim mvCls_SalesDetailUpdate As New cls_SalesDetail_Update

    Public tungay As DateTime
    Public denngay As DateTime
    Dim sohd As String
#End Region
#Region "Hàm khởi tạo"
    Private Sub SubM_InitializeForm()

        SubM_LoadDataIntoGrid()
        SubM_LoadMetial()
    End Sub

#End Region
#Region "Load data"
    Public Sub SubM_LoadDataIntoGrid()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_SalesDetailUpdate.FuncG_Danhsachmonmo(tungay, denngay)
            Me.GridControl1.DataSource = mvObj_DataTable
            Me.GridView1.PopulateColumns()
            Me.GridView1.Columns("Mã hàng").Caption = "Mã hàng"
            Me.GridView1.Columns("Tên hàng").Caption = "Tên hàng"
            Me.GridView1.Columns("Số lượng").Caption = "Số lượng"
            Me.GridView1.Columns("Đơn giá").Caption = "Đơn giá"
            Me.GridView1.Columns("Đơn giá").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridView1.Columns("Đơn giá").DisplayFormat.FormatString = "#,###"
            Me.GridView1.Columns("Ngày").Caption = "Ngày"
            Me.GridView1.Columns("id").Visible = False
            Me.GridView1.BestFitColumns()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub SubM_LoadMetial()
        Dim mvObj_DataTable2 As New DataTable
        Dim mvCls_MaterialUpdate As New cls_Material_Update
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
        Me.lkpName.Properties.Columns("ImportToInvRate").Visible = False
        Me.lkpName.Properties.Columns("InventoryUnit").Visible = False
        ' Me.lkpName.Properties.Columns("SLCANTRU").Visible = False
        Me.lkpName.Properties.Columns("MaterialID").Caption = "Mã"
        Me.lkpName.Properties.Columns("MaterialName").Caption = "Tên"
        Me.lkpName.Properties.Columns("ImportUnit").Caption = "ĐV"
        'Me.lkpName.Properties.Columns("ExportUnit").Caption = "ĐV Xuất"
        'Me.lkpName.Properties.Columns("ExportToInvRate").Caption = "Tỷ lệ Xuất/Tồn"

    End Sub

#End Region
#Region "Form events"
    Private Sub frm_DiscountServiceVat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region
#Region "Nút Edit"
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try

            If String.IsNullOrEmpty(lkpName.EditValue) Or txtSoluongDinhMuc.Text = "" Or txtSoluongTieuHao.Text = "" Then
                FunG_Alert("Lỗi", "Vui lòng nhập số lượng hoặc chọn nguyên liệu", frm_Alert.WTYPE.ERROR)
            Else
                Dim InventoryID, MaterialID, InvoiceID, ItemID, Unit As String
                Dim ExportQty, Price, Quantity As Double


                InventoryID = "001"
                MaterialID = lkpName.EditValue
                InvoiceID = sohd
                ItemID = txtStockID.Text
                Unit = lkpName.GetColumnValue("ImportUnit")
                ExportQty = txtSoluongTieuHao.Text
                Price = txtGiaban.Text
                Quantity = 0

                If mvCls_SalesDetailUpdate.FuncG_Check(sohd, ItemID, MaterialID) Then
                    FunG_Alert("Thông báo", "Mặt hàng cùng với nguyên liệu  đã xuất cho hóa đơn này rồi ! Vui lòng kiểm tra lại ", frm_Alert.WTYPE.ERROR)
                Else
                    mvCls_SalesDetailUpdate.FuncG_InsertDinhluongmonmo(InventoryID, MaterialID, InvoiceID, ItemID, ExportQty, Unit, Price, 0)
                    '======lưu lịch sử định lượng món mở===================
                    mvCls_SalesDetailUpdate.FuncG_InsertLichSuDinhLuong(InvoiceID, ItemID, txtTenhang.Text, txtSoluongTieuHao.Text, MaterialID, lkpName.Text, InventoryID, gvStr_AccUser, txtSoluongDinhMuc.Text)
                    FunG_Alert("Thông báo", "Bạn đã xuất kho thành công", frm_Alert.WTYPE.CHECK)
                    txtSoluongDinhMuc.Text = "0"
                    txtSoluongTieuHao.Text = "0"
                End If

               

            End If

           
        Catch ex As Exception
            FunG_Alert("Lỗi", ex.Message, frm_Alert.WTYPE.ERROR)
        End Try

    End Sub
#End Region

#Region "Nút exit"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
#End Region
    Private Sub GridView1_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Try
            Dim GIA As String
            If Me.GridView1.FocusedRowHandle > -1 Then
                Me.txtStockID.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã hàng").ToString()
                Me.txtStockID.Tag = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Mã hàng").ToString()
                Me.txtTenhang.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Tên hàng").ToString()
                Me.txtSoLuongBan.Text = Decimal.Parse(Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Số lượng")).ToString("N3")
                GIA = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Đơn giá").ToString()
                Me.txtGiaban.Text = Decimal.Parse(GIA).ToString("N0")

                sohd = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("id").ToString()

                'Me.txtStockReportID.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("StockReportID")
            End If
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub txtSoluongDinhMuc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSoluongDinhMuc.TextChanged
        Try
            Dim tong As Double
            tong = Convert.ToDouble(txtSoLuongBan.Text) * Convert.ToDouble(txtSoluongDinhMuc.Text)
            txtSoluongTieuHao.Text = tong
        Catch ex As Exception
            txtSoluongTieuHao.Text = "Vui lòng nhập số "
        End Try
    End Sub
End Class