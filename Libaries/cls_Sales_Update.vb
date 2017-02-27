Public Class cls_Sales_Update
    Inherits cls_Database_Base
#Region "Get Data"
    Public Function FuncG_GetData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM [TBL_SALES]"
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
                mvStr_Sql = "SELECT TOP 1 * FROM [TBL_SALES] WHERE LOC_ID = @iNVChr_LOCID AND [ID] = @iNVChr_ID"
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
    Public Function FuncG_GetDataByTableID(ByVal iInt_TableID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TOP 1 * FROM [TBL_SALES] WHERE LOC_ID = @iNVChr_LOCID AND TABLE_ID = @iInt_TABLEID"
                mvStr_Sql += "  AND STATUS <> 0 AND CHECK_OUT IS NULL ORDER BY CREATEDATE DESC"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iInt_TABLEID", iInt_TableID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function

    Public Function FuncG_GetCreateDateByTableID(ByVal iInt_TableID As String) As DateTime
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TOP 1 * FROM [TBL_SALES] WHERE LOC_ID = @iNVChr_LOCID AND TABLE_ID = @iInt_TABLEID"
                mvStr_Sql += "  AND STATUS <> 0 AND CHECK_OUT IS NULL"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iInt_TABLEID", iInt_TableID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return Convert.ToDateTime(mvDataTale.Rows(0)("CREATEDATE"))
    End Function

    Public Function FuncG_Get_Bill_Info() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM [TBL_OPTIONS] WHERE LOC_ID = @iNVChr_LOCID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)

                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
                Return mvDataTale
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try

    End Function
    Public Function FuncG_GetData_2(ByVal date1 As Date, ByVal date2 As Date) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT s.ID as [Số hóa đơn], t.NAME as [Bàn],[CASHIER_ID] as [Thu ngân]"
                mvStr_Sql += " ,[CHECK_IN] AS [Giờ vào], [CHECK_OUT] AS [Giờ ra],t.ID as [Table_ID]"
                mvStr_Sql += " FROM [TBL_SALES] s join [TBL_TABLE] t on s.TABLE_ID = t.ID"
                mvStr_Sql += " where CHECK_OUT between @date1 and @date2 AND S.STATUS <3 AND S.STATUS >= 1 order by CREATEDATE desc"
                SubM_AddParameter("@date1", date1)
                SubM_AddParameter("@date2", date2)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function

    Public Function FuncG_LayIDBanTheoMaHD(ByVal maHD As String) As String
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM TBL_SALES WHERE ID=@P_ID AND LOC_ID=@P_LOC_ID"
                SubM_AddParameter("@P_ID", maHD)
                SubM_AddParameter("@P_LOC_ID", gvStr_LocID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try

        If mvDataTale.Rows.Count > 0 Then
            Return mvDataTale.Rows(0).Item("TABLE_ID").ToString()
        Else
            Return ""
        End If
    End Function
#End Region
#Region "Create invoice number"
    Public Function FuncG_CreateInvoiceNo() As String
        Dim mvStr_ID As String = ""
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                'Tìm hóa đơn đầu tiên trong ngày, nếu có lấy số HĐ lớn nhất
                mvStr_Sql = "SELECT TOP 1 * FROM [TBL_SALES] WHERE LOC_ID = @iNVChr_LOCID AND DATEADD(day, 0, DATEDIFF(day, 0, CREATEDATE)) = CONVERT(NVARCHAR,GETDATE(),1) ORDER BY CAST (LEFT(ID,5) AS INT) DESC"
                'mvStr_Sql = "SELECT TOP 1 * FROM [TBL_SALES] WHERE LOC_ID = @iNVChr_LOCID AND DATEADD(day, 0, DATEDIFF(day, 0, CREATEDATE)) = @iDate_CREATEDATE ORDER BY CAST (LEFT(ID,5) AS INT) DESC"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                ' SubM_AddParameter("@iDate_CREATEDATE", Today.Date)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
                If mvDataTale.Rows.Count <> 0 Then
                    mvStr_ID = FuncG_CreateSerial(mvDataTale.Rows(0)("ID"), 5)
                Else
                    mvStr_ID = "00001-" + Format(Today, "ddMMyyyy") + gvStr_LocID
                End If
            End If        
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvStr_ID
    End Function
    Public Function FuncG_CreateInvoiceNoMax() As DateTime
        Dim mvStr_CREATEDATE As DateTime
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                'Tìm hóa đơn đầu tiên trong ngày, nếu có lấy số HĐ lớn nhất
                mvStr_Sql = "select top 1 * from TBL_SALES WHERE LOC_ID = @iNVChr_LOCID order by CREATEDATE desc"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                'SubM_AddParameter("@iDate_CREATEDATE", Today.Date)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
                If mvDataTale.Rows.Count <> 0 Then
                    mvStr_CREATEDATE = mvDataTale.Rows(0)("CREATEDATE")
                Else
                    mvStr_CREATEDATE = DateTime.Now
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvStr_CREATEDATE
    End Function
#End Region
#Region "Insert - Update"
    Public Function FuncG_Insert(ByVal iCls_Sales As cls_Sales) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Sales.ID)
                SubM_AddParameter("@iNVChr_CASHIER", iCls_Sales.CashierID)
                SubM_AddParameter("@iNVChr_CUSTOMER", iCls_Sales.CustomerID)
                SubM_AddParameter("@iNVChr_WAITER", iCls_Sales.WaiterID)
                SubM_AddParameter("@iInt_TABLE", iCls_Sales.TableID)
                SubM_AddParameter("@iDate_CHECKIN", iCls_Sales.CheckIn)
                SubM_AddParameter("@iTInt_VAT", iCls_Sales.VAT)
                SubM_AddParameter("@iTInt_STATUS", iCls_Sales.Status)
                SubM_AddParameter("@iBool_FastFood", gvBol_FastFood)
                SubM_AddParameter("@iInt_CustomerNumber", iCls_Sales.CustomerNumber)
                If FuncM_ExecuteStore("usp_InsertSales") Then
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
    Public Function FuncG_UpdateStatus(ByVal iStr_ID As String, ByVal iByte_Status As Byte) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "UPDATE [TBL_SALES] SET STATUS = @iTInt_STATUS,CASHIER_ID = @iNVChr_CASHIER, CHECK_OUT = getdate()"
                mvStr_Sql += "WHERE LOC_ID = @iNVChr_LOCID AND ID = @iNVChr_ID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                SubM_AddParameter("@iTInt_STATUS", iByte_Status)
                SubM_AddParameter("@iNVChr_CASHIER", gvStr_AccUser)
                If FuncM_ExecuteNonQuery(mvStr_Sql) Then
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
    '==========Update giờ cũ=============================
    Public Function FuncG_UpdateThoigianChiTietBanHang(ByVal iStr_ID As String, ByVal Thoigianmoban As Date) As Boolean
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "update   [TBL_SALES_DETAIL] set CREATEDATE=@iNVChr_Thoigianmoban WHERE LOC_ID = @iNVChar_LOC_ID and ID = @iNVChr_ID "
                SubM_AddParameter("@iNVChar_LOC_ID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                SubM_AddParameter("@iNVChr_Thoigianmoban", Thoigianmoban)
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
    Public Function FuncG_UpdateThoigianBanhang(ByVal iStr_ID As String, ByVal Thoigianmoban As Date, ByVal Thoigiandongban As Date) As Boolean
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "update   [TBL_SALES] set CREATEDATE=@iNVChr_Thoigianmoban,CHECK_IN=@iNVChr_Thoigianmoban,CHECK_OUT=@Inv_CHECK_OUT WHERE LOC_ID = @iNVChar_LOC_ID and ID = @iNVChr_ID "
                SubM_AddParameter("@iNVChar_LOC_ID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                SubM_AddParameter("@iNVChr_Thoigianmoban", Thoigianmoban)
                SubM_AddParameter("@Inv_CHECK_OUT", Thoigiandongban)
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
    Public Function FuncG_UpdateThoigianIncome(ByVal iStr_ID As String, ByVal Thoigiandongban As Date) As Boolean
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "update   [TBL_INCOME] set CREATEDATE=@iNVChr_Thoigianmoban WHERE LOC_ID = @iNVChar_LOC_ID and INVOICE_ID = @iNVChr_ID "
                SubM_AddParameter("@iNVChar_LOC_ID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                SubM_AddParameter("@iNVChr_Thoigianmoban", Thoigiandongban)
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
    '=================================================
    Public Function FuncG_UpdateCustomer(ByVal iStr_ID As String, ByVal soluongkhach As String, ByVal tenkhach As String) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "UPDATE [TBL_SALES] SET CUSTOMER_ID = @tenkhach,CustomerNumber = @soluongkhach "
                mvStr_Sql += "WHERE LOC_ID = @iNVChr_LOCID AND ID = @iNVChr_ID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                SubM_AddParameter("@soluongkhach", soluongkhach)
                SubM_AddParameter("@tenkhach", tenkhach)
                If FuncM_ExecuteNonQuery(mvStr_Sql) Then
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
    Public Function FuncG_UpdateEmployee(ByVal iStr_ID As String, ByVal soluongkhach As String, ByVal tennv As String) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "UPDATE [TBL_SALES] SET WAITER_ID = @tennv,CustomerNumber = @soluongkhach "
                mvStr_Sql += "WHERE LOC_ID = @iNVChr_LOCID AND ID = @iNVChr_ID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                SubM_AddParameter("@soluongkhach", soluongkhach)
                SubM_AddParameter("@tennv", tennv)
                If FuncM_ExecuteNonQuery(mvStr_Sql) Then
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
    Public Function FuncG_UpdateStatus_Payment(ByVal iStr_ID As String, ByVal iByte_Status As Byte, ByVal iDbl_Payment As Double, ByVal iDbl_Rate As Double, ByVal iStr_CurrencyID As String) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "UPDATE [TBL_SALES] SET STATUS = @iTInt_STATUS, PAYMENT = @iFlt_PAYMENT, CASHIER_ID = @iNVChr_CASHIER, CHECK_OUT = getdate(),"
                mvStr_Sql += "CURRENCY_ID = @iNVChr_CURRENCYID, RATE = @Flt_RATE "
                mvStr_Sql += "WHERE LOC_ID = @iNVChr_LOCID AND ID = @iNVChr_ID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                SubM_AddParameter("@iTInt_STATUS", iByte_Status)
                SubM_AddParameter("@iNVChr_CASHIER", gvStr_AccUser)
                SubM_AddParameter("@iFlt_PAYMENT", iDbl_Payment)
                SubM_AddParameter("@iNVChr_CURRENCYID", iStr_CurrencyID)
                SubM_AddParameter("@Flt_RATE", iDbl_Rate)
                If FuncM_ExecuteNonQuery(mvStr_Sql) Then
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
    Public Function FuncG_DeleteBill(ByVal iStr_ID As String, ByVal iStr_UserID As String, ByVal iByte_Status As Byte) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "UPDATE [TBL_SALES] SET STATUS = @iTInt_STATUS, WAITER_ID = @iNVChr_UserID, CHECK_OUT = getdate()"
                mvStr_Sql += "  WHERE LOC_ID = @iNVChr_LOCID AND ID = @iNVChr_ID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                SubM_AddParameter("@iNVChr_UserID", iStr_UserID)
                SubM_AddParameter("@iTInt_STATUS", iByte_Status)
                If FuncM_ExecuteNonQuery(mvStr_Sql) Then
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
    Public Function FuncG_UpdateCustomerNumber(ByVal iInt_Number As Integer, ByVal iStr_ID As String) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "UPDATE [TBL_SALES] SET CustomerNumber = @iInt_CustomerNumber"
                mvStr_Sql += " WHERE LOC_ID = @iNVChr_LOCID AND ID = @iNVChr_ID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                SubM_AddParameter("@iInt_CustomerNumber", iInt_Number)
                If FuncM_ExecuteNonQuery(mvStr_Sql) Then
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
    Public Function FuncG_UpdateTBL_OPTIONS(ByVal handungthu As String, ByVal status As String) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = " UPDATE [TBL_OPTIONS] SET DESCRIPTION = @handungthu, status = @status  "
                mvStr_Sql += " WHERE  NAME = 'HANDUNGTHULANDAU' "
                SubM_AddParameter("@handungthu", handungthu)
                SubM_AddParameter("@status", status)

                If FuncM_ExecuteNonQuery(mvStr_Sql) Then
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
    Public Function FuncG_UpdateTBL_OPTIONS_BILLNAME(ByVal handungthu As String) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "UPDATE [TBL_OPTIONS] SET DESCRIPTION = @handungthu"
                mvStr_Sql += " WHERE  NAME = 'BILL_COMPANY_NAME1'"
                SubM_AddParameter("@handungthu", handungthu)
                If FuncM_ExecuteNonQuery(mvStr_Sql) Then
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
    Public Function FuncG_UpdateTBL_OPTIONS_BILL_ADDRESS_1(ByVal handungthu As String) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "UPDATE [TBL_OPTIONS] SET DESCRIPTION = @handungthu"
                mvStr_Sql += " WHERE  NAME = 'BILL_ADDRESS_1'"
                SubM_AddParameter("@handungthu", handungthu)
                If FuncM_ExecuteNonQuery(mvStr_Sql) Then
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
    Public Function FuncG_UpdateTBL_OPTIONS_BILL_TELEPHONE(ByVal handungthu As String) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "UPDATE [TBL_OPTIONS] SET DESCRIPTION = @handungthu "
                mvStr_Sql += " WHERE  NAME = 'BILL_TELEPHONE'"
                SubM_AddParameter("@handungthu", handungthu)
                If FuncM_ExecuteNonQuery(mvStr_Sql) Then
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
    Public Function FuncG_GETHANDUNGTHU() As String
        Dim mvDataTale As New DataTable
        Dim datestart As String = ""
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT top 1 * FROM [TBL_OPTIONS] WHERE LOC_ID = @iNVChr_LOCID AND NAME='HANDUNGTHULANDAU' "
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
                If mvDataTale.Rows.Count > 0 Then
                    datestart = mvDataTale.Rows(0)("status").ToString() + mvDataTale.Rows(0)("DESCRIPTION").ToString()
                Else
                    datestart = ""
                End If


            End If
        Catch ex As Exception
            datestart = ""
        Finally
            FuncM_CloseConnection()
        End Try
        Return datestart
    End Function
#End Region
#Region "Delete"
    Public Function FuncG_Delete(ByVal iStr_ID As String, ByVal iInt_TableID As Integer) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                SubM_AddParameter("@iInt_TABLE", iInt_TableID)
                If FuncM_ExecuteStore("usp_DeleteSales") Then
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

    Public Function FuncG_DeleteSaleByInvoice(ByVal iStr_ID As String, ByVal iInt_TableID As Integer) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                SubM_AddParameter("@iInt_TABLE", iInt_TableID)
                If FuncM_ExecuteStore("usp_DeleteSaleByInvoice") Then
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
#Region "Transfer table"
    Public Function FuncG_Transfer(ByVal iStr_ID As String, ByVal iInt_TableID1 As Integer, ByVal iInt_TableID2 As Integer) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                SubM_AddParameter("@iInt_TABLE1", iInt_TableID1)
                SubM_AddParameter("@iInt_TABLE2", iInt_TableID2)
                If FuncM_ExecuteStore("usp_TransferTable") Then
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
#Region "Update voucher"
    Public Function FuncG_UpdateVoucher(ByVal iCls_Sales As cls_Sales, ByVal iByte_Status As Byte) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Sales.ID)
                SubM_AddParameter("@iSInt_VOUCHER", iCls_Sales.Voucher)
                SubM_AddParameter("@iTInt_STATUS", iByte_Status)
                If FuncM_ExecuteStore("usp_UpdateVoucher") Then
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
End Class
