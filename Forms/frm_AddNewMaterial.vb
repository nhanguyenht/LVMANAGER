Public Class frm_AddNewMaterial
#Region "Khai báo biến"
    Dim mvCls_Item As New cls_Item
    Dim mvCls_ItemUpdate As New cls_Item_Update
    Dim mvStr_ID As String
    Public mvBol_Edit As Boolean
#End Region
#Region "Hàm khởi tạo"
    Private Sub SubM_InitializeForm()
        Try
            If Not mvBol_Edit Then
                mvStr_ID = mvCls_ItemUpdate.FuncG_GetMaxMaterial
                Me.txtID.Text = mvStr_ID
            End If
        Catch ex As Exception

        End Try
        If gvByte_Language = 1 Then

        End If
    End Sub
#End Region
#Region "Form events"
    Private Sub frm_AddNewMaterial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SubM_InitializeForm()
    End Sub
#End Region
#Region "Nút Exit"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
#End Region
#Region "Nút Confirm"
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        Try
            If String.IsNullOrEmpty(Me.txtName.Text) Then
                SubG_Alert(69)
                'FunG_Alert("Annonce", "Vui lòng nhập tên nguyên liệu!", frm_Alert.WTYPE.ERROR)
            ElseIf String.IsNullOrEmpty(Me.txtUnit.Text) Then
                SubG_Alert(70)
                'FunG_Alert("Annonce", "Vui lòng nhập đơn vị nguyên liệu!", frm_Alert.WTYPE.ERROR)
            Else
                mvCls_Item.ID = Me.txtID.Text
                mvCls_Item.Name = Me.txtName.Text
                mvCls_Item.Unit = Me.txtUnit.Text
                If mvBol_Edit Then
                    'Edit
                    mvCls_Item.Status = 1
                Else
                    'Insert
                    mvCls_Item.Status = 0
                End If
                mvCls_ItemUpdate.FuncG_Material(mvCls_Item)
                frm_Promat.SubM_LoadDataIntoGrid()
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class