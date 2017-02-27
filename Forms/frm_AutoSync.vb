Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO
Public Class frm_AutoSync
    Public mvBol_ManualSync As Boolean = False

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSync.Click
        Dim mvObj_Locations As New List(Of cls_Location)
        Dim mvCls_SyncData As New cls_Synchronous_Data()
        Dim mvObj_ClientConn As New SqlConnectionStringBuilder()
        Dim mvObj_ServerConn As New SqlConnectionStringBuilder()
        Try
            mvObj_Locations = SubM_ReadXML()
            If mvObj_Locations.Count <> 0 Then
                SubM_SyncAll(mvObj_Locations)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SubM_SyncAll(ByVal iList_Location As List(Of cls_Location))
        Dim mvObj_ClientConn As New SqlConnectionStringBuilder()
        Dim mvObj_ServerConn As New SqlConnectionStringBuilder() With {.DataSource = gvStr_Server, .InitialCatalog = gvStr_Database, .UserID = gvStr_User, .Password = gvStr_Pass, .PersistSecurityInfo = False}
        Dim mvCls_SyncData As New cls_Synchronous_Data()
        Dim mvBool_Succ As Boolean = False
        Dim mvStr_Mess As String = ""
        Try
            'gvStr_LocID = "00"
            If gvStr_LocID = "00" Then
                'mvStr_Mess = "Đồng bộ thành công:" + Chr(13)
                lblProgress.Text = "Vui lòng chờ ...!"
                mvCls_SyncData.ServerConn = mvObj_ServerConn.ConnectionString
                For Each mvObj_Location As cls_Location In iList_Location
                    If mvObj_Location.ID <> "00" Then
                        'Add client connection string
                        With mvObj_ClientConn
                            .DataSource = mvObj_Location.IPAddress
                            .InitialCatalog = gvStr_Database
                            .UserID = mvObj_Location.UserName
                            .Password = mvObj_Location.Password
                            .PersistSecurityInfo = False
                        End With
                        Try
                            mvCls_SyncData.ClientConn = mvObj_ClientConn.ConnectionString
                            'Sync Data by table name
                            mvBool_Succ = False
                            mvBool_Succ = mvCls_SyncData.FuncM_SyncByTableName("TBL_MENUGROUPITEM", mvObj_Location.ID)
                            If mvBool_Succ = True Then
                                mvBool_Succ = mvCls_SyncData.FuncM_SyncByTableName("TBL_ITEM", mvObj_Location.ID)
                                If mvBool_Succ = True Then
                                    mvBool_Succ = mvCls_SyncData.FuncM_SyncByTableName("TBL_TABLE", mvObj_Location.ID)
                                    If mvBool_Succ = True Then
                                        mvBool_Succ = mvCls_SyncData.FuncM_SyncByTableName("TBL_SALES", mvObj_Location.ID)
                                        If mvBool_Succ = True Then
                                            mvBool_Succ = mvCls_SyncData.FuncM_SyncByTableName("TBL_SALES_DETAIL", mvObj_Location.ID)
                                            If mvBool_Succ = True Then
                                                mvBool_Succ = mvCls_SyncData.FuncM_SyncByTableName("TBL_INCOME", mvObj_Location.ID)
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            If mvBool_Succ = True Then
                                If mvStr_Mess = "" Then
                                    mvStr_Mess = "Đồng bộ thành công:" + Chr(13)
                                End If
                                mvStr_Mess = mvStr_Mess + "- Máy " + mvObj_Location.ID + Chr(13)
                            End If
                        Catch ex As Exception

                        End Try
                    End If
                Next
                If mvStr_Mess = "" Then
                    mvStr_Mess = "Đồng bộ không thành công !"
                End If
                lblProgress.Text = mvStr_Mess
            Else
                If mvStr_Mess = "" Then
                    mvStr_Mess = "Đồng bộ không thành công! Máy bạn không phải là máy chủ"
                End If
                lblProgress.Text = mvStr_Mess
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function SubM_ReadXML() As List(Of cls_Location)
        Dim mvCls_Location As New cls_Location
        Dim iList_Location As New List(Of cls_Location)()
        Try
            If File.Exists(Application.StartupPath + "\location.xml") Then
                ' Create an XML reader.
                Using reader As XmlReader = XmlReader.Create(Application.StartupPath + "\location.xml")
                    While reader.Read()
                        If reader.IsStartElement() Then
                            If reader.Name = "Locations" Then

                            ElseIf reader.Name = "ID" Then
                                ' Text data.
                                If reader.Read() Then
                                    mvCls_Location.ID = reader.Value
                                End If
                            ElseIf reader.Name = "Name" Then
                                ' Text data.
                                If reader.Read() Then
                                    mvCls_Location.Name = reader.Value
                                End If
                            ElseIf reader.Name = "Address" Then
                                ' Text data.
                                If reader.Read() Then
                                    mvCls_Location.Address = reader.Value
                                End If
                            ElseIf reader.Name = "IPAddress" Then
                                ' Text data.
                                If reader.Read() Then
                                    mvCls_Location.IPAddress = reader.Value
                                End If
                            ElseIf reader.Name = "Username" Then
                                ' Text data.
                                If reader.Read() Then
                                    mvCls_Location.UserName = reader.Value
                                End If
                            ElseIf reader.Name = "Password" Then
                                ' Text data.
                                If reader.Read() Then
                                    mvCls_Location.Password = reader.Value
                                    'Add data in to gird
                                    iList_Location.Add(New cls_Location() With {.ID = mvCls_Location.ID, .Name = mvCls_Location.Name, .Address = mvCls_Location.Address _
                                                                               , .IPAddress = mvCls_Location.IPAddress, .UserName = mvCls_Location.UserName, .Password = mvCls_Location.Password})
                                End If
                            End If
                        End If
                    End While
                End Using
            End If

        Catch ex As Exception

        End Try
        Return iList_Location
    End Function

    Private Sub frm_AutoSync_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblProgress.Text = ""
    End Sub
End Class