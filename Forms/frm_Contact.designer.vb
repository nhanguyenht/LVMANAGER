<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Contact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Contact))
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdThoat = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.lblHeader = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.lblLicense = New DevExpress.XtraEditors.LabelControl
        Me.lblVersion = New DevExpress.XtraEditors.LabelControl
        Me.lblThanks = New DevExpress.XtraEditors.LabelControl
        Me.lblEmail = New DevExpress.XtraEditors.LabelControl
        Me.lblPhone = New DevExpress.XtraEditors.LabelControl
        Me.lblDesignBy = New DevExpress.XtraEditors.LabelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
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
        Me.cmdThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThoat.Appearance.Options.UseFont = True
        Me.cmdThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdThoat.Image = CType(resources.GetObject("cmdThoat.Image"), System.Drawing.Image)
        Me.cmdThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdThoat.Location = New System.Drawing.Point(281, 198)
        Me.cmdThoat.Name = "cmdThoat"
        Me.cmdThoat.Size = New System.Drawing.Size(142, 58)
        Me.cmdThoat.TabIndex = 11
        Me.cmdThoat.Text = "Thoát"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblHeader)
        Me.PanelControl1.Controls.Add(Me.GroupControl3)
        Me.PanelControl1.Controls.Add(Me.cmdThoat)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(437, 263)
        Me.PanelControl1.TabIndex = 191
        '
        'lblHeader
        '
        Me.lblHeader.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Appearance.Image = CType(resources.GetObject("lblHeader.Appearance.Image"), System.Drawing.Image)
        Me.lblHeader.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHeader.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblHeader.Location = New System.Drawing.Point(8, 5)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(187, 55)
        Me.lblHeader.TabIndex = 233
        Me.lblHeader.Text = "Liên hệ"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.lblLicense)
        Me.GroupControl3.Controls.Add(Me.lblVersion)
        Me.GroupControl3.Controls.Add(Me.lblThanks)
        Me.GroupControl3.Controls.Add(Me.lblEmail)
        Me.GroupControl3.Controls.Add(Me.lblPhone)
        Me.GroupControl3.Controls.Add(Me.lblDesignBy)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 66)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(411, 126)
        Me.GroupControl3.TabIndex = 212
        Me.GroupControl3.Text = "Danh sách món ăn"
        '
        'lblLicense
        '
        Me.lblLicense.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLicense.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicense.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblLicense.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblLicense.Location = New System.Drawing.Point(8, 101)
        Me.lblLicense.Name = "lblLicense"
        Me.lblLicense.Size = New System.Drawing.Size(161, 19)
        Me.lblLicense.TabIndex = 239
        Me.lblLicense.Text = "Registered!"
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblVersion.Location = New System.Drawing.Point(208, 101)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(198, 19)
        Me.lblVersion.TabIndex = 238
        Me.lblVersion.Text = "Version"
        '
        'lblThanks
        '
        Me.lblThanks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblThanks.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThanks.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblThanks.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblThanks.Location = New System.Drawing.Point(8, 77)
        Me.lblThanks.Name = "lblThanks"
        Me.lblThanks.Size = New System.Drawing.Size(398, 19)
        Me.lblThanks.TabIndex = 237
        Me.lblThanks.Text = "Cám ơn quý khách đã sử dụng chương trình"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblEmail.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblEmail.Location = New System.Drawing.Point(8, 53)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(398, 19)
        Me.lblEmail.TabIndex = 236
        Me.lblEmail.Text = "Email : hoangnguyen1985vn@gmail.com"
        '
        'lblPhone
        '
        Me.lblPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPhone.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblPhone.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblPhone.Location = New System.Drawing.Point(8, 29)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(398, 19)
        Me.lblPhone.TabIndex = 235
        Me.lblPhone.Text = "Phone : 0935.328.921"
        '
        'lblDesignBy
        '
        Me.lblDesignBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDesignBy.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesignBy.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblDesignBy.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblDesignBy.Location = New System.Drawing.Point(8, 5)
        Me.lblDesignBy.Name = "lblDesignBy"
        Me.lblDesignBy.Size = New System.Drawing.Size(398, 19)
        Me.lblDesignBy.TabIndex = 234
        Me.lblDesignBy.Text = "Chương trình được thiết kế bởi Nguyễn Hoàng Nguyên"
        '
        'frm_Contact
        '
        Me.AcceptButton = Me.cmdThoat
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdThoat
        Me.ClientSize = New System.Drawing.Size(437, 263)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Contact"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liên hệ"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblHeader As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDesignBy As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVersion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblThanks As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPhone As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLicense As DevExpress.XtraEditors.LabelControl
End Class
