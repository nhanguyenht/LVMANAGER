Imports System
Imports System.IO
Public Class frm_ChangePassword
    Inherits DevExpress.XtraEditors.XtraForm
#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcChangePass As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtPassCu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPass2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPass1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblRePass As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNewPass As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOldPass As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ChangePassword))
        Me.cmdThoat = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCapNhat = New DevExpress.XtraEditors.SimpleButton
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gpcChangePass = New DevExpress.XtraEditors.GroupControl
        Me.lblRePass = New DevExpress.XtraEditors.LabelControl
        Me.lblNewPass = New DevExpress.XtraEditors.LabelControl
        Me.lblOldPass = New DevExpress.XtraEditors.LabelControl
        Me.txtPass2 = New DevExpress.XtraEditors.TextEdit
        Me.txtPass1 = New DevExpress.XtraEditors.TextEdit
        Me.txtPassCu = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcChangePass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcChangePass.SuspendLayout()
        CType(Me.txtPass2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassCu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdThoat
        '
        Me.cmdThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThoat.Appearance.Options.UseFont = True
        Me.cmdThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdThoat.Image = CType(resources.GetObject("cmdThoat.Image"), System.Drawing.Image)
        Me.cmdThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdThoat.Location = New System.Drawing.Point(779, 32)
        Me.cmdThoat.Name = "cmdThoat"
        Me.cmdThoat.Size = New System.Drawing.Size(133, 50)
        Me.cmdThoat.TabIndex = 5
        Me.cmdThoat.Text = "Thoát"
        '
        'cmdCapNhat
        '
        Me.cmdCapNhat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCapNhat.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCapNhat.Appearance.Options.UseFont = True
        Me.cmdCapNhat.Image = CType(resources.GetObject("cmdCapNhat.Image"), System.Drawing.Image)
        Me.cmdCapNhat.Location = New System.Drawing.Point(636, 32)
        Me.cmdCapNhat.Name = "cmdCapNhat"
        Me.cmdCapNhat.Size = New System.Drawing.Size(137, 50)
        Me.cmdCapNhat.TabIndex = 4
        Me.cmdCapNhat.Text = "Cập nhật"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'gpcChangePass
        '
        Me.gpcChangePass.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcChangePass.Appearance.Options.UseFont = True
        Me.gpcChangePass.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcChangePass.AppearanceCaption.Options.UseFont = True
        Me.gpcChangePass.Controls.Add(Me.lblRePass)
        Me.gpcChangePass.Controls.Add(Me.lblNewPass)
        Me.gpcChangePass.Controls.Add(Me.lblOldPass)
        Me.gpcChangePass.Controls.Add(Me.cmdThoat)
        Me.gpcChangePass.Controls.Add(Me.cmdCapNhat)
        Me.gpcChangePass.Controls.Add(Me.txtPass2)
        Me.gpcChangePass.Controls.Add(Me.txtPass1)
        Me.gpcChangePass.Controls.Add(Me.txtPassCu)
        Me.gpcChangePass.Location = New System.Drawing.Point(5, 5)
        Me.gpcChangePass.Name = "gpcChangePass"
        Me.gpcChangePass.Size = New System.Drawing.Size(917, 88)
        Me.gpcChangePass.TabIndex = 1
        Me.gpcChangePass.Text = "Đổi mật khẩu"
        '
        'lblRePass
        '
        Me.lblRePass.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRePass.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRePass.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblRePass.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblRePass.Location = New System.Drawing.Point(308, 61)
        Me.lblRePass.Name = "lblRePass"
        Me.lblRePass.Size = New System.Drawing.Size(153, 19)
        Me.lblRePass.TabIndex = 231
        Me.lblRePass.Text = "Nhập lại mật khẩu :"
        '
        'lblNewPass
        '
        Me.lblNewPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNewPass.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPass.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblNewPass.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblNewPass.Location = New System.Drawing.Point(308, 35)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(153, 19)
        Me.lblNewPass.TabIndex = 230
        Me.lblNewPass.Text = "Mật khẩu mới :"
        '
        'lblOldPass
        '
        Me.lblOldPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOldPass.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldPass.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblOldPass.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblOldPass.Location = New System.Drawing.Point(6, 35)
        Me.lblOldPass.Name = "lblOldPass"
        Me.lblOldPass.Size = New System.Drawing.Size(137, 19)
        Me.lblOldPass.TabIndex = 229
        Me.lblOldPass.Text = "Mật khẩu cũ :"
        '
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(467, 58)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass2.Properties.Appearance.Options.UseFont = True
        Me.txtPass2.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass2.Size = New System.Drawing.Size(163, 25)
        Me.txtPass2.TabIndex = 3
        '
        'txtPass1
        '
        Me.txtPass1.Location = New System.Drawing.Point(467, 32)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass1.Properties.Appearance.Options.UseFont = True
        Me.txtPass1.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass1.Size = New System.Drawing.Size(163, 25)
        Me.txtPass1.TabIndex = 2
        '
        'txtPassCu
        '
        Me.txtPassCu.EditValue = ""
        Me.txtPassCu.Location = New System.Drawing.Point(149, 32)
        Me.txtPassCu.Name = "txtPassCu"
        Me.txtPassCu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassCu.Properties.Appearance.Options.UseFont = True
        Me.txtPassCu.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassCu.Size = New System.Drawing.Size(153, 25)
        Me.txtPassCu.TabIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(5, 99)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(917, 302)
        Me.PanelControl1.TabIndex = 222
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.PanelControl1)
        Me.PanelControl2.Controls.Add(Me.gpcChangePass)
        Me.PanelControl2.Location = New System.Drawing.Point(3, 4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(927, 406)
        Me.PanelControl2.TabIndex = 223
        '
        'frm_ChangePassword
        '
        Me.AcceptButton = Me.cmdCapNhat
        Me.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.cmdThoat
        Me.ClientSize = New System.Drawing.Size(934, 413)
        Me.Controls.Add(Me.PanelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frm_ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcChangePass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcChangePass.ResumeLayout(False)
        CType(Me.txtPass2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassCu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Khai Báo Biến"
    Dim mvCls_AccountUpdate As New cls_Account_Update
    Private mvUrc_FullKeyboard As New urc_FullScreenKeyboard
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        Me.txtPassCu.TabIndex = 0
        Me.txtPass1.TabIndex = 1
        Me.txtPass2.TabIndex = 2
        Me.txtPassCu.Text = ""
        Me.txtPass1.Text = ""
        Me.txtPass2.Text = ""
        Me.cmdCapNhat.Enabled = False
        With Me.PanelControl2
            .Top = (Me.ClientRectangle.Height / 2) - (.Height / 2)
            .Left = (Me.ClientRectangle.Width / 2) - (.Width / 2)
        End With
        mod_LoadLanguageForm.SubG_ChangePasswordForm()
        mod_Format.Sub_ShowControl(mvUrc_FullKeyboard, 2)
        mvUrc_FullKeyboard.SubM_InitializeForm()
        'Form.ActiveForm.ActiveControl = Me.txtPassCu
        Me.txtPassCu.BackColor = Color.PaleGreen
        Me.txtPass1.BackColor = Color.White
        Me.txtPass2.BackColor = Color.White
        gvTxt_Focus = Me.txtPassCu
        Me.txtPassCu.Focus()
    End Sub
#End Region
#Region "Form Events"
    Private Sub Frm_CIE_Config_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SubM_InitializeForm()
    End Sub
#End Region
#Region "Hàm Kiểm Tra"
#Region "Kiểm Tra Chứng thực Password"
    Private Function FuncM_KiemTraPassword() As Boolean
        If Me.txtPass1.Text.Trim.Equals(Me.txtPass2.Text.Trim) Then
            Return True
        Else : Return False
        End If
    End Function
#End Region
#Region "Kiểm tra rỗng Nút"
    Private Function FuncM_IsNullOrEmptyNut() As Boolean
        If Me.txtPassCu.Text.Trim <> "" _
        And Me.txtPass1.Text.Trim <> "" _
        And Me.txtPass2.Text.Trim <> "" _
        Then
            Return True
        Else : Return False
        End If
    End Function
#End Region
#End Region
#Region "Hàm Xử lí"
#Region "Xử lí nhập - Leave, TextChanged"
#Region "TextChanged"
    Private Sub Check_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassCu.TextChanged, txtPass1.TextChanged, txtPass2.TextChanged
        SubG_TextChanged(FuncM_IsNullOrEmptyNut, cmdCapNhat)
    End Sub
#End Region
#End Region
#Region "Change textbox focus"
    Private Sub ActiveFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass1.Enter, txtPass2.Enter, txtPassCu.Enter
        Try
            Dim mvCtr_ActiveControl As New Control
            mvCtr_ActiveControl = Form.ActiveForm.ActiveControl.Parent
            If mvCtr_ActiveControl.Name = "txtPassCu" Then
                Me.txtPassCu.BackColor = Color.PaleGreen
                Me.txtPass1.BackColor = Color.White
                Me.txtPass2.BackColor = Color.White
                gvTxt_Focus = Me.txtPassCu
            ElseIf mvCtr_ActiveControl.Name = "txtPass1" Then
                Me.txtPassCu.BackColor = Color.White
                Me.txtPass1.BackColor = Color.PaleGreen
                Me.txtPass2.BackColor = Color.White
                gvTxt_Focus = Me.txtPass1
            ElseIf mvCtr_ActiveControl.Name = "txtPass2" Then
                Me.txtPassCu.BackColor = Color.White
                Me.txtPass1.BackColor = Color.White
                Me.txtPass2.BackColor = Color.PaleGreen
                gvTxt_Focus = Me.txtPass2
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#End Region
#Region "Nút"
#Region "Nút Cập Nhật"
    Private Sub cmdCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCapNhat.Click
        Try
            If Not FuncM_KiemTraPassword() And Me.txtPass1.Text.Trim <> "" And Me.txtPass2.Text.Trim <> "" Then
                SubG_Alert(72)
                'FunG_Alert("Annonce", "Mật khẩu lần 1 và mật khẩu lần 2 chưa khớp", frm_Alert.WTYPE.ERROR)
            Else
                If mvCls_AccountUpdate.FuncG_DoiPassWord(gvProp_AccUser, getMd5Hash(Me.txtPassCu.Text.Trim), getMd5Hash(Me.txtPass1.Text.Trim)) Then
                    SubG_Alert(73)
                    'FunG_Alert("Annonce", "Đổi mật khẩu thành công!", frm_Alert.WTYPE.CHECK)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            If gvByte_Language = 1 Then
                FunG_Alert("Lỗi", ex.Message, frm_Alert.WTYPE.ERROR)
            Else
                FunG_Alert("Error", ex.Message, frm_Alert.WTYPE.ERROR)
            End If
            SubM_InitializeForm()
        End Try
        SubM_InitializeForm()
    End Sub
#End Region
#Region "Nút Thoát"
    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        Me.Close()
    End Sub
#End Region
#End Region
End Class
