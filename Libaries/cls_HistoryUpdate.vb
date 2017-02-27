Public Class cls_HistoryUpdate
    Inherits cls_Database_Base
#Region "Insert - Update - Delete"
    Public Function Insert(ByVal HistoryBalance As cls_HistoryBalance) As Boolean
        Dim query As String = "INSERT INTO HISTORY_BALANCE(USER_ID,CREATEDATE,MATERIAL_ID,QTYOLD,QTYNEW,PRICE) VALUES (@USER_ID,@CREATEDATE,@MATERIAL_ID,@QTYOLD,@QTYNEW,@PRICE)"

        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@USER_ID", HistoryBalance.USER)
                SubM_AddParameter("@CREATEDATE", HistoryBalance.CreateDate)
                SubM_AddParameter("@MATERIAL_ID", HistoryBalance.MATERIAL_ID)
                SubM_AddParameter("@QTYOLD", HistoryBalance.QTYOLD)
                SubM_AddParameter("@QTYNEW", HistoryBalance.QTYNEW)
                SubM_AddParameter("@PRICE", HistoryBalance.PRICE)
                FuncM_ExecuteNonQuery(query)

            End If
        Catch ex As Exception
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
        Return True
    End Function
#End Region
#Region "SELECT ITEM"
    Public Function Func_GetAllData() As DataTable
        Dim query As String = "SELECT * FROM HistoryBalance"
        Dim DTBALANCE As New DataTable
        Try
            If FuncM_OpenConnection() Then
                DTBALANCE = FuncM_GetDataTable(query)

            End If
        Catch ex As Exception
        Finally
            FuncM_CloseConnection()

        End Try
        Return DTBALANCE
    End Function
    'Public Function Func_GetAllDataByTime(ByVal fromdate As Date, ByVal todate As Date) As DataTable

    'End Function
#End Region

End Class
