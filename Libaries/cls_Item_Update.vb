Public Class cls_Item_Update
    Inherits cls_Database_Base
#Region "Get FuncG_GetMaxCode"
    Public Function FuncG_GetMaxCode() As String
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT MAX(CAST(ID AS BIGINT)) FROM [TBL_ITEM]"
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
    Public Function FuncG_GetMaxMaterial() As String
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT MAX(CAST(ID AS BIGINT)) FROM [TBL_ITEM] WHERE CAST(ID AS BIGINT) > 1000000000"
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
                If mvDataTale.Rows(0)(0) Is DBNull.Value Then
                    Return "1000000001"
                Else
                    Return (mvDataTale.Rows(0)(0) + 1).ToString
                End If
            End If
        Catch ex As Exception
            Return "1000000001"
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return "100001"
    End Function
#End Region
#Region "Get Item"
    Public Function FuncG_GetAllData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM [TBL_ITEM] WHERE LOC_ID = @iNVChr_LOCID AND ID<>'899' ORDER BY [ID]"
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

    
    Public Function FuncG_GetDataByName(ByVal iStr_Name As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID AS [Mã hàng], NAME AS [Tên hàng], UNIT AS [Đơn vị], PRICE1 AS [Đơn giá] "
                mvStr_Sql += "  FROM [TBL_ITEM] WHERE NAME != '' AND LOC_ID = @iNVChr_LOCID AND ID<>'899' AND CAST([ID] AS BIGINT) <= 1920  AND NAME LIKE @iNVChr_NAME"
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


    Public Function FuncG_GetAllData1() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID AS [Mã hàng], NAME AS [Tên hàng], UNIT AS [Đơn vị], PRICE1 AS [Đơn giá] "
                mvStr_Sql += "  FROM [TBL_ITEM] WHERE LOC_ID = @iNVChr_LOCID ORDER BY CAST([ID] AS BIGINT)"
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
    Public Function FuncG_GetPromatItem() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID AS [Mã hàng], NAME AS [Tên hàng], UNIT AS [Đơn vị], PRICE1 AS [Đơn giá] "
                mvStr_Sql += "  FROM [TBL_ITEM] WHERE LOC_ID = @iNVChr_LOCID AND PROMAT = 1 ORDER BY CAST([ID] AS BIGINT)"
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
    Public Function FuncG_GetAllData2() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID AS [Mã hàng], NAME AS [Tên hàng], UNIT AS [Đơn vị], PRICE1 AS [Đơn giá] "
                mvStr_Sql += "  FROM [TBL_ITEM] WHERE NAME != '' AND CAST([ID] AS BIGINT) <= 1920   ORDER BY  CAST([ID] AS BIGINT)" 'PRINTER ASC"
                'mvStr_Sql = "SELECT ID AS [Mã hàng], NAME AS [Tên hàng], UNIT AS [Đơn vị], PRICE1 AS [Đơn giá] "
                'mvStr_Sql += "  FROM [TBL_ITEM] WHERE LOC_ID = @iNVChr_LOCID AND CAST([ID] AS BIGINT) <= 960 ORDER BY CAST([ID] AS BIGINT)"
                '  SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetAllByInventory() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = " SELECT TBL_ITEM.ID AS [Mã hàng], NAME AS [Tên hàng] "
                mvStr_Sql += " FROM TBL_ITEM LEFT JOIN TBL_PROMAT ON TBL_ITEM .ID = TBL_PROMAT .ID  WHERE NAME != '' AND(TBL_PROMAT .InventoryID IS NULL OR TBL_PROMAT .InventoryID<>'101' )  AND CAST(TBL_ITEM.ID AS BIGINT) <= 1920  GROUP BY TBL_ITEM.ID,TBL_ITEM.NAME ORDER BY  CAST(TBL_ITEM.ID AS BIGINT)" 'PRINTER ASC"
                'mvStr_Sql = " SELECT TBL_ITEM.ID AS [Mã hàng], NAME AS [Tên hàng] "
                'mvStr_Sql += " FROM TBL_ITEM LEFT JOIN TBL_PROMAT ON TBL_ITEM .ID = TBL_PROMAT .ID  WHERE NAME != '' AND(TBL_PROMAT .InventoryID IS NULL OR TBL_PROMAT .InventoryID='001' )  AND CAST(TBL_ITEM.ID AS BIGINT) <= 960   ORDER BY  CAST(TBL_ITEM.ID AS BIGINT)" 'PRINTER ASC"
                ''mvStr_Sql = "SELECT ID AS [Mã hàng], NAME AS [Tên hàng], UNIT AS [Đơn vị], PRICE1 AS [Đơn giá] "
                'mvStr_Sql += "  FROM [TBL_ITEM] WHERE LOC_ID = @iNVChr_LOCID AND CAST([ID] AS BIGINT) <= 960 ORDER BY CAST([ID] AS BIGINT)"
                '  SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetAllDataBYInventory() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TBL_ITEM.ID AS [Mã hàng], NAME AS [Tên hàng], UNIT AS [Đơn vị], PRICE1 AS [Đơn giá] "
                mvStr_Sql += " FROM TBL_ITEM LEFT JOIN TBL_PROMAT ON TBL_ITEM .ID = TBL_PROMAT .ID  WHERE NAME != '' AND(TBL_PROMAT .InventoryID IS NULL OR TBL_PROMAT .InventoryID='001' )  AND CAST(TBL_ITEM.ID AS BIGINT) <= 1920   ORDER BY  CAST(TBL_ITEM.ID AS BIGINT)" 'PRINTER ASC"
                'mvStr_Sql = "SELECT ID AS [Mã hàng], NAME AS [Tên hàng], UNIT AS [Đơn vị], PRICE1 AS [Đơn giá] "
                'mvStr_Sql += "  FROM [TBL_ITEM] WHERE LOC_ID = @iNVChr_LOCID AND CAST([ID] AS BIGINT) <= 960 ORDER BY CAST([ID] AS BIGINT)"
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
    Public Function FuncG_GetAllMaterial() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID AS [Mã hàng], NAME AS [Tên hàng], UNIT AS [Đơn vị]"
                mvStr_Sql += "  FROM [TBL_ITEM] WHERE LOC_ID = @iNVChr_LOCID AND CAST([ID] AS BIGINT) <= 1920 ORDER BY CAST([ID] AS BIGINT)"
                'mvStr_Sql += "  FROM [TBL_ITEM] WHERE LOC_ID = @iNVChr_LOCID AND CAST([ID] AS BIGINT) > 1000000000 ORDER BY CAST([ID] AS BIGINT)"
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


    Public Function FuncG_GetMaterialByName(ByVal iStr_Name As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID AS [Mã hàng], NAME AS [Tên hàng], UNIT AS [Đơn vị]"
                mvStr_Sql += "  FROM [TBL_ITEM] WHERE LOC_ID = @iNVChr_LOCID AND CAST([ID] AS BIGINT) <= 1920 AND NAME LIKE @iNVChr_NAME ORDER BY CAST([ID] AS BIGINT)"
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

    Public Function FuncG_GetAllMaterial1() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID AS [Mã hàng], NAME AS [Tên hàng], UNIT AS [Đơn vị], PRICE1 AS [Đơn giá]"
                mvStr_Sql += "  FROM [TBL_ITEM] WHERE LOC_ID = @iNVChr_LOCID AND CAST([ID] AS BIGINT) <= 1920 ORDER BY CAST([ID] AS BIGINT)"
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
                mvStr_Sql = "SELECT * FROM [TBL_ITEM] WHERE LOC_ID = @iNVChr_LOCID AND GROUP_ID = @iNVChr_GROUPID AND ID<>'899' ORDER BY CAST ([ID] AS INT)"
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
#Region "Update Item"
    Public Function FuncG_UpdateItem(ByVal iCls_Item As cls_Item, ByVal iFlag As Byte) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Item.ID)
                SubM_AddParameter("@iNVChr_NAME", iCls_Item.Name)
                SubM_AddParameter("@iFlt_PRICE1", iCls_Item.Price1)
                SubM_AddParameter("@iFlt_PRICE2", iCls_Item.Price2)
                SubM_AddParameter("@iFlt_PRICE3", iCls_Item.Price3)
                SubM_AddParameter("@iFlt_PRICE4", iCls_Item.Price4)
                SubM_AddParameter("@iFlt_PRICE5", iCls_Item.Price5)
                SubM_AddParameter("@iNVChr_UNIT", iCls_Item.Unit)
                SubM_AddParameter("@iNVChr_PRINTER", iCls_Item.Printer)
                SubM_AddParameter("@iTInt_PRINT", iCls_Item.Print)
                SubM_AddParameter("@iTInt_STATUS", iCls_Item.Status)
                SubM_AddParameter("@iTInt_PROMAT", iCls_Item.Promat)
                SubM_AddParameter("@iInt_COLOR", iCls_Item.Color)
                SubM_AddParameter("@iTInt_Flag", iFlag)

                ''Add 2013/12/19 by Van Long
                'SubM_AddParameter("@iIMG_IMAGE1", iCls_Item.Image1)
                'SubM_AddParameter("@iIMG_IMAGE2", iCls_Item.Image2)
                'SubM_AddParameter("@iIMG_IMAGE3", iCls_Item.Image3)
                'SubM_AddParameter("@iIMG_IMAGE4", iCls_Item.Image4)
                'SubM_AddParameter("@iIMG_IMAGE5", iCls_Item.Image5)

                SubM_AddParameter("@iIMG_IMAGE1", "0")
                SubM_AddParameter("@iIMG_IMAGE2", "0")
                SubM_AddParameter("@iIMG_IMAGE3", "0")
                SubM_AddParameter("@iIMG_IMAGE4", "0")
                SubM_AddParameter("@iIMG_IMAGE5", "0")

                SubM_AddParameter("@iNVChr_DESCRIPTION", iCls_Item.Description)
                SubM_AddParameter("@iNVChr_TYPE", iCls_Item.TYPE)

                If FuncM_ExecuteStore("usp_Item") Then
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
    Public Function FuncG_Material(ByVal iCls_Item As cls_Item) As Boolean
        Try
            'Status 0 : Insert, else Update
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Item.ID)
                SubM_AddParameter("@iNVChr_NAME", iCls_Item.Name)
                SubM_AddParameter("@iNVChr_UNIT", iCls_Item.Unit)
                SubM_AddParameter("@iTInt_STATUS", iCls_Item.Status)
                If FuncM_ExecuteStore("usp_Material") Then
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

    Public Function FuncG_GetAllData_Item() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT i.id as ID, i.NAME AS [Tên món], g.name as [Nhóm món],i.UNIT as ĐVT"
                mvStr_Sql += " from dbo.TBL_ITEM i join dbo.TBL_MENUGROUPITEM g on i.GROUP_ID = g.ID"
                mvStr_Sql += " where i.STATUS = 1  and i.name <> '' and g.name <> '' and i.type <>1 "
                mvStr_Sql += " group by i.NAME, g.name ,i.UNIT,i.id"
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

    Public Function FuncG_GetAllData_Item_Item(ByVal item_ID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT i.id as ID,i.Price1 as [Giá], i.NAME AS [Tên món] , g.name as [Nhóm món],ii.NUMBER as [SL], i.UNIT as ĐVT"
                mvStr_Sql += " from dbo.TBL_ITEM i join "
                mvStr_Sql += " dbo.TBL_ITEM_ITEM ii on i.id = ii.ITEM2_ID join"
                mvStr_Sql += " dbo.TBL_MENUGROUPITEM g on i.GROUP_ID = g.ID"
                mvStr_Sql += " where ii.STATUS = 1 and ii.ITEM_ID = @item_ID"
                mvStr_Sql += " group by g.name ,i.NAME, i.UNIT,i.id,ii.NUMBER,i.Price1"

                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@item_ID", item_ID)

                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function

    Public Function FuncG_InsertOrUpdate_Item_Item(ByVal Item1_ID As String, ByVal Item2_ID As String, ByVal Number As Double) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID_1", Item1_ID)
                SubM_AddParameter("@iNVChr_ID_2", Item2_ID)
                SubM_AddParameter("@iFlt_Number", Number)

                If FuncM_ExecuteStore("usp_InsertOrUpDate_Item_Item") Then
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

    Public Function FuncG_Delete_Item_Item(ByVal Item1_ID As String, ByVal Item2_ID As String) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID_1", Item1_ID)
                SubM_AddParameter("@iNVChr_ID_2", Item2_ID)

                If FuncM_ExecuteStore("usp_Delete_Item_Item") Then
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

    Public Function FuncG_DeleteAll_Item_Item(ByVal Item1_ID As String) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID_1", Item1_ID)

                If FuncM_ExecuteStore("usp_DeleteAll_Item_Item") Then
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
#End Region
End Class
