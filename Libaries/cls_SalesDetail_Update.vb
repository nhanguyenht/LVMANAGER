Public Class cls_SalesDetail_Update
    Inherits cls_Database_Base
#Region "Get Data"
    Public Function FuncG_GetData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM [TBL_SALES_DETAIL]"
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function

    Public Function FuncG_GetTotalData_Order(ByVal FromDate As DateTime, ByVal Todate As DateTime) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                'mvStr_Sql = "select SUM(FINALTOTAL) AS TONG from TBL_SALES_DETAIL WHERE  ID IN (select ID from TBL_SALES WHERE STATUS=2)"
                mvStr_Sql = "select SUM(FINALTOTAL) AS TONG from TBL_SALES_DETAIL WHERE  ID IN (select ID from TBL_SALES WHERE STATUS=2  AND  CREATEDATE between (@FromDate) and (@Todate))"
                SubM_AddParameter("@FromDate", FromDate)
                SubM_AddParameter("@Todate", Todate)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetData(ByVal iStr_ID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TBL_SALES_DETAIL.ITEM_ID, TBL_ITEM.NAME AS [Tên hàng], TBL_SALES_DETAIL.QUANTITY AS [S.L], TBL_SALES_DETAIL.PRICE AS [Giá],"
                mvStr_Sql += "  TBL_SALES_DETAIL.DISCOUNT, TBL_SALES_DETAIL.SERVICE, TBL_SALES_DETAIL.VAT, TBL_SALES_DETAIL.FINALTOTAL, TBL_SALES_DETAIL.CHARGE_ID, TBL_SALES_DETAIL.CREATEDATE, TBL_SALES_DETAIL.ACTIVE"
                mvStr_Sql += "  FROM TBL_SALES_DETAIL INNER JOIN TBL_ITEM ON TBL_SALES_DETAIL.LOC_ID = TBL_ITEM.LOC_ID AND TBL_SALES_DETAIL.ITEM_ID = TBL_ITEM.ID"
                mvStr_Sql += "  WHERE TBL_SALES_DETAIL.LOC_ID = @iNVChr_LOCID AND TBL_SALES_DETAIL.[ID] = @iNVChr_ID"
                mvStr_Sql += "  ORDER BY TBL_SALES_DETAIL.CREATEDATE"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetAllData(ByVal iStr_ID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TBL_SALES_DETAIL.LOC_ID,TBL_SALES_DETAIL.ID,TBL_SALES_DETAIL.ITEM_ID, TBL_ITEM.NAME AS [Tên hàng], TBL_SALES_DETAIL.QUANTITY AS [S.L], TBL_SALES_DETAIL.PRICE AS [Giá],"
                mvStr_Sql += "  TBL_SALES_DETAIL.DISCOUNT,TBL_SALES_DETAIL.VAT,TBL_SALES_DETAIL.SERVICE, TBL_SALES_DETAIL.CREATEDATE, TBL_SALES_DETAIL.NOTE, TBL_SALES_DETAIL.CHARGE_ID, TBL_SALES_DETAIL.CHECK_OUT, TBL_SALES_DETAIL.ACTIVE"
                mvStr_Sql += "  FROM TBL_SALES_DETAIL INNER JOIN TBL_ITEM ON TBL_SALES_DETAIL.LOC_ID = TBL_ITEM.LOC_ID AND TBL_SALES_DETAIL.ITEM_ID = TBL_ITEM.ID"
                mvStr_Sql += "  WHERE TBL_SALES_DETAIL.LOC_ID = @iNVChr_LOCID AND TBL_SALES_DETAIL.[ID] = @iNVChr_ID"
                mvStr_Sql += "  ORDER BY TBL_SALES_DETAIL.CREATEDATE"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetTotal(ByVal iStr_ID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = " SELECT ISNULL(SUM(QUANTITY * PRICE),0) AS TOTAL,  "
                mvStr_Sql += " ISNULL(SUM(QUANTITY * PRICE * DISCOUNT /100),0) AS DISCOUNT,  "
                mvStr_Sql += " ISNULL(SUM(QUANTITY * PRICE * SERVICE /100),0) AS SERVICE,  "
                mvStr_Sql += " ISNULL(SUM(QUANTITY * PRICE * VAT /100),0) AS VAT,  "
                mvStr_Sql += " ISNULL((SUM(QUANTITY * PRICE + (QUANTITY * PRICE * (ISNULL(VAT,0) + ISNULL(SERVICE,0) - ISNULL(DISCOUNT,0)) /100))-(SELECT isnull(VOUCHER,0) FROM TBL_SALES S WHERE S.ID  = @iNVChr_ID)),0) AS TOTALCOST, "
                mvStr_Sql += " (SELECT ISNULL(VOUCHER,0) FROM TBL_SALES S WHERE S.ID  = @iNVChr_ID) AS VOUCHER "
                mvStr_Sql += " FROM TBL_SALES_DETAIL WHERE LOC_ID = @iNVChr_LOCID AND [ID] = @iNVChr_ID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetData_2(ByVal iStr_ID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TBL_ITEM.NAME AS [Tên hàng], TBL_SALES_DETAIL.QUANTITY AS [S.L], TBL_SALES_DETAIL.PRICE AS [Giá],TBL_SALES_DETAIL.ITEM_ID as [ITEM_ID]"
                mvStr_Sql += "  FROM TBL_SALES_DETAIL INNER JOIN TBL_ITEM ON TBL_SALES_DETAIL.LOC_ID = TBL_ITEM.LOC_ID AND TBL_SALES_DETAIL.ITEM_ID = TBL_ITEM.ID"
                mvStr_Sql += "  WHERE TBL_SALES_DETAIL.LOC_ID = @iNVChr_LOCID AND TBL_SALES_DETAIL.[ID] = @iNVChr_ID"
                mvStr_Sql += "  ORDER BY TBL_SALES_DETAIL.CREATEDATE"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetDis(ByVal iStr_ID As String) As Integer
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = " SELECT DISCOUNT"
                mvStr_Sql += " FROM TBL_SALES_DETAIL WHERE LOC_ID = @iNVChr_LOCID AND [ID] = @iNVChr_ID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale.Rows(0)("DISCOUNT")

    End Function
#End Region
#Region "Insert - Update"
    Public Function FuncG_InsertUpdate(ByVal iCls_SalesDetail As cls_SalesDetail) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_SalesDetail.ID)
                SubM_AddParameter("@iInt_ITEM", iCls_SalesDetail.ItemID)
                SubM_AddParameter("@iFlt_QUANTITY", iCls_SalesDetail.Quantity)
                SubM_AddParameter("@iFlt_PRICE", iCls_SalesDetail.Price)
                SubM_AddParameter("@iNVChr_NOTE", iCls_SalesDetail.Note)
                SubM_AddParameter("@iNVChr_ChargeID", "00") 'iCls_SalesDetail.ChargeID)
                SubM_AddParameter("@iDat_CreateDate", Now) 'iCls_SalesDetail.CreateDate)
                If FuncM_ExecuteStore("usp_SalesDetail") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try

    End Function

    Public Function FuncG_BulkInsert(ByVal iDat_SaleDetails As DataTable) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@SaleDetail", iDat_SaleDetails, SqlDbType.Structured)
                If FuncM_ExecuteStore("usp_InsertSaleDetails") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try

    End Function

    Public Function FuncG_UpdateCharge(ByVal iCls_SalesDetail As cls_SalesDetail) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_SalesDetail.ID)
                SubM_AddParameter("@iInt_ITEM", iCls_SalesDetail.ItemID)
                SubM_AddParameter("@iFlt_PRICE", iCls_SalesDetail.Price)
                SubM_AddParameter("@iNVChr_ChargeID", iCls_SalesDetail.ChargeID)
                If FuncM_ExecuteStore("usp_UpdateSalesDetailCharge") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try

    End Function
    'Cập nhật lại số lượng khi trả hàng
    Public Function FuncG_Update(ByVal iCls_SalesDetail As cls_SalesDetail) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_SalesDetail.ID)
                SubM_AddParameter("@iInt_ITEM", iCls_SalesDetail.ItemID)
                SubM_AddParameter("@iFlt_QUANTITY", iCls_SalesDetail.Quantity)
                If FuncM_ExecuteStore("usp_UpdateSalesDetail") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try

    End Function
    Public Function FuncG_UpdateNote(ByVal iCls_SalesDetail As cls_SalesDetail) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_SalesDetail.ID)
                SubM_AddParameter("@iInt_ITEM", iCls_SalesDetail.ItemID)
                SubM_AddParameter("@iNVChr_NOTE", iCls_SalesDetail.Note)
                If FuncM_ExecuteStore("usp_UpdateNote") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try

    End Function

    Public Function FuncG_UpdateNoteChargeItem(ByVal iCls_SalesDetail As cls_SalesDetail) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_SalesDetail.ID)
                SubM_AddParameter("@iInt_ITEM", iCls_SalesDetail.ItemID)
                'SubM_AddParameter("@iNVChr_NOTE", iCls_SalesDetail.Note)
                If FuncM_ExecuteStore("usp_UpdateNoteChargeItem") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try

    End Function

    Public Function FuncG_UpdateNoteActiveChargeItem(ByVal iCls_SalesDetail As cls_SalesDetail) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_SalesDetail.ID)
                SubM_AddParameter("@iInt_ITEM", iCls_SalesDetail.ItemID)
                'SubM_AddParameter("@iNVChr_NOTE", iCls_SalesDetail.Note)
                If FuncM_ExecuteStore("usp_UpdateNoteActiveChargeItem") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try

    End Function
