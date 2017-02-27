Imports System.Data
Imports System.Data.SqlClient
Public Class cls_Report_Update
    Inherits cls_Database_Base
#Region "Report Total"
    Public Function FuncG_Total(ByVal iDate_From As Date, ByVal iDate_To As Date) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@LOC_ID", gvStr_LocID)
                SubM_AddParameter("@FROM_DATE", iDate_From)
                SubM_AddParameter("@TO_DATE", iDate_To)
                If FuncM_ExecuteStore("usp_SOTONGHOP") Then
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

#Region ""
    Public Function FuncG_GetMaterial(ByVal iDate_From As Date, ByVal iDate_To As Date, ByVal InventoryID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try

            mvStr_Sql = " SELECT TMB.LOC_ID,TMB.InventoryID,TMB.MaterialID AS MANL,TMB.MaterialName AS TENNL,sum(TMB.SLTON) as SLTON,TMB.TranCode,TMB.ImportUnit AS DVT,SUM(TMB.Items) AS SLBAN,sum(TMB.NGUYENLIEUTIEUHAO) as NGUYENLIEUTIEUHAO FROM ( "
            mvStr_Sql += " SELECT r.LOC_ID, r.InventoryID, r.MaterialID, SUM(r.Quantity) AS SLTON, dbo.TBL_MATERIAL.MaterialName,dbo.Stock_Details.Items, "
            mvStr_Sql += " dbo.Stock_Details.TranCode, dbo.TBL_MATERIAL.ImportUnit ,(dbo.Stock_Details.Items *dbo.TBL_PROMAT.QTY) AS NGUYENLIEUTIEUHAO"
            mvStr_Sql += " FROM         dbo.Stock_Reports AS r INNER JOIN"
            mvStr_Sql += " dbo.TBL_MATERIAL ON r.LOC_ID = dbo.TBL_MATERIAL.LOC_ID AND r.MaterialID = dbo.TBL_MATERIAL.MaterialID INNER JOIN"
            mvStr_Sql += " dbo.Stock_Details ON r.LOC_ID = dbo.Stock_Details.LOC_ID AND r.MaterialID = dbo.Stock_Details.MaterialID"
            mvStr_Sql += " INNER JOIN dbo.TBL_PROMAT ON dbo.TBL_MATERIAL.MaterialID = dbo.TBL_PROMAT.ITEM_ID"
            mvStr_Sql += " WHERE     (r.Quantity <> 0) AND dbo.Stock_Details.TranCode='OUT' AND  R.InventoryID=@nvr_InventoryID   AND dbo.Stock_Details.ItemID IS NULL  AND (dbo.Stock_Details.TranDate  between @fromday AND @today)"
            mvStr_Sql += " GROUP BY r.LOC_ID, r.InventoryID, r.MaterialID, dbo.TBL_MATERIAL.MaterialName,  dbo.Stock_Details.TranCode, dbo.TBL_MATERIAL.ImportUnit,dbo.Stock_Details.Items, dbo.TBL_PROMAT.QTY)"
            mvStr_Sql += " TMB  GROUP BY TMB.LOC_ID,TMB.InventoryID,TMB.MaterialID,TMB.MaterialName,TMB.TranCode,TMB.ImportUnit"
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@LOC_ID", gvStr_LocID)
                SubM_AddParameter("@fromday", iDate_From)
                SubM_AddParameter("@today", iDate_To)
                SubM_AddParameter("@nvr_InventoryID", InventoryID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
            Return mvDataTale
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetMaterial(ByVal iDate_From As Date, ByVal iDate_To As Date) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try

            mvStr_Sql = " SELECT TMB.LOC_ID,TMB.InventoryID,TMB.MaterialID AS MANL,TMB.MaterialName AS TENNL,TMB.SLTON,TMB.TranCode,TMB.Unit AS DVT,SUM(TMB.Items) AS SLBAN FROM ( "
            mvStr_Sql += " SELECT r.LOC_ID, r.InventoryID, r.MaterialID, SUM(r.Quantity) AS SLTON, dbo.TBL_MATERIAL.MaterialName,dbo.Stock_Details.Items, "
            mvStr_Sql += " dbo.Stock_Details.TranCode, dbo.Stock_Details.Unit"
            mvStr_Sql += " FROM         dbo.Stock_Reports AS r INNER JOIN"
            mvStr_Sql += " dbo.TBL_MATERIAL ON r.LOC_ID = dbo.TBL_MATERIAL.LOC_ID AND r.MaterialID = dbo.TBL_MATERIAL.MaterialID INNER JOIN"
            mvStr_Sql += " dbo.Stock_Details ON r.LOC_ID = dbo.Stock_Details.LOC_ID AND r.MaterialID = dbo.Stock_Details.MaterialID"
            mvStr_Sql += " WHERE     (r.Quantity <> 0) AND dbo.Stock_Details.TranCode='OUT'    AND dbo.Stock_Details.ItemID IS NULL  AND (dbo.Stock_Details.TranDate  between @fromday AND @today)"
            mvStr_Sql += " GROUP BY r.LOC_ID, r.InventoryID, r.MaterialID, dbo.TBL_MATERIAL.MaterialName,  dbo.Stock_Details.TranCode, dbo.Stock_Details.Unit,dbo.Stock_Details.Items)"
            mvStr_Sql += " TMB GROUP BY TMB.LOC_ID,TMB.InventoryID,TMB.MaterialID,TMB.MaterialName,TMB.SLTON,TMB.TranCode,TMB.Unit"
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@LOC_ID", gvStr_LocID)
                SubM_AddParameter("@fromday", iDate_From)
                SubM_AddParameter("@today", iDate_To)

                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
            Return mvDataTale
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
#End Region

#Region "Report Detail"
    Public Function FuncG_Detail(ByVal iDate_From As Date, ByVal iDate_To As Date, ByVal iStr_Code As String) As Boolean
        Try

            If FuncM_OpenConnection() Then
                SubM_AddParameter("@LOC_ID", gvStr_LocID)
                SubM_AddParameter("@FROM_DATE", iDate_From)
                SubM_AddParameter("@TO_DATE", iDate_To)
                SubM_AddParameter("@CODE", iStr_Code)
                If FuncM_ExecuteStore("usp_SOCHITIET") Then
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

    Public Function FuncG_GetProfitData(ByVal iDate_FromDay As Date, ByVal iDate_ToDay As Date) As DataTable
        Dim mvDataTale As New DataTable
        Dim wSqlDataAdapter As New SqlDataAdapter
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                '================================================thi=============================================
                mvStr_Sql = "SELECT d.ITEM_ID AS ItemID, i.NAME AS ItemName, SUM(d.QUANTITY) AS Quantity, d.PRICE AS Price,"
                mvStr_Sql += " SUM(d.TOTALDISCOUNT) AS TotalDiscount,"
                mvStr_Sql += " SUM(d.TOTALSERVICE) AS TotalService, SUM(d.TOTALVAT) AS TotalVAT,"
                mvStr_Sql += " SUM(d.FINALTOTAL) AS FinalTotal, SUM(v.TotalCost) AS TotalCost FROM dbo.TBL_SALES_DETAIL d"
                mvStr_Sql += " LEFT JOIN"
                mvStr_Sql += " ("
                mvStr_Sql += " select SUM(tl.o) as TotalCost,tl.ID AS ITEM_ID from ( SELECT (sum(ConvertedPrice*Items)/SUM(CurrentItems))*TBL_PROMAT.QTY as o,TBL_PROMAT.ID  FROM dbo.Stock_Details JOIN TBL_PROMAT ON TBL_PROMAT.ITEM_ID = Stock_Details.MaterialID  WHERE TranCode<>'OUT' "
                mvStr_Sql += " GROUP BY MaterialID,TBL_PROMAT.QTY,TBL_PROMAT.ID) as tl "
                mvStr_Sql += " group by tl.ID "
                mvStr_Sql += " ) AS v"
                mvStr_Sql += " ON  v.Item_ID = d.ITEM_ID"
                mvStr_Sql += " INNER JOIN dbo.TBL_ITEM i"
                mvStr_Sql += " on d.ITEM_ID = i.ID AND d.LOC_ID = i.LOC_ID"
                mvStr_Sql += " INNER JOIN dbo.TBL_SALES s"
                mvStr_Sql += " ON d.ID = s.ID AND d.LOC_ID = s.LOC_ID"
                mvStr_Sql += " WHERE s.LOC_ID = @iNVChr_LOCID AND s.CHECK_OUT BETWEEN @FromDay AND @ToDay"
                mvStr_Sql += " GROUP BY d.ITEM_ID, d.PRICE, i.NAME"
                mvStr_Sql += " ORDER BY d.ITEM_ID "
                '===================================================CU============================================
                'mvStr_Sql = "SELECT d.ITEM_ID AS ItemID, i.NAME AS ItemName, SUM(d.QUANTITY) AS Quantity, d.PRICE AS Price,"
                'mvStr_Sql += " SUM(d.TOTALDISCOUNT) AS TotalDiscount,"
                'mvStr_Sql += " SUM(d.TOTALSERVICE) AS TotalService, SUM(d.TOTALVAT) AS TotalVAT,"
                'mvStr_Sql += " SUM(d.FINALTOTAL) AS FinalTotal, SUM(v.TotalCost) AS TotalCost FROM dbo.TBL_SALES_DETAIL d"
                'mvStr_Sql += " LEFT JOIN"
                'mvStr_Sql += " ("
                'mvStr_Sql += " SELECT sd.LOC_ID, sd.InvoiceID, sd.ItemID, SUM(ConvertedPrice*ConvertedItems) AS TotalCost"
                'mvStr_Sql += " FROM dbo.Stock_Details sd"
                'mvStr_Sql += " GROUP BY sd.LOC_ID, sd.InvoiceID, sd.ItemID"
                'mvStr_Sql += " ) AS v"
                'mvStr_Sql += " ON v.LOC_ID = D.LOC_ID AND v.InvoiceID = d.ID  AND v.ItemID = d.ITEM_ID"
                'mvStr_Sql += " INNER JOIN dbo.TBL_ITEM i"
                'mvStr_Sql += " on d.ITEM_ID = i.ID AND d.LOC_ID = i.LOC_ID"
                'mvStr_Sql += " INNER JOIN dbo.TBL_SALES s"
                'mvStr_Sql += " ON d.ID = s.ID AND d.LOC_ID = s.LOC_ID"
                'mvStr_Sql += " WHERE s.LOC_ID = @iNVChr_LOCID AND s.CHECK_OUT BETWEEN @FromDay AND @ToDay"
                'mvStr_Sql += " GROUP BY d.ITEM_ID, d.PRICE, i.NAME"

                ''================================================DAT===================================================================================='
                'mvStr_Sql = " SELECT ItemID ,V.NAME AS ItemName , V.QUANTITY ,V.PRICE  AS PRICE,V.TOTALDISCOUNT ,V.TOTALSERVICE ,V.TOTALVAT,(V.GIABAN  ) AS FINALTOTAL,(sdi.ConvertedPrice *sdi.ConvertedItems) as TOTALCOST"
                'mvStr_Sql += " FROM (SELECT d.ITEM_ID , i.NAME, SUM(D.QUANTITY ) AS QUANTITY, SUM(d .TOTAL ) AS GIABAN,d .PRICE "
                'mvStr_Sql += " ,SUM(TOTALDISCOUNT ) AS TOTALDISCOUNT, SUM(TOTALSERVICE ) AS TOTALSERVICE,SUM(TOTALVAT ) AS TOTALVAT"
                'mvStr_Sql += " FROM TBL_SALES_DETAIL AS d inner join TBL_ITEM as i on i.ID = d.ITEM_ID "
                'mvStr_Sql += " WHERE d.CREATEDATE BETWEEN @FromDay AND @ToDay "
                'mvStr_Sql += " GROUP BY d.ITEM_ID , i.NAME,d .PRICE ) AS V inner join (SELECT  ItemID, AVG(ConvertedPrice ) as ConvertedPrice, SUM(ConvertedItems ) as ConvertedItems"
                'mvStr_Sql += " FROM Stock_Details  inner join TBL_ITEM as i on i.ID = Stock_Details.ItemID "
                'mvStr_Sql += " WHERE Stock_Details.TranDate BETWEEN @FromDay AND @ToDay"
                'mvStr_Sql += " group by ItemID  ) as sdi on sdi.ItemID = V .ITEM_ID "
                'mvStr_Sql += " GROUP BY ItemID ,V.NAME , V.QUANTITY ,V.PRICE,V.TOTALDISCOUNT ,V.TOTALSERVICE ,V.TOTALVAT,V.GIABAN,sdi.ConvertedPrice ,sdi.ConvertedItems  "

                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@FromDay", iDate_FromDay)
                SubM_AddParameter("@ToDay", iDate_ToDay)

                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
                Return mvDataTale
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function

    Public Function FuncG_GetBCCanBangKho(ByVal tuNgay As Date, ByVal denNgay As Date) As DataTable
        Dim mvDataTale As New DataTable
        Dim wSqlDataAdapter As New SqlDataAdapter
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT A.InventoryID AS MAKHO, A.MaterialID AS MAHANG, B.MaterialName AS TENHANG, A.Unit AS DONVI, SUM(A.Quantity) AS SLMOI, "
                mvStr_Sql += " (SELECT SUM(Quantity) FROM Stock_Reports "
                mvStr_Sql += " where MaterialID=A.MaterialID AND LastTranDate BETWEEN @FromDay AND @ToDay AND LastTranDate not in "
                mvStr_Sql += " (select max(LastTranDate) as LastTranDate from Stock_Reports "
                mvStr_Sql += " WHERE MaterialID=A.MaterialID AND LastTranDate BETWEEN @FromDay AND @ToDay)"
                mvStr_Sql += " ) AS SLCU, A.PRICE AS GIA FROM Stock_Reports AS A INNER JOIN TBL_MATERIAL AS B ON A.MaterialID = B.MaterialID"
                mvStr_Sql += " WHERE A.LOC_ID = @iNVChr_LOCID AND A.LastTranDate BETWEEN @FromDay AND @ToDay"
                mvStr_Sql += " GROUP BY A.MaterialID, A.LOC_ID, A.InventoryID, B.MaterialName, A.Unit, A.Price"
                mvStr_Sql += " ORDER BY MAHANG"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@FromDay", tuNgay)
                SubM_AddParameter("@ToDay", denNgay)

                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
                Return mvDataTale
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetDataReport_CTHoaDon(ByVal tuNgay As Date, ByVal denNgay As Date, ByVal cashierID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT (CASE  D.NAME WHEN '' THEN N'MÓN MỞ' ELSE D.NAME END) AS GROUPNAME , C.NAME AS ITEMNAME, SUM(B.QUANTITY) AS QUANTITY, SUM(B.PRICE) AS PRICE, "
                mvStr_Sql += " SUM(B.TOTALDISCOUNT) AS TOTALDISCOUNT, SUM(B.TOTALSERVICE) AS TOTALSERVICE, SUM(B.TOTALVAT) AS TOTALVAT, "
                mvStr_Sql += " SUM(B.FINALTOTAL) AS FINALTOTAL"
                mvStr_Sql += " FROM TBL_SALES AS A "
                mvStr_Sql += " INNER JOIN TBL_SALES_DETAIL AS B ON A.ID = B.ID"
                mvStr_Sql += " INNER JOIN TBL_ITEM AS C ON B.ITEM_ID = C.ID"
                mvStr_Sql += " INNER JOIN TBL_MENUGROUPITEM AS D ON C.GROUP_ID = D.ID"
                mvStr_Sql += " WHERE (A.CHECK_OUT BETWEEN @P_TUNGAY AND @P_DENNGAY) AND"
                mvStr_Sql += " A.STATUS = 1 AND A.LOC_ID = @P_LOC_ID " ' AND D.NAME != ''"
                If cashierID = "" Then
                Else
                    mvStr_Sql += " AND A.CASHIER_ID = @P_CASHIER_ID"
                End If

                mvStr_Sql += " GROUP BY C.NAME, D.NAME,D.ID"
                mvStr_Sql += " ORDER BY D.ID "
                SubM_AddParameter("@P_LOC_ID", gvStr_LocID)
                SubM_AddParameter("@P_TUNGAY", tuNgay)
                SubM_AddParameter("@P_DENNGAY", denNgay)
                If cashierID = "" Then
                Else
                    SubM_AddParameter("@P_CASHIER_ID", cashierID)
                End If

                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function

    Public Function FuncG_GetDataReport_CTHoaDon_2(ByVal tuNgay As Date, ByVal denNgay As Date, ByVal cashierID As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT (CASE  D.NAME WHEN '' THEN N'MÓN MỞ' ELSE D.NAME END) AS GROUPNAME, SUM(B.QUANTITY) AS QUANTITY, SUM(B.PRICE) AS PRICE, "
                mvStr_Sql += " SUM(B.TOTALDISCOUNT) AS TOTALDISCOUNT, SUM(B.TOTALSERVICE) AS TOTALSERVICE, SUM(B.TOTALVAT) AS TOTALVAT, "
                mvStr_Sql += " SUM(B.FINALTOTAL) AS FINALTOTAL"
                mvStr_Sql += " FROM TBL_SALES AS A "
                mvStr_Sql += " INNER JOIN TBL_SALES_DETAIL AS B ON A.ID = B.ID"
                mvStr_Sql += " INNER JOIN TBL_ITEM AS C ON B.ITEM_ID = C.ID"
                mvStr_Sql += " INNER JOIN TBL_MENUGROUPITEM AS D ON C.GROUP_ID = D.ID"
                mvStr_Sql += " WHERE (A.CHECK_OUT BETWEEN @P_TUNGAY AND @P_DENNGAY) AND"
                mvStr_Sql += " A.STATUS = 1 AND A.LOC_ID = @P_LOC_ID " ' AND D.NAME != ''"

                If cashierID = "" Then
                Else
                    mvStr_Sql += " AND A.CASHIER_ID = @P_CASHIER_ID"
                End If

                mvStr_Sql += " GROUP BY D.NAME,D.ID"
                mvStr_Sql += " ORDER BY D.ID"
                SubM_AddParameter("@P_LOC_ID", gvStr_LocID)
                SubM_AddParameter("@P_TUNGAY", tuNgay)
                SubM_AddParameter("@P_DENNGAY", denNgay)
                If cashierID = "" Then

                Else
                    SubM_AddParameter("@P_CASHIER_ID", cashierID)
                End If

                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function

    Public Function FuncG_GetNXT(ByVal inventoryID As String, ByVal tuNgay As Date, ByVal denNgay As Date, ByVal Fromday_Tondau As Date) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            'mvStr_Sql = "SELECT A.MaterialName AS TENNL, A.ExportUnit AS DVT"
            'mvStr_Sql += " , (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'TD' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) AS SLTONDAU"
            'mvStr_Sql += " , (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'PN' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) AS SLNHAP"
            'mvStr_Sql += " , (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND InventoryID = @P_INVENTORYID AND ((LEFT(InvoiceID, 2) = 'PX') OR (ItemID IS NOT NULL AND TranCode = 'OUT')) AND TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY) AS SLXUAT"
            'mvStr_Sql += " , ("
            'mvStr_Sql += " CASE WHEN (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'TD' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) IS NULL THEN 0 ELSE (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'TD' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) END +"
            'mvStr_Sql += " CASE WHEN (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'PN' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) IS NULL THEN 0 ELSE (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'PN' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) END -"
            'mvStr_Sql += " CASE WHEN (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND InventoryID = @P_INVENTORYID AND ((LEFT(InvoiceID, 2) = 'PX') OR (ItemID IS NOT NULL AND TranCode = 'OUT')) AND TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY) IS NULL THEN 0 ELSE (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND InventoryID = @P_INVENTORYID AND ((LEFT(InvoiceID, 2) = 'PX') OR (ItemID IS NOT NULL AND TranCode = 'OUT')) AND TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY) END"
            'mvStr_Sql += " ) AS SLTONCUOI"
            'mvStr_Sql += " FROM TBL_MATERIAL AS A WHERE A.LOC_ID = @P_LOC_ID"
            ''=====================================================
            'mvStr_Sql = "SELECT A.MaterialName AS TENNL, A.ExportUnit AS DVT"
            'mvStr_Sql += " , (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND (LEFT(InvoiceID, 2) = 'TD' OR LEFT(InvoiceID, 2) = 'PX' AND TranCode ='IN') AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) AS SLTONDAU"
            'mvStr_Sql += " , (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'PN' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) AS SLNHAP"
            'mvStr_Sql += " , (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND InventoryID = @P_INVENTORYID AND ((LEFT(InvoiceID, 2) = 'PX' AND TranCode = 'OUT') OR (ItemID IS NOT NULL AND TranCode = 'OUT')) AND TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY) AS SLXUAT"
            'mvStr_Sql += " , ("
            'mvStr_Sql += " CASE WHEN (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'TD' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) IS NULL  THEN 0 ELSE (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'TD' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) END +"
            'mvStr_Sql += " CASE WHEN (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'PX' AND TranCode ='IN' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) IS NULL THEN 0 ELSE (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'PX' AND TranCode ='IN' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) END -"
            'mvStr_Sql += " CASE WHEN (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND InventoryID = @P_INVENTORYID AND ((LEFT(InvoiceID, 2) = 'PX' AND TranCode = 'OUT') OR (ItemID IS NOT NULL AND TranCode = 'OUT')) AND TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY) IS NULL THEN 0 ELSE (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND InventoryID = @P_INVENTORYID AND ((LEFT(InvoiceID, 2) = 'PX' AND TranCode = 'OUT') OR (ItemID IS NOT NULL AND TranCode = 'OUT')) AND TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY) END"
            'mvStr_Sql += " ) AS SLTONCUOI"
            'mvStr_Sql += " FROM TBL_MATERIAL AS A WHERE A.LOC_ID = @P_LOC_ID"
            '=======================================================
            'mvStr_Sql += "SELECT A.MaterialName AS TENNL, A.ExportUnit AS DVT"
            'mvStr_Sql += ", (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'TD'  AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) AS SLTONDAU"
            'mvStr_Sql += ", (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND (LEFT(InvoiceID, 2) = 'PN' OR LEFT(InvoiceID, 2) = 'PX' AND TranCode ='IN') AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) AS SLNHAP "
            'mvStr_Sql += ", (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND InventoryID = @P_INVENTORYID AND ((LEFT(InvoiceID, 2) = 'PX' AND TranCode = 'OUT') OR (ItemID IS NOT NULL AND TranCode = 'OUT')) AND TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY) AS SLXUAT "
            'mvStr_Sql += ", (CASE WHEN (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'TD' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) IS NULL  THEN 0 ELSE (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'TD' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) END + "
            'mvStr_Sql += "CASE WHEN (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND (LEFT(InvoiceID, 2) = 'PN' OR LEFT(InvoiceID, 2) = 'PX' AND TranCode ='IN') AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) IS NULL THEN 0 ELSE (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND (LEFT(InvoiceID, 2) = 'PN' OR LEFT(InvoiceID, 2) = 'PX' AND TranCode ='IN') AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) END - "
            'mvStr_Sql += "CASE WHEN (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND InventoryID = @P_INVENTORYID AND ((LEFT(InvoiceID, 2) = 'PX' AND TranCode = 'OUT') OR (ItemID IS NOT NULL AND TranCode = 'OUT')) AND TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY) IS NULL THEN 0 ELSE (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND InventoryID = @P_INVENTORYID AND ((LEFT(InvoiceID, 2) = 'PX' AND TranCode = 'OUT') OR (ItemID IS NOT NULL AND TranCode = 'OUT')) AND TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY) END "
            'mvStr_Sql += ") AS SLTONCUOI "
            'mvStr_Sql += "FROM TBL_MATERIAL AS A WHERE A.LOC_ID = @P_LOC_ID "
            '=======================================================
            Dim Tondau As String = "CASE WHEN (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'TD' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAYTD AND @P_DENNGAYTD)) IS NULL  THEN 0 ELSE (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND LEFT(InvoiceID, 2) = 'TD' AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAYTD AND @P_DENNGAYTD)) END + CASE WHEN (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND (LEFT(InvoiceID, 2) = 'PN' OR LEFT(InvoiceID, 2) = 'PX' AND TranCode ='IN') AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAYTD AND @P_DENNGAYTD)) IS NULL THEN 0 ELSE (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND (LEFT(InvoiceID, 2) = 'PN' OR LEFT(InvoiceID, 2) = 'PX' AND TranCode ='IN') AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAYTD AND @P_DENNGAYTD)) END - CASE WHEN (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND InventoryID = @P_INVENTORYID AND ((LEFT(InvoiceID, 2) = 'PX' AND TranCode = 'OUT') OR (ItemID IS NOT NULL AND TranCode = 'OUT')) AND TranDate BETWEEN @P_TUNGAYTD AND @P_DENNGAYTD) IS NULL THEN 0 ELSE (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND InventoryID = @P_INVENTORYID AND ((LEFT(InvoiceID, 2) = 'PX' AND TranCode = 'OUT') OR (ItemID IS NOT NULL AND TranCode = 'OUT')) AND TranDate BETWEEN @P_TUNGAYTD AND @P_DENNGAYTD) END "
            mvStr_Sql += "SELECT A.MaterialName AS TENNL, A.ExportUnit AS DVT"
            mvStr_Sql += ", (" + Tondau + ") AS SLTONDAU"
            mvStr_Sql += ", (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND (LEFT(InvoiceID, 2) = 'PN' OR LEFT(InvoiceID, 2) = 'PX' AND TranCode ='IN') AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) AS SLNHAP "
            mvStr_Sql += ", (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND InventoryID = @P_INVENTORYID AND ((LEFT(InvoiceID, 2) = 'PX' AND TranCode = 'OUT') OR (ItemID IS NOT NULL AND TranCode = 'OUT')) AND TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY) AS SLXUAT "
            mvStr_Sql += ", (" + Tondau + "+"
            mvStr_Sql += "CASE WHEN (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND (LEFT(InvoiceID, 2) = 'PN' OR LEFT(InvoiceID, 2) = 'PX' AND TranCode ='IN') AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) IS NULL THEN 0 ELSE (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND (LEFT(InvoiceID, 2) = 'PN' OR LEFT(InvoiceID, 2) = 'PX' AND TranCode ='IN') AND InventoryID = @P_INVENTORYID AND (TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY)) END - "
            mvStr_Sql += "CASE WHEN (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND InventoryID = @P_INVENTORYID AND ((LEFT(InvoiceID, 2) = 'PX' AND TranCode = 'OUT') OR (ItemID IS NOT NULL AND TranCode = 'OUT')) AND TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY) IS NULL THEN 0 ELSE (SELECT SUM(Items) FROM Stock_Details WHERE MaterialID = A.MaterialID AND InventoryID = @P_INVENTORYID AND ((LEFT(InvoiceID, 2) = 'PX' AND TranCode = 'OUT') OR (ItemID IS NOT NULL AND TranCode = 'OUT')) AND TranDate BETWEEN @P_TUNGAY AND @P_DENNGAY) END "
            mvStr_Sql += ") AS SLTONCUOI "
            mvStr_Sql += "FROM TBL_MATERIAL AS A WHERE A.LOC_ID = @P_LOC_ID "


            If FuncM_OpenConnection() Then
                SubM_AddParameter("@P_TUNGAY", tuNgay)
                SubM_AddParameter("@P_DENNGAY", denNgay)
                SubM_AddParameter("@P_TUNGAYTD", Fromday_Tondau)
                SubM_AddParameter("@P_DENNGAYTD", tuNgay)
                SubM_AddParameter("@P_INVENTORYID", inventoryID)
                SubM_AddParameter("@P_LOC_ID", gvStr_LocID)
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
