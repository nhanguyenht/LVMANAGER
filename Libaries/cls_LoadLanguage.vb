Public Class cls_LoadLanguage
    Inherits cls_Database_Base
    Function FuncG_GetData(ByVal iStr_ID As String, ByVal iStr_IDGroup As String, ByVal iStr_Table As String) As String
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Dim mvStr_Language As String = ""
        Dim mvStr_TableName As String
        Try
            If FuncM_OpenConnection() Then
                Select Case iStr_Table
                    Case 1
                        mvStr_TableName = "TBL_LANG_MENU_MANAGER"
                    Case 2
                        mvStr_TableName = "tbl_lang_message_MANAGER"
                    Case Else
                        mvStr_TableName = "tbl_lang_report"
                End Select
                mvStr_Sql = "SELECT * FROM " & mvStr_TableName & " WHERE ID = @iNVChr_ID AND ID_GROUP = @iNVChr_IDGROUP"
                SubM_AddParameter("@iNVChr_ID", iStr_ID)
                SubM_AddParameter("@iNVChr_IDGROUP", iStr_IDGroup)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
                If mvDataTale.Rows.Count <> 0 Then
                    mvStr_Language = mvDataTale.Rows(0)(gvByte_Language + 1)
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvStr_Language
    End Function
End Class
