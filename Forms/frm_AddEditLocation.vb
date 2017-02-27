Public Class frm_AddEditLocation
#Region "Khai báo biến"
    Dim mvStr_ID As String
    Public mvBol_Edit As Boolean
    Dim mvCls_Loctions As New cls_Location
#End Region
#Region "Hàm khởi tạo"
    Private Sub SubM_InitializeForm()
        Try
            If mvBol_Edit Then
                Me.txtID.Properties.ReadOnly = True
            Else
                Me.txtID.Properties.ReadOnly = False
            End If
        Catch ex As Exception

        End Try
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
        Dim mvBol_Flag As Boolean = False
        Dim mvInt_Index As Integer
        Try
            If String.IsNullOrEmpty(Me.txtID.Text) Then
                SubG_Alert(65)
                'FunG_Alert("Annonce", "Vui lòng nhập ID khu vực!", frm_Alert.WTYPE.ERROR)
            ElseIf String.IsNullOrEmpty(Me.txtIPAddress.Text) Then
                SubG_Alert(66)
                'FunG_Alert("Annonce", "Vui lòng nhập IP khu vực", frm_Alert.WTYPE.ERROR)
            ElseIf String.IsNullOrEmpty(Me.txtUser.Text) Then
                SubG_Alert(67)
                'FunG_Alert("Annonce", "Vui lòng nhập tên người dùng", frm_Alert.WTYPE.ERROR)
            Else
                mvCls_Loctions.ID = Me.txtID.Text.Trim
                mvCls_Loctions.Name = Me.txtName.Text
                mvCls_Loctions.Address = Me.txtAddress.Text
                mvCls_Loctions.IPAddress = Me.txtIPAddress.Text.Trim
                mvCls_Loctions.UserName = Me.txtUser.Text.Trim
                mvCls_Loctions.Password = Me.txtPassword.Text.Trim
                If mvBol_Edit Then
                    'Edit
                    For mvInt_Index = 0 To frm_Location.GridView1.RowCount - 1
                        If mvCls_Loctions.ID = frm_Location.GridView1.GetDataRow(mvInt_Index)(0) Then
                            mvBol_Flag = True
                            Exit For
                        End If
                    Next
                    If mvBol_Flag Then
                        frm_Location.mvObj_GridData.Rows(mvInt_Index)(1) = mvCls_Loctions.Name
                        frm_Location.mvObj_GridData.Rows(mvInt_Index)(2) = mvCls_Loctions.Address
                        frm_Location.mvObj_GridData.Rows(mvInt_Index)(3) = mvCls_Loctions.IPAddress
                        frm_Location.mvObj_GridData.Rows(mvInt_Index)(4) = mvCls_Loctions.UserName
                        frm_Location.mvObj_GridData.Rows(mvInt_Index)(5) = mvCls_Loctions.Password
                        frm_Location.GridView1.BestFitColumns()
                        frm_Location.GridView1.RefreshData()
                        Me.Close()
                    End If
                Else    'Insert
                    For mvInt_Index = 0 To frm_Location.GridView1.RowCount - 1
                        If mvCls_Loctions.ID = frm_Location.GridView1.GetDataRow(mvInt_Index)(0) Then
                            mvBol_Flag = True
                            Exit For
                        End If
                    Next
                    If mvBol_Flag Then
                        SubG_Alert(68) '  FunG_Alert("Thông báo", "ID này đã có rồi!", frm_Alert.WTYPE.ERROR)
                    Else
                        'Add data in to gird
                        frm_Location.mvObj_GridData.Rows.Add(New Object() {mvCls_Loctions.ID, mvCls_Loctions.Name, mvCls_Loctions.Address, _
                        mvCls_Loctions.IPAddress, mvCls_Loctions.UserName, mvCls_Loctions.Password})
                        frm_Location.GridView1.BestFitColumns()
                        frm_Location.GridView1.RefreshData()
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class