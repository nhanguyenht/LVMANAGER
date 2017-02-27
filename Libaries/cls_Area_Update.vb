Public Class cls_Area_Update
    Inherits cls_Database_Base
#Region "Get FuncG_GetMaxCode"
    Public Function FuncG_GetMaxCode() As String
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT MAX(ID) FROM [TBL_AREA]"
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
#Region "Get AREA Info orderby ID"
    Public Function FuncG_GetAllData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                ' mvStr_Sql = "SELECT ID,NAME,STATUS FROM [TBL_AREA] WHERE LOC_ID = @iNVChr_LOCID ORDER BY [ID]"
                mvStr_Sql = "SELECT * FROM [TBL_AREA] WHERE LOC_ID = @iNVChr_LOCID ORDER BY [ID]"
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
#Region "Update AREA"
    Public Function FuncG_UpdateArea(ByVal iCls_Area As cls_Area) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Area.ID)
                SubM_AddParameter("@iNVChr_NAME", iCls_Area.Name)
                SubM_AddParameter("@iTInt_STATUS", iCls_Area.Status)
                SubM_AddParameter("@iTInt_TYPE", iCls_Area.Type)
                SubM_AddParameter("@iTInt_PRICELEVEL", iCls_Area.PriceLevel)

                SubM_AddParameter("@iDat_Time_Begin", iCls_Area.Time_Begin)
                SubM_AddParameter("@iDat_Time_End", iCls_Area.Time_End)
                SubM_AddParameter("@iFlt_Bill_Service", iCls_Area.Bill_Service)
                SubM_AddParameter("@iFlt_Karaoke_Service", iCls_Area.Karaoke_Service)
                SubM_AddParameter("@iByte_Type_Service", iCls_Area.Type_Service)
                SubM_AddParameter("@iByte_Status_Service", iCls_Area.Status_Service)

                If FuncM_ExecuteStore("usp_Area") Then
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
