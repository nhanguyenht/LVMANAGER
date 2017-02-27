Public Class frm_EditTable 
    Dim mvCls_Table As New cls_Table
    Dim mvCls_Table_Update As New cls_Table_Update


 

    Private Sub frm_EditTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gvByte_Language = 1 Then
            Me.Text = "CHỈNH SỬA THÔNG TIN BÀN"
            gpcHeader.Text = "THÔNG TIN BÀN"
            LabelControl1.Text = "Mã bàn"
            lblItem.Text = "Tên bàn"
            cmdApply.Text = "Cập nhật"
            cmdExit.Text = "Thoát"
            rgpLanguage.Properties.Items.Item(0).Description = "Tắt"
            rgpLanguage.Properties.Items.Item(1).Description = "Mở"
        Else
            rgpLanguage.Properties.Items.Item(0).Description = "Turn off"
            rgpLanguage.Properties.Items.Item(1).Description = "Turn on"
            Me.Text = "EDIT TABLE"
            gpcHeader.Text = "TABLE INFORMATION"
            LabelControl1.Text = "Table ID"
            lblItem.Text = "Table Name"
            cmdApply.Text = "Update"
            cmdExit.Text = "Exit"
        End If
    End Sub

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        If txtID.Text = "" Then
            SubG_Alert(17)
        Else
            mvCls_Table.ID = Me.txtID.Text
            mvCls_Table.Name = Me.txtName.Text
            mvCls_Table.Status = rgpLanguage.SelectedIndex
            mvCls_Table_Update.FuncG_InsertUpdateDelete(mvCls_Table)
            Me.Close()
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class