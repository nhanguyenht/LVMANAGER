Public Class cls_Customer_Update
    Inherits cls_Database_Base
#Region "Get Data"
    '1 : Khách hàng , 2 : Nhân viên
    Public Function FuncG_GetAllData(ByVal iByte_Type As Byte) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT * FROM [TBL_CUSTOMER_EMPLOYEE] WHERE LOC_ID = @iNVChr_LOCID AND TYPE = @iTInt_TYPE ORDER BY [NAME]"
                'mvStr_Sql = "SELECT ID, NAME, ADDRESS, TEL, EMAIL FROM [TBL_CUSTOMER_EMPLOYEE] WHERE LOC_ID = @iNVChr_LOCID AND TYPE = @iTInt_TYPE ORDER BY [NAME]"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iTInt_TYPE", iByte_Type)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetAll(ByVal iByte_Type As Byte) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID AS [Mã], NAME AS [Tên], ADDRESS AS [Địa chỉ], TEL AS [Điện thoại], Email FROM [TBL_CUSTOMER_EMPLOYEE] WHERE LOC_ID = @iNVChr_LOCID AND TYPE = @iTInt_TYPE ORDER BY [ID]"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iTInt_TYPE", iByte_Type)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetAll2(ByVal iByte_Type As Byte) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID , NAME , ADDRESS , TEL , Email FROM [TBL_CUSTOMER_EMPLOYEE] WHERE LOC_ID = @iNVChr_LOCID AND TYPE = @iTInt_TYPE ORDER BY [ID]"
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iTInt_TYPE", iByte_Type)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetAllData(ByVal iCls_Customer As cls_Customer) As DataTable
        Dim mvDataTale As New DataTable
        Dim mvStr_Sql As String = ""
        Try
            If FuncM_OpenConnection() Then
                mvStr_Sql = "SELECT ID, NAME, ADDRESS, TEL, EMAIL FROM [TBL_CUSTOMER_EMPLOYEE] WHERE LOC_ID = @iNVChr_LOCID AND TYPE = @iTInt_TYPE"
                If iCls_Customer.ID <> "" Then
                    mvStr_Sql += "  AND ID = @iNVChr_ID"
                    SubM_AddParameter("@iNVChr_ID", iCls_Customer.ID)
                End If
                If iCls_Customer.Name <> "" Then
                    mvStr_Sql += "  AND NAME LIKE '%' + @iNVChr_NAME + '%'"
                    SubM_AddParameter("@iNVChr_NAME", iCls_Customer.Name)
                End If
                If iCls_Customer.Address <> "" Then
                    mvStr_Sql += "  AND ADDRESS LIKE '%' + @iNVChr_ADDRESS + '%'"
                    SubM_AddParameter("@iNVChr_ADDRESS", iCls_Customer.Address)
                End If
                If iCls_Customer.Tel <> "" Then
                    mvStr_Sql += "  AND TEL LIKE '%' + @iNVChr_TEL + '%'"
                    SubM_AddParameter("@iNVChr_TEL", iCls_Customer.Tel)
                End If
                If iCls_Customer.Email <> "" Then
                    mvStr_Sql += "  AND EMAIL LIKE '%' + @iNVChr_EMAIL + '%'"
                    SubM_AddParameter("@iNVChr_EMAIL", iCls_Customer.Email)
                End If
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iTInt_TYPE", iCls_Customer.Type)
                mvDataTale = FuncM_GetDataTable(mvStr_Sql)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            FuncM_CloseConnection()
        End Try
        Return mvDataTale
    End Function
    Public Function FuncG_GetCustomerSalesByID(ByVal id As String) As Boolean
        Const query As String = "select CE.ID ,CE.NAME  from TBL_CUSTOMER_EMPLOYEE CE JOIN TBL_SALES S ON CE.ID = S.CUSTOMER_ID WHERE CE.ID=@ID GROUP BY CE.ID , CE.NAME "
        Dim DT As New DataTable
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@id", id)
                DT = FuncM_GetDataTable(query)
                If DT.Rows.Count > 0 Then
                    Return False
                Else
                    Return True
                End If
            End If
        Catch ex As Exception
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function
    Public Function FuncG_GetNCCSalesByID(ByVal id As String) As Boolean
        Const query As String = "select CE.ID ,CE.NAME,sum(d.REMAIN) as remain   from TBL_CUSTOMER_EMPLOYEE CE JOIN TBL_DEPTS d ON CE.ID = d.CUSTOMER WHERE CE.ID=@ID group  by CE.ID ,CE.NAME "
        Dim DT As New DataTable
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@id", id)
                DT = FuncM_GetDataTable(query)
                If DT.Rows.Count > 0 Then
                    Return False
                Else
                    Return True
                End If
            End If
        Catch ex As Exception
            Return False
        Finally
            FuncM_CloseConnection()
        End Try
    End Function
    Public Function FuncG_GetNCCSalesByID2(ByVal id As String) As DataTable
        Const query As String = "select CE.ID ,CE.NAME  from TBL_CUSTOMER_EMPLOYEE CE JOIN TBL_SALES S ON CE.ID = S.CUSTOMER_ID WHERE CE.ID=@ID GROUP BY CE.ID , CE.NAME "
        Dim DT As New DataTable
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@id", id)
                DT = FuncM_GetDataTable(query)
                Return DT
            End If
        Catch ex As Exception

        Finally
            FuncM_CloseConnection()
        End Try
    End Function
