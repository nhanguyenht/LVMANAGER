Public Class cls_HistoryEditBill_Update
    Inherits cls_Database_Base
#Region "GET"

#End Region
#Region "EDIT"
    Public Sub INSERT(ByVal iCls_HistoryEditBill As cls_HistoryEditBill)
        Dim query As String = "INSERT INTO TBL_HISTORYEDITBILL(INVOICE_ID,CREATEDATE,USERNAME,DESCRIPTION) VALUES (@INVOICE_ID,@CREATEDATE,@USERNAME,@DESCRIPTION)"
        Try
            If FuncM_OpenConnection() Then
                SubM_AddParameter("@INVOICE_ID", iCls_HistoryEditBill.INVOICE_ID)
                SubM_AddParameter("@CREATEDATE", iCls_HistoryEditBill.CREATEDATE)
                SubM_AddParameter("@USERNAME", iCls_HistoryEditBill.UserName)
                SubM_AddParameter("@DESCRIPTION", iCls_HistoryEditBill.DESCRIPTION)
                FuncM_ExecuteNonQuery(query)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