#End Region
#Region "Insert_Update ChargeItem"
    Public Function FuncG_InsertUpdateChargeItem(ByVal iCls_SalesDetail As cls_SalesDetail) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_SalesDetail.ID)
                SubM_AddParameter("@iInt_ITEM", iCls_SalesDetail.ItemID)
                SubM_AddParameter("@iFlt_QUANTITY", iCls_SalesDetail.Quantity)
                SubM_AddParameter("@iFlt_PRICE", iCls_SalesDetail.Price)
                SubM_AddParameter("@iNVChr_CHARGEID", iCls_SalesDetail.ChargeID)
                SubM_AddParameter("@iTint_ACTIVE", iCls_SalesDetail.Active)
                If FuncM_ExecuteStore("usp_SalesDetailChargeItem") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function

    Public Function FuncG_UpdateSaleDetailItemStatus(ByVal iCls_SalesDetail As cls_SalesDetail) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_SalesDetail.ID)
                SubM_AddParameter("@iInt_ITEM", iCls_SalesDetail.ItemID)
                SubM_AddParameter("@iTint_ACTIVE", iCls_SalesDetail.Active)
                If FuncM_ExecuteStore("usp_UpdateSaleDetailItemStatus") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function

    Public Function FuncG_UpdateSalesDetailCharge(ByVal iCls_SalesDetail As cls_SalesDetail) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_SalesDetail.ID)
                SubM_AddParameter("@iInt_ITEM", iCls_SalesDetail.ItemID)
                SubM_AddParameter("@iFlt_PRICE", iCls_SalesDetail.Price)
                SubM_AddParameter("@iNVChr_ChargeID", iCls_SalesDetail.ChargeID)
                If FuncM_ExecuteStore("usp_UpdateSalesDetailCharge") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function

    Public Function FuncG_UpdateCheckoutSalesDetailCharge(ByVal iCls_SalesDetail As cls_SalesDetail) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_SalesDetail.ID)
                SubM_AddParameter("@iInt_ITEM", iCls_SalesDetail.ItemID)
                SubM_AddParameter("@iFlt_QUANTITY", iCls_SalesDetail.Quantity)
                SubM_AddParameter("@iDat_CHECKOUT", iCls_SalesDetail.CheckOut)
                If FuncM_ExecuteStore("usp_UpdateCheckoutSalesDetailCharge") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function