#End Region
#Region "Insert - Update"
    Public Function FuncG_InsertUpdate(ByVal iCls_Customer As cls_Customer) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Customer.ID)
                SubM_AddParameter("@iNVChr_NAME", iCls_Customer.Name)
                SubM_AddParameter("@iNVChr_ADDRESS", iCls_Customer.Address)
                SubM_AddParameter("@iNVChr_TEL", iCls_Customer.Tel)
                SubM_AddParameter("@iBit_Add", 0)
                SubM_AddParameter("@iTInt_TYPE", iCls_Customer.Type)
                SubM_AddParameter("@Mathegiamgia", iCls_Customer.Mathegiamgia)
                SubM_AddParameter("@Phantram", iCls_Customer.Phantram)
                SubM_AddParameter("@Note", iCls_Customer.Note)
                SubM_AddParameter("@Mail", iCls_Customer.Email)
                SubM_AddParameter("@Loaithe", iCls_Customer.Loaithe)
                SubM_AddParameter("@Soluonggiam", iCls_Customer.Soluonggiam)
                If FuncM_ExecuteStore("usp_Customer_Employee") Then
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
    'EDIT 2013/12/18 by Van Long
    Public Function FuncG_InsertUpdate_Customer_Employee(ByVal iCls_Customer As cls_Customer, ByVal _isAdd As Int16) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Customer.ID)
                SubM_AddParameter("@iNVChr_NAME", iCls_Customer.Name)
                SubM_AddParameter("@iNVChr_ADDRESS", iCls_Customer.Address)
                SubM_AddParameter("@iNVChr_TEL", iCls_Customer.Tel)
                SubM_AddParameter("@iBit_Add", _isAdd)
                SubM_AddParameter("@iTInt_TYPE", iCls_Customer.Type)

                SubM_AddParameter("@Mathegiamgia", iCls_Customer.Mathegiamgia)
                SubM_AddParameter("@Phantram", iCls_Customer.Phantram)
                SubM_AddParameter("@Note", iCls_Customer.Note)
                SubM_AddParameter("@Mail", iCls_Customer.Email)
                SubM_AddParameter("@Loaithe", iCls_Customer.Loaithe)
                SubM_AddParameter("@Soluonggiam", iCls_Customer.Soluonggiam)
                If FuncM_ExecuteStore("usp_InsertOrUpdate_Employee") Then
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

    Public Function FuncG_Delete_Customer(ByVal iCls_Customer As cls_Customer) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Customer.ID)

                If FuncM_ExecuteStore("usp_Delete_Customer") Then
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
    

    Public Function FuncG_Delete_Employee(ByVal iCls_Customer As cls_Customer) As Boolean
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@iNVChr_LOCID", gvStr_LocID)
                SubM_AddParameter("@iNVChr_ID", iCls_Customer.ID)

                If FuncM_ExecuteStore("usp_Delete_Employee") Then
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
End Class
