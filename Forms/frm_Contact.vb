Public Class frm_Contact
#Region "Nút Thoát"
    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        Me.Close()
    End Sub
#End Region
#Region "Form events"
    Private Sub frm_ERP_LienHe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If frm_MainMenu.bbiDangKy.Enabled Then
                Me.lblLicense.Text = "Unregistered!"
            Else
                Me.lblLicense.Text = "Registered!"
            End If
            Me.lblVersion.Text = String.Format("Version {0}.{1:0}.{1:00}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build)
            mod_LoadLanguageForm.SubG_ContactForm()
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class