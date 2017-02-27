Public Class cls_Printer_Update
    Inherits cls_Database_Base
#Region "Get Printer Info orderby ID"
    Public Function FuncG_GetAllData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID, NAME, STATUS FROM [TBL_PRINTER] WHERE LOC_ID = @iNVChr_LOCID ORDER BY [ID]"
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
    Public Function FuncG_GetAllData1() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID AS [Mã], NAME AS [Tên máy] FROM [TBL_PRINTER] WHERE LOC_ID = @iNVChr_LOCID AND STATUS = 1 ORDER BY [ID]"
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
#End Region
#Region "Update Printer"
    Public Function FuncG_Update(ByVal iCls_Printer As cls_Printer) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Printer.ID)
                SubM_AddParameter("@iNVChr_NAME", iCls_Printer.Name)
                SubM_AddParameter("@iTInt_STATUS", iCls_Printer.Status)
                If FuncM_ExecuteStore("usp_Printer") Then
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
