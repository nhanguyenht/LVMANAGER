Public Class frm_InventoryBalance
#Region "Khai báo biến"
    
    Dim mvCls_StockUpdate As New cls_Stock_Update


    Dim mvCls_ImExDetailUpdate As New cls_ImportExportDetail_Update
    Dim mvCls_ImExDetail As New cls_ImportExportDetail

    Dim mvCls_ImportExport As New cls_ImportExport
    Dim mvCls_ImportExportUpdate As New cls_ImportExport_Update

    Dim soluongbandau As Double
    Dim soluongthaydoi As Double
    Dim mvBool_Search As Boolean = False
#End Region
#Region "Hàm khởi tạo"
    Private Sub SubM_InitializeForm()

        SubM_LoadDataIntoGrid()
        If gvByte_Language = 1 Then
            Me.Text = "CÂN ĐỐI KHO"
            LabelControl3.Text = "CÂN ĐỐI KHO"
            GroupControl1.Text = "DANH SÁCH CÂN ĐỐI KHO"
            GroupControl2.Text = "THÔNG TIN CÂN ĐỐI KHO"
            LabelControl2.Text = "Mã hàng"
            LabelControl5.Text = "Tên hàng"
            LabelControl6.Text = "Giá bán"
            LabelControl7.Text = "S.L Tồn"
            LabelControl1.Text = "Đơn Vị Tồn"
            LabelControl4.Text = "Kho"
            cmdEdit.Text = "Sửa"
            cmdSearch.Text = "Tim kiếm"
            cmdExit.Text = "Thoát"
        Else

            Me.Text = "INVENTORY BALANCE"
            LabelControl3.Text = "INVENTORY BALANCE"
            GroupControl1.Text = "LIST INVENTORY BALANCE"
            GroupControl2.Text = "INVENTORY BALANCE INFORMATION"
            LabelControl2.Text = "Item ID"
            LabelControl5.Text = "Item Name"
            LabelControl6.Text = "Price"
            LabelControl7.Text = "Qty Stock"
            LabelControl1.Text = "Unit Stock"
            LabelControl4.Text = "Inventory"
            cmdEdit.Text = "Edit"
            cmdSearch.Text = "Search"
            cmdExit.Text = "Exit"
        End If
    End Sub

#End Region
#Region "Load data"
    Public Sub SubM_LoadDataIntoGrid()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_StockUpdate.FuncG_GetAllDataStock_Reports()
            Me.GridControl1.DataSource = mvObj_DataTable
            Me.GridView1.PopulateColumns()
            If gvByte_Language = 1 Then
                Me.GridView1.Columns("Tên hàng").Caption = "Tên hàng"
                Me.GridView1.Columns("Mã hàng").Caption = "Mã hàng"
                Me.GridView1.Columns("Số lượng").Caption = "Số lượng"
                Me.GridView1.Columns("Đơn giá").Caption = "Đơn giá"
                Me.GridView1.Columns("DVT").Caption = "ĐVT"
                Me.GridView1.Columns("Kho").Caption = "Kho"
            Else
                Me.GridView1.Columns("Tên hàng").Caption = "Item Name"
                Me.GridView1.Columns("Mã hàng").Caption = "Item ID"
                Me.GridView1.Columns("Số lượng").Caption = "Quantity"
                Me.GridView1.Columns("Đơn giá").Caption = "Price"
                Me.GridView1.Columns("DVT").Caption = "Unit"
                Me.GridView1.Columns("Kho").Caption = "Inventory name"
            End If
            
            Me.GridView1.Columns("Đơn giá").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridView1.Columns("Đơn giá").DisplayFormat.FormatString = "#,###"
           
            Me.GridView1.BestFitColumns()
            
        Catch ex As Exception

        End Try
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
            txtTenhang.Enabled = False
            txtSoluong.Enabled = True
            Dim mvCls_Stock As New cls_Stock
            Dim mvStock As New cls_Stock_Update
            If gvByte_Language = 1 Then
                If cmdEdit.Text = "Cập Nhật" Then
                    If txtSoluong.Text <> Nothing Then
                        soluongthaydoi = Double.Parse(txtSoluong.Text) - soluongbandau
                        If (soluongthaydoi > 0) Then
                            CreatePN(soluongthaydoi)
                        ElseIf soluongthaydoi < 0 Then
                            CreatePX(soluongthaydoi)
                        End If
                        Ints_History(soluongbandau, txtGiaban.Text)
                        txtSoluong.Enabled = False
                        SubM_LoadDataIntoGrid()
                        cmdEdit.Text = "Sửa"
                    End If
                End If
            Else
                If cmdEdit.Text = "Update" Then
                    If txtSoluong.Text <> Nothing Then
                        soluongthaydoi = Double.Parse(txtSoluong.Text) - soluongbandau
                        If (soluongthaydoi > 0) Then
                            CreatePN(soluongthaydoi)
                        ElseIf soluongthaydoi < 0 Then
                            CreatePX(soluongthaydoi)
                        End If
                        txtSoluong.Enabled = False
                        SubM_LoadDataIntoGrid()
                        cmdEdit.Text = "Edit"
                    End If
                End If
            End If
            
            
        Catch ex As Exception
            FunG_Alert("Error", ex.Message, frm_Alert.WTYPE.ERROR)
        End Try

    End Sub
