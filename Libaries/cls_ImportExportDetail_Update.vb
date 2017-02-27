Public Class cls_ImportExportDetail_Update
    Inherits cls_Database_Base
#Region "Get Info"
    Public Function FuncG_GetData(ByVal iStr_InvoiceID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql += "SELECT TBL_IMPORTEXPORTDETAIL.ITEM_ID AS [Mã hàng], M.MaterialName AS [Tên hàng], TBL_IMPORTEXPORTDETAIL.QUANTITY AS [Số lượng],"
                mvStr_Sql += "  TBL_IMPORTEXPORTDETAIL.PRICE AS [Đơn giá], TBL_IMPORTEXPORTDETAIL.TOTAL AS [Thành tiền],TBL_IMPORTEXPORTDETAIL.VAT AS [Thuế VAT]"
                mvStr_Sql += "  FROM TBL_IMPORTEXPORTDETAIL INNER JOIN TBL_MATERIAL M ON TBL_IMPORTEXPORTDETAIL.LOC_ID = M.LOC_ID AND TBL_IMPORTEXPORTDETAIL.ITEM_ID = M.MaterialID"
                mvStr_Sql += "  WHERE TBL_IMPORTEXPORTDETAIL.LOC_ID = @iNVChr_LOCID AND TBL_IMPORTEXPORTDETAIL.ID = @iNVChr_ID"
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
#Region "Lấy số lượng tồn"
    Public Function FuncG_GetSLTon(ByVal MaterialID As Integer, ByVal InventoryID As String) As Double
        Dim slt As Double = 0
        Dim mvStr_Sql As String = "		declare @slt float = (select  SUM(ITEMS) FROM Stock_Details WHERE  (LEFT(InvoiceID,2)='pn' OR LEFT(InvoiceID,2)='PX' OR LEFT(InvoiceID,2)='PN') AND TranCode ='IN' AND MaterialID =@MaterialID and InventoryID =@InventoryID)- ISNULL((select  SUM(ITEMS) FROM Stock_Details WHERE  LEFT(InvoiceID,2)='px' AND TranCode ='out' AND MaterialID =@MaterialID and InventoryID =@InventoryID ),0) select @slt as SLT"

        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@MaterialID", MaterialID)
                SubM_AddParameter("@InventoryID", InventoryID)
                slt = Convert.ToDouble(FuncM_ExecuteScalar(mvStr_Sql))
            End If
            Return slt
        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region
#Region "Delete"
    Public Function FuncG_Delete(ByVal iStr_InvoiceID As String) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "DELETE TBL_IMPORTEXPORTDETAIL WHERE LOC_ID = @iNVChr_LOCID AND ID = @iNVChr_ID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_InvoiceID)
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
    Public Function FuncG_Delete(ByVal iStr_InvoiceID As String, ByVal iStr_ItemID As String) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "DELETE TBL_IMPORTEXPORTDETAIL WHERE LOC_ID = @iNVChr_LOCID AND ID = @iNVChr_ID AND ITEM_ID = @iNVChr_ITEMID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_InvoiceID)
                SubM_AddParameter("@iNVChr_ITEMID", iStr_ItemID)
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
#End Region
#Region "Insert Update"
    Public Function FuncG_InsertUpdate(ByVal iCls_ImExDetail As cls_ImportExportDetail) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_ImExDetail.ID)
                SubM_AddParameter("@iNVChr_ITEMID", iCls_ImExDetail.ItemID)
                SubM_AddParameter("@iFlt_QUANTITY", iCls_ImExDetail.Quantity)
                SubM_AddParameter("@iFlt_PRICE", iCls_ImExDetail.Price)
                SubM_AddParameter("@iTInt_VAT", iCls_ImExDetail.Vat)
                SubM_AddParameter("@iTInt_STATUS", iCls_ImExDetail.Status)
                If FuncM_ExecuteStore("usp_ImportExportDetail") Then
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
