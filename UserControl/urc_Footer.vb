Public Class urc_Footer
#Region "Formload"
    Private Sub urc_Footer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Lấy thông tin công ty
        SubM_GetCompanyInfo()
        Me.txtUser.Text = gvStr_AccUser
        Me.txtCompany.Text = gvCls_Company.Name
        Me.txtMachine.Text = String.Format("Máy {0}", gvStr_LocID)
        Dim mvCls_LoadLanguage As New cls_LoadLanguage
        Me.lblCopyright.Text = mvCls_LoadLanguage.FuncG_GetData(1, "urc_Footer", 1)
        Me.lblCopyright.Left = (Parent.ClientRectangle.Width / 2) - (Me.lblCopyright.Width / 2)
    End Sub
#End Region
#Region "Refresh time"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.txtTime.Text = Format(Now(), "dd/MM/yyyy HH:mm:ss")
    End Sub
#End Region
End Class
