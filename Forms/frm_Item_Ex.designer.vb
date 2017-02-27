<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Item_Ex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Item_Ex))
        Me.gpcHeader = New DevExpress.XtraEditors.GroupControl
        Me.lblPrice2 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrice2 = New DevExpress.XtraEditors.TextEdit
        Me.lblPrice1 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrice1 = New DevExpress.XtraEditors.TextEdit
        Me.lblGroupItem = New DevExpress.XtraEditors.LabelControl
        Me.lblItem = New DevExpress.XtraEditors.LabelControl
        Me.txtGroupItem = New DevExpress.XtraEditors.TextEdit
        Me.txtItem = New DevExpress.XtraEditors.TextEdit
        Me.cmdThoat = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdAllLeft = New DevExpress.XtraEditors.SimpleButton
        Me.cmdLeft = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRight = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtNumber = New DevExpress.XtraEditors.SpinEdit
        Me.cmdUp2 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDown2 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdUp1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDown1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcHeader.SuspendLayout()
        CType(Me.txtPrice2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGroupItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txtNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcHeader
        '
        Me.gpcHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gpcHeader.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcHeader.Appearance.Options.UseFont = True
        Me.gpcHeader.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcHeader.AppearanceCaption.Options.UseFont = True
        Me.gpcHeader.Controls.Add(Me.lblPrice2)
        Me.gpcHeader.Controls.Add(Me.txtPrice2)
        Me.gpcHeader.Controls.Add(Me.lblPrice1)
        Me.gpcHeader.Controls.Add(Me.txtPrice1)
        Me.gpcHeader.Controls.Add(Me.lblGroupItem)
        Me.gpcHeader.Controls.Add(Me.lblItem)
        Me.gpcHeader.Controls.Add(Me.txtGroupItem)
        Me.gpcHeader.Controls.Add(Me.txtItem)
        Me.gpcHeader.Location = New System.Drawing.Point(-2, 0)
        Me.gpcHeader.Name = "gpcHeader"
        Me.gpcHeader.Size = New System.Drawing.Size(1039, 108)
        Me.gpcHeader.TabIndex = 2
        Me.gpcHeader.Text = "Thông tin món chính"
        '
        'lblPrice2
        '
        Me.lblPrice2.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblPrice2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblPrice2.Location = New System.Drawing.Point(668, 70)
        Me.lblPrice2.Name = "lblPrice2"
        Me.lblPrice2.Size = New System.Drawing.Size(76, 19)
        Me.lblPrice2.TabIndex = 36
        Me.lblPrice2.Text = "GIÁ 2"
        Me.lblPrice2.Visible = False
        '
        'txtPrice2
        '
        Me.txtPrice2.EditValue = ""
        Me.txtPrice2.Location = New System.Drawing.Point(750, 64)
        Me.txtPrice2.Name = "txtPrice2"
        Me.txtPrice2.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPrice2.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice2.Properties.Appearance.Options.UseBackColor = True
        Me.txtPrice2.Properties.Appearance.Options.UseFont = True
        Me.txtPrice2.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrice2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPrice2.Properties.ReadOnly = True
        Me.txtPrice2.Size = New System.Drawing.Size(147, 31)
        Me.txtPrice2.TabIndex = 35
        Me.txtPrice2.Visible = False
        '
        'lblPrice1
        '
        Me.lblPrice1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblPrice1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblPrice1.Location = New System.Drawing.Point(668, 39)
        Me.lblPrice1.Name = "lblPrice1"
        Me.lblPrice1.Size = New System.Drawing.Size(76, 19)
        Me.lblPrice1.TabIndex = 34
        Me.lblPrice1.Text = "GIÁ 1"
        Me.lblPrice1.Visible = False
        '
        'txtPrice1
        '
        Me.txtPrice1.EditValue = ""
        Me.txtPrice1.Location = New System.Drawing.Point(750, 33)
        Me.txtPrice1.Name = "txtPrice1"
        Me.txtPrice1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPrice1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice1.Properties.Appearance.Options.UseBackColor = True
        Me.txtPrice1.Properties.Appearance.Options.UseFont = True
        Me.txtPrice1.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrice1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPrice1.Properties.ReadOnly = True
        Me.txtPrice1.Size = New System.Drawing.Size(147, 31)
        Me.txtPrice1.TabIndex = 33
        Me.txtPrice1.Visible = False
        '
        'lblGroupItem
        '
        Me.lblGroupItem.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupItem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblGroupItem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblGroupItem.Location = New System.Drawing.Point(44, 73)
        Me.lblGroupItem.Name = "lblGroupItem"
        Me.lblGroupItem.Size = New System.Drawing.Size(108, 19)
        Me.lblGroupItem.TabIndex = 31
        Me.lblGroupItem.Text = "NHÓM MÓN"
        Me.lblGroupItem.Visible = False
        '
        'lblItem
        '
        Me.lblItem.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblItem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblItem.Location = New System.Drawing.Point(156, 45)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(108, 19)
        Me.lblItem.TabIndex = 30
        Me.lblItem.Text = "TÊN MÓN"
        '
        'txtGroupItem
        '
        Me.txtGroupItem.EditValue = ""
        Me.txtGroupItem.Location = New System.Drawing.Point(158, 67)
        Me.txtGroupItem.Name = "txtGroupItem"
        Me.txtGroupItem.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.txtGroupItem.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupItem.Properties.Appearance.Options.UseBackColor = True
        Me.txtGroupItem.Properties.Appearance.Options.UseFont = True
        Me.txtGroupItem.Properties.Appearance.Options.UseTextOptions = True
        Me.txtGroupItem.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtGroupItem.Properties.MaxLength = 10
        Me.txtGroupItem.Properties.ReadOnly = True
        Me.txtGroupItem.Size = New System.Drawing.Size(349, 31)
        Me.txtGroupItem.TabIndex = 2
        Me.txtGroupItem.Visible = False
        '
        'txtItem
        '
        Me.txtItem.EditValue = ""
        Me.txtItem.Location = New System.Drawing.Point(299, 36)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtItem.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Properties.Appearance.Options.UseBackColor = True
        Me.txtItem.Properties.Appearance.Options.UseFont = True
        Me.txtItem.Properties.Appearance.Options.UseTextOptions = True
        Me.txtItem.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtItem.Properties.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(349, 31)
        Me.txtItem.TabIndex = 1
        '
        'cmdThoat
        '
        Me.cmdThoat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThoat.Appearance.Options.UseFont = True
        Me.cmdThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdThoat.Image = CType(resources.GetObject("cmdThoat.Image"), System.Drawing.Image)
        Me.cmdThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdThoat.Location = New System.Drawing.Point(463, 498)
        Me.cmdThoat.Name = "cmdThoat"
        Me.cmdThoat.Size = New System.Drawing.Size(107, 52)
        Me.cmdThoat.TabIndex = 5
        Me.cmdThoat.Text = "Thoát"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(-2, 114)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(459, 379)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Danh sách món hiện có"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridControl1.Location = New System.Drawing.Point(4, 33)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(450, 341)
        Me.GridControl1.TabIndex = 7
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
        'GroupControl2
        '
        Me.GroupControl2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.GridControl2)
        Me.GroupControl2.Location = New System.Drawing.Point(578, 114)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(459, 379)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Danh sách món phụ kèm theo"
        '
        'GridControl2
        '
        Me.GridControl2.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridControl2.Location = New System.Drawing.Point(5, 33)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(449, 341)
        Me.GridControl2.TabIndex = 8
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowColumnResizing = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowColumnHeaders = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'cmdAllLeft
        '
        Me.cmdAllLeft.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdAllLeft.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAllLeft.Appearance.Options.UseFont = True
        Me.cmdAllLeft.Image = CType(resources.GetObject("cmdAllLeft.Image"), System.Drawing.Image)
        Me.cmdAllLeft.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAllLeft.Location = New System.Drawing.Point(473, 372)
        Me.cmdAllLeft.Name = "cmdAllLeft"
        Me.cmdAllLeft.Size = New System.Drawing.Size(88, 52)
        Me.cmdAllLeft.TabIndex = 232
        Me.cmdAllLeft.Text = "Xuống"
        Me.cmdAllLeft.Visible = False
        '
        'cmdLeft
        '
        Me.cmdLeft.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdLeft.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLeft.Appearance.Options.UseFont = True
        Me.cmdLeft.Image = CType(resources.GetObject("cmdLeft.Image"), System.Drawing.Image)
        Me.cmdLeft.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdLeft.Location = New System.Drawing.Point(473, 311)
        Me.cmdLeft.Name = "cmdLeft"
        Me.cmdLeft.Size = New System.Drawing.Size(88, 52)
        Me.cmdLeft.TabIndex = 231
        Me.cmdLeft.Text = "Lên"
        '
        'cmdRight
        '
        Me.cmdRight.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdRight.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRight.Appearance.Options.UseFont = True
        Me.cmdRight.Image = CType(resources.GetObject("cmdRight.Image"), System.Drawing.Image)
        Me.cmdRight.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRight.Location = New System.Drawing.Point(473, 159)
        Me.cmdRight.Name = "cmdRight"
        Me.cmdRight.Size = New System.Drawing.Size(88, 52)
        Me.cmdRight.TabIndex = 229
        Me.cmdRight.Text = "Lên"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtNumber)
        Me.Panel1.Location = New System.Drawing.Point(473, 236)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(88, 50)
        Me.Panel1.TabIndex = 234
        '
        'txtNumber
        '
        Me.txtNumber.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtNumber.Location = New System.Drawing.Point(8, 9)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNumber.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumber.Properties.Appearance.Options.UseFont = True
        Me.txtNumber.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNumber.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtNumber.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtNumber.Size = New System.Drawing.Size(70, 31)
        Me.txtNumber.TabIndex = 233
        '
        'cmdUp2
        '
        Me.cmdUp2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdUp2.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUp2.Appearance.Options.UseFont = True
        Me.cmdUp2.Image = CType(resources.GetObject("cmdUp2.Image"), System.Drawing.Image)
        Me.cmdUp2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdUp2.Location = New System.Drawing.Point(771, 498)
        Me.cmdUp2.Name = "cmdUp2"
        Me.cmdUp2.Size = New System.Drawing.Size(59, 52)
        Me.cmdUp2.TabIndex = 235
        '
        'cmdDown2
        '
        Me.cmdDown2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdDown2.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDown2.Appearance.Options.UseFont = True
        Me.cmdDown2.Image = CType(resources.GetObject("cmdDown2.Image"), System.Drawing.Image)
        Me.cmdDown2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdDown2.Location = New System.Drawing.Point(836, 498)
        Me.cmdDown2.Name = "cmdDown2"
        Me.cmdDown2.Size = New System.Drawing.Size(59, 52)
        Me.cmdDown2.TabIndex = 236
        '
        'cmdUp1
        '
        Me.cmdUp1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdUp1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUp1.Appearance.Options.UseFont = True
        Me.cmdUp1.Image = CType(resources.GetObject("cmdUp1.Image"), System.Drawing.Image)
        Me.cmdUp1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdUp1.Location = New System.Drawing.Point(203, 498)
        Me.cmdUp1.Name = "cmdUp1"
        Me.cmdUp1.Size = New System.Drawing.Size(59, 52)
        Me.cmdUp1.TabIndex = 237
        '
        'cmdDown1
        '
        Me.cmdDown1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdDown1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDown1.Appearance.Options.UseFont = True
        Me.cmdDown1.Image = CType(resources.GetObject("cmdDown1.Image"), System.Drawing.Image)
        Me.cmdDown1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdDown1.Location = New System.Drawing.Point(138, 498)
        Me.cmdDown1.Name = "cmdDown1"
        Me.cmdDown1.Size = New System.Drawing.Size(59, 52)
        Me.cmdDown1.TabIndex = 238
        '
        'frm_Item_Ex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 562)
        Me.Controls.Add(Me.cmdUp1)
        Me.Controls.Add(Me.cmdDown1)
        Me.Controls.Add(Me.cmdUp2)
        Me.Controls.Add(Me.cmdDown2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdThoat)
        Me.Controls.Add(Me.cmdAllLeft)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.cmdLeft)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gpcHeader)
        Me.Controls.Add(Me.cmdRight)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Item_Ex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Item_Ex"
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcHeader.ResumeLayout(False)
        CType(Me.txtPrice2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGroupItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.txtNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcHeader As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblPrice2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrice2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPrice1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrice1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblGroupItem As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblItem As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtGroupItem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtItem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdAllLeft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdLeft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRight As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdUp2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDown2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUp1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDown1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNumber As DevExpress.XtraEditors.SpinEdit
End Class
