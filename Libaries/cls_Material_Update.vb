Public Class cls_Material_Update
    Inherits cls_Database_Base
    Public Function FuncG_GetAllData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TBL_MATERIAL .LOC_ID ,TBL_MATERIAL .MaterialID,TBL_MATERIAL.MaterialName,TBL_MATERIAL.ImportUnit,TBL_MATERIAL .ImportToInvRate,TBL_MATERIAL .ExportUnit , TBL_MATERIAL .ExportToInvRate,TBL_MATERIAL .InventoryUnit FROM TBL_MATERIAL    ORDER BY TBL_MATERIAL .MaterialID"
                ' mvStr_Sql = "SELECT TBL_MATERIAL .LOC_ID ,TBL_MATERIAL .MaterialID,TBL_MATERIAL.MaterialName,TBL_MATERIAL.ImportUnit,TBL_MATERIAL .ImportToInvRate,TBL_MATERIAL .ExportUnit , TBL_MATERIAL .ExportToInvRate,TBL_MATERIAL .InventoryUnit FROM TBL_MATERIAL INNER JOIN TBL_PROMAT ON TBL_MATERIAL .MaterialID = TBL_PROMAT .ITEM_ID  "
                'mvStr_Sql = "SELECT * FROM [TBL_MATERIAL] WHERE LOC_ID = @iNVChr_LOCID ORDER BY [MaterialName]"
                'SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                'SubM_AddParameter("@InventoryID", iStr_InvoiceID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetAllDataByInventoryID(ByVal iStr_InventoryID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                ' mvStr_Sql = "SELECT * FROM TBL_MATERIAL INNER JOIN TBL_PROMAT ON TBL_MATERIAL .MaterialID = TBL_PROMAT .ITEM_ID   ORDER BY TBL_MATERIAL .MaterialID"
                mvStr_Sql = "SELECT TBL_MATERIAL .LOC_ID ,TBL_MATERIAL .MaterialID,TBL_MATERIAL.MaterialName,TBL_MATERIAL.ImportUnit,TBL_MATERIAL .ImportToInvRate,TBL_MATERIAL .ExportUnit , TBL_MATERIAL .ExportToInvRate,TBL_MATERIAL .InventoryUnit FROM TBL_MATERIAL INNER JOIN Stock_Reports ON TBL_MATERIAL .MaterialID = Stock_Reports .MaterialID WHERE InventoryID = @InventoryID GROUP BY TBL_MATERIAL .LOC_ID ,TBL_MATERIAL .MaterialID,TBL_MATERIAL.MaterialName,TBL_MATERIAL.ImportUnit,TBL_MATERIAL .ImportToInvRate,TBL_MATERIAL .ExportUnit , TBL_MATERIAL .ExportToInvRate,TBL_MATERIAL .InventoryUnit "
                'mvStr_Sql = "SELECT * FROM [TBL_MATERIAL] WHERE LOC_ID = @iNVChr_LOCID ORDER BY [MaterialName]"
                'SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@InventoryID", iStr_InventoryID)
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
                'mvStr_Sql = "SELECT TBL_MATERIAL .LOC_ID ,TBL_MATERIAL .MaterialID,TBL_MATERIAL.MaterialName,TBL_MATERIAL.ImportUnit,TBL_MATERIAL .ImportToInvRate,TBL_MATERIAL .ExportUnit , TBL_MATERIAL .ExportToInvRate,TBL_MATERIAL .InventoryUnit"
                'mvStr_Sql += " FROM TBL_MATERIAL LEFT JOIN  TBL_PROMAT ON TBL_MATERIAL .MaterialID = TBL_PROMAT .ITEM_ID  "
                'mvStr_Sql += " where   TBL_MATERIAL.MaterialID is not null  and (TBL_PROMAT.InventoryID is null or TBL_PROMAT .InventoryID <>'101') AND TBL_MATERIAL.LOC_ID=@iNVChr_LOCID GROUP BY TBL_MATERIAL .LOC_ID ,TBL_MATERIAL .MaterialID,TBL_MATERIAL.MaterialName,TBL_MATERIAL.ImportUnit,TBL_MATERIAL .ImportToInvRate,TBL_MATERIAL .ExportUnit , TBL_MATERIAL .ExportToInvRate,TBL_MATERIAL .InventoryUnit"
                'mvStr_Sql += " ORDER BY MaterialID"
                mvStr_Sql = "SELECT TBL_MATERIAL .LOC_ID ,TBL_MATERIAL .MaterialID,TBL_MATERIAL.MaterialName,TBL_MATERIAL.ImportUnit,TBL_MATERIAL .ImportToInvRate,TBL_MATERIAL .ExportUnit , TBL_MATERIAL .ExportToInvRate,TBL_MATERIAL .InventoryUnit FROM TBL_MATERIAL INNER JOIN Stock_Reports ON TBL_MATERIAL .MaterialID = Stock_Reports .MaterialID GROUP BY TBL_MATERIAL .LOC_ID ,TBL_MATERIAL .MaterialID,TBL_MATERIAL.MaterialName,TBL_MATERIAL.ImportUnit,TBL_MATERIAL .ImportToInvRate,TBL_MATERIAL .ExportUnit , TBL_MATERIAL .ExportToInvRate,TBL_MATERIAL .InventoryUnit "
                'mvStr_Sql = "SELECT * FROM [TBL_MATERIAL] WHERE LOC_ID = @iNVChr_LOCID ORDER BY [MaterialName]"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                'SubM_AddParameter("@iStr_InventoryID", iStr_InventoryID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function

    Public Function FuncG_GetMaterialByName(ByVal iStr_Name As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT *"
                mvStr_Sql += "  FROM [TBL_MATERIAL] WHERE MaterialName LIKE @iNVChr_NAME ORDER BY MaterialName"
                'mvStr_Sql += "  FROM [TBL_MATERIAL] WHERE LOC_ID = @iNVChr_LOCID AND MaterialName LIKE @iNVChr_NAME ORDER BY MaterialName"
                'SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_NAME", "%" & iStr_Name & "%")
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function

    Public Function FuncG_Insert(ByVal iCls_Material As cls_Material, ByVal iBol_Update As Boolean) As String
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@LOC_ID", gvStr_LocID)
                'SubM_AddParameter("@LOC_ID", iCls_Material.LOC_ID)
                SubM_AddParameter("@MaterialID", iCls_Material.MaterialID)
                SubM_AddParameter("@MaterialName", iCls_Material.MaterialName)
                SubM_AddParameter("@ImportUnit", iCls_Material.ImportUnit)
                SubM_AddParameter("@ImportToInvRate", iCls_Material.ImportToInvRate)
                SubM_AddParameter("@ExportUnit", iCls_Material.ExportUnit)
                SubM_AddParameter("@ExportToInvRate", iCls_Material.ExportToInvRate)
                SubM_AddParameter("@InventoryUnit", iCls_Material.InventoryUnit)
                SubM_AddParameter("@IsUpdate", iBol_Update)
                If FuncM_ExecuteStore("sp_InsertUpdateMaterial") Then
                    Return String.Empty
                Else
                    Return "Không thể cập nhật"
                End If
            End If
        Catch ex As Exception
            Return ex.Message
        Finally
            FuncM_CloseConnection()
        End Try
    End Function
    Public Function FuncG_GetMaterialPrice(ByVal iStr_Name As String) As String
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT max(PRICE) as price"
                mvStr_Sql += "  FROM TBL_IMPORTEXPORTDETAIL WHERE LOC_ID = @iNVChr_LOCID AND ITEM_ID=@iNVChr_NAME"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_NAME", iStr_Name)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale.Rows(0)(0).ToString()
    End Function
    Public Function FuncG_GetTBL_STOCK_Price(ByVal iStr_Name As String) As String
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT max(PRICE) as price"
                mvStr_Sql += "  FROM TBL_STOCK WHERE LOC_ID = @iNVChr_LOCID AND ID=@iNVChr_NAME"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_NAME", iStr_Name)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale.Rows(0)(0).ToString()
    End Function
    Public Sub FuncG_DeleteMaterial(ByVal iStr_ID As String)
        Const query As String = "DELETE FROM TBL_MATERIAL  WHERE MaterialID =@MaterialID AND LOC_ID =@LOC_ID"
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@MaterialID", iStr_ID)
                SubM_AddParameter("@LOC_ID", gvStr_LocID)
                FuncM_ExecuteNonQuery(query)

            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try

    End Sub
End Class