#End Region
#Region "Tạo Phiếu Nhập"
    Public Sub CreatePN(ByVal quantity As Double)
        Dim InvoiceID As String = ""
        InvoiceID = mvCls_ImportExportUpdate.FuncG_CreateInvoiceNo("PN", DateTime.Now.ToShortDateString())
        Try
            Dim dtinfoIMPORTEXPORT As New DataTable()
            'Tạo chi tiết TBL_IMPORTEXPORTDETAIL'
            mvCls_ImExDetail.ID = InvoiceID
            mvCls_ImExDetail.ItemID = txtStockID.Text
            mvCls_ImExDetail.Price = Me.txtGiaban.Text
            mvCls_ImExDetail.Quantity = quantity 'Me.txtQty.Text
            mvCls_ImExDetail.Vat = 0
            mvCls_ImExDetail.Status = 0
            mvCls_ImExDetailUpdate.FuncG_InsertUpdate(mvCls_ImExDetail)

            'Tạo vào bảng TBL_IMPORTEXPORT

            mvCls_ImportExport.ID = InvoiceID
            mvCls_ImportExport.Invoice = ""
            mvCls_ImportExport.CreateDay = DateTime.Now
            mvCls_ImportExport.Note = "CAN DOI KHO"
            mvCls_ImportExport.Suppliers = "NCC01"
            mvCls_ImportExport.User = gvStr_AccUser
            mvCls_ImportExport.Type = 0
            mvCls_ImportExport.InventoryID = txtKho.Tag
            mvCls_ImportExport.ToInventoryID = ""
            dtinfoIMPORTEXPORT = mvCls_ImportExportUpdate.FuncG_GetData(InvoiceID)
            If (dtinfoIMPORTEXPORT.Rows.Count > 0) Then
                mvCls_ImportExport.Status = 1
            Else
                mvCls_ImportExport.Status = 0
            End If

            mvCls_ImportExportUpdate.FuncG_InsertUpdate(mvCls_ImportExport)
        Catch ex As Exception
            mvCls_ImExDetailUpdate.FuncG_Delete(InvoiceID)
        End Try


        'Ghi vào kho
        mvCls_ImportExportUpdate.FuncG_ImportExport_StockDetail(InvoiceID, True)

    End Sub
    Public Sub CreatePX(ByVal quantity As Double)
        Dim InvoiceID As String = ""
        InvoiceID = mvCls_ImportExportUpdate.FuncG_CreateInvoiceNo("PX", DateTime.Now.ToShortDateString())
        Try
            Dim dtinfoIMPORTEXPORT As New DataTable()
            'Tạo chi tiết TBL_IMPORTEXPORTDETAIL'
            mvCls_ImExDetail.ID = InvoiceID
            mvCls_ImExDetail.ItemID = txtStockID.Text
            mvCls_ImExDetail.Price = Me.txtGiaban.Text
            mvCls_ImExDetail.Quantity = -quantity 'Me.txtQty.Text
            mvCls_ImExDetail.Vat = 0
            mvCls_ImExDetail.Status = 0
            mvCls_ImExDetailUpdate.FuncG_InsertUpdate(mvCls_ImExDetail)

            'Tạo vào bảng TBL_IMPORTEXPORT

            mvCls_ImportExport.ID = InvoiceID
            mvCls_ImportExport.Invoice = ""
            mvCls_ImportExport.CreateDay = DateTime.Now
            mvCls_ImportExport.Note = "CAN DOI KHO"
            mvCls_ImportExport.Suppliers = "NCC01"
            mvCls_ImportExport.User = gvStr_AccUser
            mvCls_ImportExport.Type = 1
            mvCls_ImportExport.InventoryID = txtKho.Tag
            mvCls_ImportExport.ToInventoryID = "999" ' txtKho.Tag
            dtinfoIMPORTEXPORT = mvCls_ImportExportUpdate.FuncG_GetData(InvoiceID)
            If (dtinfoIMPORTEXPORT.Rows.Count > 0) Then
                mvCls_ImportExport.Status = 1
            Else
                mvCls_ImportExport.Status = 0
            End If

            mvCls_ImportExportUpdate.FuncG_InsertUpdate(mvCls_ImportExport)
        Catch ex As Exception
            mvCls_ImExDetailUpdate.FuncG_Delete(InvoiceID)
        End Try


        'Ghi vào kho
        mvCls_ImportExportUpdate.FuncG_ImportExport_StockDetail(InvoiceID, False)

    End Sub
