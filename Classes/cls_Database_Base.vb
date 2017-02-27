Imports System
Imports System.Data
Imports System.Data.SqlClient
'#---------------------------------------------------------------------------
'# ClassName        :       cls_Database_Base
'# Description      :       This class contains base operations on database
'# Author           :       THI
'# CreateDate       :       2008-06-18
'# LastUpdate       :       2008-06-18
'#---------------------------------------------------------------------------
Public MustInherit Class cls_Database_Base
#Region "Privated Variables"
    Public Shared gvStr_ConnecttionString As String
    Public Shared mvObj_SqlConnection As SqlConnection
    Protected mvObj_SqlCommand As SqlCommand
#End Region
#Region "Constructor"

#End Region
#Region "Protected Database_Base Funtioncs"
    '#-----------------------------------------------------------------------
    '# MethodName       :       FuncM_OpenConnection
    '# Description      :       This method opens a connection
    '# Parameter        :   
    '# ReturnValue      :       True Or False
    '# Author           :       THI
    '# CreateDate       :       2008-06-18
    '# LastUpdate       :       2008-06-18
    '#-----------------------------------------------------------------------
    Protected Function FuncM_OpenConnection() As Boolean
        Try
            mvObj_SqlConnection = New SqlConnection(gvStr_ConnecttionString)
            mvObj_SqlCommand = New SqlCommand()
            If (mvObj_SqlConnection.State <> ConnectionState.Open) Then
                mvObj_SqlConnection.Open()
                mvObj_SqlCommand.Connection = mvObj_SqlConnection
                Return True
            End If
        Catch ex As Exception
            Return False
            Throw ex
        End Try
        Return False
    End Function
    '#-----------------------------------------------------------------------
    '# MethodName     :       FuncM_CloseConnection
    '# Description      :       This method closes a connection
    '# Parameter        :   
    '# ReturnValue      :       True Or False
    '# Author           :       THI
    '# CreateDate       :       2008-06-18
    '# LastUpdate       :       2008-06-18
    '#-----------------------------------------------------------------------
    Protected Function FuncM_CloseConnection() As Boolean
        Try
            If (mvObj_SqlConnection.State <> ConnectionState.Closed) Then
                mvObj_SqlConnection.Close()
                Return True
            End If
        Catch ex As Exception
            Return False
            Throw ex
        End Try
        Return False
    End Function
    '#-----------------------------------------------------------------------
    '# MethodName     :       SubM_AddParameter
    '# Description      :       This method creates a parameter
    '# Parameter        :       ParamName, ParamValue, ParamType, ParamSize 
    '# ValueReturn      :       
    '# Author           :       THI
    '# CreateDate       :       2008-06-18
    '# LastUpdate       :       2008-06-18
    '#-----------------------------------------------------------------------
    Protected Sub SubM_AddParameter(ByVal iStrParamName As String, ByVal iObj_ParamValue As Object, ByVal iObj_ParamType As SqlDbType, Optional ByVal iInt_Size As Integer = 0)
        Dim wObj_SqlParameter As New SqlParameter()
        Try
            wObj_SqlParameter.ParameterName = iStrParamName
            wObj_SqlParameter.Value = iObj_ParamValue
            wObj_SqlParameter.SqlDbType = iObj_ParamType
            If (iInt_Size > 0) Then
                wObj_SqlParameter.Size = iInt_Size
            End If
            mvObj_SqlCommand.Parameters.Add(wObj_SqlParameter)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    '#-----------------------------------------------------------------------
    '# MethodName     :       SubM_AddParameter
    '# Description      :       This method overload SubM_AddParameter method
    '# Parameter        :       ParamName, ParamValue
    '# ReturnValue      :       
    '# Author           :       THI
    '# CreateDate       :       2008-06-18
    '# LastUpdate       :       2008-06-18
    '#-----------------------------------------------------------------------
    Protected Sub SubM_AddParameter(ByVal iStrParamName As String, ByVal iObj_ParamValue As Object)
        Dim wObj_SqlParameter As New SqlParameter()
        Try
            wObj_SqlParameter.ParameterName = iStrParamName
            wObj_SqlParameter.Value = iObj_ParamValue
            mvObj_SqlCommand.Parameters.Add(wObj_SqlParameter)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    '#-----------------------------------------------------------------------
    '# MethodName       :       FuncM_GetDataTable
    '# Description      :       This method gets a datatable
    '# Parameter        :       SqlString 
    '# ReturnValue      :       DataTable
    '# Author           :       THI
    '# CreateDate       :       2008-06-18
    '# LastUpdate       :       2008-06-18
    '#-----------------------------------------------------------------------
    Protected Function FuncM_GetDataTable(ByVal iStr_Sql As String) As DataTable
        Dim wDataTable As New DataTable
        Try
            mvObj_SqlCommand.CommandType = CommandType.Text
            mvObj_SqlCommand.CommandText = iStr_Sql
            Dim wSqlDataAdapter As New SqlDataAdapter
            wSqlDataAdapter.SelectCommand = mvObj_SqlCommand
            wDataTable.Clear()
            wSqlDataAdapter.Fill(wDataTable)
        Catch ex As Exception
            Throw ex
        End Try
        Return wDataTable
    End Function
    '# MethodName       :       FuncM_GetDataSet
    '# Description      :       This method gets a dataset
    '# Parameter        :       SqlString 
    '# ReturnValue      :       DataSet
    '# Author           :       THI
    '# CreateDate       :       2008-06-18
    '# LastUpdate       :       2008-06-18
    '#-----------------------------------------------------------------------
    Protected Function FuncM_GetDataSet(ByVal iStr_Sql As String) As DataSet
        Dim wDataSet As New DataSet()
        Try
            mvObj_SqlCommand.CommandType = CommandType.Text
            mvObj_SqlCommand.CommandText = iStr_Sql
            Dim wSqlDataAdapter As New SqlDataAdapter
            wSqlDataAdapter.SelectCommand = mvObj_SqlCommand
            wDataSet.Clear()
            wSqlDataAdapter.Fill(wDataSet)
        Catch ex As Exception
            Throw ex
        End Try
        Return wDataSet
    End Function
    '# MethodName       :       FuncM_ExecuteStore
    '# Description      :       This method excecutes a storeprocedure
    '# Parameter        :       StoreName 
    '# ReturnValue      :       True or False
    '# Author           :       THI
    '# CreateDate       :       2008-06-18
    '# LastUpdate       :       2008-06-18
    '#-----------------------------------------------------------------------
    Protected Function FuncM_ExecuteStore(ByVal iStr_StoreName As String) As Boolean
        Try
            mvObj_SqlCommand.Connection = mvObj_SqlConnection
            mvObj_SqlCommand.CommandType = CommandType.StoredProcedure
            mvObj_SqlCommand.CommandText = iStr_StoreName
            Dim wInt As Integer = mvObj_SqlCommand.ExecuteNonQuery()
            If (wInt > 0) Then
                Return True
            End If
        Catch ex As Exception
            Throw ex
            Return False
        End Try
        Return True
    End Function

    '# MethodName       :       FuncM_ExecuteStore
    '# Description      :       This method excecutes a storeprocedure
    '# Parameter        :       StoreName 
    '# ReturnValue      :       True or False
    '# Author           :       THI
    '# CreateDate       :       2008-06-18
    '# LastUpdate       :       2008-06-18
    '#-----------------------------------------------------------------------
    Protected Function FuncM_ExecuteFunction(ByVal iStr_FuncName As String) As Boolean
        Try
            mvObj_SqlCommand.Connection = mvObj_SqlConnection
            mvObj_SqlCommand.CommandType = CommandType.Text
            mvObj_SqlCommand.CommandText = iStr_FuncName
            mvObj_SqlCommand.ExecuteReader()
            Return True
        Catch ex As Exception
            Return False
            Throw ex
        End Try

    End Function
    '# MethodName       :       FuncM_ExecuteNonQuery
    '# Description      :       This method excecutes a excecutenonquery statement
    '# Parameter        :       excecutenonquery statement
    '# ReturnValue      :       True or False
    '# Author           :       THI
    '# CreateDate       :       2008-06-18
    '# LastUpdate       :       2008-06-18
    '#-----------------------------------------------------------------------
    Protected Function FuncM_ExecuteNonQuery(ByVal iStr_Sql As String) As Boolean
        Try
            mvObj_SqlCommand.Connection = mvObj_SqlConnection
            mvObj_SqlCommand.CommandType = CommandType.Text
            mvObj_SqlCommand.CommandText = iStr_Sql
            mvObj_SqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            Return False
            Throw ex
        End Try
        Return True
    End Function
    '# MethodName       :       FuncM_ExecuteScalar
    '# Description      :       This method excecutes a excecutescalar statement
    '# Parameter        :       excecutescalar statemen
    '# ReturnValue      :       Object
    '# Author           :       THI
    '# CreateDate       :       2008-06-18
    '# LastUpdate       :       2008-06-18
    '#-----------------------------------------------------------------------
    Protected Function FuncM_ExecuteScalar(ByVal iStr_Sql As String) As Object
        Dim wObj As Object = Nothing
        Try
            mvObj_SqlCommand.Connection = mvObj_SqlConnection
            mvObj_SqlCommand.CommandType = CommandType.Text
            mvObj_SqlCommand.CommandText = iStr_Sql
            wObj = mvObj_SqlCommand.ExecuteScalar()
        Catch ex As Exception
            Throw ex
        End Try
        Return wObj
    End Function
#End Region
End Class
