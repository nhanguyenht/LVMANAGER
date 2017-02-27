Public Class cls_Account_Update
    Inherits cls_Database_Base
#Region "Kiểm tra Thông tin Account"
    '#-----------------------------------------------------------------------
    '# MethodName       :       FuncG_GetLoginInfo
    '# Description      :       This method gets info account which log in ERP System
    '# Parameter        :       UserName, Password
    '# ReturnValue      :       cls_ERP_Account_Base
    '# Author           :       THI
    '# CreateDate       :       2008-06-19
    '# LastUpdate       :       2008-09-11
    '#-----------------------------------------------------------------------
    Public Function FuncG_GetLoginInfo(ByVal iStr_UserName As String, ByVal iStr_Password As String) As cls_Account
        Dim wDataTable As New DataTable
        Dim wDataTable1 As New DataTable
        Dim wcls_Account As cls_Account = Nothing
        Try
            If (FuncM_OpenConnection()) Then
                Dim wStr_SQL As String = ""
                wStr_SQL = "SELECT TOP 1 * FROM TBL_ACCOUNT WHERE LOC_ID = @iNVChr_LOCID AND USERNAME = @iNVChr_USERNAME AND PASSWORD = @iNVChr_PASSWORD"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_USERNAME", iStr_UserName, SqlDbType.NVarChar, 32)
                SubM_AddParameter("@iNVChr_PASSWORD", iStr_Password, SqlDbType.NVarChar, 32)
                wDataTable = FuncM_GetDataTable(wStr_SQL)
                If (wDataTable.Rows.Count > 0) Then
                    wcls_Account = New cls_Account
                    wcls_Account.UserName = iStr_UserName
                    gvStr_AccUser = iStr_UserName
                    wcls_Account.Password = iStr_Password
                    wcls_Account.Permit = mod_Common.FuncG_DBNullToString(wDataTable.Rows(0)("LEVELMG"))
                    wcls_Account.Employee = mod_Common.FuncG_DBNullToString(wDataTable.Rows(0)("NAME"))
                    wcls_Account.Status = mod_Common.FuncG_DBNullToString(wDataTable.Rows(0)("STATUS"))
                    gvStr_EmployeeName = wcls_Account.Employee
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return wcls_Account
    End Function
#End Region
#Region "Get data"
    Public Function FuncG_GetData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT USERNAME, NAME ,PASSWORD, LEVEL, STATUS"
                mvStr_Sql += "  FROM TBL_ACCOUNT WHERE LOC_ID = @iNVChr_LOCID and USERNAME<>'PHANMEM'"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetDataMG() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT USERNAME, NAME ,PASSWORD, LEVELMG, STATUS"
                mvStr_Sql += "  FROM TBL_ACCOUNT WHERE LOC_ID = @iNVChr_LOCID and USERNAME<>'PHANMEM'"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetCashierData() As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT USERNAME AS [Mã Nhân Viên], NAME AS [Tên Nhân Viên]"
                mvStr_Sql += "  FROM TBL_ACCOUNT WHERE LOC_ID = @iNVChr_LOCID"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetData(ByVal iStr_MANHANVIEN As String) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TOP 1 * FROM TBL_ACCOUNT WHERE USERNAME = @iNVchr_MANHANVIEN "
                SubM_AddParameter("@iNVchr_MANHANVIEN", iStr_MANHANVIEN)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
#End Region
#Region "Insert - Update - Delete " 'Status = 0 : Insert, Status = 1 : Update, Status = 2 : Delete, Status = 3 : Update có đổi pass
    Public Function FuncG_InsertUpdateDelete(ByVal iCls_Account As cls_Account) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_USERNAME", iCls_Account.UserName)
                SubM_AddParameter("@iNVChr_PASSWORD", iCls_Account.Password)
                SubM_AddParameter("@iNVChr_LEVEL", iCls_Account.Permit)
                SubM_AddParameter("@iNVChr_NAME", iCls_Account.Employee)
                SubM_AddParameter("@iTInt_STATUS", iCls_Account.Status)
                If FuncM_ExecuteStore("usp_Account") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function
    Public Function FuncG_InsertUpdateDeleteMG(ByVal iCls_Account As cls_Account) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_USERNAME", iCls_Account.UserName)
                SubM_AddParameter("@iNVChr_PASSWORD", iCls_Account.Password)
                SubM_AddParameter("@iNVChr_LEVEL", iCls_Account.Permit)
                SubM_AddParameter("@iNVChr_NAME", iCls_Account.Employee)
                SubM_AddParameter("@iTInt_STATUS", iCls_Account.Status)
                If FuncM_ExecuteStore("usp_AccountMG") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function
#End Region
#Region "Đổi Password"
    Public Function FuncG_DoiPassWord(ByVal iStr_TAIKHOAN As String, ByVal iStr_MATKHAUCU As String, ByVal iStr_MATKHAUMOI As String) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iVChr_USERNAME", iStr_TAIKHOAN)
                SubM_AddParameter("@iVChr_OLDPASSWORD", iStr_MATKHAUCU)
                SubM_AddParameter("@iVChr_NEWPASSWORD", iStr_MATKHAUMOI)
                If FuncM_ExecuteStore("usp_ChangePassword") Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function
#End Region
#Region "Xóa DL"
    Public Function FuncG_Delete(ByVal iDate_ToDay As Date) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iFromDay", iDate_ToDay)
                If FuncM_ExecuteStore("usp_DeleteDB") Then
                    Return True
                Else
                    Return False
                    End
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function
    Public Function FuncG_Delete(ByVal iDate_FromDay As Date, ByVal iDate_ToDay As Date) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iFromDay", iDate_FromDay)
                SubM_AddParameter("@iToDay", iDate_ToDay)
                If FuncM_ExecuteStore("usp_DeleteDB") Then
                    Return True
                Else
                    Return False
                    End
                End If
            End If
        Catch ex As Exception
            Throw ex
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function
#End Region
End Class
