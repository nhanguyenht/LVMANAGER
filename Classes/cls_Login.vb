Imports System.IO
Public Class cls_Login
#Region "Sub Lấy Thông Tin Server từ file"
    '    '#---------------------------------------------------------------------
    '    '# MethodName       :       SubM_Reader
    '    '# Description      :       Đọc file Server
    '    '# ReturnValue      :       Nothing
    '    '# Author           :       Love@ngel Hoàng Nguyên
    '    '# CreateDate       :       2009-07-25
    '    '# LastUpdate       :       2009-07-25
    '    '#---------------------------------------------------------------------
    Public Sub SubM_Reader()
        Try
            If (File.Exists(Application.StartupPath + "\Server.ini")) Then
                Dim mvIO_Reader As New StreamReader(Application.StartupPath + "\Server.ini")
                gvStr_Server = mvIO_Reader.ReadLine
                gvStr_Database = mvIO_Reader.ReadLine
                gvStr_User = mvIO_Reader.ReadLine
                gvStr_Pass = mvIO_Reader.ReadLine
                gvByte_Language = mvIO_Reader.ReadLine
                gvStr_LocID = mvIO_Reader.ReadLine
                mvIO_Reader.Close()
                mvIO_Reader.Dispose()
                If gvByte_Language = 1 Then
                    gvByte_Digit = 0
                Else
                    gvByte_Digit = 2
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#Region "Xử lí Nút"
    Public Sub SubG_FormatButton(ByVal txtUser As DevExpress.XtraEditors.TextEdit, ByVal txtPass As DevExpress.XtraEditors.TextEdit, ByVal cmdConn As DevExpress.XtraEditors.SimpleButton)
        If txtUser.Text.Trim <> "" Then
            cmdConn.Enabled = True
        Else
            cmdConn.Enabled = False
        End If
    End Sub
#End Region
End Class
