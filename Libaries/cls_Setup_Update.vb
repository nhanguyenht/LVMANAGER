Public Class cls_Setup_Update
    Inherits cls_Database_Base
#Region "Get Data"
    Public Function FuncG_GetData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TOP 1 * FROM [TBL_SETUP] "
                'mvStr_Sql = "SELECT TOP 1 * FROM [TBL_SETUP] WHERE LOC_ID = @iNVChr_LOCID"
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
#End Region
End Class
