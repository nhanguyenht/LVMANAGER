Public Class frm_TableM
#Region "Khai Báo Biến"
    Public mvStr_ID As String
    Dim mvCls_Item As New cls_Item
    Dim mvCls_ItemUpdate As New cls_Item_Update
    Dim mvCls_GroupItemUpdate As New cls_GroupItem_Update
    Dim mvCmd_SimpleButton As New DevExpress.XtraEditors.SimpleButton
    Dim mvCls_Table_Update As New cls_Table_Update
    Dim mvCls_Sales_Update As New cls_Sales_Update
    Dim mvcls_SalesDetail_Update As New cls_SalesDetail_Update
    Dim mvCls_Customer_Employee_Update As New cls_Customer_Update
    Dim mvUrc_Table As New urc_Table
#End Region
#Region "Hàm Khởi Tạo"
    Public Sub SubM_InitializeForm()
        mod_Format.Sub_ShowControl(mvUrc_Table, 3)
        SubM_LoadMenu()
        If gvByte_Language = 1 Then
            Me.Text = "Sơ đồ bàn"
            bbiEdit.Caption = "Chỉnh sửa"
            btnseedetail.Caption = "Chi tiết"
        Else
            btnseedetail.Caption = "Details"
            bbiEdit.Caption = "Edit"
            Me.Text = "Table Map"
        End If
        Timer1.Start()
    End Sub
#End Region
#Region "Load Menu"
    Private Sub SubM_LoadMenu()
        Dim mvObj_GroupItemData As New DataTable
        Dim mvObj_TableData As New DataTable
        Try
            'Load menu
           
        Catch ex As Exception

        End Try
    End Sub
    Private Shared Function FunM_GetControlByName(ByVal pobjParent As Control, ByVal pstrCtlName As String) As Control
        Dim objCtl As Control
        For Each objCtl In pobjParent.Controls
            If objCtl.Name = pstrCtlName Then
                Return (objCtl)
            End If
        Next
        ' if control is not found
        Return Nothing
    End Function
#End Region
#Region "Hàm load món ăn"
    Private Sub SubM_LoadTable(ByVal iObj_DataTable As DataTable)
        Try
            
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events"
    Private Sub Frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SubM_InitializeForm()
    End Sub
#End Region
#Region "Chọn menu"
    Private Sub cmdKhuVuc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim mvObj_AreaData As New DataTable
        Dim mvObj_DataTable As New DataTable
        Try
            'Load menu


        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Chọn món"
    Private Sub cmdBan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim mvObj_DataTable As New DataTable
        Try
            mvCmd_SimpleButton = DirectCast(sender, DevExpress.XtraEditors.SimpleButton)
            mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetDataInfo(mvCmd_SimpleButton.Tag)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Chọn món"
    
#End Region
#Region "Nút edit"
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEdit.ItemClick
        If mvStr_ID <> "" Then
            Dim dt As New DataTable
            dt = mvCls_Table_Update.FuncG_GetDataInfo(mvStr_ID)
            If dt.Rows.Count > 0 Then
                frm_EditTable.txtID.Text = dt.Rows(0)("id").ToString
                frm_EditTable.txtName.Text = dt.Rows(0)("name").ToString
                If dt.Rows(0)("Status").ToString = 0 Then
                    frm_EditTable.rgpLanguage.SelectedIndex = dt.Rows(0)("Status").ToString
                    frm_EditTable.rgpLanguage.Enabled = True
                Else
                    frm_EditTable.rgpLanguage.SelectedIndex = dt.Rows(0)("Status").ToString
                    frm_EditTable.rgpLanguage.Enabled = False
                End If

                frm_EditTable.ShowDialog()
            
            End If



        End If
    End Sub
