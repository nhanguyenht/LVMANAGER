Public Class cls_ImportExport_Update
    Inherits cls_Database_Base
#Region "Get Data"
    '0 : Phiếu nhập, 1 : Phiếu xuất
    Public Function FuncG_GetAllData(ByVal iByte_Type As Byte) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT I.ID AS [Mã phiếu], I.CREATEDATE AS [Ngày nhập], I.INVOICE AS [Số HĐ],"
                mvStr_Sql += "  C.NAME AS [Nhà cung cấp], N.InventoryName AS [Kho], N2.InventoryName AS [Đến Kho]"
                mvStr_Sql += "  FROM TBL_IMPORTEXPORT I INNER JOIN TBL_CUSTOMER_EMPLOYEE C ON"
                mvStr_Sql += "  I.LOC_ID = C.LOC_ID AND I.SUPPLIERS = C.ID"
                mvStr_Sql += " LEFT JOIN TBL_INVENTORY N ON I.LOC_ID = N.LOC_ID AND I.InventoryID = N.InventoryID"
                mvStr_Sql += " LEFT JOIN TBL_INVENTORY N2 ON I.LOC_ID = N2.LOC_ID AND I.ToInventoryID = N2.InventoryID"
                mvStr_Sql += "  WHERE (I.LOC_ID = @iNVChr_LOCID) AND (I.TYPE = @iTInt_TYPE)"
                mvStr_Sql += "  ORDER BY I.CREATEDATE DESC"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iTInt_TYPE", iByte_Type)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetDataByID(ByVal iStr_ITEMID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT *  FROM TBL_IMPORTEXPORTDETAIL  WHERE ITEM_ID = @iNVChr_ID  AND LOC_ID = @iNVChr_LOCID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ITEMID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetData(ByVal iStr_InvoiceID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TOP 1 * FROM TBL_IMPORTEXPORT"
                mvStr_Sql += "  WHERE LOC_ID = @iNVChr_LOCID AND [ID] = @iNVChr_ID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_InvoiceID)
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
#Region "Create invoice number"
    Public Function FuncG_CreateInvoiceNo(ByVal iStr_Type As String, ByVal iDate_CreateDate As Date) As String 'ByVal iStr_Type As String, ByVal iDate_CreateDate As Date
        Dim mvStr_ID As String = ""
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TOP 1 * FROM [TBL_IMPORTEXPORT] WHERE LOC_ID = @iNVChr_LOCID AND DATEADD(day, 0, DATEDIFF(day, 0, CREATEDATE)) = @iDate_CREATEDATE"
                mvStr_Sql += "  AND LEFT([ID],2) = @iNVChr_Type ORDER BY CAST (SUBSTRING(ID,14,20) AS INT) DESC"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iDate_CREATEDATE", iDate_CreateDate)
                SubM_AddParameter("@iNVChr_Type", iStr_Type)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
                If mvDataTale.Rows.Count <> 0 Then
                    Dim SERI As String = ""
                    SERI = mvDataTale.Rows(0)("ID")
                    If SERI.Length < 13 Then
                        mvStr_ID = iStr_Type + "-" + gvStr_LocID + Format(iDate_CreateDate, "ddMMyyyy") + "001"
                    Else
                        mvStr_ID = TaoSoSeri(mvDataTale.Rows(0)("ID"), 13)
                    End If

                    '======================================================================================
                    'mvStr_ID = TaoSoSeriNEW(mvDataTale.Rows(0)("ID"), 3)
                Else
                    'Số HĐ ex : PT-01ddMMyyyy001
                    mvStr_ID = iStr_Type + "-" + gvStr_LocID + Format(iDate_CreateDate, "ddMMyyyy") + "001"
                    '======================================================================================
                    'Số HĐ ex : PT-0000001
                    'mvStr_ID = iStr_Type + "-" + "0000001"
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
#Region "Insert - Update"

    '------------------------------------------------------------------------------------------------------------

    Public Function FuncG_UpdateStockType(ByVal iCls_ImportExport As cls_ImportExport) As Boolean
        Try
            If FuncM_OpenConnection() Then
                Dim sql As String = "Update TBL_IMPORTEXPORT set UpdatedStockType=2 where ID='" + iCls_ImportExport.ID + "'"
                If FuncM_ExecuteNonQuery(sql) Then
                    Return True
                End If
            End If
        Catch ex As Exception

        End Try
    End Function

    Public Function FuncG_DeleteStock_Details(ByVal iCls_ImportExport As cls_ImportExport) As Boolean
        Try
            If FuncM_OpenConnection() Then
                Dim sql As String = "Delete from Stock_Reports where StockID in (Select StockID from Stock_Details where InvoiceID = '" + iCls_ImportExport.ID + "') Delete Stock_Details where InvoiceID='" + iCls_ImportExport.ID + "'"
                If FuncM_ExecuteNonQuery(sql) Then
                    Return True
                End If
            End If
        Catch ex As Exception

        End Try
    End Function

    '------------------------------------------------------------------------------------------------------------

    Public Function FuncG_InsertUpdate(ByVal iCls_ImportExport As cls_ImportExport) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_ImportExport.ID)
                SubM_AddParameter("@iNVChr_INVOICE", iCls_ImportExport.Invoice)
                SubM_AddParameter("@iDt_CREATEDATE", iCls_ImportExport.CreateDay)
                SubM_AddParameter("@iNVChr_USER", iCls_ImportExport.User)
                SubM_AddParameter("@iNVChr_SUPPLIERS", iCls_ImportExport.Suppliers)
                SubM_AddParameter("@iFlt_TOTAL", iCls_ImportExport.Total)
                SubM_AddParameter("@iTInt_TYPE", iCls_ImportExport.Type)
                SubM_AddParameter("@iNVChr_NOTE", iCls_ImportExport.Note)
                SubM_AddParameter("@iTInt_STATUS", iCls_ImportExport.Status)
                SubM_AddParameter("@iNVChr_InventoryID", iCls_ImportExport.InventoryID)
                SubM_AddParameter("@iNVChr_ToInventoryID", iCls_ImportExport.ToInventoryID)
                If FuncM_ExecuteStore("usp_ImportExport") Then
                    If iCls_ImportExport.Status = 1 Then
                        FuncG_UpdateStockType(iCls_ImportExport)
                        FuncG_DeleteStock_Details(iCls_ImportExport)
                    End If
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

    Public Function FuncG_InsertUpdateFirsPeriod() As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@LOC_ID", gvStr_LocID)
                If FuncM_ExecuteStore("sp_FirstPeriodStock") Then
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

    Public Function FuncG_ImportExport_StockDetail(ByVal iStr_InvoiceID As String, ByVal iBol_IsImport As Boolean) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@LOC_ID", gvStr_LocID)
                SubM_AddParameter("@InvoiceID", iStr_InvoiceID)
                SubM_AddParameter("@IsImport", iBol_IsImport)
                If FuncM_ExecuteStore("sp_ImportExport_Stock_Detail") Then
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

    Public Function FuncG_DeleteImportExport(ByVal iStr_InvoiceID As String, ByVal iBol_IsImport As Boolean) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@LOC_ID", gvStr_LocID)
                SubM_AddParameter("@InvoiceID", iStr_InvoiceID)
                SubM_AddParameter("@IsImoprt", iBol_IsImport)
                If FuncM_ExecuteStore("sp_Delete_ImportExport") Then
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
#Region "Delete"
    Public Function FuncG_Delete(ByVal iStr_ID As String) As Boolean
        Dim mvStr_Sql As String
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "DELETE [TBL_IMPORTEXPORT] WHERE LOC_ID = @iNVChr_LOCID AND ID = @iNVChr_ID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                FuncM_ExecuteNonQuery(mvStr_Sql)
                mvStr_Sql = "DELETE [TBL_IMPORTEXPORTDETAIL] WHERE LOC_ID = @iNVChr_LOCID2 AND ID = @iNVChr_ID2"
                SubM_AddParameter("@iNVChr_LOCID2", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID2", iStr_ID)
                FuncM_ExecuteNonQuery(mvStr_Sql)
            End If
        Catch ex As Exception

        End Try
    End Function
#End Region
End Class
