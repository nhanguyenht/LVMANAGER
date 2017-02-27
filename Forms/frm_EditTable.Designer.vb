<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EditTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EditTable))
        Me.gpcHeader = New DevExpress.XtraEditors.GroupControl
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdApply = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtID = New DevExpress.XtraEditors.TextEdit
        Me.lblItem = New DevExpress.XtraEditors.LabelControl
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.rgpLanguage = New DevExpress.XtraEditors.RadioGroup
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcHeader.SuspendLayout()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgpLanguage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcHeader
        '
        Me.gpcHeader.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcHeader.Appearance.Options.UseFont = True
        Me.gpcHeader.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcHeader.AppearanceCaption.Options.UseFont = True
        Me.gpcHeader.Controls.Add(Me.rgpLanguage)
        Me.gpcHeader.Controls.Add(Me.cmdExit)
        Me.gpcHeader.Controls.Add(Me.cmdApply)
        Me.gpcHeader.Controls.Add(Me.LabelControl1)
        Me.gpcHeader.Controls.Add(Me.txtID)
        Me.gpcHeader.Controls.Add(Me.lblItem)
        Me.gpcHeader.Controls.Add(Me.txtName)
        Me.gpcHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpcHeader.Location = New System.Drawing.Point(0, 0)
        Me.gpcHeader.Name = "gpcHeader"
        Me.gpcHeader.Size = New System.Drawing.Size(397, 212)
        Me.gpcHeader.TabIndex = 3
        Me.gpcHeader.Text = "Thông tin bàn"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(256, 143)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(121, 57)
        Me.cmdExit.TabIndex = 231
        Me.cmdExit.Text = "Thoát"
        '
        'cmdApply
        '
        Me.cmdApply.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdApply.Appearance.Options.UseFont = True
        Me.cmdApply.Image = CType(resources.GetObject("cmdApply.Image"), System.Drawing.Image)
        Me.cmdApply.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdApply.Location = New System.Drawing.Point(95, 143)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(121, 57)
        Me.cmdApply.TabIndex = 230
        Me.cmdApply.Text = "Apply"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(8, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 19)
        Me.LabelControl1.TabIndex = 229
        Me.LabelControl1.Text = "Mã bàn"
        '
        'txtID
        '
        Me.txtID.EditValue = ""
        Me.txtID.Location = New System.Drawing.Point(95, 33)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.txtID.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Properties.Appearance.Options.UseFont = True
        Me.txtID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtID.Properties.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(282, 31)
        Me.txtID.TabIndex = 228
        '
        'lblItem
        '
        Me.lblItem.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblItem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblItem.Location = New System.Drawing.Point(8, 76)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(81, 19)
        Me.lblItem.TabIndex = 30
        Me.lblItem.Text = "Tên bàn"
        '
        'txtName
        '
        Me.txtName.EditValue = ""
        Me.txtName.Location = New System.Drawing.Point(95, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Properties.Appearance.Options.UseBackColor = True
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtName.Size = New System.Drawing.Size(282, 31)
        Me.txtName.TabIndex = 1
        '
        'rgpLanguage
        '
        Me.rgpLanguage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.rgpLanguage.Location = New System.Drawing.Point(95, 107)
        Me.rgpLanguage.Name = "rgpLanguage"
        Me.rgpLanguage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgpLanguage.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgpLanguage.Properties.Appearance.Options.UseBackColor = True
        Me.rgpLanguage.Properties.Appearance.Options.UseFont = True
        Me.rgpLanguage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.rgpLanguage.Properties.Columns = 2
        Me.rgpLanguage.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Tắt"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Mở")})
        Me.rgpLanguage.Size = New System.Drawing.Size(282, 26)
        Me.rgpLanguage.TabIndex = 232
        '
        'frm_EditTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 212)
        Me.Controls.Add(Me.gpcHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_EditTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHỈNH SỬA THÔN TIN BÀN "
        CType(Me.gpcHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcHeader.ResumeLayout(False)
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgpLanguage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcHeader As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblItem As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdApply As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rgpLanguage As DevExpress.XtraEditors.RadioGroup
End Class