#End Region
#Region "Update Fee"
    Public Function FuncG_UpdateFee(ByVal iCls_SalesDetail As cls_SalesDetail, ByVal iByte_Status As Byte) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_SalesDetail.ID)
                SubM_AddParameter("@iInt_ITEM", iCls_SalesDetail.ItemID)
                SubM_AddParameter("@iSInt_VALUE", iCls_SalesDetail.Price)
                SubM_AddParameter("@iTInt_STATUS", iByte_Status)
                If FuncM_ExecuteStore("usp_UpdateFee") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function
    Public Function FuncG_UpdateFeeBill(ByVal iCls_SalesDetail As cls_SalesDetail, ByVal iByte_Status As Byte) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_SalesDetail.ID)
                SubM_AddParameter("@iSInt_VALUE", iCls_SalesDetail.Price)
                SubM_AddParameter("@iTInt_STATUS", iByte_Status)
                If FuncM_ExecuteStore("usp_UpdateFeeBill") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function

    Public Function FuncG_DeleteSaleDetailByInvoice(ByVal iStr_ID As String) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                If FuncM_ExecuteStore("usp_DeleteSaleDetailsByInvoice") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function

    Public Function FuncG_GetItemKaraoke(ByVal iStr_ID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                'mvStr_Sql = "SELECT * FROM [TBL_SALES_DETAIL] WHERE LOC_ID = @iNVChar_LOC_ID and ID = @iNVChr_ID and ITEM_ID = '899'"
                mvStr_Sql = "SELECT * FROM [TBL_SALES_DETAIL] WHERE LOC_ID = @iNVChar_LOC_ID and ID = @iNVChr_ID "
                SubM_AddParameter("@iNVChar_LOC_ID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function

    Public Function FuncG_DeleteItemKaraoke(ByVal iStr_ID As String) As Boolean
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "DELETE  FROM [TBL_SALES_DETAIL] WHERE LOC_ID = @iNVChar_LOC_ID and ID = @iNVChr_ID and ITEM_ID = '899'"
                SubM_AddParameter("@iNVChar_LOC_ID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return False
    End Function

#End Region

    Public Function FuncG_Danhsachmonmo(ByVal FromDate As DateTime, ByVal Todate As DateTime) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = " select it.ID as [Mã hàng],it.NAME as [Tên hàng],sd.QUANTITY as [Số lượng],sd.PRICE as [Đơn giá],sd.CREATEDATE as [Ngày],sd.id from TBL_SALES_DETAIL as sd join TBL_ITEM as it on sd.ITEM_ID=it.ID "
                mvStr_Sql += " where it.ID>1920 and sd.PRICE>0 and (sd.CREATEDATE between @FromDate and @Todate) "

                SubM_AddParameter("@FromDate", FromDate)
                SubM_AddParameter("@Todate", Todate)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_InsertDinhluongmonmo(ByVal InventoryID As String, ByVal MaterialID As String, ByVal InvoiceID As String, ByVal ItemID As String, ByVal ExportQty As Double, ByVal Unit As String, ByVal Price As Double, ByVal Quantity As Double) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@ex_Stock_Report_LOC_ID", gvStr_LocID)
                SubM_AddParameter("@ex_Stock_Report_InventoryID", InventoryID)
                SubM_AddParameter("@ex_Stock_Report_MaterialID", MaterialID)
                SubM_AddParameter("@InvoiceID", InvoiceID)
                SubM_AddParameter("@saleEx_ItemID", ItemID)
                SubM_AddParameter("@saleEx_ExportQty", ExportQty)
                SubM_AddParameter("@ex_Stock_Report_Unit", Unit)
                SubM_AddParameter("@ex_Stock_Report_Price", Price)
                SubM_AddParameter("@ex_Stock_Report_Quantity", Quantity)
                If FuncM_ExecuteStore("xuatkhomonmo") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try

    End Function
    Public Function FuncG_InsertLichSuDinhLuong(ByVal SALEID As String, ByVal ITEMID As String, ByVal ITEMNAME As String, ByVal SLBAN As Double, ByVal MaterialID As String, ByVal MaterialName As String, ByVal InventoryID As String, ByVal USERNAME As String, ByVal SODINHMUC As Double) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_SALEID", SALEID)
                SubM_AddParameter("@iNVChr_ITEMID", ITEMID)
                SubM_AddParameter("@iNVChr_ITEMNAME", ITEMNAME)
                SubM_AddParameter("@iNVChr_SLBAN", SLBAN)
                SubM_AddParameter("@iNVChr_MaterialID", MaterialID)
                SubM_AddParameter("@iNVChr_MaterialName", MaterialName)
                SubM_AddParameter("@iNVChr_LOC_ID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_InventoryID", InventoryID)
                SubM_AddParameter("@iNVChr_USERNAME", USERNAME)
                SubM_AddParameter("@iNVChr_SODINHMUC", SODINHMUC)
                If FuncM_ExecuteStore("usp_InsertPromatOpenItem") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try

    End Function
    Public Function FuncG_Check(ByVal iStr_ID As String, ByVal iStr_ItemID As String, ByVal iStr_MaterialID As String) As Boolean
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = " SELECT * "
                mvStr_Sql += " FROM TBL_HISTORY_PROMATOPENITEM WHERE SALEID = @iNVChr_SaleID AND ITEMID = @iNVChr_ItemID and MaterialID=@iNVChr_MaterialID"
                SubM_AddParameter("@iNVChr_SaleID", iStr_ID)
                SubM_AddParameter("@iNVChr_ItemID", iStr_ItemID)
                SubM_AddParameter("@iNVChr_MaterialID", iStr_MaterialID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)

                If mvDataTale.Rows.Count > 0 Then
                    Return True
                Else
                    Return False

                End If

            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try


    End Function
End Class
