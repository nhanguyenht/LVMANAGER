'#---------------------------------------------------------------------------
'# ModuleName       :       mod_Common
'# Description      :       This module contains base operations on form
'# Author           :       THI
'# CreateDate       :       2008-06-18
'# LastUpdate       :       2008-06-18
'#---------------------------------------------------------------------------
Module mod_Common
#Region "Khai Báo Biến"
    Dim mvCls_CompanyUpdate As New cls_CompanyInfo_Update
#End Region
#Region "Common functions"
    '#-----------------------------------------------------------------------
    '# MethodName       :       FuncG_DBNullToString
    '# Description      :       This method changes nullvalue by spacevalue
    '# Parameter        :       A nullvalue
    '# ReturnValue      :       ""
    '# Author           :       THI
    '# CreateDate       :       2008-06-18
    '# LastUpdate       :       2008-06-18
    '#-----------------------------------------------------------------------
    Public Function FuncG_DBNullToString(ByVal iObj_Value As Object) As String
        If (iObj_Value Is DBNull.Value) Then
            Return ""
        Else
            Return iObj_Value.ToString
        End If
    End Function
#End Region
#Region "Hiển thị hộp thông báo"
    '#-----------------------------------------------------------------------
    '# MethodName       :       FunG_Alert
    '# Description      :       This method open diaglog with message
    '# Parameter        :       A nullvalue
    '# ReturnValue      :       ""
    '# Author           :       THI
    '# CreateDate       :       2008-06-18
    '# LastUpdate       :       2008-06-18
    '#-----------------------------------------------------------------------
    ''' <summary>
    ''' Hiển thị hộp thông báo
    ''' </summary>
    ''' <param name="title">Tile cửa sổ</param>
    ''' <param name="msg">Thông điệp thông báo</param>
    ''' <param name="wType">kiểu hộp thoại: 1 = alert, 2 = stop</param> 
    Public Function FunG_Alert(ByVal title As [String], ByVal msg As [String], ByVal wType As frm_Alert.WTYPE) As frm_Alert.WRESULT
        Dim frm As New frm_Alert()
        frm.setParam(title, msg, wType)
        frm.ShowDialog()
        Return frm.result
    End Function
#End Region
#Region "Lấy thông tin công ty"
    Public Sub SubM_GetCompanyInfo()
        Dim mvObj_DataTable As New DataTable
        Try
            mvObj_DataTable = mvCls_CompanyUpdate.FuncG_LayThongTin
            If mvObj_DataTable.Rows.Count <> 0 Then
                gvCls_Company.Name = mvObj_DataTable.Rows(0)("COMPANYNAME")
                gvCls_Company.Address = mvObj_DataTable.Rows(0)("ADDRESS")
                gvCls_Company.Phone = mvObj_DataTable.Rows(0)("PHONE")
                gvCls_Company.Fax = mvObj_DataTable.Rows(0)("FAX")
                gvCls_Company.Tax = mvObj_DataTable.Rows(0)("TAX")
                gvCls_Company.Email = mvObj_DataTable.Rows(0)("EMAIL")
                gvCls_Company.ContactPerson = mvObj_DataTable.Rows(0)("CONTACTPERSON")
            Else
                If gvByte_Language = 1 Then
                    FunG_Alert("Cảnh báo", "Thông tin công ty không tìm thấy!" & Chr(13) & "Vui lòng liên hệ với người quản lý!", frm_Alert.WTYPE.ERROR)
                Else
                    FunG_Alert("Warning", "Company Information not found!" & Chr(13) & "Please contact the manager!", frm_Alert.WTYPE.ERROR)
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Check table status"
    Public Function FuncG_CheckStatus(ByVal iStr_TableID As String) As Byte
        Dim mvCls_TableUpdate As New cls_Table_Update
        Dim mvObj_DataTable As New DataTable
        Try
            'Kiểm tra trạng thái của bàn
            mvObj_DataTable = mvCls_TableUpdate.FuncG_GetDataInfo(iStr_TableID)
            If mvObj_DataTable.Rows.Count <> 0 Then
                Return mvObj_DataTable.Rows(0)("STATUS")
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region
End Module
