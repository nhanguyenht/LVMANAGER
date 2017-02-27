Imports System.Data.SqlClient
Public MustInherit Class cls_Execute_Base
    Inherits cls_Database_Base
#Region "Khai Báo Biến"
#End Region
#Region "Thực thi Function Sql"
    '#---------------------------------------------------------------------------
    '# FunctionName     :       FuncM_ExecuteReader
    '# Description      :       Thực thi hàm Sql
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-11
    '# LastUpdate       :       2008-09-11
    '#---------------------------------------------------------------------------
    Protected Function FuncM_ExecuteReader(ByVal iStr_Sql As String) As Object
        Dim mvStr_Return As String = ""
        Try
            Dim mvSql_Command As New SqlCommand(iStr_Sql, mvObj_SqlConnection)
            Dim mvSql_DataReader As SqlDataReader
            mvSql_DataReader = mvSql_Command.ExecuteReader
            mvSql_DataReader.Read()
            mvStr_Return = mvSql_DataReader(0)
            mvSql_DataReader.Close()
        Catch ex As Exception
            Throw ex
        End Try
        Return mvStr_Return
    End Function
#End Region
#Region "Select Table Tam Có Tham Số"
    Public Function FunG_GetTableWithParameterTemp(ByVal iTyp_THAMSO) As DataTable
        Dim mvData_DataTable As New DataTable
        Dim wStr_Sql As String = ""
        Try
            If (FuncM_OpenConnection()) Then
                wStr_Sql = "SELECT * FROM WHERE THAMSO LIKE @inTyp_THAMSO"
                SubM_AddParameter("@inTyp_THAMSO", iTyp_THAMSO)
                mvData_DataTable = FuncM_GetDataTable(wStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvData_DataTable
    End Function
#End Region
#Region "Select Table Tam Không Có Tham Số"
    Public Function FunG_GetTableWithOutParameterTemp() As DataTable
        Dim mvData_DataTable As New DataTable
        Dim wStr_Sql As String = ""
        Try
            If (FuncM_OpenConnection()) Then
                wStr_Sql = "SELECT * FROM "
                mvData_DataTable = FuncM_GetDataTable(wStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvData_DataTable
    End Function
#End Region
#Region "Execute Stored"
    '#---------------------------------------------------------------------------
    '# FunctionName     :       FunG_ExecuteStored
    '# Description      :       Thực thi Stored
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-15
    '# LastUpdate       :       2008-09-15
    '#---------------------------------------------------------------------------
    Public Function FunG_ExecuteStored(ByVal iTyp_THAMSO As Type) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iTyp_THAMSO", iTyp_THAMSO)
                If FuncM_ExecuteStore("usp_STOREDNAME") Then
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
