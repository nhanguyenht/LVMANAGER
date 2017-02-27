<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sales_detail
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
        Me.lblkh = New DevExpress.XtraEditors.LabelControl
        Me.txtkh = New DevExpress.XtraEditors.LabelControl
        Me.txtidinvo = New DevExpress.XtraEditors.LabelControl
        Me.lblidinvo = New DevExpress.XtraEditors.LabelControl
        Me.lblTotalText = New DevExpress.XtraEditors.LabelControl
        Me.lblFinalCostText = New DevExpress.XtraEditors.LabelControl
        Me.lblFinalCost = New DevExpress.XtraEditors.LabelControl
        Me.txtVatText = New DevExpress.XtraEditors.LabelControl
        Me.lblVAT = New DevExpress.XtraEditors.LabelControl
        Me.lblDiscountText = New DevExpress.XtraEditors.LabelControl
        Me.lblDiscount = New DevExpress.XtraEditors.LabelControl
        Me.lblTotal = New DevExpress.XtraEditors.LabelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblkh
        '
        Me.lblkh.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblkh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblkh.Location = New System.Drawing.Point(12, 37)
        Me.lblkh.Name = "lblkh"
        Me.lblkh.Size = New System.Drawing.Size(142, 19)
        Me.lblkh.TabIndex = 230
        Me.lblkh.Text = "KHÁCH HÀNG:"
        '
        'txtkh
        '
        Me.txtkh.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtkh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtkh.Location = New System.Drawing.Point(160, 37)
        Me.txtkh.Name = "txtkh"
        Me.txtkh.Size = New System.Drawing.Size(184, 19)
        Me.txtkh.TabIndex = 231
        Me.txtkh.Text = "TÊN KHÁCH HÀNG"
        '
        'txtidinvo
        '
        Me.txtidinvo.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidinvo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtidinvo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtidinvo.Location = New System.Drawing.Point(160, 12)
        Me.txtidinvo.Name = "txtidinvo"
        Me.txtidinvo.Size = New System.Drawing.Size(184, 19)
        Me.txtidinvo.TabIndex = 236
        Me.txtidinvo.Text = "SỐ HÓA ĐƠN"
        '
        'lblidinvo
        '
        Me.lblidinvo.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidinvo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblidinvo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblidinvo.Location = New System.Drawing.Point(12, 12)
        Me.lblidinvo.Name = "lblidinvo"
        Me.lblidinvo.Size = New System.Drawing.Size(142, 19)
        Me.lblidinvo.TabIndex = 237
        Me.lblidinvo.Text = "MÃ HÓA ĐƠN:"
        '
        'lblTotalText
        '
        Me.lblTotalText.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTotalText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblTotalText.Location = New System.Drawing.Point(12, 62)
        Me.lblTotalText.Name = "lblTotalText"
        Me.lblTotalText.Size = New System.Drawing.Size(142, 19)
        Me.lblTotalText.TabIndex = 242
        Me.lblTotalText.Text = "TỔNG CỘNG:"
        '
        'lblFinalCostText
        '
        Me.lblFinalCostText.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalCostText.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblFinalCostText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFinalCostText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblFinalCostText.Location = New System.Drawing.Point(12, 137)
        Me.lblFinalCostText.Name = "lblFinalCostText"
        Me.lblFinalCostText.Size = New System.Drawing.Size(142, 21)
        Me.lblFinalCostText.TabIndex = 238
        Me.lblFinalCostText.Text = "THÀNH TIỀN:"
        '
        'lblFinalCost
        '
        Me.lblFinalCost.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalCost.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblFinalCost.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFinalCost.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblFinalCost.Location = New System.Drawing.Point(160, 137)
        Me.lblFinalCost.Name = "lblFinalCost"
        Me.lblFinalCost.Size = New System.Drawing.Size(184, 20)
        Me.lblFinalCost.TabIndex = 247
        Me.lblFinalCost.Text = "0"
        '
        'txtVatText
        '
        Me.txtVatText.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVatText.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtVatText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVatText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtVatText.Location = New System.Drawing.Point(12, 112)
        Me.txtVatText.Name = "txtVatText"
        Me.txtVatText.Size = New System.Drawing.Size(142, 19)
        Me.txtVatText.TabIndex = 239
        Me.txtVatText.Text = "VAT:"
        '
        'lblVAT
        '
        Me.lblVAT.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblVAT.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVAT.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblVAT.Location = New System.Drawing.Point(160, 112)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(184, 20)
        Me.lblVAT.TabIndex = 246
        Me.lblVAT.Text = "0"
        '
        'lblDiscountText
        '
        Me.lblDiscountText.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountText.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDiscountText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDiscountText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblDiscountText.Location = New System.Drawing.Point(12, 87)
        Me.lblDiscountText.Name = "lblDiscountText"
        Me.lblDiscountText.Size = New System.Drawing.Size(142, 19)
        Me.lblDiscountText.TabIndex = 241
        Me.lblDiscountText.Text = "GIẢM GIÁ:"
        '
        'lblDiscount
        '
        Me.lblDiscount.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDiscount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDiscount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblDiscount.Location = New System.Drawing.Point(160, 87)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(184, 20)
        Me.lblDiscount.TabIndex = 244
        Me.lblDiscount.Text = "0"
        '
        'lblTotal
        '
        Me.lblTotal.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTotal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblTotal.Location = New System.Drawing.Point(160, 62)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(184, 20)
        Me.lblTotal.TabIndex = 243
        Me.lblTotal.Text = "0"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridControl1.Location = New System.Drawing.Point(0, 219)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(356, 297)
        Me.GridControl1.TabIndex = 0
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
        Me.GridView1.IndicatorWidth = 30
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowRowSizing = True
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtidinvo)
        Me.PanelControl1.Controls.Add(Me.lblkh)
        Me.PanelControl1.Controls.Add(Me.lblTotalText)
        Me.PanelControl1.Controls.Add(Me.txtkh)
        Me.PanelControl1.Controls.Add(Me.lblFinalCostText)
        Me.PanelControl1.Controls.Add(Me.lblidinvo)
        Me.PanelControl1.Controls.Add(Me.lblFinalCost)
        Me.PanelControl1.Controls.Add(Me.lblTotal)
        Me.PanelControl1.Controls.Add(Me.txtVatText)
        Me.PanelControl1.Controls.Add(Me.lblDiscount)
        Me.PanelControl1.Controls.Add(Me.lblVAT)
        Me.PanelControl1.Controls.Add(Me.lblDiscountText)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(356, 219)
        Me.PanelControl1.TabIndex = 1
        '
        'frm_sales_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 517)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_sales_detail"
        Me.Text = "THÔNG TIN CHI TIẾT"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblkh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtkh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtidinvo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblidinvo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalText As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFinalCostText As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFinalCost As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVatText As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVAT As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDiscountText As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDiscount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
