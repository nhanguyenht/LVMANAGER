Public Class frm_ReportsFromTo
#Region "Khai báo biến"
    Public gvStr_ReportType As String
    Dim mvCls_CustomerSupplierUpdate As New cls_Customer_Update
    Dim mvCls_ReportUpdate As New cls_Report_Update
    Dim mvCls_ItemUpdate As New cls_Item_Update
    Dim mvCls_UpdateAccount As New cls_Account_Update
#End Region
#Region "Hàm khởi tạo"
    Private Sub SubM_InitializeForm()
        Dim mvObj_DataTable As New DataTable
        Try
            Me.DateEdit1.DateTime = Today
            Me.DateEdit2.DateTime = Today
            'Me.cheShifts.Checked = False

            If Me.gvStr_ReportType = "TaiChinh" Then
                Me.chkChitiet.Text = "Xem Chi Tiết"
                Me.chkChitiet.Visible = True
                Me.cheShifts.Visible = False
                Me.cbxByShifts.Visible = False
            ElseIf Me.gvStr_ReportType = "HoaDon" Then
                Me.chkChitiet.Visible = True
                Me.chkChitiet.Text = "Xem Báo Cáo Tiếp Khách"
                Me.cheShifts.Visible = True
                Me.cbxByShifts.Visible = True
                Me.cheShifts.Enabled = True
                Me.cbxByShifts.Enabled = True
            ElseIf gvStr_ReportType = "NhapKho" Then
                lkpObject.Visible = False
                cheShifts.Visible = False
                chkChitiet.Visible = False
                cbxByShifts.Visible = False
                LabelControl5.Visible = False
            ElseIf gvStr_ReportType = "XuatKho" Then
                lkpObject.Visible = False
                cheShifts.Visible = False
                chkChitiet.Visible = False
                cbxByShifts.Visible = False
                LabelControl5.Visible = False
            ElseIf gvStr_ReportType = "NhapKhoNCC" Then
                lkpObject.Visible = True
                LabelControl5.Visible = True
                cheShifts.Visible = False
                cbxByShifts.Visible = False

            Else
                Me.chkChitiet.Visible = False
                Me.cheShifts.Visible = True
                Me.cbxByShifts.Visible = True
                Me.cheShifts.Enabled = True
                Me.cbxByShifts.Enabled = True
            End If
            'Me.cbxByShifts.SelectedIndex = 0
            SubM_LoadCashier()
            ' Me.cbxByShifts.Enabled = False
            If gvByte_Language = 1 Then
                Me.gpcArea.Text = "Vui lòng chọn ngày cần báo cáo!"
                Me.cheShifts.Text = "Theo ca :"
                lblID.Text = "Từ Ngày:"
                LabelControl1.Text = "Đến Ngày:"
                LabelControl5.Text = "Đối Tượng:"
                chkChitiet.Text = "Xem chi tiết"
                cmdConfirm.Text = "Xác nhận"
                cmdExit.Text = "Thoát"
            Else
                cmdConfirm.Text = "Confirm"
                cmdExit.Text = "Exit"
                chkChitiet.Text = "Detail"
                lblID.Text = "From date:"
                LabelControl1.Text = "To date:"
                LabelControl5.Text = "Objects:"
                Me.gpcArea.Text = "Please select date to view reports!"
                Me.cheShifts.Text = "By shifts :"
            End If
            Select Case gvStr_ReportType
                Case "NhapKhoNCC"
                    Me.lkpObject.Properties.Columns.Clear()
                    Me.lkpObject.Enabled = True
                    mvObj_DataTable = mvCls_CustomerSupplierUpdate.FuncG_GetAll(3)
                    Me.lkpObject.Properties.DataSource = mvObj_DataTable
                    Me.lkpObject.Properties.DisplayMember = "Tên"
                    Me.lkpObject.Properties.ValueMember = "Mã"
                    Me.lkpObject.ItemIndex = 0
                Case "CongNoNCC"
                    Me.lkpObject.Properties.Columns.Clear()
                    Me.lkpObject.Enabled = True
                    mvObj_DataTable = mvCls_CustomerSupplierUpdate.FuncG_GetAll(3)
                    Dim dr As DataRow = mvObj_DataTable.NewRow()
                    dr("Mã") = "00"
                    dr("Tên") = "Tất cả"

                    Me.lkpObject.Properties.DataSource = mvObj_DataTable
                    Me.lkpObject.Properties.DisplayMember = "Tên"
                    Me.lkpObject.Properties.ValueMember = "Mã"
                    mvObj_DataTable.Rows.Add(dr)
                    Me.lkpObject.ItemIndex = 0
                Case "TonKhoCT"
                    Me.lkpObject.Properties.Columns.Clear()
                    Me.lkpObject.Enabled = True
                    mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetAllMaterial
                    Me.lkpObject.Properties.DataSource = mvObj_DataTable
                    Me.lkpObject.Properties.DisplayMember = "Tên hàng"
                    Me.lkpObject.Properties.ValueMember = "Mã hàng"
                    Me.lkpObject.ItemIndex = 0
                Case "XuatKho", "NhapKho"
                    'RESET value
                    Me.lkpObject.EditValue = Nothing
                    Me.lkpObject.Properties.Columns.Clear()

                    Me.lkpObject.Enabled = True
                    mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetAllMaterial
                    Me.lkpObject.Properties.DataSource = mvObj_DataTable
                    Me.lkpObject.Properties.DisplayMember = "Tên hàng"
                    Me.lkpObject.Properties.ValueMember = "Mã hàng"
                    'Me.lkpObject.ItemIndex = 0
                Case "DinhLuong"
                    Me.lkpObject.EditValue = Nothing
                    Me.lkpObject.Properties.Columns.Clear()

                    Me.DateEdit1.Enabled = True
                    Me.DateEdit2.Enabled = True

                    mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetPromatItem()
                    Me.lkpObject.Properties.DataSource = mvObj_DataTable
                    Me.lkpObject.Properties.DisplayMember = "Tên hàng"
                    Me.lkpObject.Properties.ValueMember = "Mã hàng"
                Case "XoaDL"
                    Me.DateEdit2.Enabled = True
                Case Else
                    Me.DateEdit2.Enabled = True
                    Me.lkpObject.Enabled = False
            End Select
            cbxByShifts.Properties.ShowHeader = False
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form events"
    Private Sub frm_DiscountServiceVat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()

        If gvStr_ReportType = "LaiLo" Then
            chkChitiet.Visible = True
        End If
    End Sub
