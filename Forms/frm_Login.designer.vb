<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdThoat = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDangNhap = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.rgpLanguage = New DevExpress.XtraEditors.RadioGroup
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.lblPassword = New DevExpress.XtraEditors.LabelControl
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblUserName = New DevExpress.XtraEditors.LabelControl
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit
        Me.lblTitle = New System.Windows.Forms.Label
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.rgpLanguage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(-15, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(9, 9)
        Me.Label5.TabIndex = 77
        '
        'cmdThoat
        '
        Me.cmdThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThoat.Appearance.Options.UseFont = True
        Me.cmdThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdThoat.Image = CType(resources.GetObject("cmdThoat.Image"), System.Drawing.Image)
        Me.cmdThoat.Location = New System.Drawing.Point(167, 5)
        Me.cmdThoat.Name = "cmdThoat"
        Me.cmdThoat.Size = New System.Drawing.Size(168, 55)
        Me.cmdThoat.TabIndex = 81
        Me.cmdThoat.Text = "Thoát"
        '
        'cmdDangNhap
        '
        Me.cmdDangNhap.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDangNhap.Appearance.Options.UseFont = True
        Me.cmdDangNhap.Enabled = False
        Me.cmdDangNhap.Image = CType(resources.GetObject("cmdDangNhap.Image"), System.Drawing.Image)
        Me.cmdDangNhap.Location = New System.Drawing.Point(5, 5)
        Me.cmdDangNhap.Name = "cmdDangNhap"
        Me.cmdDangNhap.Size = New System.Drawing.Size(156, 55)
        Me.cmdDangNhap.TabIndex = 80
        Me.cmdDangNhap.Text = "Đăng nhập"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.rgpLanguage)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.GroupControl3)
        Me.PanelControl1.Controls.Add(Me.lblTitle)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(350, 254)
        Me.PanelControl1.TabIndex = 79
        '
        'rgpLanguage
        '
        Me.rgpLanguage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rgpLanguage.Location = New System.Drawing.Point(5, 60)
        Me.rgpLanguage.Name = "rgpLanguage"
        Me.rgpLanguage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgpLanguage.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgpLanguage.Properties.Appearance.Options.UseBackColor = True
        Me.rgpLanguage.Properties.Appearance.Options.UseFont = True
        Me.rgpLanguage.Properties.Columns = 2
        Me.rgpLanguage.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Tiếng Việt"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Tiếng Anh")})
        Me.rgpLanguage.Size = New System.Drawing.Size(340, 43)
        Me.rgpLanguage.TabIndex = 219
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cmdThoat)
        Me.GroupControl1.Controls.Add(Me.cmdDangNhap)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 184)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(340, 65)
        Me.GroupControl1.TabIndex = 214
        Me.GroupControl1.Text = "Danh sách món ăn"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.lblPassword)
        Me.GroupControl3.Controls.Add(Me.lblUserName)
        Me.GroupControl3.Controls.Add(Me.txtUserName)
        Me.GroupControl3.Controls.Add(Me.txtPassword)
        Me.GroupControl3.Location = New System.Drawing.Point(5, 109)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(340, 69)
        Me.GroupControl3.TabIndex = 213
        Me.GroupControl3.Text = "Danh sách món ăn"
        '
        'lblPassword
        '
        Me.lblPassword.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPassword.Appearance.ImageIndex = 1
        Me.lblPassword.Appearance.ImageList = Me.ImageList1
        Me.lblPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblPassword.Location = New System.Drawing.Point(7, 38)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(154, 24)
        Me.lblPassword.TabIndex = 232
        Me.lblPassword.Text = "Mật khẩu"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "User.png")
        Me.ImageList1.Images.SetKeyName(1, "changepass.png")
        '
        'lblUserName
        '
        Me.lblUserName.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblUserName.Appearance.ImageIndex = 0
        Me.lblUserName.Appearance.ImageList = Me.ImageList1
        Me.lblUserName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblUserName.Location = New System.Drawing.Point(7, 7)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(154, 24)
        Me.lblUserName.TabIndex = 231
        Me.lblUserName.Text = "Tên đăng nhập"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(167, 5)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Properties.Appearance.Options.UseFont = True
        Me.txtUserName.Size = New System.Drawing.Size(168, 28)
        Me.txtUserName.TabIndex = 215
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(167, 36)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Properties.Appearance.Options.UseFont = True
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(168, 28)
        Me.txtPassword.TabIndex = 216
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Image = CType(resources.GetObject("lblTitle.Image"), System.Drawing.Image)
        Me.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitle.Location = New System.Drawing.Point(4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(229, 52)
        Me.lblTitle.TabIndex = 79
        Me.lblTitle.Text = "Đăng nhập"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_Login
        '
        Me.AcceptButton = Me.cmdDangNhap
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdThoat
        Me.ClientSize = New System.Drawing.Size(350, 254)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logon"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.rgpLanguage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdDangNhap As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rgpLanguage As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblUserName As DevExpress.XtraEditors.LabelControl
End Class
