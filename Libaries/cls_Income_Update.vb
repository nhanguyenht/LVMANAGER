Public Class cls_Income_Update
    Inherits cls_Database_Base
#Region "Find order complete"
    Public Function FuncG_Find(ByVal iStr_ID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM [TBL_INCOME] WHERE LOC_ID = @iNVChr_LOCID AND INVOICE_ID = @iNVChr_ID"
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
#End Region
#Region "Get Thu Chi"
    Public Function FuncG_GetThuChi(ByVal FromDate As DateTime, ByVal Todate As DateTime) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT distinct (SELECT sum(TOTAL) from TBL_RECEIPTPAYMENT  where CREATEDATE between (@FromDate) and (@Todate) and TYPE='PT') as totalThu "
                mvStr_Sql += " ,(SELECT sum(TOTAL) from TBL_RECEIPTPAYMENT  where DESCRIPTION <> N'Trả nợ cho nhà cung cấp(N-C-C)'  and  CREATEDATE between (@FromDate) and (@Todate) and TYPE='PC') as totalChi "
                mvStr_Sql += " FROM TBL_RECEIPTPAYMENT  where DESCRIPTION =N'Trả nợ cho nhà cung cấp(N-C-C)'  and CREATEDATE between (@FromDate) and (@Todate)  "
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
    Public Function FuncG_GetTTaiChinh(ByVal FromDate As DateTime, ByVal Todate As DateTime) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = " EXEC [sp_DoanhThu] @iNVChr_LOCID,@FromDate,@Todate  "

                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
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
    Public Function FuncG_GetTiepKhach(ByVal FromDate As DateTime, ByVal Todate As DateTime) As Double
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Dim totalTiepKhach As Double = 0
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT sum(QUANTITY) as TotalTiepKhach FROM [dbo].[TBL_INCOME] where CREATEDATE between (@FromDate) and (@Todate) and CURRENCY_ID='TIEPKHACH'  "
                SubM_AddParameter("@FromDate", FromDate)
                SubM_AddParameter("@Todate", Todate)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)

                If mvDataTale.Rows.Count > 0 Then
                    Try
                        totalTiepKhach = mvDataTale.Rows(0)("TotalTiepKhach")
                    Catch ex As Exception
                        totalTiepKhach = 0
                    End Try

                Else
                    totalTiepKhach = 0
                End If

            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return totalTiepKhach
    End Function
    Public Function FuncG_GetTongCong(ByVal FromDate As DateTime, ByVal Todate As DateTime) As Integer
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Dim tongtien As Double = 0
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = " SELECT SUM(QUANTITY) as tongtien FROM [dbo].[TBL_INCOME]  where CREATEDATE between (@FromDate) and (@Todate) "
                SubM_AddParameter("@FromDate", FromDate)
                SubM_AddParameter("@Todate", Todate)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
                If mvDataTale.Rows.Count > 0 Then
                    tongtien = mvDataTale.Rows(0)("tongtien")
                Else
                    tongtien = 0
                End If


            End If
        Catch ex As Exception
            tongtien = 0
        Finally
            FuncM_CloseConnection()
        End Try
        Return tongtien
    End Function
#End Region
#Region "Insert"
    Public Function FuncG_Insert(ByVal iCls_Income As cls_Income) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Income.ID)
                SubM_AddParameter("@iInt_CURRENCYID", iCls_Income.CurrencyID)
                SubM_AddParameter("@iFlt_QUANTITY", iCls_Income.Quantity)
                SubM_AddParameter("@iFlt_RATE", iCls_Income.Rate)
                SubM_AddParameter("@iNVChr_DESCRIPTION", iCls_Income.Description)
                If FuncM_ExecuteStore("usp_Income") Then
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
#Region "Create invoice number"
    Public Function FuncG_CreateInvoiceNo(ByVal iStr_Type As String) As String
        Dim mvStr_ID As String = ""
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                'Tìm hóa đơn đầu tiên trong ngày, nếu có lấy số HĐ lớn nhất
                mvStr_Sql = "SELECT TOP 1 * FROM [TBL_RECEIPTPAYMENT] WHERE LOC_ID = @iNVChr_LOCID AND DATEADD(day, 0, DATEDIFF(day, 0, CREATEDATE)) = @iDate_CREATEDATE"
                mvStr_Sql += "  AND LEFT(INVOICE_ID,2) = @iNVChr_Type ORDER BY CAST (SUBSTRING(INVOICE_ID,14,20) AS INT) DESC"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iDate_CREATEDATE", Today.Date)
                SubM_AddParameter("@iNVChr_Type", iStr_Type)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
                If mvDataTale.Rows.Count <> 0 Then
                    mvStr_ID = TaoSoSeri(mvDataTale.Rows(0)("INVOICE_ID"), 13)
                Else
                    'Số HĐ ex : PT-01ddMMyyyy001
                    mvStr_ID = iStr_Type + "-" + gvStr_LocID + Format(Today, "ddMMyyyy") + "001"
                    'mvStr_ID = "00001-" + Format(Today, "ddMMyyyy") + gvStr_LocID
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvStr_ID
    End Function
    Public Function FuncG_CreateInvoiceNo(ByVal iStr_Type As String, ByVal Createdate As Date) As String
        Dim mvStr_ID As String = ""
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                'Tìm hóa đơn đầu tiên trong ngày, nếu có lấy số HĐ lớn nhất
                mvStr_Sql = "SELECT TOP 1 * FROM [TBL_RECEIPTPAYMENT] WHERE LOC_ID = @iNVChr_LOCID AND DATEADD(day, 0, DATEDIFF(day, 0, CREATEDATE)) = @iDate_CREATEDATE"
                mvStr_Sql += "  AND LEFT(INVOICE_ID,2) = @iNVChr_Type ORDER BY CAST (SUBSTRING(INVOICE_ID,14,20) AS INT) DESC"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iDate_CREATEDATE", Today.Date)
                SubM_AddParameter("@iNVChr_Type", iStr_Type)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
                If mvDataTale.Rows.Count <> 0 Then
                    mvStr_ID = TaoSoSeri(mvDataTale.Rows(0)("INVOICE_ID"), 13)
                Else
                    'Số HĐ ex : PT-01ddMMyyyy001
                    mvStr_ID = iStr_Type + "-" + gvStr_LocID + Format(Createdate, "ddMMyyyy") + "001"
                    'mvStr_ID = "00001-" + Format(Today, "ddMMyyyy") + gvStr_LocID
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvStr_ID
    End Function
#End Region
#Region "Insert Receipt Payment"
    Public Function FuncG_InsertReceiptPayment(ByVal iCls_Income As cls_Income) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Income.ID)
                SubM_AddParameter("@iNVChr_CASHIER", gvProp_AccUser)
                SubM_AddParameter("@iStr_People", iCls_Income.People)
                SubM_AddParameter("@iInt_CURRENCYID", iCls_Income.CurrencyID)
                SubM_AddParameter("@iFlt_QUANTITY", iCls_Income.Quantity)
                SubM_AddParameter("@iDate_CreateDate", iCls_Income.CreateDate)
                SubM_AddParameter("@iFlt_RATE", iCls_Income.Rate)
                SubM_AddParameter("@iNVChr_DESCRIPTION", iCls_Income.Description)
                If FuncM_ExecuteStore("usp_ReceiptPayment") Then
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