#End Region
#Region "TẠO LỊCH SỬ CÂN ĐỐI KHO"
    Public Sub Ints_History(ByVal SLcu As Double, ByVal Gia As Double)
        Dim History As New cls_HistoryBalance
        History.USER = gvStr_AccUser
        History.Material_ID = txtStockID.Text
        History.CreateDate = DateTime.Now
        History.QTYOLD = SLcu
        History.QTYNEW = Double.Parse(txtSoluong.Text)
        History.PRICE = GIA
        Dim mvCls_HistoryBalanceUpdate As New cls_HistoryUpdate
        mvCls_HistoryBalanceUpdate.Insert(History)
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
                Me.txtSoluong.Text = Decimal.Parse(Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Số lượng")).ToString("N3")
                GIA = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Đơn giá").ToString()
                Me.txtGiaban.Text = Decimal.Parse(GIA).ToString("N0")
                Me.txtDVT.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("DVT").ToString()
                Me.txtKho.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Kho").ToString()
                soluongbandau = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("Số lượng").ToString()
                txtKho.Tag = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("InventoryID").ToString()
                'Me.txtStockReportID.Text = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("StockReportID")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSoluong_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSoluong.TextChanged

        If txtSoluong.Enabled = True Then
            If gvByte_Language = 1 Then
                cmdEdit.Text = "Cập Nhật"
            Else
                cmdEdit.Text = "Update"
            End If

        End If
    End Sub

    Private Sub txtSoluong_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSoluong.KeyPress
        SubG_OnlyInputDigit(sender, e, False)
    End Sub

    Private Sub txtSoluong_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSoluong.Leave
        SubG_FormatNumberDigit(sender, 3)
    End Sub
    Private Sub LoadDataSearch()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_StockUpdate.FuncG_GetAllDataStock_Reports(txtTenhang.Text.Trim())
            If mvObj_DataTable.Rows.Count <> 0 Then
                Me.GridControl1.DataSource = Nothing
                Me.GridControl1.DataSource = mvObj_DataTable
                Me.GridView1.PopulateColumns()
                If gvByte_Language = 1 Then
                    Me.GridView1.Columns("Tên hàng").Caption = "Tên hàng"
                    Me.GridView1.Columns("Số lượng").Caption = "Số lượng"
                    Me.GridView1.Columns("Đơn giá").Caption = "Đơn giá"
                Else
                    Me.GridView1.Columns("Tên hàng").Caption = "Item name"
                    Me.GridView1.Columns("Số lượng").Caption = "Quantity"
                    Me.GridView1.Columns("Đơn giá").Caption = "Price"
                End If
               
                Me.GridView1.Columns("Đơn giá").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.GridView1.Columns("Đơn giá").DisplayFormat.FormatString = "#,###"

                Me.GridView1.BestFitColumns()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim mvObj_DataTable As New DataTable
        Try
            If gvByte_Language = 1 Then
                If mvBool_Search = False Then
                    txtTenhang.Enabled = True
                    cmdSearch.Text = "Bỏ tìm"
                    LoadDataSearch()
                    txtTenhang.Enabled = True
                Else
                    txtTenhang.Enabled = False
                    cmdSearch.Text = "Tìm kiếm"
                    SubM_LoadDataIntoGrid()
                End If
            Else
                If mvBool_Search = False Then
                    txtTenhang.Enabled = True
                    cmdSearch.Text = "Cancel Search"
                    LoadDataSearch()
                    txtTenhang.Enabled = True
                Else
                    txtTenhang.Enabled = False
                    cmdSearch.Text = "Search"
                    SubM_LoadDataIntoGrid()
                End If
            End If
           
            mvBool_Search = Not mvBool_Search
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTenhang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTenhang.TextChanged
        If mvBool_Search Then
            LoadDataSearch()
        End If
    End Sub
End Class