#End Region

    Private Sub frm_TableMap_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_SetMenu.SubM_LoadData()
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        mvUrc_Table.SubM_LoadMenu()


        'Add 2015/12/01 

    End Sub

    Private Sub btnseedetail_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnseedetail.ItemClick
        If mvStr_ID <> "" Then
            Dim DT As New DataTable
            DT = mvCls_Sales_Update.FuncG_GetDataByTableID(mvStr_ID)
            If DT.Rows.Count > 0 Then
                Dim DTCE As New DataTable
                Dim DTSD As New DataTable
                Dim khname As String

                DTCE = mvCls_Customer_Employee_Update.FuncG_GetNCCSalesByID2(DT.Rows(0)("CUSTOMER_ID").ToString)
                If DTCE.Rows.Count > 0 Then
                    khname = DTCE.Rows(0)("NAME").ToString
                End If


                frm_sales_detail.txtidinvo.Text = DT.Rows(0)("id").ToString
                frm_sales_detail.txtkh.Text = khname
                'frm_sales_detail.txtidinvo.Text = DT.Rows(0)("id").ToString
                '==============================================================
                Dim total, discount, service, voucher, vat1, vat2, finacost As Double
                DTSD = mvcls_SalesDetail_Update.FuncG_GetTotal(DT.Rows(0)("id").ToString)
                total = Double.Parse(DTSD.Rows(0)("TOTAL"))
                discount = Double.Parse(DTSD.Rows(0)("DISCOUNT"))
                'service = Double.Parse(DTSD.Rows(0)("SERVICE"))
                'voucher = Double.Parse(DTSD.Rows(0)("VOUCHER"))
                vat1 = Double.Parse(DTSD.Rows(0)("VAT"))
                vat2 = (total - discount + service) * vat1 / total
                finacost = (total - discount) + vat2
                If total > 0 Then
                    frm_sales_detail.lblTotal.Text = total.ToString("N0")
                Else
                    frm_sales_detail.lblTotal.Text = "0"
                End If

                If discount > 0 Then
                    frm_sales_detail.lblDiscount.Text = discount.ToString("N0")
                Else
                    frm_sales_detail.lblDiscount.Text = "0"
                End If

                'If service > 0 Then
                '    Me.lblService.Text = service.ToString("N0")
                'Else
                '    Me.lblService.Text = "0"
                'End If

                If vat2 > 0 Then
                    frm_sales_detail.lblVAT.Text = vat2.ToString("N0")
                Else
                    frm_sales_detail.lblVAT.Text = "0"
                End If

                If finacost > 0 Then
                    frm_sales_detail.lblFinalCost.Text = finacost.ToString("N0")
                Else
                    frm_sales_detail.lblFinalCost.Text = "0"
                End If

                'If voucher > 0 Then
                '    Me.lblVipDiscount.Text = voucher.ToString("N0")
                'Else
                '    Me.lblVipDiscount.Text = "0"
                'End If
                '==============================================================
                DTSD = mvcls_SalesDetail_Update.FuncG_GetData(DT.Rows(0)("id").ToString)
                frm_sales_detail.GridControl1.DataSource = DTSD
                frm_sales_detail.GridView1.PopulateColumns(DTSD)
                
                frm_sales_detail.GridView1.Columns("Tên hàng").Width = 133
                frm_sales_detail.GridView1.Columns("S.L").Width = 40
                frm_sales_detail.GridView1.Columns("Giá").Width = 60
                frm_sales_detail.GridView1.Columns("Giá").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                frm_sales_detail.GridView1.Columns("Giá").DisplayFormat.FormatString = "#,##"
                If gvByte_Language = 1 Then
                    frm_sales_detail.GridView1.Columns("Tên hàng").Caption = "Tên hàng"
                    frm_sales_detail.GridView1.Columns("S.L").Caption = "S.L"
                    frm_sales_detail.GridView1.Columns("Giá").Caption = "Giá"
                Else
                    frm_sales_detail.GridView1.Columns("Tên hàng").Caption = "Item Name"
                    frm_sales_detail.GridView1.Columns("S.L").Caption = "Qty"
                    frm_sales_detail.GridView1.Columns("Giá").Caption = "Price"
                End If
                frm_sales_detail.GridView1.Columns("ITEM_ID").Visible = False
                frm_sales_detail.GridView1.Columns("DISCOUNT").Visible = False
                frm_sales_detail.GridView1.Columns("VAT").Visible = False
                frm_sales_detail.GridView1.Columns("SERVICE").Visible = False
                frm_sales_detail.GridView1.Columns("VAT").Visible = False
                'Me.GridView1.Columns("FINALTOTAL").Visible = 
                frm_sales_detail.GridView1.Columns("FINALTOTAL").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                frm_sales_detail.GridView1.Columns("FINALTOTAL").DisplayFormat.FormatString = "#,##"

                frm_sales_detail.GridView1.Columns("CHARGE_ID").Visible = False
                frm_sales_detail.GridView1.Columns("CREATEDATE").Visible = False
                frm_sales_detail.GridView1.Columns("ACTIVE").Visible = False
                '==============================================================
                frm_sales_detail.StartPosition = FormStartPosition.CenterScreen
                frm_sales_detail.ShowDialog()
                '==============================================================
            End If
        End If
    End Sub
End Class