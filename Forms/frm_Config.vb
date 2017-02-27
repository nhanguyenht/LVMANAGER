Imports System
Imports System.IO
Public Class frm_Config
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
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConnect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtServer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCSDL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblLicense As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Config))
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdConnect = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lblLicense = New DevExpress.XtraEditors.LabelControl
        Me.txtUser = New DevExpress.XtraEditors.TextEdit
        Me.txtCSDL = New DevExpress.XtraEditors.TextEdit
        Me.txtPass = New DevExpress.XtraEditors.TextEdit
        Me.txtServer = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCSDL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Image = CType(resources.GetObject("LabelControl4.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(8, 6)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(194, 55)
        Me.LabelControl4.TabIndex = 234
        Me.LabelControl4.Text = "Kết nối CSDL"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.cmdExit)
        Me.GroupControl1.Controls.Add(Me.cmdConnect)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 186)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(296, 67)
        Me.GroupControl1.TabIndex = 215
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(156, 5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(135, 57)
        Me.cmdExit.TabIndex = 81
        Me.cmdExit.Text = "Thoát"
        '
        'cmdConnect
        '
        Me.cmdConnect.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConnect.Appearance.Options.UseFont = True
        Me.cmdConnect.Enabled = False
        Me.cmdConnect.Image = CType(resources.GetObject("cmdConnect.Image"), System.Drawing.Image)
        Me.cmdConnect.Location = New System.Drawing.Point(5, 5)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(145, 57)
        Me.cmdConnect.TabIndex = 80
        Me.cmdConnect.Tag = ""
        Me.cmdConnect.Text = "Kết nối"
        '
        'GroupControl3
        '
        Me.GroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.Controls.Add(Me.LabelControl3)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Controls.Add(Me.lblLicense)
        Me.GroupControl3.Controls.Add(Me.txtUser)
        Me.GroupControl3.Controls.Add(Me.txtCSDL)
        Me.GroupControl3.Controls.Add(Me.txtPass)
        Me.GroupControl3.Controls.Add(Me.txtServer)
        Me.GroupControl3.Location = New System.Drawing.Point(8, 67)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(296, 113)
        Me.GroupControl3.TabIndex = 214
        Me.GroupControl3.Text = "Danh sách món ăn"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl3.Location = New System.Drawing.Point(5, 86)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(103, 19)
        Me.LabelControl3.TabIndex = 243
        Me.LabelControl3.Text = "Mật khẩu"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl2.Location = New System.Drawing.Point(5, 60)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(103, 19)
        Me.LabelControl2.TabIndex = 242
        Me.LabelControl2.Text = "Tên truy cập"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(5, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(103, 19)
        Me.LabelControl1.TabIndex = 241
        Me.LabelControl1.Text = "Tên CSDL"
        '
        'lblLicense
        '
        Me.lblLicense.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLicense.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicense.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblLicense.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblLicense.Location = New System.Drawing.Point(5, 8)
        Me.lblLicense.Name = "lblLicense"
        Me.lblLicense.Size = New System.Drawing.Size(103, 19)
        Me.lblLicense.TabIndex = 240
        Me.lblLicense.Text = "Tên máy chủ"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(114, 57)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Properties.Appearance.Options.UseFont = True
        Me.txtUser.Size = New System.Drawing.Size(177, 25)
        Me.txtUser.TabIndex = 216
        '
        'txtCSDL
        '
        Me.txtCSDL.Location = New System.Drawing.Point(114, 31)
        Me.txtCSDL.Name = "txtCSDL"
        Me.txtCSDL.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCSDL.Properties.Appearance.Options.UseFont = True
        Me.txtCSDL.Size = New System.Drawing.Size(177, 25)
        Me.txtCSDL.TabIndex = 217
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(114, 83)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Properties.Appearance.Options.UseFont = True
        Me.txtPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(177, 25)
        Me.txtPass.TabIndex = 216
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(114, 5)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServer.Properties.Appearance.Options.UseFont = True
        Me.txtServer.Size = New System.Drawing.Size(177, 25)
        Me.txtServer.TabIndex = 215
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.GroupControl3)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(312, 260)
        Me.PanelControl1.TabIndex = 235
        '
        'frm_Config
        '
        Me.AcceptButton = Me.cmdConnect
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(312, 260)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_Config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESTAURANT - COFFEE - BAR MANAGER"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCSDL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Khai Báo Biến"
    Dim mvCls_Config As New cls_Config
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        Me.cmdConnect.Enabled = True
        Me.txtServer.Text = "(local)"
        Me.txtCSDL.Text = "RESTAURANT DATABASE"
        Me.txtUser.Text = "sa"
        Me.txtPass.Text = "sa"
    End Sub
#End Region
#Region "Form Events"
    Private Sub Frm_CIE_Config_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SubM_InitializeForm()
    End Sub
#End Region
#Region "TextChanged"
    Private Sub txtChange_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtServer.TextChanged, txtCSDL.TextChanged, txtUser.TextChanged
        mvCls_Config.SubG_FormatButton(Me.txtServer, Me.txtCSDL, Me.txtUser, Me.cmdConnect)
    End Sub
#End Region
#Region "Nút Thoát"
    Private Sub cmdThoat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub
#End Region
#Region "Nút Kết Nối"
    Private Sub cmdKetNoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click
        gvProp_Server = Me.txtServer.Text.Trim
        gvProp_DataBase = Me.txtCSDL.Text.Trim
        gvProp_User = Me.txtUser.Text.Trim
        gvProp_PassWord = Me.txtPass.Text.Trim
        'Mặc định ngôn ngữ là tiếng Việt
        gvByte_Language = 1
        gvStr_LocID = "01"
        If gvByte_Language = 1 Then
            gvByte_Digit = 0
        Else
            gvByte_Digit = 2
        End If
        cls_Database_Base.gvStr_ConnecttionString = "server=" + gvProp_Server + ";Initial Catalog=" + gvProp_DataBase + ";User ID=" + gvProp_User + ";Password=" + gvProp_PassWord + ";Persist Security Info=True;"
        Try
            If mvCls_Config.FuncG_WrittenServerini(gvProp_Server, gvProp_DataBase, gvProp_User, gvProp_PassWord) Then
                Me.Close()
            End If
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Sub
#End Region
End Class
