<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class urc_Footer
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblCopyright = New DevExpress.XtraEditors.LabelControl
        Me.txtTime = New DevExpress.XtraEditors.TextEdit
        Me.txtMachine = New DevExpress.XtraEditors.TextEdit
        Me.txtCompany = New DevExpress.XtraEditors.TextEdit
        Me.txtUser = New DevExpress.XtraEditors.TextEdit
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.txtTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMachine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCopyright
        '
        Me.lblCopyright.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(4, 7)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(396, 23)
        Me.lblCopyright.TabIndex = 23
        Me.lblCopyright.Text = "Product of Le Vu Co. Ltd - www.levuepos.com"
        '
        'txtTime
        '
        Me.txtTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTime.EditValue = "Thời gian"
        Me.txtTime.Location = New System.Drawing.Point(690, 42)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTime.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Properties.Appearance.Options.UseBackColor = True
        Me.txtTime.Properties.Appearance.Options.UseFont = True
        Me.txtTime.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTime.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTime.Properties.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(51, 28)
        Me.txtTime.TabIndex = 22
        Me.txtTime.TabStop = False
        '
        'txtMachine
        '
        Me.txtMachine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMachine.EditValue = "Máy"
        Me.txtMachine.Location = New System.Drawing.Point(575, 42)
        Me.txtMachine.Name = "txtMachine"
        Me.txtMachine.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMachine.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMachine.Properties.Appearance.Options.UseBackColor = True
        Me.txtMachine.Properties.Appearance.Options.UseFont = True
        Me.txtMachine.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMachine.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMachine.Properties.ReadOnly = True
        Me.txtMachine.Size = New System.Drawing.Size(115, 28)
        Me.txtMachine.TabIndex = 21
        Me.txtMachine.TabStop = False
        '
        'txtCompany
        '
        Me.txtCompany.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCompany.EditValue = "Tên công ty"
        Me.txtCompany.Location = New System.Drawing.Point(217, 42)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCompany.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Properties.Appearance.Options.UseBackColor = True
        Me.txtCompany.Properties.Appearance.Options.UseFont = True
        Me.txtCompany.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCompany.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCompany.Properties.ReadOnly = True
        Me.txtCompany.Size = New System.Drawing.Size(358, 28)
        Me.txtCompany.TabIndex = 20
        Me.txtCompany.TabStop = False
        '
        'txtUser
        '
        Me.txtUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUser.EditValue = "Tên user"
        Me.txtUser.Location = New System.Drawing.Point(4, 42)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUser.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Properties.Appearance.Options.UseBackColor = True
        Me.txtUser.Properties.Appearance.Options.UseFont = True
        Me.txtUser.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUser.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUser.Properties.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(213, 28)
        Me.txtUser.TabIndex = 19
        Me.txtUser.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'urc_Footer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtMachine)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.txtUser)
        Me.Name = "urc_Footer"
        Me.Size = New System.Drawing.Size(745, 74)
        CType(Me.txtTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMachine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMachine As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCompany As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblCopyright As DevExpress.XtraEditors.LabelControl

End Class
