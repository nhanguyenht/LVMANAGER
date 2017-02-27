Public Class frm_Login
#Region "Khai Báo Biến"
    Dim mvCls_Logon As New cls_Login
    Dim mvCls_SetupUpdate As New cls_Setup_Update
    Private mvcls_CIE_Account_Base As cls_Account = Nothing
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        Try
            Me.txtUserName.TabIndex = 1
            Me.txtPassword.TabIndex = 2
            Me.cmdDangNhap.TabIndex = 3
            Me.cmdThoat.TabIndex = 4
            Me.txtUserName.Text = ""
            Me.txtPassword.Text = ""
            If gvStr_AccUser <> "" Then
                txtUserName.Text = gvStr_AccUser
            End If
            Me.txtUserName.Focus()
            'DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Liquid Sky")
            mod_LoadLanguageForm.SubG_LoginForm()

            'TEST
            'Me.txtUserName.Text = "ADMIN"
            'Me.txtPassword.Text = "LEVU"
            rgpLanguage.SelectedIndex = gvByte_Language - 1
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region
#Region "FormLoad"
    Private Sub frm_Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.Alt And e.KeyCode = Keys.F4) Then
            End
        End If
    End Sub
    Private Sub frm_CIE_Logon_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SubM_InitializeForm()
        'Lấy thông tin hệ thống
        SubM_LoadSetting()
    End Sub
#End Region
#Region "TextChanged"
    Private Sub txtCheck_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged, txtPassword.TextChanged
        mvCls_Logon.SubG_FormatButton(Me.txtUserName, Me.txtPassword, Me.cmdDangNhap)
    End Sub
#End Region
#Region "Lấy Thông tin Người Dùng"
    Private Function FuncM_GetPermit() As cls_Account
        Try
            Dim mvStr_HashPassMD5 As String = getMd5Hash(Me.txtPassword.Text.Trim)
            Dim wcls_ERP_Account_Update As New cls_Account_Update
            mvcls_CIE_Account_Base = wcls_ERP_Account_Update.FuncG_GetLoginInfo(Me.txtUserName.Text.Trim, mvStr_HashPassMD5)
        Catch ex As Exception
            Throw ex
        End Try
        Return mvcls_CIE_Account_Base
    End Function
#End Region
#Region "Hàm kiểm tra"
    Private Sub SubM_Logon()
        Try
            If FuncM_GetPermit() Is Nothing Then
                SubG_Alert(99) '("Thông báo", "Tài khoản này không tồn tại!", frm_Alert.WTYPE.ERROR)
                Form.ActiveForm.ActiveControl = Me.txtUserName
            Else
                If FuncM_GetPermit.Status Then

                    gvStr_Permit = FuncM_GetPermit.Permit
                    Dim Fag As Boolean = String.Equals(gvStr_Permit(2), "1"c)
                    'If Fag = True Or txtUserName.Text.ToUpper() = "ADMIN" Then
                    If gvStr_Permit = "11111111" Then
                        frm_MainMenu.SubM_PhanQuyen()
                        frm_MainMenu.RibbonPage1.Visible = True
                        'frm_MainMenu.RpCNdanhmuc.Visible = True
                        'frm_MainMenu.RpCNHethong.Visible = True
                        Me.Close()

                    Else
                        'SubG_Alert(100) 'FunG_Alert("Thông báo", "Tài khoản này không đủ quyền truy cập vào hệ thống!", frm_Alert.WTYPE.ERROR)
                        'Form.ActiveForm.ActiveControl = Me.txtUserName
                        frm_MainMenu.SubM_PhanQuyen()
                        ' frm_MainMenu.RpCNHethong.Visible = False
                        Me.Close()
                    End If

                Else
                    If gvByte_Language = 1 Then
                        FunG_Alert("Thông báo", "Tài khoản này đang bị khóa!" & Chr(13) & " Vui lòng liên hệ với người quản trị!", frm_Alert.WTYPE.ERROR)
                    Else
                        FunG_Alert("Message", "This account is locked!" & Chr(13) & "Please contact your administrator!", frm_Alert.WTYPE.ERROR)
                    End If

                    Form.ActiveForm.ActiveControl = Me.txtUserName
                End If
            End If
            Me.txtUserName.Text = ""
            Me.txtPassword.Text = ""
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#Region "Phân Quyền"
    Public Shared Sub SubM_PhanQuyen()
        frm_MainMenu.Enabled = True

    End Sub
#End Region
#Region "Thay đổi ngôn ngữ"
    Private Sub rgpLanguage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgpLanguage.SelectedIndexChanged
        Try
            If Me.rgpLanguage.SelectedIndex = 0 Then
                gvByte_Language = 1
            Else
                gvByte_Language = 2
            End If
            mod_LoadLanguageForm.SubG_LoginForm()
            frm_MainMenu.Loadlanguage()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Kết nối tạm thời"
    Private Sub cmdDangNhap_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDangNhap.Click
        gvProp_AccUser = Me.txtUserName.Text.Trim
        Try
            SubM_Logon()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#Region "Nút Thoát"
    Private Sub cmdThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        End
    End Sub
#End Region
#Region "Load setting"
    Private Sub SubM_LoadSetting()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_SetupUpdate.FuncG_GetData
            If mvObj_DataTable.Rows.Count = 0 Then
                End
            Else
                gvBol_RedStatus = mvObj_DataTable.Rows(0)("RED_STATUS")
                gvBol_VatStatus = mvObj_DataTable.Rows(0)("VAT_STATUS")
                gvBol_PrintOrder = mvObj_DataTable.Rows(0)("PRINTORDER")
                gvByte_NumberPrint = mvObj_DataTable.Rows(0)("PRINTNUMBER")
                gvByte_ReportTime = mvObj_DataTable.Rows(0)("REPORT_TIME")
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class