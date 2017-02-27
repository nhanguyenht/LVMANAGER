Public Class cls_Dept_Update
    Inherits cls_Database_Base
#Region "Get Data"
    Public Function FuncG_GetAllData(ByVal iInt_Type As Integer) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT TBL_DEPTS.INVOICE_ID, TBL_DEPTS.CREATEDATE, TBL_DEPTS.CUSTOMER, TBL_CUSTOMER_EMPLOYEE.NAME,"
                mvStr_Sql += "  TBL_DEPTS.DEPT, TBL_DEPTS.ISPAID, TBL_DEPTS.REMAIN"
                mvStr_Sql += "  FROM TBL_DEPTS INNER JOIN TBL_CUSTOMER_EMPLOYEE ON TBL_DEPTS.LOC_ID = TBL_CUSTOMER_EMPLOYEE.LOC_ID AND"
                mvStr_Sql += "  TBL_DEPTS.CUSTOMER = TBL_CUSTOMER_EMPLOYEE.ID"
                mvStr_Sql += "  WHERE (TBL_DEPTS.LOC_ID = @iNVChr_LOCID) AND (TBL_DEPTS.REMAIN > 0) AND (TBL_DEPTS.TYPE = @iTInt_TYPE)"
                mvStr_Sql += "  ORDER BY TBL_DEPTS.CREATEDATE"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iTInt_TYPE", iInt_Type)
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
#Region "Check"
    Public Function FuncG_CheckAlreadyDept(ByVal iStr_Invoice As String) As Boolean
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Dim mvBol_Flag As Boolean = False
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM TBL_DEPTS WHERE TBL_DEPTS.LOC_ID = @iNVChr_LOCID AND INVOICE_ID = @iNVChr_INVOICE"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_INVOICE", iStr_Invoice)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
                If mvDataTale.Rows.Count = 0 Then
                    mvBol_Flag = True
                Else
                    If mvDataTale.Rows(0)("ISPAID") > 0 Then
                        mvBol_Flag = True
                    Else
                        mvBol_Flag = False
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvBol_Flag
    End Function
#End Region
#Region "Update"
    Public Function FuncG_Update(ByVal iCls_Dept As cls_Depts) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_INVOICE", iCls_Dept.InvoiceID)
                SubM_AddParameter("@iNVChr_USER", gvStr_AccUser)
                SubM_AddParameter("@iFlt_DEPT", iCls_Dept.Dept)
                If FuncM_ExecuteStore("usp_UpdateDepts") Then
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
#Region "Insert"
    Public Function FuncG_Insert(ByVal iCls_Dept As cls_Depts) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_INVOICE", iCls_Dept.InvoiceID)
                SubM_AddParameter("@iNVChr_USER", gvStr_AccUser)
                SubM_AddParameter("@iNVChr_CUSTOMER", iCls_Dept.CustomerID)
                SubM_AddParameter("@iFlt_DEPT", iCls_Dept.Dept)
                SubM_AddParameter("@iTInt_TYPE", iCls_Dept.Type)
                If FuncM_ExecuteStore("usp_Depts") Then
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
End Class
