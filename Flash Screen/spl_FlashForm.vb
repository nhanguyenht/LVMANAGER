#Region "NameSpaces"
Imports ConIO.REG
Imports IO.REG
Imports Windows.REG
Imports Microsoft.Win32
Imports System.Security.Cryptography
Imports System.IO
#End Region
Public NotInheritable Class spl_FlashForm
    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    Dim count As Integer = 0
    Dim mvStr_Value As String
    Dim mvStr_Path As String = "SOFTWARE\Microsoft\Windows"
    Dim mvStr_NameKey As String = "Trial"
    Dim mvDate_CreateDate As Date
    Private Sub spl_CIE_Advertisement_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.lblVersion.Text = String.Format("Version {0}.{1:0}.{2:00}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build)
        Me.ProgressBarControl1.Properties.Minimum = 0
        Me.ProgressBarControl1.Properties.Maximum = 100
        With PictureBox2
            .Left = (Me.PanelControl1.ClientRectangle.Width / 2) - (.Width / 2)
        End With
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If count <= 100 Then
            Me.ProgressBarControl1.Position = count
            Dim wStr_Text As String = Me.lblWait.Text
            Select Case count
                Case 10, 40, 70
                    Me.lblWait.Text = "Please wait! Loading ."
                Case 20, 50, 80
                    Me.lblWait.Text = "Please wait! Loading ..."
                Case 30, 60, 90
                    Me.lblWait.Text = "Please wait! Loading ....."
            End Select
        End If
        count += 5
        Try
            If count = 95 Then
                SubG_CheckLic()
            End If
        Catch ex As Exception

        End Try
        If count = 100 Then
            Me.Close()
        End If
    End Sub
#Region "Check lic"
    Public Sub SubG_CheckLic()
        'If Not FuncG_DieuKien() Or Not FuncG_Condition() Or Not FuncG_REG() Then
        If Not FuncG_DieuKien() Or Not FuncG_Condition() Then
            'Nếu chưa đăng ký
            'Ngày để tính trial bắt đầu từ ngày tạo file
            mvDate_CreateDate = File.GetCreationTime(Application.StartupPath + "\LVManager.exe")
            Dim mvStr_KeyValue As String = FuncG_GetValuesKey(mvStr_Path, mvStr_NameKey)
            Dim mvDate_KeyValue As Date
            If mvStr_KeyValue Is Nothing Then
                'Tạo key mới
                SubG_SetValuesKey(mvStr_Path, mvStr_NameKey, Format(mvDate_CreateDate, "MM/dd/yyyy"))
                mvStr_KeyValue = Format(mvDate_CreateDate, "MM/dd/yyyy").ToString
            End If
            Try
                'mvDate_KeyValue = Convert.ToDateTime(mvStr_KeyValue)
                mvDate_KeyValue = Date.ParseExact(mvStr_KeyValue, "MM/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture)
            Catch ex As Exception
                'Registry bsị thay đổi
                If gvByte_Language = 1 Then
                    FunG_Alert("Lỗi", "Phần mềm đang dùng không hợp lệ!" & Chr(13) & "Vui lòng liên hệ với Lê Vũ ePos!", frm_Alert.WTYPE.ERROR)
                Else
                    FunG_Alert("Error", "Software being used is not valid!" & Chr(13) & "Please contact Le Vu EPOS!", frm_Alert.WTYPE.ERROR)
                End If
                SubG_DeleteKey(mvStr_Path, mvStr_NameKey)
                End
            End Try
            Dim mvInt_RemainDays As Integer = FuncG_CheckDays(mvDate_CreateDate, mvDate_KeyValue)
            If mvInt_RemainDays < 0 Or mvInt_RemainDays > 30 Then
                'FunG_Alert("Thông báo", "Phần mềm đã hết hạn dùng thử!", frm_Alert.WTYPE.STOP)
                'frm_License.mvBol_Flag = True
                'frm_License.ShowDialog()
            Else
                frm_MainMenu.lblRegistry.Caption = String.Format(frm_MainMenu.lblRegistry.Caption, 30 - mvInt_RemainDays)
                frm_MainMenu.lblRegistry.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                frm_MainMenu.lblTrial.Caption = "Phiên bản dùng thử"
                frm_MainMenu.bbiDangKy.Enabled = True
            End If
        Else
            'Nếu đã đăng ký
            frm_MainMenu.lblRegistry.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            frm_MainMenu.lblTrial.Caption = "Phiên bản chính thức"
            frm_MainMenu.bbiDangKy.Enabled = False
        End If
    End Sub
#End Region
#Region "Tạo và Gán Giá Trị cho REG_SZ"
    Public Sub SubG_SetValuesKey(ByVal iStr_Path As String, ByVal iStr_NameKey As String, ByVal iStr_Value As String)
        Dim wReg As RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey(iStr_Path, True)
        wReg.SetValue(iStr_NameKey, iStr_Value)
    End Sub
#End Region
#Region "Đọc REG Lấy Giá Trị"
    Public Function FuncG_GetValuesKey(ByVal iStr_Path As String, ByVal iStr_NameKey As String) As String
        Try
            Dim wReg As String
            wReg = My.Computer.Registry.LocalMachine.OpenSubKey(iStr_Path).GetValue(iStr_NameKey)
            Return wReg
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
#Region "Xoá Key REG_SZ"
    Public Sub SubG_DeleteKey(ByVal iStr_Path As String, ByVal iStr_NameKey As String)
        Try
            Dim wReg As RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey(iStr_Path, True)
            wReg.DeleteValue(iStr_NameKey)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Hàm kiểm tra"
    Private Function FuncG_CheckDays(ByVal iDate_CreateDate As Date, ByVal iDate_KeyVal As Date) As Integer
        Dim mvInt_Result As Integer = -1
        Dim mvTsp_TimeSpan1 As New TimeSpan
        Dim mvTsp_TimeSpan2 As New TimeSpan
        Try
            mvTsp_TimeSpan1 = Today - iDate_CreateDate.Date
            mvTsp_TimeSpan2 = Today - iDate_KeyVal.Date
            If mvTsp_TimeSpan1.Days < 0 Or mvTsp_TimeSpan2.Days < 0 Or mvTsp_TimeSpan1.Days > 30 Or mvTsp_TimeSpan2.Days > 30 Then
                mvInt_Result = -1
            Else
                If mvTsp_TimeSpan1.Days <> mvTsp_TimeSpan2.Days Then
                    'Có hiện tượng chỉnh sửa file hay registry
                    mvInt_Result = -1
                Else
                    mvInt_Result = mvTsp_TimeSpan1.Days
                End If

            End If
        Catch ex As Exception
            mvInt_Result = -1
        End Try
        Return mvInt_Result
    End Function

    Private Sub PanelControl1_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl1.Paint

    End Sub
#End Region
End Class
