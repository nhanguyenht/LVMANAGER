Public Class cls_GroupItem_Update
    Inherits cls_Database_Base
#Region "Get FuncG_GetMaxCode"
    Public Function FuncG_GetMaxCode() As String
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT MAX(ID) FROM [TBL_MENUGROUPITEM]"
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
#End Region
#Region "Get GroupItem"
    Public Function FuncG_GetAllData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID,NAME,STATUS FROM [TBL_MENUGROUPITEM] WHERE LOC_ID = @iNVChr_LOCID ORDER BY [ID]"
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
    Public Function FuncG_GetCountMenuGroup() As Integer
        Dim mvDataTale As New DataTable
        Dim countmenu As New Integer
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "select COUNT(*) as countmenu from [dbo].[TBL_MENUGROUPITEM] where LOC_ID = @iNVChr_LOCID and STATUS=1 and ID<>'99'"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
                countmenu = mvDataTale.Rows(0)("countmenu")
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return countmenu
    End Function
    Public Function FuncG_GetAllData1() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID AS [Mã nhóm],NAME AS [Nhóm hàng] FROM [TBL_MENUGROUPITEM] WHERE LOC_ID = @iNVChr_LOCID ORDER BY [ID]"
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
#Region "Update GroupItem"
    Public Function FuncG_UpdateGroup(ByVal iCls_GroupItem As cls_GroupItem) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_GroupItem.ID)
                SubM_AddParameter("@iNVChr_NAME", iCls_GroupItem.Name)
                SubM_AddParameter("@iTInt_STATUS", iCls_GroupItem.Status)
                SubM_AddParameter("@iInt_TYPE", iCls_GroupItem.Type)

                'SubM_AddParameter("@iIMG_IMAGE1", iCls_GroupItem.Image1)
                'SubM_AddParameter("@iIMG_IMAGE2", iCls_GroupItem.Image2)
                SubM_AddParameter("@iIMG_IMAGE1", "0")
                SubM_AddParameter("@iIMG_IMAGE2", "0")
                SubM_AddParameter("@iNVChr_DESCRIPTION", iCls_GroupItem.Description) 
                If FuncM_ExecuteStore("usp_MenuGroupItem") Then
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
