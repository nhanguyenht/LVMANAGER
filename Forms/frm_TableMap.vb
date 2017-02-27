Public Class frm_TableMap
#Region "Khai Báo Biến"
    Dim mvStr_ID As String
    Dim mvCls_Item As New cls_Item
    Dim mvCls_ItemUpdate As New cls_Item_Update
    Dim mvCls_GroupItemUpdate As New cls_GroupItem_Update
    Dim mvCmd_SimpleButton As New DevExpress.XtraEditors.SimpleButton
#End Region
#Region "Hàm Khởi Tạo"
    Public Sub SubM_InitializeForm()
        SubM_LoadMenu()
        PanelControl3.Visible = True
        PanelControl3.Dock = DockStyle.Top
        PanelControl2.Visible = False
        PanelControl2.Dock = DockStyle.None
    End Sub
#End Region
    Private Sub SubM_LoadMenu()
        Dim mvObj_GroupItemData As New DataTable
        Dim mvObj_TableData As New DataTable
        Try
            'Load menu
            mvObj_GroupItemData = mvCls_GroupItemUpdate.FuncG_GetAllData
            For i As Integer = gvInt_StartMenu To gvInt_EndMenu
                mvCmd_SimpleButton = DirectCast(FunM_GetControlByName(Me.PanelControl3, "cmdMenu" & CStr(i)), DevExpress.XtraEditors.SimpleButton)
                If mvObj_GroupItemData.Rows.Count > i Then
                    If mvObj_GroupItemData.Rows(i)("STATUS") = 1 Then
                        mvCmd_SimpleButton.Tag = mvObj_GroupItemData.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = mvObj_GroupItemData.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(192, 255, 255)
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(0, 192, 192)
                    Else
                        mvCmd_SimpleButton.Tag = mvObj_GroupItemData.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = mvObj_GroupItemData.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                    End If
                    If i = 0 And Me.lblIndex.Text = "" Then
                        mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.DarkOrange
                    Else
                        If Me.lblIndex.Text = mvCmd_SimpleButton.Tag Then
                            mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
                            mvCmd_SimpleButton.Appearance.BackColor2 = Color.DarkOrange
                        End If
                    End If
                Else
                    mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                    mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                    mvCmd_SimpleButton.Tag = ""
                    mvCmd_SimpleButton.Text = ""
                End If
            Next

            For i As Integer = 24 To 47
                mvCmd_SimpleButton = DirectCast(FunM_GetControlByName(Me.PanelControl2, "cmdMenu" & CStr(i)), DevExpress.XtraEditors.SimpleButton)
                If mvObj_GroupItemData.Rows.Count > i Then
                    If mvObj_GroupItemData.Rows(i)("STATUS") = 1 Then
                        mvCmd_SimpleButton.Tag = mvObj_GroupItemData.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = mvObj_GroupItemData.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(192, 255, 255)
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(0, 192, 192)
                    Else
                        mvCmd_SimpleButton.Tag = mvObj_GroupItemData.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = mvObj_GroupItemData.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                    End If
                    If i = 0 And Me.lblIndex.Text = "" Then
                        mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.DarkOrange
                    Else
                        If Me.lblIndex.Text = mvCmd_SimpleButton.Tag Then
                            mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
                            mvCmd_SimpleButton.Appearance.BackColor2 = Color.DarkOrange
                        End If
                    End If
                Else
                    mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                    mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                    mvCmd_SimpleButton.Tag = ""
                    mvCmd_SimpleButton.Text = ""
                End If
            Next

            'Load món ăn trong menu đầu tiên
            If Me.lblIndex.Text = "" Then
                mvObj_TableData = mvCls_ItemUpdate.FuncG_GetAllData(mvObj_GroupItemData.Rows(0)("ID"))
            Else
                mvObj_TableData = mvCls_ItemUpdate.FuncG_GetAllData(Me.lblIndex.Text)
            End If
            Me.SubM_LoadTable(mvObj_TableData)

            Dim countmenu As Integer = 0
            countmenu = mvCls_GroupItemUpdate.FuncG_GetCountMenuGroup()
            If countmenu > 23 Then
                cmdPrevious.Visible = True
                cmdNext.Visible = True
            Else
                cmdPrevious.Visible = False
                cmdNext.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Shared Function FunM_GetControlByName(ByVal pobjParent As Control, ByVal pstrCtlName As String) As Control
        Dim objCtl As Control
        For Each objCtl In pobjParent.Controls
            If objCtl.Name = pstrCtlName Then
                Return (objCtl)
            End If
        Next
        ' if control is not found
        Return Nothing
    End Function
