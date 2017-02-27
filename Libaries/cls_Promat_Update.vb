Public Class cls_Promat_Update
    Inherits cls_Database_Base
#Region "Get promat"
    Public Function FuncG_GetData(ByVal iStr_ID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT P.ITEM_ID AS [MaterialID], M.MaterialName, P.QTY, M.ExportUnit, I.InventoryName"
                mvStr_Sql += "   FROM TBL_PROMAT P INNER JOIN TBL_MATERIAL M ON P.LOC_ID = M.LOC_ID AND P.ITEM_ID = M.MaterialID"
                mvStr_Sql += " LEFT JOIN TBL_INVENTORY I ON P.LOC_ID = I.LOC_ID AND P.InventoryID = I.InventoryID"
                mvStr_Sql += "   WHERE P.LOC_ID = @iNVChr_LOCID AND P.ID = @iNVChr_ID"
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

    
    Public Function FuncG_GetDatainfo(ByVal iStr_ID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM TBL_PROMAT WHERE ITEM_ID  =@iNVChr_ID"
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
    Public Function FuncG_GetDataByID(ByVal iStr_ID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM TBL_PROMAT WHERE ID  =@iNVChr_ID"
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
#Region "Insert Update Delete"
    ' Status 0:Insert - Update, 1:Delete
    Public Function FuncG_InsertUpdateDelete(ByVal iCls_Promat As cls_Promat) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Promat.ID)
                SubM_AddParameter("@iNVChr_ITEMID", iCls_Promat.ItemID)
                SubM_AddParameter("@iFlt_QTY", iCls_Promat.Quantity)
                SubM_AddParameter("@iTInt_STATUS", iCls_Promat.Status)
                SubM_AddParameter("@iNVChr_InventoryID", iCls_Promat.InventoryID)
                If FuncM_ExecuteStore("usp_Promat") Then
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
