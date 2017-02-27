Public Class cls_Stock_Update
    Inherits cls_Database_Base
#Region "Get Data"
    Public Function FuncG_GetAllData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT S.ID AS [Mã hàng], M.MaterialName AS [Tên hàng], S.QUANTITY AS [Số lượng],"
                mvStr_Sql += "  S.PRICE AS [Đơn giá], S.TOTAL AS [Thành tiền], S.InventoryID AS [Kho],S.Unit AS [DVT]"
                mvStr_Sql += "  FROM TBL_STOCK s INNER JOIN TBL_MATERIAL M ON S.LOC_ID = S.LOC_ID AND S.ID = M.MaterialID"
                mvStr_Sql += "  WHERE S.LOC_ID = @iNVChr_LOCID ORDER BY S.ID"
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
    Public Function FuncG_GetGiaVon(ByVal FROMDAY As DateTime, ByVal TODAY As DateTime) As Double
        Dim GIAVON As Double
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT SUM(Items * Price) AS GIAVON  FROM [Stock_Details]  WHERE InventoryID ='999' and TranDate between @fROMDAY and @tODAY"

                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@fROMDAY", FROMDAY)
                SubM_AddParameter("@TODAY", TODAY)
                GIAVON = FuncM_ExecuteScalar(mvStr_Sql)
            End If
        Catch ex As Exception
            GIAVON = 0

        Finally
            FuncM_CloseConnection()
        End Try
        Return GIAVON
    End Function
    Public Function FuncG_GetAllDataStock_Reports() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT     dbo.TBL_MATERIAL.MaterialName AS [Tên hàng], dbo.v_Stock_Reports.MaterialID AS [Mã hàng], dbo.v_Stock_Reports.Quantity AS [Số lượng], dbo.v_Stock_Reports.AvgPrice AS [Đơn giá], dbo.v_Stock_Reports.InventoryID , dbo.TBL_MATERIAL.ImportUnit AS DVT, dbo.TBL_INVENTORY.InventoryName AS Kho "
                mvStr_Sql += "   FROM        dbo.v_Stock_Reports INNER JOIN dbo.TBL_INVENTORY ON dbo.v_Stock_Reports.InventoryID = dbo.TBL_INVENTORY.InventoryID LEFT OUTER JOIN dbo.TBL_MATERIAL ON dbo.v_Stock_Reports.MaterialID = dbo.TBL_MATERIAL.MaterialID  "
                mvStr_Sql += "  WHERE v_Stock_Reports.LOC_ID = @iNVChr_LOCID ORDER BY InventoryID   "
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
    Public Function FuncG_GetAllDataStock_Reports(ByVal iStr_Name As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT     dbo.TBL_MATERIAL.MaterialName AS [Tên hàng], dbo.v_Stock_Reports.MaterialID AS [Mã hàng], dbo.v_Stock_Reports.Quantity AS [Số lượng], dbo.v_Stock_Reports.AvgPrice AS [Đơn giá], dbo.v_Stock_Reports.InventoryID , dbo.TBL_MATERIAL.ImportUnit AS DVT, dbo.TBL_INVENTORY.InventoryName AS Kho "
                mvStr_Sql += "   FROM        dbo.v_Stock_Reports INNER JOIN dbo.TBL_INVENTORY ON dbo.v_Stock_Reports.InventoryID = dbo.TBL_INVENTORY.InventoryID LEFT OUTER JOIN dbo.TBL_MATERIAL ON dbo.v_Stock_Reports.MaterialID = dbo.TBL_MATERIAL.MaterialID  "
                mvStr_Sql += "  WHERE v_Stock_Reports.LOC_ID = @iNVChr_LOCID AND dbo.TBL_MATERIAL.MaterialName LIKE @iNVChr_NAME ORDER BY TBL_MATERIAL.MaterialID  "
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
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
    Public Function FuncG_UpdateQuantity(ByVal iStr_ID As String) As Boolean
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
    Public Function FuncG_GetMaterialByName(ByVal iStr_Name As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT S.ID AS [Mã hàng], M.MaterialName AS [Tên hàng], S.QUANTITY AS [Số lượng],"
                mvStr_Sql += "  S.PRICE AS [Đơn giá], S.TOTAL AS [Thành tiền], S.InventoryID AS [Kho]"
                mvStr_Sql += "  FROM TBL_STOCK s INNER JOIN TBL_MATERIAL M ON S.LOC_ID = S.LOC_ID AND S.ID = M.MaterialID"
                mvStr_Sql += "  WHERE S.LOC_ID = @iNVChr_LOCID ORDER BY S.ID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
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
    Public Function FuncG_GetInfo(ByVal iStr_MaHang As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                'mvStr_Sql = "SELECT TBL_STOCK.ID AS [Mã hàng], TBL_ITEM.NAME AS [Tên hàng], TBL_STOCK.QUANTITY AS [Số lượng],"
                'mvStr_Sql += "  TBL_STOCK.PRICE AS [Đơn giá], TBL_STOCK.TOTAL AS [Thành tiền]"
                'mvStr_Sql += "  FROM TBL_STOCK INNER JOIN TBL_ITEM ON TBL_STOCK.LOC_ID = TBL_ITEM.LOC_ID AND TBL_STOCK.ID = TBL_ITEM.ID"
                'mvStr_Sql += "  WHERE TBL_STOCK.LOC_ID = @iNVChr_LOCID AND TBL_STOCK.ID = @iNVChr_ID"
                mvStr_Sql = "SELECT TBL_STOCK.ID AS [Mã hàng], TBL_MATERIAL.MaterialName  AS [Tên hàng], TBL_STOCK.QUANTITY AS [Số lượng],  TBL_STOCK.PRICE AS [Đơn giá], TBL_STOCK.TOTAL AS [Thành tiền]  "
                mvStr_Sql += "  FROM TBL_STOCK INNER JOIN TBL_MATERIAL  ON TBL_STOCK.LOC_ID = TBL_MATERIAL .LOC_ID AND TBL_STOCK.ID = TBL_MATERIAL.MaterialID "
                mvStr_Sql += "  WHERE TBL_STOCK.LOC_ID =@iNVChr_LOCID AND TBL_STOCK.ID = @iNVChr_ID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iStr_MaHang)
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
#Region "Update Delete"
    Public Function FuncG_UpdateDelete(ByVal iCls_Stock As cls_Stock, ByVal iTint_Action As Byte) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Stock.ID)
                SubM_AddParameter("@iNVChr_InventoryID", iCls_Stock.InventoryID)
                SubM_AddParameter("@iNVChr_Unit", iCls_Stock.Unit)
                SubM_AddParameter("@iFlt_QUANTITY", iCls_Stock.Quantity)
                SubM_AddParameter("@iFlt_PRICE", iCls_Stock.Price)
                SubM_AddParameter("@iTInt_UpdatedType", iCls_Stock.UpdatedType)
                SubM_AddParameter("@iTInt_Action", iTint_Action)
                If FuncM_ExecuteStore("usp_Stock") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            ''Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function
    
#End Region
End Class
