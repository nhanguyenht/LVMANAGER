Public Class cls_Inventory_Update
    Inherits cls_Database_Base
    Public Function FuncG_GetAllData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                'mvStr_Sql = "SELECT InventoryID,InventoryName FROM [TBL_INVENTORY] WHERE LOC_ID = @iNVChr_LOCID ORDER BY [InventoryID]"
                mvStr_Sql = "SELECT InventoryID,InventoryName FROM [TBL_INVENTORY] WHERE InventoryID<>'101' ORDER BY [InventoryID]"
                'SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetAllData2() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                'mvStr_Sql = "SELECT InventoryID,InventoryName FROM [TBL_INVENTORY] WHERE LOC_ID = @iNVChr_LOCID ORDER BY [InventoryID]"
                mvStr_Sql = "SELECT InventoryID,InventoryName FROM [TBL_INVENTORY]  ORDER BY [InventoryID]"
                'SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetAllData3() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                'mvStr_Sql = "SELECT InventoryID,InventoryName FROM [TBL_INVENTORY] WHERE LOC_ID = @iNVChr_LOCID ORDER BY [InventoryID]"
                mvStr_Sql = "SELECT InventoryID,InventoryName FROM [TBL_INVENTORY] WHERE InventoryID<>'999'  ORDER BY [InventoryID]"
                'SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetAllDataByInventory() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT InventoryID,InventoryName FROM [TBL_INVENTORY] WHERE LOC_ID = @iNVChr_LOCID ORDER BY [InventoryID]"
                'mvStr_Sql = "SELECT InventoryID,InventoryName FROM [TBL_INVENTORY] WHERE InventoryID='001' ORDER BY [InventoryID]"
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
End Class
