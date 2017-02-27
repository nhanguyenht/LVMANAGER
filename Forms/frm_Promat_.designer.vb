<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Promat_
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Promat_))
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.lblItem = New DevExpress.XtraEditors.LabelControl
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cmdInsert = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.txtQty = New DevExpress.XtraEditors.TextEdit
        Me.cmdAddNew = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtMaterialID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtMaterialName = New DevExpress.XtraEditors.TextEdit
        Me.lkpImportUnit = New DevExpress.XtraEditors.LookUpEdit
        Me.lkpExportUnit = New DevExpress.XtraEditors.LookUpEdit
        Me.spiImportRate = New DevExpress.XtraEditors.SpinEdit
        Me.spiExportRate = New DevExpress.XtraEditors.SpinEdit
        Me.lkpInventory = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdRight = New DevExpress.XtraEditors.SimpleButton
        Me.cmdLeft = New DevExpress.XtraEditors.SimpleButton
        Me.txtItemID = New DevExpress.XtraEditors.TextEdit
        Me.lkpInvenUnit = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.lueItem = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpImportUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpExportUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spiImportRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spiExportRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpInvenUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(860, 593)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(134, 54)
        Me.cmdExit.TabIndex = 213
        Me.cmdExit.Text = "Thoát"
        '
        'cmdSearch
        '
        Me.cmdSearch.AccessibleDescription = ""
        Me.cmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSearch.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Appearance.Options.UseFont = True
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.Location = New System.Drawing.Point(715, 593)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(138, 54)
        Me.cmdSearch.TabIndex = 212
        Me.cmdSearch.Text = "Tìm kiếm"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl3.Location = New System.Drawing.Point(430, 7)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(285, 33)
        Me.LabelControl3.TabIndex = 217
        Me.LabelControl3.Text = "Thiết lập định lượng"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(4, 82)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(574, 577)
        Me.GroupControl1.TabIndex = 220
        Me.GroupControl1.Text = "Danh sách nguyên vật liệu"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 30)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(570, 545)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.ViewCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.ViewCaption.Options.UseFont = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl4.Location = New System.Drawing.Point(12, 50)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(87, 21)
        Me.LabelControl4.TabIndex = 221
        Me.LabelControl4.Text = "Mặt hàng"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.lblItem)
        Me.GroupControl2.Controls.Add(Me.txtName)
        Me.GroupControl2.Controls.Add(Me.GridControl2)
        Me.GroupControl2.Location = New System.Drawing.Point(583, 82)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(440, 229)
        Me.GroupControl2.TabIndex = 222
        Me.GroupControl2.Text = "Danh mục định lượng"
        '
        'lblItem
        '
        Me.lblItem.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblItem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblItem.Location = New System.Drawing.Point(5, 473)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(107, 19)
        Me.lblItem.TabIndex = 32
        Me.lblItem.Text = "Tên nguyên liêu"
        '
        'txtName
        '
        Me.txtName.EditValue = ""
        Me.txtName.Location = New System.Drawing.Point(126, 467)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Properties.Appearance.Options.UseBackColor = True
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtName.Size = New System.Drawing.Size(287, 31)
        Me.txtName.TabIndex = 31
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 30)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(436, 197)
        Me.GridControl2.TabIndex = 7
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Appearance.ViewCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.ViewCaption.Options.UseFont = True
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(585, 50)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(116, 21)
        Me.LabelControl1.TabIndex = 223
        Me.LabelControl1.Text = "Định lượng"
        '
        'cmdInsert
        '
        Me.cmdInsert.AccessibleDescription = ""
        Me.cmdInsert.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInsert.Appearance.Options.UseFont = True
        Me.cmdInsert.Image = CType(resources.GetObject("cmdInsert.Image"), System.Drawing.Image)
        Me.cmdInsert.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdInsert.Location = New System.Drawing.Point(966, 45)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(49, 31)
        Me.cmdInsert.TabIndex = 224
        '
        'cmdDelete
        '
        Me.cmdDelete.AccessibleDescription = ""
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.Location = New System.Drawing.Point(802, 326)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(87, 31)
        Me.cmdDelete.TabIndex = 225
        Me.cmdDelete.Text = "Xóa"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(709, 45)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Properties.Appearance.Options.UseFont = True
        Me.txtQty.Size = New System.Drawing.Size(96, 31)
        Me.txtQty.TabIndex = 226
        '
        'cmdAddNew
        '
        Me.cmdAddNew.AccessibleDescription = ""
        Me.cmdAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddNew.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNew.Appearance.Options.UseFont = True
        Me.cmdAddNew.Image = CType(resources.GetObject("cmdAddNew.Image"), System.Drawing.Image)
        Me.cmdAddNew.Location = New System.Drawing.Point(715, 526)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(138, 54)
        Me.cmdAddNew.TabIndex = 228
        Me.cmdAddNew.Text = "Tạo mới"
        '
        'cmdEdit
        '
        Me.cmdEdit.AccessibleDescription = ""
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Appearance.Options.UseFont = True
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.Location = New System.Drawing.Point(859, 526)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(135, 54)
        Me.cmdEdit.TabIndex = 229
        Me.cmdEdit.Text = "Sửa"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl2.Location = New System.Drawing.Point(584, 369)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 19)
        Me.LabelControl2.TabIndex = 231
        Me.LabelControl2.Text = "Nguyên liệu"
        '
        'txtMaterialID
        '
        Me.txtMaterialID.EditValue = ""
        Me.txtMaterialID.Enabled = False
        Me.txtMaterialID.Location = New System.Drawing.Point(674, 363)
        Me.txtMaterialID.Name = "txtMaterialID"
        Me.txtMaterialID.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMaterialID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterialID.Properties.Appearance.Options.UseBackColor = True
        Me.txtMaterialID.Properties.Appearance.Options.UseFont = True
        Me.txtMaterialID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaterialID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMaterialID.Size = New System.Drawing.Size(147, 31)
        Me.txtMaterialID.TabIndex = 230
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl5.Location = New System.Drawing.Point(584, 406)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(76, 19)
        Me.LabelControl5.TabIndex = 233
        Me.LabelControl5.Text = "ĐVT Nhập"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl6.Location = New System.Drawing.Point(584, 480)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(76, 19)
        Me.LabelControl6.TabIndex = 235
        Me.LabelControl6.Text = "ĐVT Xuất"
        '
        'txtMaterialName
        '
        Me.txtMaterialName.EditValue = ""
        Me.txtMaterialName.Location = New System.Drawing.Point(827, 363)
        Me.txtMaterialName.Name = "txtMaterialName"
        Me.txtMaterialName.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMaterialName.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterialName.Properties.Appearance.Options.UseBackColor = True
        Me.txtMaterialName.Properties.Appearance.Options.UseFont = True
        Me.txtMaterialName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaterialName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMaterialName.Size = New System.Drawing.Size(196, 31)
        Me.txtMaterialName.TabIndex = 244
        '
        'lkpImportUnit
        '
        Me.lkpImportUnit.Location = New System.Drawing.Point(674, 400)
        Me.lkpImportUnit.Name = "lkpImportUnit"
        Me.lkpImportUnit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpImportUnit.Properties.Appearance.Options.UseFont = True
        Me.lkpImportUnit.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpImportUnit.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkpImportUnit.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpImportUnit.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkpImportUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpImportUnit.Properties.NullText = ""
        Me.lkpImportUnit.Properties.PopupWidth = 400
        Me.lkpImportUnit.Size = New System.Drawing.Size(147, 31)
        Me.lkpImportUnit.TabIndex = 245
        '
        'lkpExportUnit
        '
        Me.lkpExportUnit.Enabled = False
        Me.lkpExportUnit.Location = New System.Drawing.Point(674, 474)
        Me.lkpExportUnit.Name = "lkpExportUnit"
        Me.lkpExportUnit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpExportUnit.Properties.Appearance.Options.UseFont = True
        Me.lkpExportUnit.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpExportUnit.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkpExportUnit.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpExportUnit.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkpExportUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpExportUnit.Properties.NullText = ""
        Me.lkpExportUnit.Properties.PopupWidth = 400
        Me.lkpExportUnit.Size = New System.Drawing.Size(147, 31)
        Me.lkpExportUnit.TabIndex = 246
        '
        'spiImportRate
        '
        Me.spiImportRate.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spiImportRate.Enabled = False
        Me.spiImportRate.Location = New System.Drawing.Point(827, 400)
        Me.spiImportRate.Name = "spiImportRate"
        Me.spiImportRate.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spiImportRate.Properties.Appearance.Options.UseFont = True
        Me.spiImportRate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spiImportRate.Properties.Mask.EditMask = "#,##0.00"
        Me.spiImportRate.Size = New System.Drawing.Size(196, 31)
        Me.spiImportRate.TabIndex = 248
        '
        'spiExportRate
        '
        Me.spiExportRate.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spiExportRate.Enabled = False
        Me.spiExportRate.Location = New System.Drawing.Point(827, 474)
        Me.spiExportRate.Name = "spiExportRate"
        Me.spiExportRate.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spiExportRate.Properties.Appearance.Options.UseFont = True
        Me.spiExportRate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spiExportRate.Properties.Mask.EditMask = "#,##0.00"
        Me.spiExportRate.Size = New System.Drawing.Size(196, 31)
        Me.spiExportRate.TabIndex = 249
        '
        'lkpInventory
        '
        Me.lkpInventory.Location = New System.Drawing.Point(810, 45)
        Me.lkpInventory.Name = "lkpInventory"
        Me.lkpInventory.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpInventory.Properties.Appearance.Options.UseFont = True
        Me.lkpInventory.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpInventory.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkpInventory.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpInventory.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkpInventory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpInventory.Properties.NullText = ""
        Me.lkpInventory.Properties.PopupWidth = 400
        Me.lkpInventory.Size = New System.Drawing.Size(150, 31)
        Me.lkpInventory.TabIndex = 250
        '
        'cmdRight
        '
        Me.cmdRight.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRight.Appearance.Options.UseFont = True
        Me.cmdRight.Image = CType(resources.GetObject("cmdRight.Image"), System.Drawing.Image)
        Me.cmdRight.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRight.Location = New System.Drawing.Point(637, 597)
        Me.cmdRight.Name = "cmdRight"
        Me.cmdRight.Size = New System.Drawing.Size(45, 48)
        Me.cmdRight.TabIndex = 252
        '
        'cmdLeft
        '
        Me.cmdLeft.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLeft.Appearance.Options.UseFont = True
        Me.cmdLeft.Image = CType(resources.GetObject("cmdLeft.Image"), System.Drawing.Image)
        Me.cmdLeft.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdLeft.Location = New System.Drawing.Point(586, 597)
        Me.cmdLeft.Name = "cmdLeft"
        Me.cmdLeft.Size = New System.Drawing.Size(47, 48)
        Me.cmdLeft.TabIndex = 251
        '
        'txtItemID
        '
        Me.txtItemID.Location = New System.Drawing.Point(115, 45)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemID.Properties.Appearance.Options.UseFont = True
        Me.txtItemID.Properties.ReadOnly = True
        Me.txtItemID.Size = New System.Drawing.Size(90, 31)
        Me.txtItemID.TabIndex = 253
        '
        'lkpInvenUnit
        '
        Me.lkpInvenUnit.Location = New System.Drawing.Point(674, 437)
        Me.lkpInvenUnit.Name = "lkpInvenUnit"
        Me.lkpInvenUnit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpInvenUnit.Properties.Appearance.Options.UseFont = True
        Me.lkpInvenUnit.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpInvenUnit.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkpInvenUnit.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpInvenUnit.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkpInvenUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpInvenUnit.Properties.NullText = ""
        Me.lkpInvenUnit.Properties.PopupWidth = 400
        Me.lkpInvenUnit.Size = New System.Drawing.Size(349, 31)
        Me.lkpInvenUnit.TabIndex = 255
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl7.Location = New System.Drawing.Point(584, 443)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(76, 19)
        Me.LabelControl7.TabIndex = 254
        Me.LabelControl7.Text = "ĐVT Tồn"
        '
        'lueItem
        '
        Me.lueItem.Location = New System.Drawing.Point(211, 45)
        Me.lueItem.Name = "lueItem"
        Me.lueItem.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueItem.Properties.Appearance.Options.UseFont = True
        Me.lueItem.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueItem.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lueItem.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueItem.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lueItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueItem.Properties.NullText = ""
        Me.lueItem.Properties.PopupWidth = 400
        Me.lueItem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lueItem.Size = New System.Drawing.Size(365, 31)
        Me.lueItem.TabIndex = 256
        '
        'frm_Promat_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 671)
        Me.Controls.Add(Me.lueItem)
        Me.Controls.Add(Me.lkpInvenUnit)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtItemID)
        Me.Controls.Add(Me.cmdRight)
        Me.Controls.Add(Me.cmdLeft)
        Me.Controls.Add(Me.lkpInventory)
        Me.Controls.Add(Me.spiExportRate)
        Me.Controls.Add(Me.spiImportRate)
        Me.Controls.Add(Me.lkpExportUnit)
        Me.Controls.Add(Me.lkpImportUnit)
        Me.Controls.Add(Me.txtMaterialName)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtMaterialID)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAddNew)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdInsert)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Promat_"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Định lượng"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpImportUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpExportUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spiImportRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spiExportRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpInvenUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdInsert As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAddNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblItem As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaterialID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaterialName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpImportUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkpExportUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents spiImportRate As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spiExportRate As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lkpInventory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdRight As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdLeft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtItemID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpInvenUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueItem As DevExpress.XtraEditors.LookUpEdit
End Class
