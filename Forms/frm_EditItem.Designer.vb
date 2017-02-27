<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EditItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EditItem))
        Me.gpcHeader = New DevExpress.XtraEditors.GroupControl
        Me.cmdMonPhu = New DevExpress.XtraEditors.SimpleButton
        Me.rgpCombo = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrice5 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrice4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrice3 = New DevExpress.XtraEditors.TextEdit
        Me.ColorEdit1 = New DevExpress.XtraEditors.ColorEdit
        Me.cmdRight = New DevExpress.XtraEditors.SimpleButton
        Me.cmdLeft = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cheStatus = New DevExpress.XtraEditors.CheckEdit
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.lkpPrinter = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrice2 = New DevExpress.XtraEditors.TextEdit
        Me.chePrint = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtID = New DevExpress.XtraEditors.TextEdit
        Me.lkpNhomHang = New DevExpress.XtraEditors.LookUpEdit
        Me.lblUnit = New DevExpress.XtraEditors.LabelControl
        Me.txtUnit = New DevExpress.XtraEditors.TextEdit
        Me.lblPrice1 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrice1 = New DevExpress.XtraEditors.TextEdit
        Me.lblGroupItem = New DevExpress.XtraEditors.LabelControl
        Me.lblItem = New DevExpress.XtraEditors.LabelControl
        Me.cmdApply = New DevExpress.XtraEditors.SimpleButton
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.cheShifts = New DevExpress.XtraEditors.CheckEdit
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcHeader.SuspendLayout()
        CType(Me.rgpCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpPrinter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chePrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpNhomHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheShifts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcHeader
        '
        Me.gpcHeader.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcHeader.Appearance.Options.UseFont = True
        Me.gpcHeader.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcHeader.AppearanceCaption.Options.UseFont = True
        Me.gpcHeader.Controls.Add(Me.cheShifts)
        Me.gpcHeader.Controls.Add(Me.cmdMonPhu)
        Me.gpcHeader.Controls.Add(Me.rgpCombo)
        Me.gpcHeader.Controls.Add(Me.LabelControl7)
        Me.gpcHeader.Controls.Add(Me.txtPrice5)
        Me.gpcHeader.Controls.Add(Me.LabelControl5)
        Me.gpcHeader.Controls.Add(Me.txtPrice4)
        Me.gpcHeader.Controls.Add(Me.LabelControl6)
        Me.gpcHeader.Controls.Add(Me.txtPrice3)
        Me.gpcHeader.Controls.Add(Me.ColorEdit1)
        Me.gpcHeader.Controls.Add(Me.cmdRight)
        Me.gpcHeader.Controls.Add(Me.cmdLeft)
        Me.gpcHeader.Controls.Add(Me.cmdCancel)
        Me.gpcHeader.Controls.Add(Me.cheStatus)
        Me.gpcHeader.Controls.Add(Me.LookUpEdit2)
        Me.gpcHeader.Controls.Add(Me.LabelControl4)
        Me.gpcHeader.Controls.Add(Me.lkpPrinter)
        Me.gpcHeader.Controls.Add(Me.LabelControl3)
        Me.gpcHeader.Controls.Add(Me.LabelControl2)
        Me.gpcHeader.Controls.Add(Me.txtPrice2)
        Me.gpcHeader.Controls.Add(Me.chePrint)
        Me.gpcHeader.Controls.Add(Me.LabelControl1)
        Me.gpcHeader.Controls.Add(Me.txtID)
        Me.gpcHeader.Controls.Add(Me.lkpNhomHang)
        Me.gpcHeader.Controls.Add(Me.lblUnit)
        Me.gpcHeader.Controls.Add(Me.txtUnit)
        Me.gpcHeader.Controls.Add(Me.lblPrice1)
        Me.gpcHeader.Controls.Add(Me.txtPrice1)
        Me.gpcHeader.Controls.Add(Me.lblGroupItem)
        Me.gpcHeader.Controls.Add(Me.lblItem)
        Me.gpcHeader.Controls.Add(Me.cmdApply)
        Me.gpcHeader.Controls.Add(Me.cmdOK)
        Me.gpcHeader.Controls.Add(Me.txtName)
        Me.gpcHeader.Location = New System.Drawing.Point(6, 6)
        Me.gpcHeader.Name = "gpcHeader"
        Me.gpcHeader.Size = New System.Drawing.Size(466, 469)
        Me.gpcHeader.TabIndex = 2
        Me.gpcHeader.Text = "Thông tin mặt hàng"
        '
        'cmdMonPhu
        '
        Me.cmdMonPhu.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMonPhu.Appearance.Options.UseFont = True
        Me.cmdMonPhu.Enabled = False
        Me.cmdMonPhu.Image = CType(resources.GetObject("cmdMonPhu.Image"), System.Drawing.Image)
        Me.cmdMonPhu.Location = New System.Drawing.Point(288, 275)
        Me.cmdMonPhu.Name = "cmdMonPhu"
        Me.cmdMonPhu.Size = New System.Drawing.Size(173, 56)
        Me.cmdMonPhu.TabIndex = 253
        Me.cmdMonPhu.Text = "Món phụ"
        '
        'rgpCombo
        '
        Me.rgpCombo.Location = New System.Drawing.Point(288, 238)
        Me.rgpCombo.Name = "rgpCombo"
        Me.rgpCombo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgpCombo.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgpCombo.Properties.Appearance.Options.UseBackColor = True
        Me.rgpCombo.Properties.Appearance.Options.UseFont = True
        Me.rgpCombo.Properties.Columns = 2
        Me.rgpCombo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Không"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Combo")})
        Me.rgpCombo.Size = New System.Drawing.Size(173, 31)
        Me.rgpCombo.TabIndex = 252
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl7.Location = New System.Drawing.Point(36, 298)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(67, 19)
        Me.LabelControl7.TabIndex = 251
        Me.LabelControl7.Text = "Giá 5"
        '
        'txtPrice5
        '
        Me.txtPrice5.EditValue = ""
        Me.txtPrice5.Location = New System.Drawing.Point(109, 292)
        Me.txtPrice5.Name = "txtPrice5"
        Me.txtPrice5.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPrice5.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice5.Properties.Appearance.Options.UseBackColor = True
        Me.txtPrice5.Properties.Appearance.Options.UseFont = True
        Me.txtPrice5.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrice5.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPrice5.Size = New System.Drawing.Size(173, 31)
        Me.txtPrice5.TabIndex = 250
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl5.Location = New System.Drawing.Point(36, 261)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(67, 19)
        Me.LabelControl5.TabIndex = 249
        Me.LabelControl5.Text = "Giá 4"
        '
        'txtPrice4
        '
        Me.txtPrice4.EditValue = ""
        Me.txtPrice4.Location = New System.Drawing.Point(109, 255)
        Me.txtPrice4.Name = "txtPrice4"
        Me.txtPrice4.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPrice4.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice4.Properties.Appearance.Options.UseBackColor = True
        Me.txtPrice4.Properties.Appearance.Options.UseFont = True
        Me.txtPrice4.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrice4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPrice4.Size = New System.Drawing.Size(173, 31)
        Me.txtPrice4.TabIndex = 248
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl6.Location = New System.Drawing.Point(8, 224)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(95, 19)
        Me.LabelControl6.TabIndex = 247
        Me.LabelControl6.Text = "Giá 3"
        '
        'txtPrice3
        '
        Me.txtPrice3.EditValue = ""
        Me.txtPrice3.Location = New System.Drawing.Point(109, 218)
        Me.txtPrice3.Name = "txtPrice3"
        Me.txtPrice3.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPrice3.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice3.Properties.Appearance.Options.UseBackColor = True
        Me.txtPrice3.Properties.Appearance.Options.UseFont = True
        Me.txtPrice3.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrice3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPrice3.Size = New System.Drawing.Size(173, 31)
        Me.txtPrice3.TabIndex = 246
        '
        'ColorEdit1
        '
        Me.ColorEdit1.EditValue = System.Drawing.Color.Empty
        Me.ColorEdit1.Location = New System.Drawing.Point(288, 201)
        Me.ColorEdit1.Name = "ColorEdit1"
        Me.ColorEdit1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorEdit1.Properties.Appearance.Options.UseFont = True
        Me.ColorEdit1.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorEdit1.Properties.AppearanceDisabled.Options.UseFont = True
        Me.ColorEdit1.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorEdit1.Properties.AppearanceDropDown.Options.UseFont = True
        Me.ColorEdit1.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorEdit1.Properties.AppearanceFocused.Options.UseFont = True
        Me.ColorEdit1.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorEdit1.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.ColorEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorEdit1.Properties.ColorAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColorEdit1.Properties.ColorText = DevExpress.XtraEditors.Controls.ColorText.[Integer]
        Me.ColorEdit1.Properties.ShowSystemColors = False
        Me.ColorEdit1.Properties.ShowWebColors = False
        Me.ColorEdit1.Size = New System.Drawing.Size(173, 31)
        Me.ColorEdit1.TabIndex = 245
        '
        'cmdRight
        '
        Me.cmdRight.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRight.Appearance.Options.UseFont = True
        Me.cmdRight.Image = CType(resources.GetObject("cmdRight.Image"), System.Drawing.Image)
        Me.cmdRight.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRight.Location = New System.Drawing.Point(376, 349)
        Me.cmdRight.Name = "cmdRight"
        Me.cmdRight.Size = New System.Drawing.Size(85, 48)
        Me.cmdRight.TabIndex = 244
        '
        'cmdLeft
        '
        Me.cmdLeft.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLeft.Appearance.Options.UseFont = True
        Me.cmdLeft.Image = CType(resources.GetObject("cmdLeft.Image"), System.Drawing.Image)
        Me.cmdLeft.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdLeft.Location = New System.Drawing.Point(288, 349)
        Me.cmdLeft.Name = "cmdLeft"
        Me.cmdLeft.Size = New System.Drawing.Size(85, 48)
        Me.cmdLeft.TabIndex = 243
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(153, 403)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(144, 60)
        Me.cmdCancel.TabIndex = 242
        Me.cmdCancel.Text = "Cancel"
        '
        'cheStatus
        '
        Me.cheStatus.Location = New System.Drawing.Point(288, 144)
        Me.cheStatus.Name = "cheStatus"
        Me.cheStatus.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheStatus.Properties.Appearance.Options.UseFont = True
        Me.cheStatus.Properties.Caption = "Hiển thị"
        Me.cheStatus.Size = New System.Drawing.Size(140, 24)
        Me.cheStatus.TabIndex = 239
        '
        'LookUpEdit2
        '
        Me.LookUpEdit2.Location = New System.Drawing.Point(109, 366)
        Me.LookUpEdit2.Name = "LookUpEdit2"
        Me.LookUpEdit2.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit2.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit2.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit2.Properties.AppearanceDropDown.Options.UseFont = True
        Me.LookUpEdit2.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit2.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.LookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit2.Properties.NullText = ""
        Me.LookUpEdit2.Properties.PopupWidth = 400
        Me.LookUpEdit2.Size = New System.Drawing.Size(173, 31)
        Me.LookUpEdit2.TabIndex = 238
        Me.LookUpEdit2.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl4.Location = New System.Drawing.Point(8, 372)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(95, 19)
        Me.LabelControl4.TabIndex = 237
        Me.LabelControl4.Text = "Nhóm giảm giá"
        Me.LabelControl4.Visible = False
        '
        'lkpPrinter
        '
        Me.lkpPrinter.Location = New System.Drawing.Point(109, 329)
        Me.lkpPrinter.Name = "lkpPrinter"
        Me.lkpPrinter.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpPrinter.Properties.Appearance.Options.UseFont = True
        Me.lkpPrinter.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpPrinter.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkpPrinter.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpPrinter.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkpPrinter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpPrinter.Properties.NullText = ""
        Me.lkpPrinter.Properties.PopupWidth = 400
        Me.lkpPrinter.Size = New System.Drawing.Size(173, 31)
        Me.lkpPrinter.TabIndex = 235
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl3.Location = New System.Drawing.Point(8, 335)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(95, 19)
        Me.LabelControl3.TabIndex = 234
        Me.LabelControl3.Text = "Máy in"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl2.Location = New System.Drawing.Point(36, 187)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(67, 19)
        Me.LabelControl2.TabIndex = 233
        Me.LabelControl2.Text = "Giá 2"
        '
        'txtPrice2
        '
        Me.txtPrice2.EditValue = ""
        Me.txtPrice2.Location = New System.Drawing.Point(109, 181)
        Me.txtPrice2.Name = "txtPrice2"
        Me.txtPrice2.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPrice2.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice2.Properties.Appearance.Options.UseBackColor = True
        Me.txtPrice2.Properties.Appearance.Options.UseFont = True
        Me.txtPrice2.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrice2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPrice2.Size = New System.Drawing.Size(173, 31)
        Me.txtPrice2.TabIndex = 232
        '
        'chePrint
        '
        Me.chePrint.Location = New System.Drawing.Point(288, 174)
        Me.chePrint.Name = "chePrint"
        Me.chePrint.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chePrint.Properties.Appearance.Options.UseFont = True
        Me.chePrint.Properties.Caption = "In bếp"
        Me.chePrint.Size = New System.Drawing.Size(140, 24)
        Me.chePrint.TabIndex = 231
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(8, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 19)
        Me.LabelControl1.TabIndex = 229
        Me.LabelControl1.Text = "Mã hàng"
        '
        'txtID
        '
        Me.txtID.EditValue = ""
        Me.txtID.Location = New System.Drawing.Point(109, 33)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.txtID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Properties.Appearance.Options.UseFont = True
        Me.txtID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtID.Properties.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(352, 31)
        Me.txtID.TabIndex = 228
        '
        'lkpNhomHang
        '
        Me.lkpNhomHang.Location = New System.Drawing.Point(109, 107)
        Me.lkpNhomHang.Name = "lkpNhomHang"
        Me.lkpNhomHang.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpNhomHang.Properties.Appearance.Options.UseFont = True
        Me.lkpNhomHang.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpNhomHang.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkpNhomHang.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpNhomHang.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkpNhomHang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpNhomHang.Properties.NullText = ""
        Me.lkpNhomHang.Properties.PopupWidth = 400
        Me.lkpNhomHang.Size = New System.Drawing.Size(173, 31)
        Me.lkpNhomHang.TabIndex = 227
        '
        'lblUnit
        '
        Me.lblUnit.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblUnit.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblUnit.Location = New System.Drawing.Point(288, 113)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(54, 19)
        Me.lblUnit.TabIndex = 224
        Me.lblUnit.Text = "ĐVT"
        '
        'txtUnit
        '
        Me.txtUnit.EditValue = ""
        Me.txtUnit.Location = New System.Drawing.Point(348, 107)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUnit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Properties.Appearance.Options.UseBackColor = True
        Me.txtUnit.Properties.Appearance.Options.UseFont = True
        Me.txtUnit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUnit.Size = New System.Drawing.Size(113, 31)
        Me.txtUnit.TabIndex = 223
        '
        'lblPrice1
        '
        Me.lblPrice1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblPrice1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblPrice1.Location = New System.Drawing.Point(8, 150)
        Me.lblPrice1.Name = "lblPrice1"
        Me.lblPrice1.Size = New System.Drawing.Size(95, 19)
        Me.lblPrice1.TabIndex = 34
        Me.lblPrice1.Text = "Giá 1"
        '
        'txtPrice1
        '
        Me.txtPrice1.EditValue = ""
        Me.txtPrice1.Location = New System.Drawing.Point(109, 144)
        Me.txtPrice1.Name = "txtPrice1"
        Me.txtPrice1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPrice1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice1.Properties.Appearance.Options.UseBackColor = True
        Me.txtPrice1.Properties.Appearance.Options.UseFont = True
        Me.txtPrice1.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrice1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPrice1.Size = New System.Drawing.Size(173, 31)
        Me.txtPrice1.TabIndex = 33
        '
        'lblGroupItem
        '
        Me.lblGroupItem.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupItem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblGroupItem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblGroupItem.Location = New System.Drawing.Point(8, 113)
        Me.lblGroupItem.Name = "lblGroupItem"
        Me.lblGroupItem.Size = New System.Drawing.Size(95, 19)
        Me.lblGroupItem.TabIndex = 31
        Me.lblGroupItem.Text = "Nhóm hàng"
        '
        'lblItem
        '
        Me.lblItem.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblItem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblItem.Location = New System.Drawing.Point(8, 76)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(95, 19)
        Me.lblItem.TabIndex = 30
        Me.lblItem.Text = "Tên hàng"
        '
        'cmdApply
        '
        Me.cmdApply.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdApply.Appearance.Options.UseFont = True
        Me.cmdApply.Image = CType(resources.GetObject("cmdApply.Image"), System.Drawing.Image)
        Me.cmdApply.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdApply.Location = New System.Drawing.Point(303, 403)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(140, 60)
        Me.cmdApply.TabIndex = 5
        Me.cmdApply.Text = "Apply"
        '
        'cmdOK
        '
        Me.cmdOK.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.Appearance.Options.UseFont = True
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOK.Image = CType(resources.GetObject("cmdOK.Image"), System.Drawing.Image)
        Me.cmdOK.Location = New System.Drawing.Point(23, 403)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(124, 60)
        Me.cmdOK.TabIndex = 4
        Me.cmdOK.Text = "OK"
        '
        'txtName
        '
        Me.txtName.EditValue = ""
        Me.txtName.Location = New System.Drawing.Point(109, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Properties.Appearance.Options.UseBackColor = True
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtName.Size = New System.Drawing.Size(352, 31)
        Me.txtName.TabIndex = 1
        '
        'cheShifts
        '
        Me.cheShifts.AutoSizeInLayoutControl = True
        Me.cheShifts.Location = New System.Drawing.Point(368, 144)
        Me.cheShifts.Name = "cheShifts"
        Me.cheShifts.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheShifts.Properties.Appearance.Options.UseFont = True
        Me.cheShifts.Properties.Appearance.Options.UseTextOptions = True
        Me.cheShifts.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.cheShifts.Properties.Caption = "KHO 1-1"
        Me.cheShifts.Size = New System.Drawing.Size(93, 24)
        Me.cheShifts.TabIndex = 253
        '
        'frm_EditItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 477)
        Me.Controls.Add(Me.gpcHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_EditItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chỉnh sửa mặt hàng"
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcHeader.ResumeLayout(False)
        CType(Me.rgpCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpPrinter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chePrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpNhomHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheShifts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcHeader As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdRight As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdLeft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cheStatus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpPrinter As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrice2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chePrint As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpNhomHang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblUnit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPrice1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrice1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblGroupItem As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblItem As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdApply As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ColorEdit1 As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrice4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrice3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrice5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rgpCombo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cmdMonPhu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cheShifts As DevExpress.XtraEditors.CheckEdit
End Class