#End Region
#Region "CheckChange"
    Private Sub cheShifts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cheShifts.CheckedChanged
        Try
            Me.cbxByShifts.Enabled = Me.cheShifts.Checked
        Catch ex As Exception

        End Try
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
            'mvFrm_LoadReport.ShowDialog()
            mvFrm_LoadReport.gTuNgay = mvDate_FromDate
            mvFrm_LoadReport.gDenNgay = mvDate_ToDate
            mvFrm_LoadReport.gCashierID = Me.cbxByShifts.EditValue
            mvFrm_LoadReport.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

#End Region
#Region "Load Cashier"
    Private Sub SubM_LoadCashier()
        Dim mvObj_DataTable As New DataTable
        Dim mvCls_AccountUpdate As New cls_Account_Update
        Try
            mvObj_DataTable = mvCls_AccountUpdate.FuncG_GetCashierData()
            Me.cbxByShifts.Properties.DataSource = mvObj_DataTable
            Me.cbxByShifts.Properties.DisplayMember = "Tên Nhân Viên"
            Me.cbxByShifts.Properties.ValueMember = "Mã Nhân Viên"
            If mvObj_DataTable.Rows.Count > 0 Then
                cbxByShifts.ItemIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Confirm"
    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        Try
            Dim mvCls_IncomeUpdate As New cls_Income_Update
            If Me.gvStr_ReportType = "TaiChinh" Then
                ''====================================

                If chkChitiet.Checked = True Then
                    Dim mvRpt_Report As New rpt_FinanceReport
                    'Dim mvRpt_Report As New rpt_ReportFinance
                    'Thêm tham số nếu cần thiết
                    mvRpt_Report.SetParameterValue("@fromday", DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date))
                    mvRpt_Report.SetParameterValue("@today", DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date))
                    mvRpt_Report.SetParameterValue("@LOC_ID", gvStr_LocID)
                    mvRpt_Report.SetParameterValue("@ReportTime", gvByte_ReportTime)

                    If Me.cheShifts.Checked Then
                        mvRpt_Report.SetParameterValue("Ca", Me.cbxByShifts.EditValue)
                    Else
                        mvRpt_Report.SetParameterValue("Ca", "")
                    End If

                    SubM_CreateReportForm(mvRpt_Report)
                Else
                    Dim mvRpt_Report As New rpt_ReportFinance_Bill80_CU
                    Dim mvCls_SalesDetail_Update As New cls_SalesDetail_Update

                    Dim mvDate_FromDate As DateTime
                    Dim mvDate_ToDate As DateTime
                    mvDate_FromDate = DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date)
                    mvDate_ToDate = DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date)

                    'Dim obj_thuchitotal As New DataTable
                    'obj_thuchitotal = mvCls_IncomeUpdate.FuncG_GetThuChi(mvDate_FromDate, mvDate_ToDate)

                    'If obj_thuchitotal.Rows.Count > 0 Then
                    '    Try
                    '        mvRpt_Report.SetParameterValue("PhieuThu", obj_thuchitotal.Rows(0)("totalThu"))
                    '    Catch ex As Exception
                    '        mvRpt_Report.SetParameterValue("PhieuThu", 0)
                    '    End Try
                    '    Try
                    '        mvRpt_Report.SetParameterValue("PhieuChi", obj_thuchitotal.Rows(0)("totalChi"))
                    '    Catch ex As Exception
                    '        mvRpt_Report.SetParameterValue("PhieuChi", 0)
                    '    End Try
                    'Else
                    '    mvRpt_Report.SetParameterValue("PhieuThu", 0)
                    '    mvRpt_Report.SetParameterValue("PhieuChi", 0)
                    'End If
                    'mvRpt_Report.SetParameterValue("Tiepkhach", mvCls_IncomeUpdate.FuncG_GetTiepKhach(mvDate_FromDate, mvDate_ToDate))
                    '======================
                    Dim dtTaichinh As DataTable
                    dtTaichinh = mvCls_IncomeUpdate.FuncG_GetTTaiChinh(mvDate_FromDate, mvDate_ToDate)
                    Dim USD, MASTER, VISA, TIEPKHACH, DOANHTHU, VND, BANHANG, TONGTHU, TONGCHI As Double
                    Try
                        USD = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='USD'")
                    Catch ex As Exception
                        USD = 0
                    End Try
                    Try
                        VISA = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='VISA'")
                    Catch ex As Exception
                        VISA = 0
                    End Try
                    Try
                        MASTER = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='MASTER'")
                    Catch ex As Exception
                        MASTER = 0
                    End Try
                    Try
                        TIEPKHACH = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='TIEPKHACH'")
                    Catch ex As Exception
                        TIEPKHACH = 0
                    End Try
                    Try
                        DOANHTHU = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='DOANHTHU'")
                    Catch ex As Exception
                        DOANHTHU = 0
                    End Try
                    Try
                        VND = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='VND'")
                    Catch ex As Exception
                        VND = 0
                    End Try
                    Try
                        BANHANG = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='BANHANG'")
                    Catch ex As Exception
                        BANHANG = 0
                    End Try
                    Try
                        TONGTHU = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='TONGTHU'")
                    Catch ex As Exception
                        TONGTHU = 0
                    End Try
                    Try
                        TONGCHI = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='TONGCHI'")
                    Catch ex As Exception
                        TONGCHI = 0
                    End Try
                    mvRpt_Report.SetParameterValue("Tiepkhach", TIEPKHACH)
                    mvRpt_Report.SetParameterValue("USD", USD)
                    mvRpt_Report.SetParameterValue("VISA", VISA)
                    mvRpt_Report.SetParameterValue("MASTER", MASTER)
                    mvRpt_Report.SetParameterValue("DOANHTHU", DOANHTHU)
                    mvRpt_Report.SetParameterValue("VND", VND)
                    mvRpt_Report.SetParameterValue("BANHANG", BANHANG)
                    mvRpt_Report.SetParameterValue("PhieuThu", TONGTHU)
                    mvRpt_Report.SetParameterValue("PhieuChi", TONGCHI)
                    '======================
                    'Dim mvRpt_Report As New rpt_ReportFinance
                    'Thêm tham số nếu cần thiết
                    If Me.cheShifts.Checked Then
                        mvRpt_Report.SetParameterValue("Ca", Me.cbxByShifts.EditValue)
                    Else
                        mvRpt_Report.SetParameterValue("Ca", "")
                    End If
                    SubM_CreateReportForm(mvRpt_Report)
                End If


                ''===========================================
            ElseIf Me.gvStr_ReportType = "LaiLo" Then
                If (chkChitiet.Checked) Then
                    ' xem chi tiet
                    Dim mvRpt_Report As New rpt_ReportNewProfit
                    ' Thêm tham số nếu cần thiết
                    Dim dt As New DataTable
                    Dim mvCls_ReportUpdate As New cls_Report_Update

                    dt = mvCls_ReportUpdate.FuncG_GetProfitData(DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date), DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date))

                    mvRpt_Report.SetDataSource(dt)
                    'mvRpt_Report.SetParameterValue("TuNgay", DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date))
                    'mvRpt_Report.SetParameterValue("DenNgay", DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date))
                    'mvRpt_Report.SetParameterValue("LocID", gvStr_LocID)

                    SubM_CreateReportForm(mvRpt_Report)
                Else
                    ' xem tong
                    Dim mvRpt_Report As New rpt_ReportLaiLo
                    Dim mvCls_SalesDetail_Update As New cls_SalesDetail_Update
                    Dim mv_StockUpdate As New cls_Stock_Update
                    Dim mvDate_FromDate As DateTime
                    Dim mvDate_ToDate As DateTime
                    mvDate_FromDate = DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date)
                    mvDate_ToDate = DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date)

                    Dim obj_thuchitotal As New DataTable
                    obj_thuchitotal = mvCls_IncomeUpdate.FuncG_GetThuChi(mvDate_FromDate, mvDate_ToDate)

                    If obj_thuchitotal.Rows.Count > 0 Then
                        Try
                            mvRpt_Report.SetParameterValue("PhieuThu", obj_thuchitotal.Rows(0)("totalThu"))
                        Catch ex As Exception
                            mvRpt_Report.SetParameterValue("PhieuThu", 0)
                        End Try
                        Try
                            mvRpt_Report.SetParameterValue("PhieuChi", obj_thuchitotal.Rows(0)("totalChi"))
                        Catch ex As Exception
                            mvRpt_Report.SetParameterValue("PhieuChi", 0)
                        End Try
                    Else
                        mvRpt_Report.SetParameterValue("PhieuThu", 0)
                        mvRpt_Report.SetParameterValue("PhieuChi", 0)
                    End If

                    Dim dtTaichinh As DataTable
                    dtTaichinh = mvCls_IncomeUpdate.FuncG_GetTTaiChinh(mvDate_FromDate, mvDate_ToDate)
                    Dim USD, MASTER, VISA, TIEPKHACH, DOANHTHU, VND, BANHANG, GIAVON As Double
                    Try
                        USD = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='USD'")
                    Catch ex As Exception
                        USD = 0
                    End Try
                    Try
                        VISA = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='VISA'")
                    Catch ex As Exception
                        VISA = 0
                    End Try
                    Try
                        MASTER = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='MASTER'")
                    Catch ex As Exception
                        MASTER = 0
                    End Try
                    Try
                        TIEPKHACH = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='TIEPKHACH'")
                    Catch ex As Exception
                        TIEPKHACH = 0
                    End Try
                    Try
                        DOANHTHU = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='DOANHTHU'")
                    Catch ex As Exception
                        DOANHTHU = 0
                    End Try
                    Try
                        VND = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='VND'")
                    Catch ex As Exception
                        VND = 0
                    End Try
                    Try
                        BANHANG = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='BANHANG'")
                    Catch ex As Exception
                        BANHANG = 0
                    End Try

                    Dim dt As New DataTable
                    Dim mvCls_ReportUpdate As New cls_Report_Update

                    dt = mvCls_ReportUpdate.FuncG_GetProfitData(DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date), DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date))
                    Try
                        GIAVON = dt.Compute("SUM(TotalCost)", "")
                    Catch ex As Exception
                        GIAVON = 0
                    End Try
                    GIAVON += mv_StockUpdate.FuncG_GetGiaVon(mvDate_FromDate, mvDate_ToDate)
                    mvRpt_Report.SetParameterValue("GiaVon", GIAVON)
                    mvRpt_Report.SetParameterValue("Tiepkhach", TIEPKHACH)
                    mvRpt_Report.SetParameterValue("USD", USD)
                    mvRpt_Report.SetParameterValue("VISA", VISA)
                    mvRpt_Report.SetParameterValue("MASTER", MASTER)
                    mvRpt_Report.SetParameterValue("DOANHTHU", DOANHTHU)
                    mvRpt_Report.SetParameterValue("VND", VND)
                    mvRpt_Report.SetParameterValue("BANHANG", BANHANG)

                    'Thêm tham số nếu cần thiết
                    If Me.cheShifts.Checked Then
                        mvRpt_Report.SetParameterValue("Ca", Me.cbxByShifts.EditValue)
                    Else
                        mvRpt_Report.SetParameterValue("Ca", "")
                    End If

                    SubM_CreateReportForm(mvRpt_Report)
                End If
            ElseIf Me.gvStr_ReportType = "CTHoaDon" Then
                'Dim mvRpt_Report As New rpt_ReportBillDetail_Cus
                Dim mvRpt_Report As New rpt_ReportBillDetail_Moi
                If Me.cheShifts.Checked Then
                    mvRpt_Report.SetParameterValue("Ca", Me.cbxByShifts.EditValue)
                Else
                    mvRpt_Report.SetParameterValue("Ca", "")
                End If
                'THEM VOUCHER VAO CHI TIET HOA DON
                Dim mvDate_FromDate As DateTime
                Dim mvDate_ToDate As DateTime
                mvDate_FromDate = DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date)
                mvDate_ToDate = DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date)
                Dim dtTaichinh As DataTable
                dtTaichinh = mvCls_IncomeUpdate.FuncG_GetTTaiChinh(mvDate_FromDate, mvDate_ToDate)
                Dim USD, MASTER, VISA, VOUCHER, DEBT, TIEPKHACH, DOANHTHU, VND, BANHANG, TONGTHU, TONGCHI As Double
                Try
                    USD = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='USD'")
                Catch ex As Exception
                    USD = 0
                End Try
                Try
                    VISA = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='VISA'")
                Catch ex As Exception
                    VISA = 0
                End Try
                Try
                    MASTER = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='MASTER'")
                Catch ex As Exception
                    MASTER = 0
                End Try
                Try
                    TIEPKHACH = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='TIEPKHACH'")
                Catch ex As Exception
                    TIEPKHACH = 0
                End Try
                Try
                    DOANHTHU = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='DOANHTHU'")
                Catch ex As Exception
                    DOANHTHU = 0
                End Try
                Try
                    VND = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='VND'")
                Catch ex As Exception
                    VND = 0
                End Try
                Try
                    BANHANG = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='BANHANG'")
                Catch ex As Exception
                    BANHANG = 0
                End Try
                Try
                    TONGTHU = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='TONGTHU'")
                Catch ex As Exception
                    TONGTHU = 0
                End Try
                Try
                    TONGCHI = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='TONGCHI'")
                Catch ex As Exception
                    TONGCHI = 0
                End Try
                Try
                    VOUCHER = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='VOUCHER'")
                Catch ex As Exception
                    VOUCHER = 0
                End Try
                Try
                    DEBT = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='DEBT'")
                Catch ex As Exception
                    DEBT = 0
                End Try
                mvRpt_Report.SetParameterValue("TIEPKHACH", TIEPKHACH)
                mvRpt_Report.SetParameterValue("DOANHTHU", DOANHTHU)
                mvRpt_Report.SetParameterValue("VOUCHER", VOUCHER)
                mvRpt_Report.SetParameterValue("DEBT", DEBT)
                mvRpt_Report.SetParameterValue("CHI", TONGCHI)
                mvRpt_Report.SetParameterValue("THU", TONGTHU)
                'mvRpt_Report.SetParameterValue("USD", USD)
                'mvRpt_Report.SetParameterValue("VISA", VISA)
                'mvRpt_Report.SetParameterValue("MASTER", MASTER)


                SubM_CreateReportForm(mvRpt_Report)
            ElseIf Me.gvStr_ReportType = "HoaDon" Then

                If chkChitiet.Checked = True Then
                    Dim mvRpt_Report As New rpt_ReportBillsTK

                    Dim mvDate_FromDate As DateTime
                    Dim mvDate_ToDate As DateTime
                    If Me.cheShifts.Checked Then
                        mvRpt_Report.SetParameterValue("Ca", Me.cbxByShifts.EditValue)
                    Else
                        mvRpt_Report.SetParameterValue("Ca", "")
                    End If
                    mvDate_FromDate = DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date)
                    mvDate_ToDate = DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date)
                    Me.SubM_CreateReportForm(mvRpt_Report)
                Else
                    Dim mvRpt_Report As New rpt_ReportBills

                    Dim mvDate_FromDate As DateTime
                    Dim mvDate_ToDate As DateTime
                    If Me.cheShifts.Checked Then
                        mvRpt_Report.SetParameterValue("Ca", Me.cbxByShifts.EditValue)
                    Else
                        mvRpt_Report.SetParameterValue("Ca", "")
                    End If
                    mvDate_FromDate = DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date)
                    mvDate_ToDate = DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date)
                    Dim dtTaichinh As DataTable
                    dtTaichinh = mvCls_IncomeUpdate.FuncG_GetTTaiChinh(mvDate_FromDate, mvDate_ToDate)
                    Dim USD, MASTER, VISA, VOUCHER, DEBT, TIEPKHACH, DOANHTHU, VND, BANHANG, TONGTHU, TONGCHI As Double
                    Try
                        USD = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='USD'")
                    Catch ex As Exception
                        USD = 0
                    End Try
                    Try
                        VISA = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='VISA'")
                    Catch ex As Exception
                        VISA = 0
                    End Try
                    Try
                        MASTER = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='MASTER'")
                    Catch ex As Exception
                        MASTER = 0
                    End Try
                    Try
                        TIEPKHACH = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='TIEPKHACH'")
                    Catch ex As Exception
                        TIEPKHACH = 0
                    End Try
                    Try
                        DOANHTHU = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='DOANHTHU'")
                    Catch ex As Exception
                        DOANHTHU = 0
                    End Try
                    Try
                        VND = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='VND'")
                    Catch ex As Exception
                        VND = 0
                    End Try
                    Try
                        BANHANG = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='BANHANG'")
                    Catch ex As Exception
                        BANHANG = 0
                    End Try
                    Try
                        TONGTHU = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='TONGTHU'")
                    Catch ex As Exception
                        TONGTHU = 0
                    End Try
                    Try
                        TONGCHI = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='TONGCHI'")
                    Catch ex As Exception
                        TONGCHI = 0
                    End Try
                    Try
                        VOUCHER = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='VOUCHER'")
                    Catch ex As Exception
                        VOUCHER = 0
                    End Try
                    Try
                        DEBT = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='DEBT'")
                    Catch ex As Exception
                        DEBT = 0
                    End Try
                    mvRpt_Report.SetParameterValue("TIEPKHACH", TIEPKHACH)
                    mvRpt_Report.SetParameterValue("DOANHTHU", DOANHTHU)
                    mvRpt_Report.SetParameterValue("VOUCHER", VOUCHER)
                    mvRpt_Report.SetParameterValue("DEBT", DEBT)
                    mvRpt_Report.SetParameterValue("CHI", TONGCHI)
                    mvRpt_Report.SetParameterValue("THU", TONGTHU)
                    mvRpt_Report.SetParameterValue("MASTER", MASTER)
                    mvRpt_Report.SetParameterValue("VISA", VISA)
                    mvRpt_Report.SetParameterValue("USD", USD)
                    Me.SubM_CreateReportForm(mvRpt_Report)
                End If

                'Dim mvCls_IncomeUpdate As New cls_Income_Update
                'Dim mvRpt_Report As New rpt_ReportBills
                'If Me.cheShifts.Checked Then
                '    mvRpt_Report.SetParameterValue("Ca", Me.cbxByShifts.EditValue)
                '    mvRpt_Report.SetParameterValue("TenCa", Me.cbxByShifts.Text)
                'Else
                '    mvRpt_Report.SetParameterValue("Ca", "")
                '    mvRpt_Report.SetParameterValue("TenCa", "")
                'End If
                'mvRpt_Report.SetParameterValue("Tongtien", mvCls_IncomeUpdate.FuncG_GetTongCong(DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date), DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date)))
                'SubM_CreateReportForm(mvRpt_Report)
            ElseIf Me.gvStr_ReportType = "BCHUYBAN" Then
                Dim mvRpt_Report As New rpt_ReportBillsHuy

                Dim mvDate_FromDate As DateTime
                Dim mvDate_ToDate As DateTime
                If Me.cheShifts.Checked Then
                    mvRpt_Report.SetParameterValue("Ca", Me.cbxByShifts.EditValue)
                Else
                    mvRpt_Report.SetParameterValue("Ca", "")
                End If
                mvDate_FromDate = DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date)
                mvDate_ToDate = DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date)
                Dim dtTaichinh As DataTable
                dtTaichinh = mvCls_IncomeUpdate.FuncG_GetTTaiChinh(mvDate_FromDate, mvDate_ToDate)
                Dim VOUCHER As Double
                Try
                    VOUCHER = dtTaichinh.Compute("sum(QUANTITY)", "SCOPE_NAME='VOUCHER'")
                Catch ex As Exception
                    VOUCHER = 0
                End Try
                mvRpt_Report.SetParameterValue("VOUCHER", VOUCHER)
                Me.SubM_CreateReportForm(mvRpt_Report)

                'end fix
            ElseIf Me.gvStr_ReportType = "ThuChi" Then
                Dim mvRpt_Report As New rpt_ReportReceiptPayment
                SubM_CreateReportForm(mvRpt_Report)
            ElseIf Me.gvStr_ReportType = "TraHang" Then
                Dim mvRpt_Report As New rpt_ReportReturn
                SubM_CreateReportForm(mvRpt_Report)
            ElseIf Me.gvStr_ReportType = "CongNoKH" Then
                Dim mvRpt_Report As New rpt_ReportDepts
                mvRpt_Report.SetParameterValue("Type", 0)
                SubM_CreateReportForm(mvRpt_Report)
            ElseIf Me.gvStr_ReportType = "CongNoNCC" Then
                Dim mvRpt_Report As New rpt_ReportDeptsNCC
                If Me.lkpObject.EditValue Is Nothing Then
                    mvRpt_Report.SetParameterValue("NCC", "")
                Else
                    mvRpt_Report.SetParameterValue("NCC", Me.lkpObject.EditValue)
                End If
                mvRpt_Report.SetParameterValue("Type", 1)
                SubM_CreateReportForm(mvRpt_Report)
            ElseIf Me.gvStr_ReportType = "NhapKho" Then
                Dim mvRpt_Report As New rpt_ReportTotalImport
                'If Me.lkpObject.EditValue Is Nothing Then
                '    mvRpt_Report.SetParameterValue("Mahang", "")
                'Else
                '    mvRpt_Report.SetParameterValue("Mahang", Me.lkpObject.EditValue)
                'End If
                mvRpt_Report.SetParameterValue("LoaiPhieu", "PN")
                SubM_CreateReportForm(mvRpt_Report)
            ElseIf Me.gvStr_ReportType = "XuatKho" Then
                Dim mvRpt_Report As New rpt_ReportTotalImport
                'If Me.lkpObject.EditValue Is Nothing Then
                '    mvRpt_Report.SetParameterValue("Mahang", "")
                'Else
                '    mvRpt_Report.SetParameterValue("Mahang", Me.lkpObject.EditValue)
                'End If
                mvRpt_Report.SetParameterValue("LoaiPhieu", "PX")
                SubM_CreateReportForm(mvRpt_Report)
            ElseIf Me.gvStr_ReportType = "NhapKhoNCC" Then
                If Me.lkpObject.EditValue Is Nothing Then
                    SubG_Alert(56) ' FunG_Alert("Lỗi", "Chưa chọn nhà cung cấp!", frm_Alert.WTYPE.ERROR)
                Else
                    Dim mvRpt_Report As New rpt_ReportImportExportByObject
                    mvRpt_Report.SetParameterValue("LoaiPhieu", "PN")
                    mvRpt_Report.SetParameterValue("Supplier", Me.lkpObject.EditValue)
                    SubM_CreateReportForm(mvRpt_Report)
                End If
            ElseIf Me.gvStr_ReportType = "TonKhoTongHop" Then
                Dim mvRpt_Report As New rpt_ReportTotal
                mvCls_ReportUpdate.FuncG_Total(DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime), DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime))
                SubM_CreateReportForm(mvRpt_Report)
            ElseIf Me.gvStr_ReportType = "TonKhoCT" Then
                If Me.lkpObject.EditValue Is Nothing Then
                    SubG_Alert(57) 'FunG_Alert("Lỗi", "Chưa chọn mặt hàng cần xem!", frm_Alert.WTYPE.ERROR)
                Else
                    Dim mvRpt_Report As New rpt_ReportDetail
                    mvCls_ReportUpdate.FuncG_Detail(DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime), DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime), Me.lkpObject.EditValue)
                    SubM_CreateReportForm(mvRpt_Report)
                    '
                End If
            ElseIf gvStr_ReportType = "DOANHTHUKH" Then
                Dim mvRpt_Report As New rpt_ReportDoanhthuKHByTime
                mvRpt_Report.SetParameterValue("Type", 1)
                SubM_CreateReportForm(mvRpt_Report)
            ElseIf Me.gvStr_ReportType = "DinhLuong" Then
                Dim mvRpt_Report As New rpt_Promat
                If Me.lkpObject.EditValue Is Nothing Then
                    mvRpt_Report.SetParameterValue("Mahang", "")
                Else
                    mvRpt_Report.SetParameterValue("Mahang", Me.lkpObject.EditValue)
                End If
                mvRpt_Report.SetParameterValue("LocID", gvStr_LocID)
                SubM_CreateReportForm(mvRpt_Report)
            ElseIf Me.gvStr_ReportType = "NguyenLieu" Then
                Dim mvRpt_Report As New rpt_ReportMaterial
                'Thêm tham số nếu cần thiết

                Dim dt As New DataTable
                Dim mvCls_ReportUpdate As New cls_Report_Update

                dt = mvCls_ReportUpdate.FuncG_GetMaterial(DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date), DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date))

                mvRpt_Report.SetDataSource(dt)
                'mvRpt_Report.SetParameterValue("TuNgay", DateAdd(DateInterval.Hour, gvByte_ReportTime, Me.DateEdit1.DateTime.Date))
                'mvRpt_Report.SetParameterValue("DenNgay", DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date))
                mvRpt_Report.SetParameterValue("Language", 1)
                'mvRpt_Report.SetParameterValue("@LOC_ID", gvStr_LocID)
                SubM_CreateReportForm(mvRpt_Report)
            ElseIf Me.gvStr_ReportType = "BCXUATMONMO" Then
                Dim mvRpt_Report As New rpt_ReportPromatOpenItem
                SubM_CreateReportForm(mvRpt_Report)
            ElseIf Me.gvStr_ReportType = "HISTORYBALANCE" Then
                Dim mvRpt_Report As New rpt_ReportHistoryBalance
                SubM_CreateReportForm(mvRpt_Report)
            ElseIf Me.gvStr_ReportType = "XoaDL" Then
                
                If FunG_Alert("Confirm", "Are you sure to delete database?", frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                    Dim mvDate_FromDate As DateTime
                    Dim mvDate_ToDate As DateTime
                    mvDate_FromDate = DateAdd(DateInterval.Hour, 0, Me.DateEdit1.DateTime.Date)
                    mvDate_ToDate = DateAdd(DateInterval.Hour, 24 + 0, Me.DateEdit2.DateTime.Date)
                    ' mvCls_UpdateAccount.FuncG_Delete(DateAdd(DateInterval.Hour, gvByte_AddedHour + gvByte_ReportTime, Me.DateEdit2.DateTime.Date))
                    mvCls_UpdateAccount.FuncG_Delete(mvDate_FromDate, mvDate_ToDate)
                    FunG_Alert("Info", "Delete database succeed!", frm_Alert.WTYPE.CHECK)
                    Me.Close()
                End If
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

    Private Sub chkChitiet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChitiet.CheckedChanged
        If Me.gvStr_ReportType = "TaiChinh" Then
            If chkChitiet.Checked = True Then
                Me.cheShifts.Visible = True
                Me.cbxByShifts.Visible = True
                Me.cheShifts.Enabled = True
                Me.cbxByShifts.Enabled = True
            Else

                Me.cheShifts.Visible = False
                Me.cbxByShifts.Visible = False
                Me.cheShifts.Enabled = False
            End If
        End If

    End Sub
End Class