Public Class cls_StockReport
    Inherits cls_Database_Base
#Region "Get Data"
    Public Function Func_GetItemByID(ByVal iStr_ID As String) As DataTable
        Dim DTTable As New DataTable
        Dim query As String = "SELECT *  FROM Stock_Reports where MaterialID =@iStr_ID"
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iStr_ID", iStr_ID)
                DTTable = FuncM_GetDataTable(query)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return DTTable
    End Function
    Public Function Func_GetItemByID(ByVal iStr_ID As String, ByVal INVENTORY_ID As String) As DataTable
        Dim DTTable As New DataTable
        Dim query As String = "SELECT *  FROM Stock_Reports where MaterialID =@iStr_ID AND InventoryID=@InventoryID"
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iStr_ID", iStr_ID)
                SubM_AddParameter("@InventoryID", INVENTORY_ID)

                DTTable = FuncM_GetDataTable(query)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return DTTable
    End Function
#End Region
#Region "Update Data"
    Public Sub Func_Update(ByVal iStr_ID As String, ByVal IntQuantity As Int16, ByVal iStrInventoryID As String, ByVal iStrStockID As Integer)
        Const query As String = "Update Stock_Reports Set Quantity = @IntQuantity Where MaterialID =@iStr_ID AND InventoryID=@InventoryID AND StockID=@StockID"
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@IntQuantity", IntQuantity)
                SubM_AddParameter("@InventoryID", iStrInventoryID)
                SubM_AddParameter("@iStr_ID", iStr_ID)
                SubM_AddParameter("@StockID", iStrStockID)
                FuncM_ExecuteNonQuery(query)

            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
    End Sub
    Public Sub Func_Update(ByVal iStr_ID As String, ByVal IntQuantity As Int16)
        Const query As String = "Update Stock_Reports Set Quantity = @IntQuantity Where MaterialID =@iStr_ID"
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@IntQuantity", IntQuantity)
                SubM_AddParameter("@iStr_ID", iStr_ID)
                FuncM_ExecuteNonQuery(query)

            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
    End Sub
#End Region
End Class