#Region "Hàm load món ăn"
    Private Sub SubM_LoadTable(ByVal iObj_DataTable As DataTable)
        Try
            For i As Integer = gvInt_StartPluOfMenu To gvInt_EndPluOfMenu
                mvCmd_SimpleButton = DirectCast(FunM_GetControlByName(Me.PanelControl1, "cmdBan" & CStr(i)), DevExpress.XtraEditors.SimpleButton)
                If iObj_DataTable.Rows.Count > i Then
                    If iObj_DataTable.Rows(i)("STATUS") = 1 Then
                        mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.White
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(iObj_DataTable.Rows(i)("COLOR"))
                        'mvCmd_SimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
                    Else
                        mvCmd_SimpleButton.Tag = iObj_DataTable.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = iObj_DataTable.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                        'mvCmd_SimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
                    End If
                Else
                    mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                    mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                    mvCmd_SimpleButton.Tag = ""
                    mvCmd_SimpleButton.Text = ""
                    mvCmd_SimpleButton.Enabled = True
                End If
            Next

        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Events"
    Private Sub Frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SubM_InitializeForm()
    End Sub
#End Region
#Region "Chọn menu"
    Private Sub cmdKhuVuc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMenu9.Click, cmdMenu8.Click, cmdMenu7.Click, cmdMenu6.Click, cmdMenu5.Click, cmdMenu47.Click, cmdMenu46.Click, cmdMenu45.Click, cmdMenu44.Click, cmdMenu43.Click, cmdMenu4.Click, cmdMenu39.Click, cmdMenu38.Click, cmdMenu37.Click, cmdMenu36.Click, cmdMenu35.Click, cmdMenu34.Click, cmdMenu33.Click, cmdMenu32.Click, cmdMenu31.Click, cmdMenu30.Click, cmdMenu3.Click, cmdMenu29.Click, cmdMenu28.Click, cmdMenu27.Click, cmdMenu26.Click, cmdMenu25.Click, cmdMenu24.Click, cmdMenu23.Click, cmdMenu22.Click, cmdMenu21.Click, cmdMenu20.Click, cmdMenu2.Click, cmdMenu19.Click, cmdMenu18.Click, cmdMenu17.Click, cmdMenu16.Click, cmdMenu15.Click, cmdMenu14.Click, cmdMenu13.Click, cmdMenu12.Click, cmdMenu11.Click, cmdMenu10.Click, cmdMenu1.Click, cmdMenu0.Click
        Dim mvObj_AreaData As New DataTable
        Dim mvObj_DataTable As New DataTable
        Try

            'Load menu
            mvObj_AreaData = mvCls_GroupItemUpdate.FuncG_GetAllData
            For i As Integer = gvInt_StartMenu To gvInt_EndMenu
                mvCmd_SimpleButton = DirectCast(FunM_GetControlByName(Me.PanelControl3, "cmdMenu" & CStr(i)), DevExpress.XtraEditors.SimpleButton)
                If mvObj_AreaData.Rows.Count > i Then
                    If mvObj_AreaData.Rows(i)("STATUS") = 1 Then
                        mvCmd_SimpleButton.Tag = mvObj_AreaData.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = mvObj_AreaData.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(192, 255, 255)
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(0, 192, 192)
                    Else
                        mvCmd_SimpleButton.Tag = mvObj_AreaData.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = mvObj_AreaData.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                    End If
                Else
                    mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                    mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                    mvCmd_SimpleButton.Tag = ""
                    mvCmd_SimpleButton.Text = ""
                End If
            Next

            '===========================================
            For i As Integer = 24 To 47
                mvCmd_SimpleButton = DirectCast(FunM_GetControlByName(Me.PanelControl2, "cmdMenu" & CStr(i)), DevExpress.XtraEditors.SimpleButton)
                If mvObj_AreaData.Rows.Count > i Then
                    If mvObj_AreaData.Rows(i)("STATUS") = 1 Then
                        mvCmd_SimpleButton.Tag = mvObj_AreaData.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = mvObj_AreaData.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.FromArgb(192, 255, 255)
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.FromArgb(0, 192, 192)
                    Else
                        mvCmd_SimpleButton.Tag = mvObj_AreaData.Rows(i)("ID")
                        mvCmd_SimpleButton.Text = mvObj_AreaData.Rows(i)("NAME")
                        mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                        mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                    End If
                Else
                    mvCmd_SimpleButton.Appearance.BackColor = Color.Transparent
                    mvCmd_SimpleButton.Appearance.BackColor2 = Color.Transparent
                    mvCmd_SimpleButton.Tag = ""
                    mvCmd_SimpleButton.Text = ""
                End If
            Next
            '===========================================
            mvCmd_SimpleButton = DirectCast(sender, DevExpress.XtraEditors.SimpleButton)
            mvCmd_SimpleButton.Appearance.BackColor = Color.Moccasin
            mvCmd_SimpleButton.Appearance.BackColor2 = Color.DarkOrange
            'Me.txtGroupItem.Text = mvCmd_SimpleButton.Text
            'Me.txtGroupItem.Tag = mvCmd_SimpleButton.Tag
            'Me.txtItem.Tag = ""
            'Me.txtItem.Text = ""
            'Me.txtPrice1.Text = ""
            'Me.txtPrice2.Text = ""
            'Me.txtUnit.Text = ""
            'Me.cmdOn.Enabled = False
            'Me.cmdOff.Enabled = False
            'Lấy ID từ thuộc tính Tag
            Me.lblIndex.Text = mvCmd_SimpleButton.Tag
            mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetAllData(mvCmd_SimpleButton.Tag)
            Me.SubM_LoadTable(mvObj_DataTable)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Chọn món"
    Private Sub cmdBan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBan0.Click, _
    cmdBan1.Click, cmdBan2.Click, cmdBan3.Click, cmdBan4.Click, cmdBan5.Click, cmdBan6.Click, cmdBan7.Click, _
    cmdBan8.Click, cmdBan9.Click, cmdBan10.Click, cmdBan11.Click, cmdBan12.Click, cmdBan13.Click, cmdBan14.Click, _
    cmdBan15.Click, cmdBan16.Click, cmdBan17.Click, cmdBan18.Click, cmdBan19.Click, cmdBan20.Click, cmdBan21.Click, _
    cmdBan22.Click, cmdBan23.Click, cmdBan24.Click, cmdBan25.Click, cmdBan26.Click, cmdBan27.Click, cmdBan28.Click, _
    cmdBan29.Click, cmdBan30.Click, cmdBan31.Click, cmdBan32.Click, cmdBan33.Click, cmdBan34.Click, cmdBan35.Click, _
    cmdBan36.Click, cmdBan37.Click, cmdBan38.Click, cmdBan39.Click, cmdMenu42.Click, cmdMenu41.Click, cmdMenu40.Click
        Dim mvObj_DataTable As New DataTable
        Try
            mvCmd_SimpleButton = DirectCast(sender, DevExpress.XtraEditors.SimpleButton)
            mvObj_DataTable = mvCls_ItemUpdate.FuncG_GetDataInfo(mvCmd_SimpleButton.Tag)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Chọn món"
    Private Sub cmdBan_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdBan0.MouseDown, _
        cmdBan1.MouseDown, cmdBan2.MouseDown, cmdBan3.MouseDown, cmdBan4.MouseDown, cmdBan5.MouseDown, cmdBan6.MouseDown, cmdBan7.MouseDown, _
        cmdBan8.MouseDown, cmdBan9.MouseDown, cmdBan10.MouseDown, cmdBan11.MouseDown, cmdBan12.MouseDown, cmdBan13.MouseDown, cmdBan14.MouseDown, _
        cmdBan15.MouseDown, cmdBan16.MouseDown, cmdBan17.MouseDown, cmdBan18.MouseDown, cmdBan19.MouseDown, cmdBan20.MouseDown, cmdBan21.MouseDown, _
        cmdBan22.MouseDown, cmdBan23.MouseDown, cmdBan24.MouseDown, cmdBan25.MouseDown, cmdBan26.MouseDown, cmdBan27.MouseDown, cmdBan28.MouseDown, _
        cmdBan29.MouseDown, cmdBan30.MouseDown, cmdBan31.MouseDown, cmdBan32.MouseDown, cmdBan33.MouseDown, cmdBan34.MouseDown, cmdBan35.MouseDown, _
        cmdBan36.MouseDown, cmdBan37.MouseDown, cmdBan38.MouseDown, cmdBan39.MouseDown
        If MouseButtons = System.Windows.Forms.MouseButtons.Right Then
            mvStr_ID = DirectCast(sender, DevExpress.XtraEditors.SimpleButton).Tag
            Me.PopupMenu1.ShowPopup(Control.MousePosition)
        End If
    End Sub
#End Region
#Region "Nút edit"
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEdit.ItemClick
        If mvStr_ID <> "" Then
            frm_EditItem.gvStr_ID = mvStr_ID
            frm_EditItem.ShowDialog()
        End If
    End Sub
#End Region

    Private Sub frm_TableMap_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_SetMenu.SubM_LoadData()
    End Sub
    Private Sub cmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevious.Click
        PanelControl3.Visible = True
        PanelControl3.Dock = DockStyle.Top
        PanelControl2.Visible = False
        PanelControl2.Dock = DockStyle.None
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click


        PanelControl3.Visible = False
        PanelControl3.Dock = DockStyle.None
        PanelControl2.Visible = True
        PanelControl2.Dock = DockStyle.Top
    End Sub
End Class