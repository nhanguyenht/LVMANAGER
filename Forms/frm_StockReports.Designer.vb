<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_StockReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_StockReports))
        Me.gpcArea = New DevExpress.XtraEditors.GroupControl
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdConfirm = New DevExpress.XtraEditors.SimpleButton
        Me.lblID = New DevExpress.XtraEditors.LabelControl
        Me.lkpInventory = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.gpcArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpcArea.SuspendLayout()
        CType(Me.lkpInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpcArea
        '
        Me.gpcArea.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcArea.Appearance.Options.UseFont = True
        Me.gpcArea.AppearanceCaption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpcArea.AppearanceCaption.Options.UseFont = True
        Me.gpcArea.Controls.Add(Me.lkpInventory)
        Me.gpcArea.Controls.Add(Me.cmdExit)
        Me.gpcArea.Controls.Add(Me.cmdConfirm)
        Me.gpcArea.Controls.Add(Me.lblID)
        Me.gpcArea.Location = New System.Drawing.Point(3, 3)
        Me.gpcArea.Name = "gpcArea"
        Me.gpcArea.Size = New System.Drawing.Size(293, 174)
        Me.gpcArea.TabIndex = 215
        Me.gpcArea.Text = "Chọn kho cần báo cáo"
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(154, 112)
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
        Me.cmdConfirm.Location = New System.Drawing.Point(5, 112)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(141, 57)
        Me.cmdConfirm.TabIndex = 212
        Me.cmdConfirm.Text = "Xác nhận"
        '
        'lblID
        '
        Me.lblID.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblID.Location = New System.Drawing.Point(14, 61)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(75, 19)
        Me.lblID.TabIndex = 31
        Me.lblID.Text = "Chọn kho :"
        '
        'lkpInventory
        '
        Me.lkpInventory.Location = New System.Drawing.Point(95, 57)
        Me.lkpInventory.Name = "lkpInventory"
        Me.lkpInventory.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpInventory.Properties.Appearance.Options.UseFont = True
        Me.lkpInventory.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpInventory.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkpInventory.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkpInventory.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkpInventory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpInventory.Properties.NullText = ""
        Me.lkpInventory.Properties.PopupWidth = 400
        Me.lkpInventory.Size = New System.Drawing.Size(189, 28)
        Me.lkpInventory.TabIndex = 214
        '
        'frm_StockReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 181)
        Me.Controls.Add(Me.gpcArea)
        Me.Name = "frm_StockReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.gpcArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpcArea.ResumeLayout(False)
        CType(Me.lkpInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpcArea As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpInventory As DevExpress.XtraEditors.LookUpEdit
End Class
