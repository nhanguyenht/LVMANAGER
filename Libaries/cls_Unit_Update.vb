Public Class cls_Unit_Update
    Inherits cls_Database_Base

    Public Function FuncG_GetAllData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM [TBL_UNIT] ORDER BY [UnitID]"
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetCustomerSalesByID(ByVal id As String) As Boolean
        Const query As String = "select *  from TBL_UNIT WHERE UnitID=@ID "
        Dim DT As New DataTable
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@ID", id)
                DT = FuncM_GetDataTable(query)
                If DT.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function
    Public Function FuncG_GetAllData(ByVal iStr_ID As String, ByVal iStr_Name As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM [TBL_UNIT] "

                If iStr_ID <> "" And iStr_Name <> "" Then
                    mvStr_Sql += " where  UnitID = @iNVChr_ID and UnitName LIKE '%' + @iNVChr_NAME + '%'"
                End If

                If iStr_ID <> "" Then
                    mvStr_Sql += " where  UnitID = @iNVChr_ID"
                    SubM_AddParameter("@iNVChr_ID", iStr_ID)
                End If
                If iStr_Name <> "" Then
                    mvStr_Sql += "where   UnitName LIKE '%' + @iNVChr_NAME + '%'"
                    SubM_AddParameter("@iNVChr_NAME", iStr_Name)
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

#Region "Insert Update"
    Public Function FuncG_Insert(ByVal iStr_ID As String, ByVal iStr_Name As String) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "insert into TBL_UNIT(UnitID,UnitName) VALUES(@iNVChr_UnitID,@iNVChr_UnitName)"
                SubM_AddParameter("@iNVChr_UnitID", iStr_ID)
                SubM_AddParameter("@iNVChr_UnitName", iStr_Name)
              
                If FuncM_ExecuteNonQuery(mvStr_Sql) Then
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
    Public Function FuncG_Update(ByVal iStr_ID As String, ByVal iStr_Name As String) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = " update  TBL_UNIT set UnitName=@iNVChr_UnitName "
                mvStr_Sql += " where  UnitID=@iNVChr_UnitID "
                SubM_AddParameter("@iNVChr_UnitID", iStr_ID)
                SubM_AddParameter("@iNVChr_UnitName", iStr_Name)

                If FuncM_ExecuteNonQuery(mvStr_Sql) Then
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
    Public Function FuncG_Delete(ByVal iStr_ID As String) As Boolean
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = " delete from  TBL_UNIT  "
                mvStr_Sql += " where  UnitID=@iNVChr_UnitID "
                SubM_AddParameter("@iNVChr_UnitID", iStr_ID)

                If FuncM_ExecuteNonQuery(mvStr_Sql) Then
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
