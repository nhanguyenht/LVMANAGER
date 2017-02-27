Module mod_Event
    '#-----------------------------------------------------------------------
    '# ModuleName       :       mod_CommonEvent
    '# Description      :       Common Events
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-14
    '# LastUpdate       :       2008-09-14
    '#-----------------------------------------------------------------------
#Region "Thông Báo Lỗi - SubG_Leave"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubM_ErrorProvider
    '# Description      :       Show Error Message
    '# Parameter        :       Error Provider, Object Control, Length text Control
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-14
    '# LastUpdate       :       2008-09-14
    '#-----------------------------------------------------------------------
    Public Sub SubG_Leave(ByVal ErrorProvider As ErrorProvider, ByVal inObj_Control As Object, ByVal inInt_Length As Integer, ByVal inStr_Warning As String)
        If 1 = 1 Then
            ErrorProvider.SetError(inObj_Control, inStr_Warning)
        Else
            ErrorProvider.Clear()
        End If
    End Sub
#End Region
#Region "Kiểm Soát Phím Nhập KeyPress - SubG_KeyPress"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubM_KeyPress
    '# Description      :       Control KeyPress
    '# Parameter        :       Error Provider, Key,  Object Control, Condition for TextBox, Warning Message
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-14
    '# LastUpdate       :       2008-09-14
    '#-----------------------------------------------------------------------
    Public Sub SubG_KeyPress(ByVal ErrorProvider As ErrorProvider, ByVal inEve_EventArgs As System.Windows.Forms.KeyPressEventArgs, ByVal inObj_Control As Object, ByVal inCon_Condition As Boolean, ByVal inStr_Warning As String)
        If inEve_EventArgs.KeyChar = Chr(8) Then
            Exit Sub
        End If
        If inEve_EventArgs.KeyChar = Chr(13) Then
            SendKeys.Send(Chr(9))
        ElseIf IsNumeric(inEve_EventArgs.KeyChar()) = inCon_Condition Then
            inEve_EventArgs.KeyChar = Chr(0)
            ErrorProvider.SetError(inObj_Control, inStr_Warning)
            inObj_Control.Focus()
        Else
            ErrorProvider.Clear()
        End If
    End Sub
#End Region
#Region "Xử lí rời khỏi Control Số - SubG_LeaveNumberInputControl"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubM_LeaveNumberInputControl
    '# Description      :       Leave Number Input Control
    '# Parameter        :       Error Provider, Object Control
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-14
    '# LastUpdate       :       2008-09-14
    '#-----------------------------------------------------------------------
    Public Sub SubG_LeaveNumberInputControl(ByVal ErrorProvider As ErrorProvider, ByVal inObj_Control As TextBox)
        If inObj_Control.Text.Trim = "" Then
            ErrorProvider.Clear()
            inObj_Control.Text = 0
        Else
            ErrorProvider.Clear()
        End If
    End Sub
#End Region
#Region "Next Control - SubG_NextControl"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubM_NextControl
    '# Description      :       Auto Goto Next Control
    '# Parameter        :       Object Control, Length Of Control Text
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-14
    '# LastUpdate       :       2008-09-14
    '#-----------------------------------------------------------------------
    Public Sub SubG_NextControl(ByVal inObj_AppearControl As Object, ByVal inObj_LengthAppearControl As Integer)
        If inObj_AppearControl.Text.Trim.Length >= inObj_LengthAppearControl Then
            SendKeys.Send(Chr(9))
        End If
    End Sub
#End Region
#Region "Xử lí Nút Lưu và Nút Bỏ Qua - SubG_TextChanged"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubM_TextChanged
    '# Description      :       Accept Button
    '# Parameter        :       Object Button
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-14
    '# LastUpdate       :       2008-09-14
    '#-----------------------------------------------------------------------
    Public Sub SubG_TextChanged(ByVal Condition As Boolean, ByVal iObj_Button As DevExpress.XtraEditors.SimpleButton)
        If Condition = True Then
            iObj_Button.Enabled = True
        Else : iObj_Button.Enabled = False
        End If
    End Sub
#End Region
#Region "Nhận Focus những Control Đặc biệt - SubG_GotFocus"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubG_GotFocus
    '# Description      :       Special TextBox GotFocus
    '# Parameter        :       TextBox
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-24
    '# LastUpdate       :       2008-09-24
    '#-----------------------------------------------------------------------
    Public Sub SubG_GotFocus(ByVal iObj_TextBox As TextBox)
        Clipboard.Clear()
        iObj_TextBox.Text = ""
    End Sub
#End Region
#Region "Enable Nút"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubG_GotFocus
    '# Description      :       Special TextBox GotFocus
    '# Parameter        :       TextBox
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-10-04
    '# LastUpdate       :       2008-10-04
    '#-----------------------------------------------------------------------
    Public Sub SubG_EnableChanged(ByRef iBoolean As Boolean, ByVal iButtonCondition As DevExpress.XtraEditors.SimpleButton, ByVal iButtonNeedActive As DevExpress.XtraEditors.SimpleButton)
        If iButtonCondition.Enabled = True Then
            iBoolean = False
        End If
        SubG_TextChanged(iBoolean, iButtonNeedActive)
    End Sub
#End Region
#Region "On Screen Keyboard"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubG_OnScreenKeypress
    '# Description      :       Add text into textbox
    '# Parameter        :       TextBox
    '# Author           :       love@ngel Nguyen Hoang
    '# CreateDate       :       2011-06-27
    '# LastUpdate       :       2011-06-27
    '#-----------------------------------------------------------------------
    Public Sub SubG_OnScreenKeypress(ByRef iButton As DevExpress.XtraEditors.SimpleButton, ByVal iTextBox As DevExpress.XtraEditors.TextEdit)
        'Dim mvChr_InputChar As Char
        Dim mvInt_Position As Integer
        Try
            Select Case iButton.Text
                Case "XÓA", "DEL", "CE"
                    iTextBox.Focus()
                    SendKeys.Send("{BS}")
                Case Else
                    mvInt_Position = iTextBox.SelectionStart
                    iTextBox.Text = iTextBox.Text.Insert(iTextBox.SelectionStart, iButton.Text)
                    iTextBox.SelectionStart = mvInt_Position + iButton.Text.Length
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SubM_ConvertVietnamese(ByVal iStr_InputString As String)
        Try

        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Tính tống trên Listview"
    '#-----------------------------------------------------------------------
    '# ModuleName       :       FuncG_TinhTongTrenGridView
    '# Description      :       Tính tổng trên girdview
    '# Author           :       love@ngel Hoang Nguyen
    '# CreateDate       :       2011-09-25
    '# LastUpdate       :       2011-09-25
    '#-----------------------------------------------------------------------
    Public Function FuncG_TinhTongTrenGridView(ByVal ilst As DevExpress.XtraGrid.Views.Grid.GridView, ByVal iStr_TenCot As String) As Double
        Dim mvDou_TongTien As Double = 0
        For i As Integer = 0 To ilst.RowCount - 1
            mvDou_TongTien += Double.Parse(ilst.GetDataRow(i)(iStr_TenCot))
        Next
        Return mvDou_TongTien
    End Function
#End Region
End Module
