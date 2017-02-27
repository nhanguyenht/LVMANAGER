<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReportsFromTo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ReportsFromTo))
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdConfirm = New DevExpress.XtraEditors.SimpleButton
        Me.gpcArea = New DevExpress.XtraEditors.GroupControl
        Me.chkChitiet = New DevExpress.XtraEditors.CheckEdit
        Me.cbxByShifts = New DevExpress.XtraEditors.LookUpEdit
        Me.cheShifts = New DevExpress.XtraEditors.CheckEdit
        Me.lkpObject = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lblID = New DevExpress.XtraEditors.LabelControl
        CType(Me.gpcArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcArea.SuspendLayout()
        CType(Me.chkChitiet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxByShifts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheShifts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpObject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(150, 196)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(134, 57)
        Me.cmdExit.TabIndex = 213
        Me.cmdExit.Text = "Thoát"
        '
        'cmdConfirm
        '
        Me.cmdConfirm.AccessibleDescription = ""
        Me.cmdConfirm.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.Appearance.Options.UseFont = True
        Me.cmdConfirm.Image = CType(resources.GetObject("cmdConfirm.Image"), System.Drawing.Image)
        Me.cmdConfirm.Location = New System.Drawing.Point(1, 196)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(141, 57)
        Me.cmdConfirm.TabIndex = 212
        Me.cmdConfirm.Text = "Xác nhận"
        '
        'gpcArea
        '
        Me.gpcArea.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcArea.Appearance.Options.UseFont = True
        Me.gpcArea.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcArea.AppearanceCaption.Options.UseFont = True
        Me.gpcArea.Controls.Add(Me.chkChitiet)
        Me.gpcArea.Controls.Add(Me.cbxByShifts)
        Me.gpcArea.Controls.Add(Me.cheShifts)
        Me.gpcArea.Controls.Add(Me.lkpObject)
        Me.gpcArea.Controls.Add(Me.LabelControl5)
        Me.gpcArea.Controls.Add(Me.DateEdit2)
        Me.gpcArea.Controls.Add(Me.cmdExit)
        Me.gpcArea.Controls.Add(Me.DateEdit1)
        Me.gpcArea.Controls.Add(Me.cmdConfirm)
        Me.gpcArea.Controls.Add(Me.LabelControl1)
        Me.gpcArea.Controls.Add(Me.lblID)
        Me.gpcArea.Location = New System.Drawing.Point(6, 6)
        Me.gpcArea.Name = "gpcArea"
        Me.gpcArea.Size = New System.Drawing.Size(293, 265)
        Me.gpcArea.TabIndex = 214
        Me.gpcArea.Text = "Chọn ngày cần báo cáo"
        '
        'chkChitiet
        '
        Me.chkChitiet.Location = New System.Drawing.Point(7, 166)
        Me.chkChitiet.Name = "chkChitiet"
        Me.chkChitiet.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChitiet.Properties.Appearance.Options.UseFont = True
        Me.chkChitiet.Properties.Appearance.Options.UseTextOptions = True
        Me.chkChitiet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkChitiet.Properties.Caption = "Xem Chi Tiết "
        Me.chkChitiet.Size = New System.Drawing.Size(277, 24)
        Me.chkChitiet.TabIndex = 218
        Me.chkChitiet.Visible = False
        '
        'cbxByShifts
        '
        Me.cbxByShifts.Location = New System.Drawing.Point(116, 125)
        Me.cbxByShifts.Name = "cbxByShifts"
        Me.cbxByShifts.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxByShifts.Properties.Appearance.Options.UseFont = True
        Me.cbxByShifts.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxByShifts.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbxByShifts.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxByShifts.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.cbxByShifts.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxByShifts.Properties.NullText = ""
        Me.cbxByShifts.Properties.PopupWidth = 400
        Me.cbxByShifts.Size = New System.Drawing.Size(172, 28)
        Me.cbxByShifts.TabIndex = 217
        '
        'cheShifts
        '
        Me.cheShifts.Location = New System.Drawing.Point(5, 126)
        Me.cheShifts.Name = "cheShifts"
        Me.cheShifts.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cheShifts.Properties.Appearance.Options.UseFont = True
        Me.cheShifts.Properties.Appearance.Options.UseTextOptions = True
        Me.cheShifts.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.cheShifts.Properties.Caption = "Theo ca :"
        Me.cheShifts.Size = New System.Drawing.Size(105, 24)
        Me.cheShifts.TabIndex = 216
        '
        'lkpObject
        '
        Me.lkpObject.Location = New System.Drawing.Point(116, 94)
        Me.lkpObject.Name = "lkpObject"
        Me.lkpObject.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpObject.Properties.Appearance.Options.UseFont = True
        Me.lkpObject.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpObject.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkpObject.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpObject.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkpObject.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpObject.Properties.NullText = ""
        Me.lkpObject.Properties.PopupWidth = 400
        Me.lkpObject.Size = New System.Drawing.Size(172, 28)
        Me.lkpObject.TabIndex = 214
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(42, 97)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(68, 19)
        Me.LabelControl5.TabIndex = 215
        Me.LabelControl5.Text = "Đối tượng :"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(116, 63)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEdit2.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEdit2.Properties.Appearance.Options.UseFont = True
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.DateEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateEdit2.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.DateEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateEdit2.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm"
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit2.Size = New System.Drawing.Size(172, 28)
        Me.DateEdit2.TabIndex = 34
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(116, 33)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateEdit1.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.DateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DateEdit1.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm"
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(172, 28)
        Me.DateEdit1.TabIndex = 33
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(35, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 19)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Đến ngày :"
        '
        'lblID
        '
        Me.lblID.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblID.Location = New System.Drawing.Point(35, 37)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(75, 19)
        Me.lblID.TabIndex = 31
        Me.lblID.Text = "Từ ngày :"
        '
        'frm_ReportsFromTo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 274)
        Me.Controls.Add(Me.gpcArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_ReportsFromTo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.gpcArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcArea.ResumeLayout(False)
        Me.gpcArea.PerformLayout()
        CType(Me.chkChitiet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxByShifts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheShifts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpObject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gpcArea As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpObject As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cheShifts As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbxByShifts As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkChitiet As DevExpress.XtraEditors.CheckEdit
End Class
