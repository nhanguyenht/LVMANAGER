Imports System.Data.SqlClient
Imports Microsoft.Synchronization
Imports Microsoft.Synchronization.Data
Imports Microsoft.Synchronization.Data.SqlServer
Imports System.Collections.ObjectModel

Public Class cls_Synchronous_Data
    Inherits cls_Database_Base

    Dim mvStr_ClientConn As String
    Dim mvStr_ServerConn As String

    Public Property ClientConn()
        Get
            Return mvStr_ClientConn
        End Get
        Set(ByVal value)
            mvStr_ClientConn = value
        End Set
    End Property

    Public Property ServerConn()
        Get
            Return mvStr_ServerConn
        End Get
        Set(ByVal value)
            mvStr_ServerConn = value
        End Set
    End Property
    Public WriteOnly Property ClientConn(ByVal iServer As String, ByVal iDbName As String, ByVal iUserName As String, ByVal iPassword As String)
        Set(ByVal value)
            Dim mvObj_Conn As New SqlConnectionStringBuilder() With {.DataSource = iServer, .InitialCatalog = iDbName, .UserID = iUserName, .Password = iPassword, .PersistSecurityInfo = False}
            value = mvObj_Conn.ConnectionString
            mvStr_ClientConn = value
        End Set
    End Property

    Public WriteOnly Property ServerConn(ByVal iServer As String, ByVal iDbName As String, ByVal iUserName As String, ByVal iPassword As String)
        Set(ByVal value)
            Dim mvObj_Conn As New SqlConnectionStringBuilder() With {.DataSource = iServer, .InitialCatalog = iDbName, .UserID = iUserName, .Password = iPassword, .PersistSecurityInfo = False}
            mvStr_ServerConn = mvObj_Conn.ConnectionString
        End Set
    End Property

    Public Function FuncM_SetServerProvision(ByVal iStr_TableName As String, ByVal iStr_LocID As String, Optional ByVal iStr_FilterColumn As String = "", Optional ByVal iStr_FilterValue As String = "") As String
        Try
            Dim mvStr_ScopeName As String
            Dim mvObj_TableDesc As New DbSyncTableDescription()
            Dim mvObj_SqlConnection As New SqlConnection(mvStr_ServerConn)
            If iStr_FilterColumn = "" Then
                mvStr_ScopeName = iStr_TableName & "_Scope_" & iStr_LocID
            Else
                mvStr_ScopeName = iStr_TableName & "-" & iStr_FilterColumn & "-" & iStr_FilterValue
            End If

            'Define the scope description
            Dim mvObj_ScopeDesc As New DbSyncScopeDescription(mvStr_ScopeName)

            'Get the description of the table
            mvObj_TableDesc = SqlSyncDescriptionBuilder.GetDescriptionForTable(iStr_TableName, mvObj_SqlConnection)
            mvObj_ScopeDesc.Tables.Add(mvObj_TableDesc)
            If iStr_TableName = "TBL_SALES_DETAIL" Then
                mvObj_ScopeDesc.Tables(iStr_TableName).Columns.Remove(mvObj_ScopeDesc.Tables(iStr_TableName).Columns("TOTAL"))
                mvObj_ScopeDesc.Tables(iStr_TableName).Columns.Remove(mvObj_ScopeDesc.Tables(iStr_TableName).Columns("TOTALDISCOUNT"))
                mvObj_ScopeDesc.Tables(iStr_TableName).Columns.Remove(mvObj_ScopeDesc.Tables(iStr_TableName).Columns("TOTALSERVICE"))
                mvObj_ScopeDesc.Tables(iStr_TableName).Columns.Remove(mvObj_ScopeDesc.Tables(iStr_TableName).Columns("TOTALVAT"))
                mvObj_ScopeDesc.Tables(iStr_TableName).Columns.Remove(mvObj_ScopeDesc.Tables(iStr_TableName).Columns("FINALTOTAL"))
            End If
            If iStr_TableName = "TBL_INCOME" Then
                mvObj_ScopeDesc.Tables(iStr_TableName).Columns.Remove(mvObj_ScopeDesc.Tables(iStr_TableName).Columns("TOTAL"))
            End If
            'Create a server scope provisioning object
            Dim mvObj_ServerProvision As New SqlSyncScopeProvisioning(mvObj_SqlConnection, mvObj_ScopeDesc)
            mvObj_ServerProvision.SetCreateTableDefault(DbSyncCreationOption.Skip)
            If iStr_FilterColumn <> "" Then
                'Set the filter column
                mvObj_ServerProvision.Tables(iStr_TableName).AddFilterColumn(iStr_FilterColumn)
                'Set the filter value
                mvObj_ServerProvision.Tables(iStr_TableName).FilterClause = "[side].[" & iStr_FilterColumn & "] = " & iStr_FilterValue
            End If
            If Not mvObj_ServerProvision.ScopeExists(mvStr_ScopeName) Then
                'Start the server provisioning process
                mvObj_ServerProvision.Apply()
                Return mvStr_ScopeName
            Else
                Return mvStr_ScopeName
            End If
        Catch ex As Exception
            If gvByte_Language = 1 Then
                FunG_Alert("Thông báo lỗi", ex.Message, frm_Alert.WTYPE.ERROR)
            Else
                FunG_Alert("Error", ex.Message, frm_Alert.WTYPE.ERROR)
            End If

            Return ""
        End Try
    End Function

    Public Function FuncM_SetClientProvision(ByVal iStr_ScopeName As String, ByVal iStr_LocID As String) As Boolean
        Try
            Dim mvObj_SqlServerConnection As New SqlConnection(mvStr_ServerConn)
            Dim mvObj_SqlClientConnection As New SqlConnection(mvStr_ClientConn)

            'get the scope description from server
            Dim mvObj_ScopeDesc As New DbSyncScopeDescription()
            mvObj_ScopeDesc = SqlSyncDescriptionBuilder.GetDescriptionForScope(iStr_ScopeName, mvObj_SqlServerConnection)
            If iStr_ScopeName = "TBL_INCOME_Scope_" & iStr_LocID Then
                'mvObj_ScopeDesc.Tables("TBL_INCOME").Columns.Remove(mvObj_ScopeDesc.Tables("TBL_INCOME").Columns("ID"))
            End If
            'Create a client provisioning object
            Dim mvObj_ClientProvision As New SqlSyncScopeProvisioning(mvObj_SqlClientConnection, mvObj_ScopeDesc)
            If Not mvObj_ClientProvision.ScopeExists(iStr_ScopeName) Then
                'Start the client provisioning process
                mvObj_ClientProvision.Apply()
                Return True
            Else
                Return True
            End If
        Catch ex As Exception
            If gvByte_Language = 1 Then
                FunG_Alert("Thông báo lỗi", ex.Message, frm_Alert.WTYPE.ERROR)
            Else
                FunG_Alert("Error", ex.Message, frm_Alert.WTYPE.ERROR)
            End If
            Return False
        End Try
    End Function
    Public Function FuncM_ExecuteSynchronization(ByVal iStr_ScopeName As String) As Boolean
        Try
            Dim mvObj_SqlServerConnection As New SqlConnection(mvStr_ServerConn)
            Dim mvObj_SqlClientConnection As New SqlConnection(mvStr_ClientConn)
            Dim mvObj_Orchestrator As New SyncOrchestrator

            'Set the local provider of sync orchestrator
            mvObj_Orchestrator.LocalProvider = New SqlSyncProvider(iStr_ScopeName, mvObj_SqlClientConnection)
            'Set the remote provider
            mvObj_Orchestrator.RemoteProvider = New SqlSyncProvider(iStr_ScopeName, mvObj_SqlServerConnection)

            'Set the direction to upload
            mvObj_Orchestrator.Direction = SyncDirectionOrder.Upload

            'Start the synchornization session
            Dim mvObj_SyncStats As SyncOperationStatistics
            mvObj_SyncStats = mvObj_Orchestrator.Synchronize()

            'MessageBox.Show("Start time: " & mvObj_SyncStats.SyncStartTime & " Total Changes Uploaded: " & mvObj_SyncStats.UploadChangesTotal _
            '                & " Total Changes Downloaded: " & mvObj_SyncStats.DownloadChangesTotal & " End time: " & mvObj_SyncStats.SyncEndTime)
            Return True
        Catch ex As Exception
            If gvByte_Language = 1 Then
                FunG_Alert("Thông báo lỗi", ex.Message, frm_Alert.WTYPE.ERROR)
            Else
                FunG_Alert("Error", ex.Message, frm_Alert.WTYPE.ERROR)
            End If
            Return False
        End Try
    End Function

    Public Function FuncM_SyncByTableName(ByVal iStr_TableName As String, ByVal iStr_LocID As String, Optional ByVal iStr_FilterColumn As String = "", Optional ByVal iStr_FilterValue As String = "") As Boolean
        Dim mvStr_ScopeName As String
        Dim mvBol_IsClientProvision As Boolean = False
        Try
            mvStr_ScopeName = FuncM_SetServerProvision(iStr_TableName, iStr_LocID, iStr_FilterColumn, iStr_FilterValue)
            If mvStr_ScopeName = "" Then
                Return False
            End If
            mvBol_IsClientProvision = FuncM_SetClientProvision(mvStr_ScopeName, iStr_LocID)
            If mvBol_IsClientProvision = False Then
                Return False
            End If
            Return FuncM_ExecuteSynchronization(mvStr_ScopeName)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function FuncM_DeprovisionClientByScope(ByVal iStr_ScopeName As String) As Boolean
        Try
            Dim mvObj_SqlClientConnection As New SqlConnection(mvStr_ClientConn)
            Dim mvObj_DeprovisionClient As New SqlSyncScopeDeprovisioning(mvObj_SqlClientConnection)

            mvObj_DeprovisionClient.DeprovisionScope(iStr_ScopeName)
            Return True
        Catch ex As Exception
            Return False
        End Try
        
    End Function
End Class
