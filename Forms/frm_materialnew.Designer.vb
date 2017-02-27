<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_materialnew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_materialnew))
        Me.lkpInvenUnit = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.spiExportRate = New DevExpress.XtraEditors.SpinEdit
        Me.spiImportRate = New DevExpress.XtraEditors.SpinEdit
        Me.lkpExportUnit = New DevExpress.XtraEditors.LookUpEdit
        Me.lkpImportUnit = New DevExpress.XtraEditors.LookUpEdit
        Me.txtMaterialName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtMaterialID = New DevExpress.XtraEditors.TextEdit
        Me.cmdAddNew = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.lkpInvenUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spiExportRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spiImportRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpExportUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpImportUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterialID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lkpInvenUnit
        '
        Me.lkpInvenUnit.Location = New System.Drawing.Point(171, 128)
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
        Me.lkpInvenUnit.TabIndex = 268
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl7.Location = New System.Drawing.Point(11, 131)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(154, 19)
        Me.LabelControl7.TabIndex = 267
        Me.LabelControl7.Text = "ĐVT Tồn"
        '
        'spiExportRate
        '
        Me.spiExportRate.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spiExportRate.Enabled = False
        Me.spiExportRate.Location = New System.Drawing.Point(324, 165)
        Me.spiExportRate.Name = "spiExportRate"
        Me.spiExportRate.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spiExportRate.Properties.Appearance.Options.UseFont = True
        Me.spiExportRate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spiExportRate.Properties.Mask.EditMask = "#,##0.00"
        Me.spiExportRate.Size = New System.Drawing.Size(196, 31)
        Me.spiExportRate.TabIndex = 266
        '
        'spiImportRate
        '
        Me.spiImportRate.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spiImportRate.Enabled = False
        Me.spiImportRate.Location = New System.Drawing.Point(324, 91)
        Me.spiImportRate.Name = "spiImportRate"
        Me.spiImportRate.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spiImportRate.Properties.Appearance.Options.UseFont = True
        Me.spiImportRate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spiImportRate.Properties.Mask.EditMask = "#,##0.00"
        Me.spiImportRate.Size = New System.Drawing.Size(196, 31)
        Me.spiImportRate.TabIndex = 265
        '
        'lkpExportUnit
        '
        Me.lkpExportUnit.Enabled = False
        Me.lkpExportUnit.Location = New System.Drawing.Point(171, 165)
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
        Me.lkpExportUnit.TabIndex = 264
        '
        'lkpImportUnit
        '
        Me.lkpImportUnit.Location = New System.Drawing.Point(171, 91)
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
        Me.lkpImportUnit.TabIndex = 263
        '
        'txtMaterialName
        '
        Me.txtMaterialName.EditValue = ""
        Me.txtMaterialName.Location = New System.Drawing.Point(324, 54)
        Me.txtMaterialName.Name = "txtMaterialName"
        Me.txtMaterialName.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMaterialName.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterialName.Properties.Appearance.Options.UseBackColor = True
        Me.txtMaterialName.Properties.Appearance.Options.UseFont = True
        Me.txtMaterialName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaterialName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMaterialName.Size = New System.Drawing.Size(196, 31)
        Me.txtMaterialName.TabIndex = 262
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl6.Location = New System.Drawing.Point(11, 168)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(154, 19)
        Me.LabelControl6.TabIndex = 261
        Me.LabelControl6.Text = "ĐVT Xuất"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl5.Location = New System.Drawing.Point(11, 94)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(154, 19)
        Me.LabelControl5.TabIndex = 260
        Me.LabelControl5.Text = "ĐVT Nhập"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl2.Location = New System.Drawing.Point(11, 57)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(154, 19)
        Me.LabelControl2.TabIndex = 259
        Me.LabelControl2.Text = "Nguyên liệu"
        '
        'txtMaterialID
        '
        Me.txtMaterialID.EditValue = ""
        Me.txtMaterialID.Enabled = False
        Me.txtMaterialID.Location = New System.Drawing.Point(171, 54)
        Me.txtMaterialID.Name = "txtMaterialID"
        Me.txtMaterialID.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMaterialID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterialID.Properties.Appearance.Options.UseBackColor = True
        Me.txtMaterialID.Properties.Appearance.Options.UseFont = True
        Me.txtMaterialID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaterialID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMaterialID.Size = New System.Drawing.Size(147, 31)
        Me.txtMaterialID.TabIndex = 258
        '
        'cmdAddNew
        '
        Me.cmdAddNew.AccessibleDescription = ""
        Me.cmdAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddNew.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNew.Appearance.Options.UseFont = True
        Me.cmdAddNew.Image = CType(resources.GetObject("cmdAddNew.Image"), System.Drawing.Image)
        Me.cmdAddNew.Location = New System.Drawing.Point(198, 207)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(138, 54)
        Me.cmdAddNew.TabIndex = 256
        Me.cmdAddNew.Text = "Tạo mới"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.LabelControl1.Location = New System.Drawing.Point(11, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(554, 19)
        Me.LabelControl1.TabIndex = 259
        Me.LabelControl1.Text = "TẠO MỚI NGUYÊN VẬT LIỆU"
        '
        'frm_materialnew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 273)
        Me.Controls.Add(Me.lkpInvenUnit)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.spiExportRate)
        Me.Controls.Add(Me.spiImportRate)
        Me.Controls.Add(Me.lkpExportUnit)
        Me.Controls.Add(Me.lkpImportUnit)
        Me.Controls.Add(Me.txtMaterialName)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtMaterialID)
        Me.Controls.Add(Me.cmdAddNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_materialnew"
        Me.Text = "TẠO MỚI NGUYÊN VẬT LIỆU"
        CType(Me.lkpInvenUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spiExportRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spiImportRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpExportUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpImportUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterialID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lkpInvenUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spiExportRate As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spiImportRate As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lkpExportUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkpImportUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMaterialName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaterialID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAddNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
