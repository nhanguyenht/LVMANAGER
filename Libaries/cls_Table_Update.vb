Public Class cls_Table_Update
    Inherits cls_Database_Base
#Region "Count table"
    Public Function FuncG_CountTable(ByVal iByte_Status As Byte) As Integer
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT COUNT(TBL_TABLE.ID) FROM [TBL_TABLE] INNER JOIN"
                mvStr_Sql += "  TBL_AREA ON TBL_TABLE.LOC_ID = TBL_AREA.LOC_ID AND TBL_TABLE.AREA_ID = TBL_AREA.ID"
                mvStr_Sql += "  WHERE TBL_TABLE.LOC_ID = @iNVChr_LOCID AND TBL_TABLE.STATUS = @iTInt_STATUS AND TBL_AREA.STATUS <> 0"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iTInt_STATUS", iByte_Status)
                Return FuncM_ExecuteScalar(mvStr_Sql)
            End If
        Catch ex As Exception
            Return 0
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return 0
    End Function
    Public Function FuncG_CountTable(ByVal iStr_AreaID As String, ByVal iByte_Status As Byte) As Integer
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT COUNT(TBL_TABLE.ID) FROM [TBL_TABLE] INNER JOIN"
                mvStr_Sql += "  TBL_AREA ON TBL_TABLE.LOC_ID = TBL_AREA.LOC_ID AND TBL_TABLE.AREA_ID = TBL_AREA.ID"
                mvStr_Sql += "  WHERE TBL_TABLE.LOC_ID = @iNVChr_LOCID AND TBL_TABLE.STATUS = @iTInt_STATUS AND TBL_TABLE.AREA_ID = @iNVChr_AREAID AND TBL_AREA.STATUS <> 0"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_AREAID", iStr_AreaID)
                SubM_AddParameter("@iTInt_STATUS", iByte_Status)
                Return FuncM_ExecuteScalar(mvStr_Sql)
            End If
        Catch ex As Exception
            Return 0
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return 0
    End Function
#End Region
#Region "Get Data"
    Public Function FuncG_GetData(ByVal iStr_AreaID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM [TBL_TABLE] WHERE LOC_ID = @iNVChr_LOCID AND AREA_ID = @iNVChr_AREAID ORDER BY [ID]"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_AREAID", iStr_AreaID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function


    Public Function FuncG_GetTongtien(ByVal iStr_TableID As String) As Decimal
        Dim mvDataTale As New DataTable
        Dim tongtien As Decimal
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "(select ISNULL((SUM(QUANTITY * PRICE + (QUANTITY * PRICE * (ISNULL(VAT,0) + ISNULL(SERVICE,0) - ISNULL(DISCOUNT,0)) /100))),0) FROM TBL_SALES_DETAIL AS sd WHERE  [ID] = (select TOP 1 ID from TBL_SALES where TABLE_ID='" + iStr_TableID + "' AND STATUS <>0 and CHECK_OUT is null ORDER BY CREATEDATE DESC )) "

                tongtien = FuncM_ExecuteScalar(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return tongtien
    End Function
    Public Function FuncG_GetDataAble(ByVal iStr_AreaID As String, ByVal iStr_TableID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then


                mvStr_Sql = "SELECT DISTINCT TBL_TABLE.ID, SUM(PRICE*QUANTITY) as tongtien,TBL_TABLE .STATUS,TBL_TABLE .NAME,AREA_ID  "
                mvStr_Sql += " FROM (TBL_TABLE INNER JOIN TBL_AREA  ON TBL_AREA .ID = TBL_TABLE .AREA_ID ) LEFT JOIN(TBL_SALES INNER JOIN TBL_SALES_DETAIL ON TBL_SALES .ID = TBL_SALES_DETAIL .ID )ON TBL_TABLE .ID = TBL_SALES .TABLE_ID "
                mvStr_Sql += " WHERE (TBL_TABLE .STATUS >0 AND AREA_ID = @AreaID) AND  TBL_SALES .CHECK_OUT IS NULL AND TABLE_ID =@Table_id"
                mvStr_Sql += " GROUP BY TBL_TABLE .ID,TBL_SALES.ID,TBL_TABLE .STATUS,TBL_TABLE .NAME,AREA_ID ORDER BY TBL_TABLE .ID  "
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@AreaID", iStr_AreaID)
                SubM_AddParameter("@Table_id", iStr_TableID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetDataTBSales(ByVal iNT_START As Integer, ByVal iNT_END As Integer) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then


                mvStr_Sql = "SELECT TABLE_ID , SUM(PRICE*QUANTITY ) AS TONGTIEN "
                mvStr_Sql += " FROM TBL_SALES INNER JOIN TBL_SALES_DETAIL  ON TBL_SALES .ID = TBL_SALES_DETAIL .ID"
                mvStr_Sql += " WHERE TBL_SALES .CHECK_OUT IS NULL and TABLE_ID BETWEEN @iNT_START AND @iNT_END"
                mvStr_Sql += " GROUP BY TABLE_ID ORDER BY TABLE_ID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNT_START", iNT_START)
                SubM_AddParameter("@iNT_END", iNT_END)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetDataTABLE(ByVal iStr_AreaID As String, ByVal iStr_TableID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then


                mvStr_Sql = "SELECT *,(select ISNULL((SUM(QUANTITY * PRICE + (QUANTITY * PRICE * (ISNULL(VAT,0) + ISNULL(SERVICE,0) - ISNULL(DISCOUNT,0)) /100))),0) FROM TBL_SALES_DETAIL AS sd WHERE LOC_ID = '01' AND [ID] = (select TOP 1 ID from TBL_SALES where TABLE_ID=t.ID AND STATUS IN(2,3) ORDER BY CREATEDATE DESC)) as tongtien "
                mvStr_Sql += "  FROM [TBL_TABLE]  AS t "
                mvStr_Sql += "   WHERE LOC_ID = @iNVChr_LOCID AND AREA_ID = @iNVChr_AREAID  "
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_AREAID", iStr_AreaID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetDataMaTen(ByVal iStr_AreaID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID as [Mã], Name as [Tên Bàn] FROM [TBL_TABLE] WHERE LOC_ID = @iNVChr_LOCID AND AREA_ID = @iNVChr_AREAID AND STATUS=1 ORDER BY [ID]"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_AREAID", iStr_AreaID)
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
                mvStr_Sql = "SELECT * FROM [TBL_TABLE] WHERE LOC_ID = @iNVChr_LOCID AND [ID] = @iNVChr_ID ORDER BY [ID]"
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
#Region "Insert - Update"
    Public Function FuncG_InsertUpdateDelete(ByVal iCls_Table As cls_Table) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iInt_ID", iCls_Table.ID)
                SubM_AddParameter("@iNVChr_NAME", iCls_Table.Name)
                SubM_AddParameter("@iTInt_STATUS", iCls_Table.Status)
                If FuncM_ExecuteStore("usp_Table") Then
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
    Public Function FuncG_usp_Table_status(ByVal iCls_Table As cls_Table) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iInt_ID", iCls_Table.ID)
                SubM_AddParameter("@iNVChr_NAME", iCls_Table.Name)
                SubM_AddParameter("@iTInt_STATUS", iCls_Table.Status)
                If FuncM_ExecuteStore("usp_Table_status") Then
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
