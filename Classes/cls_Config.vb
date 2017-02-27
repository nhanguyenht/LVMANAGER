Imports System.IO
Public Class cls_Config
    Inherits cls_Database_Base
#Region "Cập nhật lại file Server.ini"
    '    '#---------------------------------------------------------------------
    '    '# MethodName       :       FuncG_WrittenServerini
    '    '# Description      :       Tạo lại file Server.ini
    '    '# ReturnValue      :       Boolean
    '    '# Author           :       Love@ngel Hoàng Nguyên
    '    '# CreateDate       :       2009-07-25
    '    '# LastUpdate       :       2009-07-25
    '    '#---------------------------------------------------------------------
    Public Function FuncG_WrittenServerini(ByVal mvStr_Server As String, ByVal mvStr_Database As String, ByVal mvStr_User As String, ByVal mvStr_Pass As String) As Boolean
        Try
            If FuncM_OpenConnection() Then
                If Not File.Exists(Application.StartupPath + "\Server.ini") Then
                    Dim mvIO_FileStream As New FileStream(Application.StartupPath + "\Server.ini", FileMode.Create)
                    mvIO_FileStream.Close()
                    mvIO_FileStream.Dispose()
                End If
                Dim mvIO_Writter As New StreamWriter(Application.StartupPath + "\Server.ini")
                mvIO_Writter.WriteLine(mvStr_Server)
                mvIO_Writter.WriteLine(mvStr_Database)
                mvIO_Writter.WriteLine(mvStr_User)
                mvIO_Writter.WriteLine(mvStr_Pass)
                mvIO_Writter.WriteLine(1)   'Ngôn ngữ
                mvIO_Writter.WriteLine("01") 'Vị trí máy
                mvIO_Writter.Close()
                mvIO_Writter.Dispose()
                FuncM_CloseConnection()
                Return True
            Else
                SubG_Alert(63) ' FunG_Alert("Thông báo", "Kết nối cơ sở dữ liệu không thành công!", frm_Alert.WTYPE.ERROR)
                Return False
            End If
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Function
#End Region
#Region "Xử lí Nút"
    '    '#---------------------------------------------------------------------
    '    '# MethodName       :       SubG_FormatButton
    '    '# Description      :       Kiểm tra trạng thái textbox để enable nút lệnh
    '    '# ReturnValue      :       Nothing
    '    '# Author           :       Love@ngel Hoàng Nguyên
    '    '# CreateDate       :       2009-07-25
    '    '# LastUpdate       :       2009-07-25
    '    '#---------------------------------------------------------------------
    Public Sub SubG_FormatButton(ByVal txtServer As DevExpress.XtraEditors.TextEdit, ByVal txtDatabase As DevExpress.XtraEditors.TextEdit, ByVal txtUser As DevExpress.XtraEditors.TextEdit, ByVal cmdConn As DevExpress.XtraEditors.SimpleButton)
        If txtServer.Text.Trim <> "" And txtDatabase.Text.Trim <> "" And txtUser.Text.Trim <> "" Then
            cmdConn.Enabled = True
        Else
            cmdConn.Enabled = False
        End If
    End Sub
#End Region
End Class
