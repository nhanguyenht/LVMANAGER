<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_InventoryBalance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_InventoryBalance))
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtKho = New DevExpress.XtraEditors.TextEdit
        Me.txtDVT = New DevExpress.XtraEditors.TextEdit
        Me.txtGiaban = New DevExpress.XtraEditors.TextEdit
        Me.txtSoluong = New DevExpress.XtraEditors.TextEdit
        Me.txtTenhang = New DevExpress.XtraEditors.TextEdit
        Me.txtStockID = New DevExpress.XtraEditors.TextEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtKho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGiaban.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoluong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenhang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl3.Location = New System.Drawing.Point(358, 7)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(285, 33)
        Me.LabelControl3.TabIndex = 217
        Me.LabelControl3.Text = "CÂN ĐỐI KHO"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(4, 46)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(674, 512)
        Me.GroupControl1.TabIndex = 220
        Me.GroupControl1.Text = "Danh sách kho hàng"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(2, 30)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(621, 480)
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
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.cmdSearch)
        Me.GroupControl2.Controls.Add(Me.cmdEdit)
        Me.GroupControl2.Controls.Add(Me.cmdExit)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.txtKho)
        Me.GroupControl2.Controls.Add(Me.txtDVT)
        Me.GroupControl2.Controls.Add(Me.txtGiaban)
        Me.GroupControl2.Controls.Add(Me.txtSoluong)
        Me.GroupControl2.Controls.Add(Me.txtTenhang)
        Me.GroupControl2.Controls.Add(Me.txtStockID)
        Me.GroupControl2.Location = New System.Drawing.Point(633, 46)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(385, 512)
        Me.GroupControl2.TabIndex = 255
        Me.GroupControl2.Text = "Cập nhật kho "
        '
        'cmdSearch
        '
        Me.cmdSearch.AccessibleDescription = ""
        Me.cmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSearch.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Appearance.Options.UseFont = True
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.Location = New System.Drawing.Point(157, 300)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(138, 54)
        Me.cmdSearch.TabIndex = 265
        Me.cmdSearch.Text = "Tìm kiếm"
        '
        'cmdEdit
        '
        Me.cmdEdit.AccessibleDescription = ""
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Appearance.Options.UseFont = True
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.Location = New System.Drawing.Point(78, 377)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(135, 54)
        Me.cmdEdit.TabIndex = 258
        Me.cmdEdit.Text = "Sửa"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(238, 377)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(134, 54)
        Me.cmdExit.TabIndex = 257
        Me.cmdExit.Text = "Thoát"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl7.Location = New System.Drawing.Point(23, 174)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl7.TabIndex = 264
        Me.LabelControl7.Text = "Số Lượng Tồn"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl4.Location = New System.Drawing.Point(23, 249)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl4.TabIndex = 263
        Me.LabelControl4.Text = "Kho"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(23, 212)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl1.TabIndex = 263
        Me.LabelControl1.Text = "ĐVT"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl6.Location = New System.Drawing.Point(23, 137)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl6.TabIndex = 263
        Me.LabelControl6.Text = "Giá bán"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl5.Location = New System.Drawing.Point(23, 101)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl5.TabIndex = 262
        Me.LabelControl5.Text = "Tên Hàng"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl2.Location = New System.Drawing.Point(23, 64)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl2.TabIndex = 261
        Me.LabelControl2.Text = "Mã hàng"
        '
        'txtKho
        '
        Me.txtKho.EditValue = ""
        Me.txtKho.Enabled = False
        Me.txtKho.Location = New System.Drawing.Point(142, 246)
        Me.txtKho.Name = "txtKho"
        Me.txtKho.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtKho.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKho.Properties.Appearance.Options.UseBackColor = True
        Me.txtKho.Properties.Appearance.Options.UseFont = True
        Me.txtKho.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKho.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtKho.Size = New System.Drawing.Size(230, 31)
        Me.txtKho.TabIndex = 260
        '
        'txtDVT
        '
        Me.txtDVT.EditValue = ""
        Me.txtDVT.Enabled = False
        Me.txtDVT.Location = New System.Drawing.Point(142, 209)
        Me.txtDVT.Name = "txtDVT"
        Me.txtDVT.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDVT.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDVT.Properties.Appearance.Options.UseBackColor = True
        Me.txtDVT.Properties.Appearance.Options.UseFont = True
        Me.txtDVT.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDVT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDVT.Size = New System.Drawing.Size(230, 31)
        Me.txtDVT.TabIndex = 260
        '
        'txtGiaban
        '
        Me.txtGiaban.EditValue = ""
        Me.txtGiaban.Enabled = False
        Me.txtGiaban.Location = New System.Drawing.Point(142, 134)
        Me.txtGiaban.Name = "txtGiaban"
        Me.txtGiaban.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtGiaban.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGiaban.Properties.Appearance.Options.UseBackColor = True
        Me.txtGiaban.Properties.Appearance.Options.UseFont = True
        Me.txtGiaban.Properties.Appearance.Options.UseTextOptions = True
        Me.txtGiaban.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtGiaban.Size = New System.Drawing.Size(230, 31)
        Me.txtGiaban.TabIndex = 260
        '
        'txtSoluong
        '
        Me.txtSoluong.EditValue = ""
        Me.txtSoluong.Enabled = False
        Me.txtSoluong.Location = New System.Drawing.Point(142, 171)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSoluong.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoluong.Properties.Appearance.Options.UseBackColor = True
        Me.txtSoluong.Properties.Appearance.Options.UseFont = True
        Me.txtSoluong.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSoluong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSoluong.Size = New System.Drawing.Size(230, 31)
        Me.txtSoluong.TabIndex = 257
        '
        'txtTenhang
        '
        Me.txtTenhang.EditValue = ""
        Me.txtTenhang.Enabled = False
        Me.txtTenhang.Location = New System.Drawing.Point(142, 98)
        Me.txtTenhang.Name = "txtTenhang"
        Me.txtTenhang.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTenhang.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenhang.Properties.Appearance.Options.UseBackColor = True
        Me.txtTenhang.Properties.Appearance.Options.UseFont = True
        Me.txtTenhang.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTenhang.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTenhang.Size = New System.Drawing.Size(230, 31)
        Me.txtTenhang.TabIndex = 258
        '
        'txtStockID
        '
        Me.txtStockID.EditValue = ""
        Me.txtStockID.Enabled = False
        Me.txtStockID.Location = New System.Drawing.Point(142, 58)
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtStockID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockID.Properties.Appearance.Options.UseBackColor = True
        Me.txtStockID.Properties.Appearance.Options.UseFont = True
        Me.txtStockID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStockID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtStockID.Size = New System.Drawing.Size(230, 31)
        Me.txtStockID.TabIndex = 259
        '
        'frm_InventoryBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 553)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.LabelControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_InventoryBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cân đối kho"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txtKho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGiaban.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoluong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenhang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGiaban As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSoluong As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTenhang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStockID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKho As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDVT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
End Class
