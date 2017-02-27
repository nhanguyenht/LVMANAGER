Imports System
Imports System.IO
Public Class frm_Account
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
    Friend WithEvents gpcRight As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cheSetting As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cheSale As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRePassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gpcAccount As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rgpStatus As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblRePass As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cheInventory As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cheReport As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cheReturn As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cheChangePass As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cheDelete As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cheDeleteDB As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheTinhtien As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim CompareAgainstControlValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule = New DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Account))
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit
        Me.txtRePassword = New DevExpress.XtraEditors.TextEdit
        Me.gpcRight = New DevExpress.XtraEditors.GroupControl
        Me.cheDeleteDB = New DevExpress.XtraEditors.CheckEdit
        Me.cheDelete = New DevExpress.XtraEditors.CheckEdit
        Me.cheReturn = New DevExpress.XtraEditors.CheckEdit
        Me.cheInventory = New DevExpress.XtraEditors.CheckEdit
        Me.cheReport = New DevExpress.XtraEditors.CheckEdit
        Me.cheSetting = New DevExpress.XtraEditors.CheckEdit
        Me.cheSale = New DevExpress.XtraEditors.CheckEdit
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.txtID = New DevExpress.XtraEditors.TextEdit
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gpcAccount = New DevExpress.XtraEditors.GroupControl
        Me.cheChangePass = New DevExpress.XtraEditors.CheckEdit
        Me.rgpStatus = New DevExpress.XtraEditors.RadioGroup
        Me.lblRePass = New DevExpress.XtraEditors.LabelControl
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.lblName = New DevExpress.XtraEditors.LabelControl
        Me.lblID = New DevExpress.XtraEditors.LabelControl
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.CheTinhtien = New DevExpress.XtraEditors.CheckEdit
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRePassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcRight.SuspendLayout()
        CType(Me.cheDeleteDB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheDelete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheReturn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheReport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheSetting.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheSale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpcAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcAccount.SuspendLayout()
        CType(Me.cheChangePass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgpStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheTinhtien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.DxValidationProvider1.SetIconAlignment(Me.txtPassword, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txtPassword.Location = New System.Drawing.Point(160, 99)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPassword.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txtPassword.Properties.Appearance.Options.UseBackColor = True
        Me.txtPassword.Properties.Appearance.Options.UseFont = True
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(204, 31)
        Me.txtPassword.TabIndex = 217
        '
        'txtRePassword
        '
        Me.DxValidationProvider1.SetIconAlignment(Me.txtRePassword, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txtRePassword.Location = New System.Drawing.Point(160, 133)
        Me.txtRePassword.Name = "txtRePassword"
        Me.txtRePassword.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRePassword.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txtRePassword.Properties.Appearance.Options.UseBackColor = True
        Me.txtRePassword.Properties.Appearance.Options.UseFont = True
        Me.txtRePassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRePassword.Size = New System.Drawing.Size(204, 31)
        Me.txtRePassword.TabIndex = 218
        CompareAgainstControlValidationRule1.CaseSensitive = True
        CompareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals
        CompareAgainstControlValidationRule1.Control = Me.txtPassword
        CompareAgainstControlValidationRule1.ErrorText = "Mật khẩu nhập không trùng"
        CompareAgainstControlValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.DxValidationProvider1.SetValidationRule(Me.txtRePassword, CompareAgainstControlValidationRule1)
        '
        'gpcRight
        '
        Me.gpcRight.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcRight.AppearanceCaption.Options.UseFont = True
        Me.gpcRight.Controls.Add(Me.CheTinhtien)
        Me.gpcRight.Controls.Add(Me.cheDeleteDB)
        Me.gpcRight.Controls.Add(Me.cheDelete)
        Me.gpcRight.Controls.Add(Me.cheReturn)
        Me.gpcRight.Controls.Add(Me.cheInventory)
        Me.gpcRight.Controls.Add(Me.cheReport)
        Me.gpcRight.Controls.Add(Me.cheSetting)
        Me.gpcRight.Controls.Add(Me.cheSale)
        Me.gpcRight.Location = New System.Drawing.Point(370, 33)
        Me.gpcRight.Name = "gpcRight"
        Me.gpcRight.Size = New System.Drawing.Size(184, 267)
        Me.gpcRight.TabIndex = 214
        Me.gpcRight.Text = "Phân quyền"
        '
        'cheDeleteDB
        '
        Me.cheDeleteDB.Location = New System.Drawing.Point(5, 205)
        Me.cheDeleteDB.Name = "cheDeleteDB"
        Me.cheDeleteDB.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheDeleteDB.Properties.Appearance.Options.UseFont = True
        Me.cheDeleteDB.Properties.Caption = "Xóa dữ liệu"
        Me.cheDeleteDB.Size = New System.Drawing.Size(174, 24)
        Me.cheDeleteDB.TabIndex = 6
        '
        'cheDelete
        '
        Me.cheDelete.Location = New System.Drawing.Point(5, 176)
        Me.cheDelete.Name = "cheDelete"
        Me.cheDelete.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheDelete.Properties.Appearance.Options.UseFont = True
        Me.cheDelete.Properties.Caption = "Hủy hóa đơn"
        Me.cheDelete.Size = New System.Drawing.Size(174, 24)
        Me.cheDelete.TabIndex = 5
        '
        'cheReturn
        '
        Me.cheReturn.Location = New System.Drawing.Point(5, 146)
        Me.cheReturn.Name = "cheReturn"
        Me.cheReturn.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheReturn.Properties.Appearance.Options.UseFont = True
        Me.cheReturn.Properties.Caption = "Trả hàng"
        Me.cheReturn.Size = New System.Drawing.Size(174, 24)
        Me.cheReturn.TabIndex = 4
        '
        'cheInventory
        '
        Me.cheInventory.Location = New System.Drawing.Point(5, 117)
        Me.cheInventory.Name = "cheInventory"
        Me.cheInventory.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheInventory.Properties.Appearance.Options.UseFont = True
        Me.cheInventory.Properties.Caption = "Quản lý kho"
        Me.cheInventory.Size = New System.Drawing.Size(174, 24)
        Me.cheInventory.TabIndex = 3
        '
        'cheReport
        '
        Me.cheReport.Location = New System.Drawing.Point(5, 88)
        Me.cheReport.Name = "cheReport"
        Me.cheReport.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheReport.Properties.Appearance.Options.UseFont = True
        Me.cheReport.Properties.Caption = "Báo cáo"
        Me.cheReport.Size = New System.Drawing.Size(174, 24)
        Me.cheReport.TabIndex = 2
        '
        'cheSetting
        '
        Me.cheSetting.Location = New System.Drawing.Point(5, 59)
        Me.cheSetting.Name = "cheSetting"
        Me.cheSetting.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheSetting.Properties.Appearance.Options.UseFont = True
        Me.cheSetting.Properties.Caption = "Cài đặt"
        Me.cheSetting.Size = New System.Drawing.Size(174, 24)
        Me.cheSetting.TabIndex = 1
        '
        'cheSale
        '
        Me.cheSale.Location = New System.Drawing.Point(5, 30)
        Me.cheSale.Name = "cheSale"
        Me.cheSale.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheSale.Properties.Appearance.Options.UseFont = True
        Me.cheSale.Properties.Caption = "Bán hàng"
        Me.cheSale.Size = New System.Drawing.Size(174, 24)
        Me.cheSale.TabIndex = 0
        '
        'DxValidationProvider1
        '
        Me.DxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'txtID
        '
        Me.txtID.EditValue = ""
        Me.DxValidationProvider1.SetIconAlignment(Me.txtID, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.txtID.Location = New System.Drawing.Point(160, 33)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Properties.Appearance.Options.UseFont = True
        Me.txtID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtID.Size = New System.Drawing.Size(204, 31)
        Me.txtID.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(5, 306)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(548, 274)
        Me.GridControl1.TabIndex = 217
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowColumnHeaders = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'gpcAccount
        '
        Me.gpcAccount.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcAccount.Appearance.Options.UseFont = True
        Me.gpcAccount.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcAccount.AppearanceCaption.Options.UseFont = True
        Me.gpcAccount.Controls.Add(Me.cheChangePass)
        Me.gpcAccount.Controls.Add(Me.rgpStatus)
        Me.gpcAccount.Controls.Add(Me.lblRePass)
        Me.gpcAccount.Controls.Add(Me.gpcRight)
        Me.gpcAccount.Controls.Add(Me.cmdUpdate)
        Me.gpcAccount.Controls.Add(Me.cmdExit)
        Me.gpcAccount.Controls.Add(Me.lblName)
        Me.gpcAccount.Controls.Add(Me.GridControl1)
        Me.gpcAccount.Controls.Add(Me.lblID)
        Me.gpcAccount.Controls.Add(Me.txtRePassword)
        Me.gpcAccount.Controls.Add(Me.txtPassword)
        Me.gpcAccount.Controls.Add(Me.txtName)
        Me.gpcAccount.Controls.Add(Me.txtID)
        Me.gpcAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpcAccount.Location = New System.Drawing.Point(0, 0)
        Me.gpcAccount.Name = "gpcAccount"
        Me.gpcAccount.Size = New System.Drawing.Size(558, 650)
        Me.gpcAccount.TabIndex = 218
        Me.gpcAccount.Text = "Cài đặt người sử dụng"
        '
        'cheChangePass
        '
        Me.cheChangePass.Location = New System.Drawing.Point(8, 102)
        Me.cheChangePass.Name = "cheChangePass"
        Me.cheChangePass.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheChangePass.Properties.Appearance.Options.UseFont = True
        Me.cheChangePass.Properties.Appearance.Options.UseTextOptions = True
        Me.cheChangePass.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.cheChangePass.Properties.Caption = "ĐỔI MẬT KHẨU"
        Me.cheChangePass.Size = New System.Drawing.Size(151, 24)
        Me.cheChangePass.TabIndex = 222
        '
        'rgpStatus
        '
        Me.rgpStatus.Location = New System.Drawing.Point(160, 168)
        Me.rgpStatus.Name = "rgpStatus"
        Me.rgpStatus.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgpStatus.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgpStatus.Properties.Appearance.Options.UseBackColor = True
        Me.rgpStatus.Properties.Appearance.Options.UseFont = True
        Me.rgpStatus.Properties.Columns = 2
        Me.rgpStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Sử dụng"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Khóa")})
        Me.rgpStatus.Size = New System.Drawing.Size(204, 35)
        Me.rgpStatus.TabIndex = 221
        '
        'lblRePass
        '
        Me.lblRePass.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRePass.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblRePass.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblRePass.Location = New System.Drawing.Point(5, 139)
        Me.lblRePass.Name = "lblRePass"
        Me.lblRePass.Size = New System.Drawing.Size(149, 19)
        Me.lblRePass.TabIndex = 220
        Me.lblRePass.Text = "NHẬP LẠI M.KHẨU"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.Image = CType(resources.GetObject("cmdUpdate.Image"), System.Drawing.Image)
        Me.cmdUpdate.Location = New System.Drawing.Point(273, 586)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(137, 59)
        Me.cmdUpdate.TabIndex = 4
        Me.cmdUpdate.Text = "Cập nhật"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(416, 586)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(137, 59)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "Thoát"
        '
        'lblName
        '
        Me.lblName.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblName.Location = New System.Drawing.Point(5, 72)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(149, 19)
        Me.lblName.TabIndex = 31
        Me.lblName.Text = "TÊN NGƯỜI DÙNG"
        '
        'lblID
        '
        Me.lblID.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblID.Location = New System.Drawing.Point(5, 39)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(149, 19)
        Me.lblID.TabIndex = 30
        Me.lblID.Text = "TÊN TRUY CẬP"
        '
        'txtName
        '
        Me.txtName.EditValue = ""
        Me.txtName.Location = New System.Drawing.Point(160, 66)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtName.Properties.MaxLength = 10
        Me.txtName.Size = New System.Drawing.Size(204, 31)
        Me.txtName.TabIndex = 2
        '
        'CheTinhtien
        '
        Me.CheTinhtien.Location = New System.Drawing.Point(5, 235)
        Me.CheTinhtien.Name = "CheTinhtien"
        Me.CheTinhtien.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheTinhtien.Properties.Appearance.Options.UseFont = True
        Me.CheTinhtien.Properties.Caption = "Tính tiền"
        Me.CheTinhtien.Size = New System.Drawing.Size(174, 24)
        Me.CheTinhtien.TabIndex = 7
        '
        'frm_Account
        '
        Me.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(558, 650)
        Me.Controls.Add(Me.gpcAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frm_Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRePassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcRight.ResumeLayout(False)
        CType(Me.cheDeleteDB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheDelete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheReturn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheReport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheSetting.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheSale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpcAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcAccount.ResumeLayout(False)
        CType(Me.cheChangePass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgpStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheTinhtien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Khai Báo Biến"
    Dim mvCls_Account As New cls_Account
    Dim mvCls_UpdateAccount As New cls_Account_Update
    Private mvUrc_FullKeyboard As New urc_FullScreenKeyboard
#End Region
#Region "Hàm Khởi Tạo"
    Private Sub SubM_InitializeForm()
        SubM_LoadAccount()
        mod_LoadLanguageForm.SubG_AccountForm()
        mod_Format.Sub_ShowControl(mvUrc_FullKeyboard, 12)
        mvUrc_FullKeyboard.SubM_InitializeForm()
        Me.txtID.Text = ""
        Me.txtName.Text = ""
        Me.txtPassword.Text = ""
        Me.txtPassword.Enabled = False
        Me.txtRePassword.Text = ""
        Me.txtRePassword.Enabled = False
        Me.cheChangePass.Checked = False
        'Form.ActiveForm.ActiveControl = Me.txtID
        Me.txtID.BackColor = Color.LightSkyBlue
        Me.txtName.BackColor = Color.White
        Me.txtPassword.BackColor = Color.Gainsboro
        Me.txtRePassword.BackColor = Color.Gainsboro
        gvTxt_Focus = Me.txtID
        If gvByte_Language = 1 Then
            Me.cheDeleteDB.Text = "Xóa dữ liệu"
            Me.CheTinhtien.Text = "Tính tiền"
        Else
            Me.cheDeleteDB.Text = "Delete Data"
            Me.CheTinhtien.Text = "Checkout"

        End If
    End Sub
#End Region
#Region "Form Events"
    Private Sub Frm_ERP_Account_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SubM_InitializeForm()
    End Sub
#End Region
#Region "Hàm Kiểm Tra"
    Private Function FuncM_IsNullOrEmptyButton() As Boolean
        If Me.txtID.Text.Trim <> "" _
        And Me.txtPassword.Text.Trim <> "" _
        Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
#Region "Hàm Xử lí"
#Region "Xoá trắng Controls"
    Private Sub SubM_XoaTrangConTrols()
        Me.txtID.Text = ""
        Me.txtName.Text = ""
        Me.txtPassword.Text = ""
        Me.txtRePassword.Text = ""
    End Sub
#End Region
#Region "Change textbox focus"
    Private Sub ActiveFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.Enter, txtName.Enter, txtPassword.Enter, txtRePassword.Enter
        Try
            Dim mvCtr_ActiveControl As New Control
            mvCtr_ActiveControl = Form.ActiveForm.ActiveControl.Parent
            If mvCtr_ActiveControl.Name = "txtID" Then
                Me.txtID.BackColor = Color.LightSkyBlue
                Me.txtName.BackColor = Color.White
                If Me.cheChangePass.Checked Then
                    Me.txtPassword.BackColor = Color.White
                    Me.txtRePassword.BackColor = Color.White
                Else
                    Me.txtPassword.BackColor = Color.Gainsboro
                    Me.txtRePassword.BackColor = Color.Gainsboro
                End If
                gvTxt_Focus = Me.txtID
            ElseIf mvCtr_ActiveControl.Name = "txtName" Then
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.LightSkyBlue
                If Me.cheChangePass.Checked Then
                    Me.txtPassword.BackColor = Color.White
                    Me.txtRePassword.BackColor = Color.White
                Else
                    Me.txtPassword.BackColor = Color.Gainsboro
                    Me.txtRePassword.BackColor = Color.Gainsboro
                End If
                gvTxt_Focus = Me.txtName
            ElseIf mvCtr_ActiveControl.Name = "txtPassword" Then
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.White
                Me.txtPassword.BackColor = Color.LightSkyBlue
                Me.txtRePassword.BackColor = Color.White
                gvTxt_Focus = Me.txtPassword
            ElseIf mvCtr_ActiveControl.Name = "txtRePassword" Then
                Me.txtID.BackColor = Color.White
                Me.txtName.BackColor = Color.White
                Me.txtPassword.BackColor = Color.White
                Me.txtRePassword.BackColor = Color.LightSkyBlue
                gvTxt_Focus = Me.txtRePassword
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Gán Quyền"
    Private Function FuncM_GetPermit() As String
        Dim mvChr_Premit(7) As Char
        Try
            mvChr_Premit(0) = IIf(Me.cheSale.Checked, "1", "0")
            mvChr_Premit(1) = IIf(Me.cheSetting.Checked, "1", "0")
            mvChr_Premit(2) = IIf(Me.cheReport.Checked, "1", "0")
            mvChr_Premit(3) = IIf(Me.cheInventory.Checked, "1", "0")
            mvChr_Premit(4) = IIf(Me.cheReturn.Checked, "1", "0")
            mvChr_Premit(5) = IIf(Me.cheDelete.Checked, "1", "0")
            mvChr_Premit(6) = IIf(Me.cheDeleteDB.Checked, "1", "0")
            mvChr_Premit(7) = IIf(Me.CheTinhtien.Checked, "1", "0")
            Dim mvStr_Permit As New String(mvChr_Premit)
            Return mvStr_Permit
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Private Sub SubM_SetPemit(ByVal iStr_Pemit As String)
        Try
            Me.cheSale.Checked = String.Equals(iStr_Pemit(0), "1"c)
            Me.cheSetting.Checked = String.Equals(iStr_Pemit(1), "1"c)
            Me.cheReport.Checked = String.Equals(iStr_Pemit(2), "1"c)
            Me.cheInventory.Checked = String.Equals(iStr_Pemit(3), "1"c)
            Me.cheReturn.Checked = String.Equals(iStr_Pemit(4), "1"c)
            Me.cheDelete.Checked = String.Equals(iStr_Pemit(5), "1"c)
            Me.cheDeleteDB.Checked = String.Equals(iStr_Pemit(6), "1"c)
            Me.CheTinhtien.Checked = String.Equals(iStr_Pemit(7), "1"c)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Xử lí nhập - Leave, TextChanged, SelectionChangeCommit"
#Region "TextChanged"
    Private Sub txtTaiKhoan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged, txtPassword.TextChanged, txtRePassword.TextChanged
        DxValidationProvider1.Validate()
    End Sub
#End Region
#End Region
#End Region
#Region "Hàm Hiển Thị"
    Private Sub SubM_LoadAccount()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_UpdateAccount.FuncG_GetData
            Me.GridControl1.DataSource = mvObj_DataTable
            Me.GridView1.Columns("PASSWORD").Visible = False
            Me.GridView1.Columns("LEVEL").Visible = False
            Me.GridView1.BestFitColumns()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#Region "Click on gird"
    Private Sub SubM_ClickOnGird()
        Dim mvStr_Permit As String
        Try
            Me.txtID.Text = Me.GridView1.GetFocusedDataRow("USERNAME")
            Me.txtName.Text = Me.GridView1.GetFocusedDataRow("NAME")
            mvStr_Permit = Me.GridView1.GetFocusedDataRow("LEVEL")
            Me.SubM_SetPemit(mvStr_Permit)
            If Me.GridView1.GetFocusedDataRow("STATUS") = 1 Then
                Me.rgpStatus.SelectedIndex = 0
            Else
                Me.rgpStatus.SelectedIndex = 1
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        SubM_ClickOnGird()
    End Sub
    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        SubM_ClickOnGird()
    End Sub
#End Region
#Region "Check change"
    Private Sub cheChangePass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cheChangePass.CheckedChanged
        Try
            Me.txtPassword.Enabled = Me.cheChangePass.Checked
            Me.txtRePassword.Enabled = Me.cheChangePass.Checked
            If Me.cheChangePass.Checked Then
                Me.txtPassword.BackColor = Color.White
                Me.txtRePassword.BackColor = Color.White
            Else
                Me.txtPassword.BackColor = Color.Gainsboro
                Me.txtRePassword.BackColor = Color.Gainsboro
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút"
#Region "Nút Up"
    Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Me.GridView1.GetFocusedDataSourceRowIndex <> 0 Then
                Me.GridView1.FocusedRowHandle = Me.GridView1.GetFocusedDataSourceRowIndex - 1
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Down"
    Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Me.GridView1.GetFocusedDataSourceRowIndex <> Me.GridView1.RowCount - 1 Then
                Me.GridView1.FocusedRowHandle = Me.GridView1.GetFocusedDataSourceRowIndex + 1
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút thêm"
    Private Sub cmdUpdateClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            If Me.DxValidationProvider1.Validate Then
                If String.IsNullOrEmpty(Me.txtID.Text) Then
                    SubG_Alert(64) ' FunG_Alert("Thông báo", "Chưa có thông tin tài khoản!", frm_Alert.WTYPE.STOP)
                Else
                    mvCls_Account.UserName = Me.txtID.Text.Trim
                    mvCls_Account.Employee = Me.txtName.Text.Trim
                    If Me.rgpStatus.SelectedIndex = 0 Then
                        mvCls_Account.Status = 1
                    Else
                        mvCls_Account.Status = 0
                    End If
                    mvCls_Account.Permit = FuncM_GetPermit()
                    If Me.cheChangePass.Checked Then
                        mvCls_Account.Password = getMd5Hash(Me.txtPassword.Text.Trim)
                    Else
                        mvCls_Account.Password = ""
                    End If
                    mvCls_UpdateAccount.FuncG_InsertUpdateDelete(mvCls_Account)
                    SubM_InitializeForm()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Nút Thoát"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
#End Region
#End Region
End Class
