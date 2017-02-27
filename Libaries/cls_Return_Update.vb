Public Class cls_Return_Update
    Inherits cls_Database_Base
#Region "Get FuncG_GetMaxCode"
    Public Function FuncG_GetMaxCode() As String
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT MAX(ID) FROM [TBL_ITEM]"
                Return FuncM_ExecuteScalar(mvStr_Sql)
            End If
        Catch ex As Exception
            Return "0"
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return "0"
    End Function
#End Region
#Region "Get Item"
    Public Function FuncG_GetAllData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM [TBL_ITEM] WHERE LOC_ID = @iNVChr_LOCID ORDER BY [ID]"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetAllData(ByVal iStr_GroupID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM [TBL_ITEM] WHERE LOC_ID = @iNVChr_LOCID AND GROUP_ID = @iNVChr_GROUPID ORDER BY CAST ([ID] AS INT)"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_GROUPID", iStr_GroupID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetDataInfo(ByVal iStr_ID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM [TBL_ITEM] WHERE LOC_ID = @iNVChr_LOCID AND [ID] = @iNVChr_ID"
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
#Region "Insert"
    Public Function FuncG_Insert(ByVal iCls_Return As cls_Return) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Return.ID)
                SubM_AddParameter("@iNVChr_ITEMID", iCls_Return.Item)
                SubM_AddParameter("@iFlt_QUANTITY", iCls_Return.Quantity)
                SubM_AddParameter("@iFlt_RETURNQTY", iCls_Return.ReturnQty)
                SubM_AddParameter("@iNVChr_CASHIER", iCls_Return.Cashier)
                If FuncM_ExecuteStore("usp_Return") Then
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
