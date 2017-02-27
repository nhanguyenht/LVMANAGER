Public Class frm_Item_Ex 

    Dim mvCls_ItemUpdate As New cls_Item_Update
    Public mvCls_SalesDetail As New cls_SalesDetail
    Dim mvCls_SalesDetailUpdate As New cls_SalesDetail_Update

    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        frm_SetMenu.Show()
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDown1.Click
        Try
            If Me.GridView1.GetFocusedDataSourceRowIndex <> Me.GridView1.RowCount - 1 Then
                Me.GridView1.FocusedRowHandle = Me.GridView1.GetFocusedDataSourceRowIndex + 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp1.Click
        Try
            If Me.GridView1.GetFocusedDataSourceRowIndex <> 0 Then
                Me.GridView1.FocusedRowHandle = Me.GridView1.GetFocusedDataSourceRowIndex - 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDown2.Click

        Try
            If Me.GridView2.GetFocusedDataSourceRowIndex <> Me.GridView2.RowCount - 1 Then
                Me.GridView2.FocusedRowHandle = Me.GridView2.GetFocusedDataSourceRowIndex + 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp2.Click
        Try
            If Me.GridView2.GetFocusedDataSourceRowIndex <> 0 Then
                Me.GridView2.FocusedRowHandle = Me.GridView2.GetFocusedDataSourceRowIndex - 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtQuantity_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumber.Leave
        Try
            Me.txtNumber.Text = (Double.Parse(Me.txtNumber.Text)).ToString("N2")
        Catch ex As Exception
            Me.txtNumber.Text = "1"
        End Try
    End Sub

    Private Sub cmdRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRight.Click
        Try
            Dim item1_ID As String = Me.txtItem.Tag
            Dim item2_ID As String = Me.GridView1.GetFocusedDataRow("ID")
            Dim number As Double = Me.txtNumber.Text

            If number > 0 Then
                mvCls_ItemUpdate.FuncG_InsertOrUpdate_Item_Item(item1_ID, item2_ID, number)
                Me.GridControl2.DataSource = mvCls_ItemUpdate.FuncG_GetAllData_Item_Item(item1_ID)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLeft.Click
        Try
            Dim item1_ID As String = Me.txtItem.Tag
            Dim item2_ID As String = Me.GridView2.GetFocusedDataRow("ID")
            If gvByte_Language = 1 Then
                If FunG_Alert("Xác nhận", "Bạn có chắc chắn muốn bỏ món phụ đang chọn không?", frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                    mvCls_ItemUpdate.FuncG_Delete_Item_Item(item1_ID, item2_ID)
                    Me.GridControl2.DataSource = mvCls_ItemUpdate.FuncG_GetAllData_Item_Item(item1_ID)
                End If
            Else
                If FunG_Alert("Confirm", "Are you sure you want to remove the selected side dishes do not?", frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                    mvCls_ItemUpdate.FuncG_Delete_Item_Item(item1_ID, item2_ID)
                    Me.GridControl2.DataSource = mvCls_ItemUpdate.FuncG_GetAllData_Item_Item(item1_ID)
                End If
            End If
           
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAllLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAllLeft.Click
        Try
            Dim item1_ID As String = Me.txtItem.Tag
            Dim item2_ID As String = Me.GridView2.GetFocusedDataRow("ID")
            If gvByte_Language = 1 Then
                If FunG_Alert("Xác nhận", "Bạn có chắc chắn muốn bỏ tất cả các món phụ không?", frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                    mvCls_ItemUpdate.FuncG_DeleteAll_Item_Item(item1_ID)

                    Me.GridControl2.DataSource = mvCls_ItemUpdate.FuncG_GetAllData_Item_Item(item1_ID)
                End If
            Else
                If FunG_Alert("Confirm", "Are you sure you want to remove all side dishes?", frm_Alert.WTYPE.YESNO) = frm_Alert.WRESULT.YES Then
                    mvCls_ItemUpdate.FuncG_DeleteAll_Item_Item(item1_ID)

                    Me.GridControl2.DataSource = mvCls_ItemUpdate.FuncG_GetAllData_Item_Item(item1_ID)
                End If
            End If
            
        Catch ex As Exception

        End Try
    End Sub
End Class