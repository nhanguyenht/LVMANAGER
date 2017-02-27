Imports System.Threading
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Module mod_Format
    '#-----------------------------------------------------------------------
    '# ModuleName       :       mod_CommonFormat
    '# Description      :       Common Formats
    '# Author           :       tigertron Tri Nguyen & love@ngel Hoang Nguyen
    '# CreateDate       :       2008-09-16
    '# LastUpdate       :       2008-10-17
    '#-----------------------------------------------------------------------
#Region "Load - Show"
#Region "ShowForm"
    Public Sub SubG_ShowForm(ByVal frm As Form)
        'frm_ERP_Main.SplitContainerControl1.Panel2.Controls.Clear()
        'frm.TopLevel = False
        'frm.Parent = frm_ERP_Main.SplitContainerControl1.Panel2
        'frm.Size = frm_ERP_Main.SplitContainerControl1.Panel2.Size
        'frm.Show()
    End Sub
    Public Sub Sub_ShowControl(ByVal obj As Control, ByVal iByte_Index As Byte)
        Try
            obj.Dock = DockStyle.Fill
            Select Case iByte_Index
                Case 1
                    frm_Login.PanelControl1.Controls.Clear()
                    frm_Login.PanelControl1.Controls.Add(obj)
                Case 2
                    frm_ChangePassword.PanelControl1.Controls.Clear()
                    frm_ChangePassword.PanelControl1.Controls.Add(obj)
                Case 3
                    frm_TableM.PanelControl1.Controls.Clear()
                    frm_TableM.PanelControl1.Controls.Add(obj)
                    'Case 4
                    '    frm_Sale.PanelControl1.Controls.Clear()
                    '    frm_Sale.PanelControl1.Controls.Add(obj)
                    'Case 5
                    '    frm_Sale.plcCaculator.Controls.Clear()
                    '    frm_Sale.plcCaculator.Controls.Add(obj)
                Case 6
                    frm_Area.Panel2.Controls.Clear()
                    frm_Area.Panel2.Controls.Add(obj)
                Case 7
                    frm_Rate.plcCaculator.Controls.Clear()
                    frm_Rate.plcCaculator.Controls.Add(obj)
                    'Case 9
                    '    frm_Setup.PanelControl2.Controls.Clear()
                    '    frm_Setup.PanelControl2.Controls.Add(obj)
                    'Case 10
                    '    frm_Reports.PanelControl2.Controls.Clear()
                    '    frm_Reports.PanelControl2.Controls.Add(obj)
                    'Case 11
                    '    frm_GroupItem.PanelControl1.Controls.Clear()
                    '    frm_GroupItem.PanelControl1.Controls.Add(obj)
                    'Case 12
                    '    frm_Account.PanelControl2.Controls.Clear()
                    '    frm_Account.PanelControl2.Controls.Add(obj)
                    'Case 13
                    '    frm_Customer.PanelControl1.Controls.Clear()
                    '    frm_Customer.PanelControl1.Controls.Add(obj)
                    'Case 14
                    '    frm_Employee.PanelControl1.Controls.Clear()
                    '    frm_Employee.PanelControl1.Controls.Add(obj)
                    'Case 15
                    '    frm_SetArea.PanelControl4.Controls.Clear()
                    '    frm_SetArea.PanelControl4.Controls.Add(obj)
                Case 16
                    frm_ReceiptPayment.PanelControl1.Controls.Clear()
                    frm_ReceiptPayment.PanelControl1.Controls.Add(obj)
                    'Case 17
                    '    frm_SetMenu.PanelControl4.Controls.Clear()
                    '    frm_SetMenu.PanelControl4.Controls.Add(obj)
                    'Case 18
                    '    frm_DiscountServiceVat.plcCaculator.Controls.Clear()
                    '    frm_DiscountServiceVat.plcCaculator.Controls.Add(obj)
                    'Case 19
                    '    frm_Printer.PanelControl1.Controls.Clear()
                    '    frm_Printer.PanelControl1.Controls.Add(obj)
                    'Case 20
                    '    frm_Cash.plcCaculator.Controls.Clear()
                    '    frm_Cash.plcCaculator.Controls.Add(obj)
                    'Case 21
                    '    frm_Return.plcCaculator.Controls.Clear()
                    '    frm_Return.plcCaculator.Controls.Add(obj)
                    'Case 22
                    '    frm_Description.PanelControl1.Controls.Clear()
                    '    frm_Description.PanelControl1.Controls.Add(obj)
                    'Case 23
                    '    frm_RePrintBill.plcCaculator.Controls.Clear()
                    '    frm_RePrintBill.plcCaculator.Controls.Add(obj)
                    'Case 24
                    '    frm_NewItem.PanelControl1.Controls.Clear()
                    '    frm_NewItem.PanelControl1.Controls.Add(obj)
                    'Case 25
                    '    frm_DisSerVatPerBill.plcCaculator.Controls.Clear()
                    '    frm_DisSerVatPerBill.plcCaculator.Controls.Add(obj)
                    'Case 26
                    '    frm_SpilitQty.plcCaculator.Controls.Clear()
                    '    frm_SpilitQty.plcCaculator.Controls.Add(obj)
                    'Case 27
                    '    frm_NewPrice.plcCaculator.Controls.Clear()
                    '    frm_NewPrice.plcCaculator.Controls.Add(obj)
                Case 30
                    frm_DeptCollection.plcCaculator.Controls.Clear()
                    frm_DeptCollection.plcCaculator.Controls.Add(obj)
            End Select
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "LoadListView"
    Public Sub LoadListView(ByVal lv As ListView, ByVal table As DataTable)
        Dim j As Integer = 0
        Dim row As DataRow
        Dim item As ListViewItem
        For Each row In table.Rows
            item = New ListViewItem(table.Rows(j).Item(0).ToString)
            Dim i As Integer
            For i = 1 To table.Columns.Count - 1
                item.SubItems.Add(table.Rows(j).Item(i).ToString())
            Next i
            j = j + 1
            lv.Items.Add(item)
        Next
    End Sub
#End Region
#Region "Hiển thị dữ liệu lên Listview - SubM_ShowListview (0 Cột số)"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubG_ShowListview
    '# Description      :       Add Rows ListView
    '# Parameter        :       DataTable, ListView, Number of Listview Columns
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-16
    '# LastUpdate       :       2008-09-16
    '#-----------------------------------------------------------------------
    Public Sub SubG_ShowListview(ByVal iOjb_DataTable As DataTable, ByVal iObj_ListView As ListView)
        iObj_ListView.Items.Clear()
        Dim STT As Integer = 0
        For Each row As DataRow In iOjb_DataTable.Rows
            Dim Array(iOjb_DataTable.Columns.Count) As String
            STT += 1
            Array(0) = STT
            For i As Integer = 1 To iObj_ListView.Columns.Count - 1
                Array(i) = Trim(row(i - 1))
            Next
            Dim RowItem As ListViewItem = New ListViewItem(Array)
            iObj_ListView.Items.Add(RowItem)
        Next
    End Sub
#End Region
#Region "Hiển thị dữ liệu lên Listview - SubM_ShowListview (1 Cột số)"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubG_ShowListview
    '# Description      :       Add Rows ListView
    '# Parameter        :       DataTable, ListView, Number of Listview Columns
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-16
    '# LastUpdate       :       2008-09-24
    '#-----------------------------------------------------------------------
    Public Sub SubG_ShowListview(ByVal iOjb_DataTable As DataTable, ByVal iObj_ListView As ListView, _
    ByVal iInt_NumberColumn As Integer)
        iObj_ListView.Items.Clear()
        Dim STT As Integer = 0
        For Each row As DataRow In iOjb_DataTable.Rows
            Dim Array(iOjb_DataTable.Columns.Count) As String
            STT += 1
            Array(0) = STT
            For i As Integer = 1 To iOjb_DataTable.Columns.Count - 1
                If i = iInt_NumberColumn Then
                    Array(i) = Format(CInt(Trim(row(i - 1))), "#,###")
                Else
                    Array(i) = Trim(row(i - 1))
                End If
            Next
            Dim RowItem As ListViewItem = New ListViewItem(Array)
            iObj_ListView.Items.Add(RowItem)
        Next
    End Sub
#End Region
#Region "Hiển thị dữ liệu lên Listview - SubM_ShowListview (2 Cột số)"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubG_ShowListview
    '# Description      :       Add Rows ListView
    '# Parameter        :       DataTable, ListView, Number of Listview Columns
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-16
    '# LastUpdate       :       2008-09-24
    '#-----------------------------------------------------------------------
    Public Sub SubG_ShowListview(ByVal iOjb_DataTable As DataTable, ByVal iObj_ListView As ListView, _
    ByVal iInt_NumberColumn1 As Integer, ByVal iInt_NumberColumn2 As Integer)
        iObj_ListView.Items.Clear()
        Dim STT As Integer = 0
        For Each row As DataRow In iOjb_DataTable.Rows
            Dim Array(iOjb_DataTable.Columns.Count) As String
            STT += 1
            Array(0) = STT
            For i As Integer = 0 To iOjb_DataTable.Columns.Count - 1
                If i = iInt_NumberColumn1 Or i = iInt_NumberColumn2 Then
                    Array(i) = FormatNumber(Trim(row(i)), 1)
                Else
                    Array(i) = Trim(row(i))
                End If
            Next
            Dim RowItem As ListViewItem = New ListViewItem(Array)
            iObj_ListView.Items.Add(RowItem)
        Next
    End Sub
#End Region
#Region "Hiển thị dữ liệu lên Listview - SubM_ShowListview (3 Cột số)"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubG_ShowListview
    '# Description      :       Add Rows ListView
    '# Parameter        :       DataTable, ListView, Number of Listview Columns
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-16
    '# LastUpdate       :       2008-09-24
    '#-----------------------------------------------------------------------
    Public Sub SubG_ShowListview(ByVal iOjb_DataTable As DataTable, ByVal iObj_ListView As ListView, _
    ByVal iInt_NumberColumn1 As Integer, ByVal iInt_NumberColumn2 As Integer, ByVal iInt_NumberColumn3 As Integer)
        iObj_ListView.Items.Clear()
        Dim STT As Integer = 0
        For Each row As DataRow In iOjb_DataTable.Rows
            Dim Array(iOjb_DataTable.Columns.Count) As String
            STT += 1
            Array(0) = STT
            For i As Integer = 1 To iOjb_DataTable.Columns.Count - 1
                If i = iInt_NumberColumn1 Or i = iInt_NumberColumn2 Or i = iInt_NumberColumn3 Then
                    Array(i) = Format(CInt(Trim(row(i - 1))), "#,###")
                Else
                    Array(i) = Trim(row(i - 1))
                End If
            Next
            Dim RowItem As ListViewItem = New ListViewItem(Array)
            iObj_ListView.Items.Add(RowItem)
        Next
    End Sub
#End Region
#Region "Hiện thị lại ListView sau khi hiệu chỉnh TextBox"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubG_HienThiLaiListView
    '# Description      :       Show Info from Control to Listview after Edit
    '# Parameter        :       ListView, Number of Listview Columns, TextBox Control, Boolean to Action
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-10-1
    '# LastUpdate       :       2008-10-1
    '#-----------------------------------------------------------------------
    Public Sub SubG_HienThiLaiListView(ByVal iObj_LISTVIEW As ListView, ByVal iInt_VITRICOT As Integer, _
    ByVal iOjb_CONTROL As TextBox, ByVal iBoolean As Boolean)
        If iObj_LISTVIEW.Items.Count > 0 And iBoolean = True Then
            iObj_LISTVIEW.SelectedItems(0).SubItems(iInt_VITRICOT).Text = iOjb_CONTROL.Text.Trim
        End If
    End Sub
#End Region
#Region "Hiển thị lại ListView sau khi hiệu chỉnh ComboBox"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubG_HienThiLaiListView
    '# Description      :       Show Info from Control to Listview after Edit
    '# Parameter        :       ListView, Number of Listview Columns, TextBox Control, Boolean to Action
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-10-1
    '# LastUpdate       :       2008-10-1
    '#-----------------------------------------------------------------------
    Public Sub SubG_HienThiLaiListView(ByVal iObj_LISTVIEW As ListView, ByVal iInt_VITRICOT As Integer, _
    ByVal iOjb_CONTROL As ComboBox, ByVal iBoolean As Boolean)
        If iObj_LISTVIEW.Items.Count > 0 And iBoolean = True Then
            iObj_LISTVIEW.SelectedItems(0).SubItems(iInt_VITRICOT).Text = iOjb_CONTROL.Text.Trim
        End If
    End Sub
#End Region
#Region "Hiển thị lại ListView sau khi hiệu chỉnh RichTextBox"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubG_HienThiLaiListView
    '# Description      :       Show Info from Control to Listview after Edit
    '# Parameter        :       ListView, Number of Listview Columns, TextBox Control, Boolean To Action
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-10-1
    '# LastUpdate       :       2008-10-1
    '#-----------------------------------------------------------------------
    Public Sub SubG_HienThiLaiListView(ByVal iObj_LISTVIEW As ListView, ByVal iInt_VITRICOT As Integer, _
    ByVal iOjb_CONTROL As RichTextBox, ByVal iBoolean As Boolean)
        If iObj_LISTVIEW.Items.Count > 0 And iBoolean = True Then
            iObj_LISTVIEW.SelectedItems(0).SubItems(iInt_VITRICOT).Text = iOjb_CONTROL.Text.Trim
        End If
    End Sub
#End Region
#Region "Kiểm tra Chiều Dài Password"
    Public Sub SubG_ChieuDaiPassword(ByVal iErr As ErrorProvider, ByVal iObj As DevExpress.XtraEditors.TextEdit, ByVal iInt As Integer)
        If iObj.Text.Trim.Length < iInt Then
            iErr.SetError(iObj, "Password phải dài hơn " & iInt & " kí tự")
            iObj.Focus()
        Else
            iErr.Clear()
        End If
    End Sub
#End Region
#Region "Mã hóa password bằng MD5"
    Function getMd5Hash(ByVal input As String) As String
        ' Create a new instance of the MD5 object.
        Dim md5Hasher As MD5 = MD5.Create()

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function
#End Region
#End Region
#Region "Format"
#Region "Định dạng ListView - SubG_FormatListView"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubG_FormatListView
    '# Description      :       Format ListView
    '# Parameter        :       ListView
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-16
    '# LastUpdate       :       2008-09-16
    '#-----------------------------------------------------------------------
    Public Sub SubG_FormatListView(ByVal iObj_ListView As ListView)
        iObj_ListView.GridLines = True
        iObj_ListView.ShowGroups = True
        iObj_ListView.FullRowSelect = True
        iObj_ListView.MultiSelect = False
        iObj_ListView.View = View.Details
    End Sub
#End Region
    '#Region "Hàm Thay đổi Size CrystalReportViewer"
    '    Public Sub SubG_ThayDoiSizeCrystalReports(ByVal iObj_CrystalReportViewer As CrystalReportViewer, ByVal iBoolean As Boolean)
    '        If iBoolean Then
    '            iObj_CrystalReportViewer.Dock = DockStyle.Fill
    '        Else
    '            iObj_CrystalReportViewer.Dock = DockStyle.Bottom
    '        End If
    '    End Sub
    '#End Region
#Region "Định Dạng Số"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubG_FormatNumber
    '# Description      :       Format Number
    '# Parameter        :       ListView
    '# Author           :       tigertron Tri Nguyen
    '# CreateDate       :       2008-09-20
    '# LastUpdate       :       2008-09-20
    '#-----------------------------------------------------------------------
    Public Sub SubG_FormatNumber(ByVal iObj_Control As Object)
        If iObj_Control.Text <> "" And IsNumeric(iObj_Control.Text) = True Then
            iObj_Control.Text = Format(CLng(iObj_Control.Text), "#,###")
            iObj_Control.SelectionStart = iObj_Control.Text.Length
        End If
    End Sub
#End Region
#Region "Định Dạng Số Thập Phân"
    '#-----------------------------------------------------------------------
    '# MethodName       :       SubG_FormatNumberDigit
    '# Description      :       Format Number
    '# Parameter        :       ListView
    '# Author           :       hantinhyeu Nguyen Hoang Nguyen
    '# CreateDate       :       2009-05-09
    '# LastUpdate       :       2009-05-09
    '#-----------------------------------------------------------------------
    Public Sub SubG_FormatNumberDigit(ByVal iTextBox As Object, ByVal iInt_NumberDigit As Integer)
        Dim mvStr_Temp As String
        Try
            If iTextBox.Text <> "" And IsNumeric(iTextBox.Text) = True Then
                If Convert.ToDouble(iTextBox.Text) = 0 Then
                    iTextBox.Text = "0"
                Else
                    Dim mvChr_Decimal As Char = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator(0)
                    Dim mvChr_Group As Char = System.Globalization.NumberFormatInfo.CurrentInfo.NumberGroupSeparator(0)
                    mvStr_Temp = Convert.ToDouble(iTextBox.Text).ToString(String.Format("#{0}##0{1}000", mvChr_Group, mvChr_Decimal))
                    mvStr_Temp = mvStr_Temp.TrimStart("0"c).TrimEnd("0"c).TrimEnd(mvChr_Decimal)
                    If mvStr_Temp.StartsWith(mvChr_Decimal) Then
                        mvStr_Temp = "0" & mvStr_Temp
                    End If
                    iTextBox.Text = mvStr_Temp
                End If
            End If
        Catch ex As Exception
            iTextBox.Text = "0"
        End Try
    End Sub
    Public Sub SubG_FormatNumberDigit2(ByVal iTextBox As Object, ByVal iInt_NumberDigit As Integer)
        Dim mvStr_Temp As String
        Try
            If iTextBox.Text <> "" And IsNumeric(iTextBox.Text) = True Then
                If Convert.ToDouble(iTextBox.Text) = 0 Then
                    iTextBox.Text = "0"
                Else
                    Dim mvChr_Decimal As Char = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator(0)
                    Dim mvChr_Group As Char = System.Globalization.NumberFormatInfo.CurrentInfo.NumberGroupSeparator(0)
                    mvStr_Temp = Convert.ToDouble(iTextBox.Text).ToString(String.Format("#{0}##0{1}00", mvChr_Group, mvChr_Decimal))
                    mvStr_Temp = mvStr_Temp.TrimStart("0"c).TrimEnd("0"c).TrimEnd(mvChr_Decimal)
                    If mvStr_Temp.StartsWith(mvChr_Decimal) Then
                        mvStr_Temp = "0" & mvStr_Temp
                    End If
                    iTextBox.Text = mvStr_Temp
                End If
            End If
        Catch ex As Exception
            iTextBox.Text = "0"
        End Try
    End Sub
#End Region
#End Region
#Region "Chỉ cho phép nhập số (có cả số thập phân)"
    Public Sub SubG_OnlyInputDigit(ByVal iObj_TextBox As DevExpress.XtraEditors.TextEdit, ByVal e As KeyPressEventArgs, ByVal iBol_Flag As Boolean)
        Try
            Dim decimalString As String = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator
            Dim decimalChar As Char = Convert.ToChar(decimalString)
            If iObj_TextBox.Text.Length = 0 Then
                If iBol_Flag And (e.KeyChar = "-"c) Then
                ElseIf (((Char.IsDigit(e.KeyChar) = False)) And ((Char.IsControl(e.KeyChar) = False))) Then
                    e.Handled = True
                End If
            End If

            If (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or ((e.KeyChar = ".") And (iObj_TextBox.Text.IndexOf(".") = -1))) Then
            ElseIf (e.KeyChar = decimalString) And (iObj_TextBox.Text.IndexOf(decimalString) = -1) Then
            ElseIf iBol_Flag And (e.KeyChar = "-"c) Then
            Else
                e.Handled = True
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Create Serial"
    Public Function FuncG_CreateSerial(ByVal iStr_InputString As String, ByVal iInt_NumberLength As Integer) As String
        Dim mvStr_Numper As String = ""
        Dim mvStr_Text As String = ""
        Try
            mvStr_Numper = iStr_InputString.Substring(0, iInt_NumberLength)
            mvStr_Text = iStr_InputString.Substring(5)
            mvStr_Numper = (Convert.ToInt64(mvStr_Numper) + 1).ToString
            For i As Integer = 0 To (iInt_NumberLength - mvStr_Numper.Length - 1)
                mvStr_Numper = mvStr_Numper.Insert(0, "0")
            Next
            mvStr_Numper += mvStr_Text
        Catch ex As Exception

        End Try
        Return mvStr_Numper
    End Function
#End Region
#Region "Tạo mã số tự động"
    Public Function TaoSoSeri(ByVal strMa As String, ByVal intLenMa As Integer) As String
        Dim strSo As String
        Dim intSo As Integer
        Dim strTam As String = ""
        Dim i As Integer
        Try
            strSo = strMa.Substring(intLenMa, strMa.Length - intLenMa)
            intSo = Convert.ToInt64(strSo)
            intSo += 1
            strTam = intSo.ToString
            If (strTam.Length < (strMa.Length - intLenMa)) Then
                For i = 1 To strMa.Length - intLenMa - strTam.Length
                    strTam = strTam.Insert(0, "0")
                Next
            End If
            strTam = strTam.Insert(0, strMa.Substring(0, intLenMa))
        Catch ex As Exception

        End Try
        Return strTam
    End Function
    Public Function TaoSoSeriNEW(ByVal strMa As String, ByVal intLenMa As Integer) As String
        Dim strSo As String
        Dim intSo As Integer
        Dim strTam As String = ""
        Dim i As Integer
        Try


            strSo = strMa.Substring(intLenMa, strMa.Length - intLenMa)
            If strSo.Length > 7 Then
                strSo = strSo.Substring(10, 3)

                intSo = Convert.ToInt32(strSo)
                intSo += 1
                strTam = intSo
                If (strTam.Length < 7) Then
                    For i = 1 To 7 - strTam.Length
                        strTam = strTam.Insert(0, "0")
                    Next
                End If
                strTam = strTam.Insert(0, strMa.Substring(0, intLenMa))
                Return strTam
            Else
                intSo = Convert.ToSingle(strSo)
                intSo += 1
                strTam = intSo.ToString
                If (strTam.Length < (strMa.Length - intLenMa)) Then
                    For i = 1 To strMa.Length - intLenMa - strTam.Length
                        strTam = strTam.Insert(0, "0")
                    Next
                End If
                strTam = strTam.Insert(0, strMa.Substring(0, intLenMa))
                Return strTam
            End If
            
        Catch ex As Exception

        End Try

    End Function
#End Region
#Region "Lấy ngày tháng làm mã số"
    Public Function GetSerialFromDate(ByVal iDate As Date) As String
        Dim strTam As String = ""
        Try
            If iDate.Month < 10 Then
                strTam += "0" + iDate.Month.ToString
            Else
                strTam += iDate.Month.ToString
            End If
            If iDate.Day < 10 Then
                strTam += "0" + iDate.Day.ToString
            Else
                strTam += iDate.Day.ToString
            End If
            strTam += iDate.Year.ToString.Substring(2, 2)
        Catch ex As Exception

        End Try
        Return strTam
    End Function
#End Region
#Region "Lấy tháng với năm làm mã số cho phiếu thu/chi"
    Public Function GetMonthAndYearFromDate(ByVal iDate As Date) As String
        Dim strTam As String = ""
        Try
            strTam += "/"
            If iDate.Month < 10 Then
                strTam += "0" + iDate.Month.ToString
            Else
                strTam += iDate.Month.ToString
            End If
            strTam += "-"
            strTam += iDate.Year.ToString
        Catch ex As Exception

        End Try
        Return strTam
    End Function
#End Region
#Region "Chuyển ngày thành chuỗi"
    Public Function GetStringFromDate(ByVal iDate As Date) As String
        Dim strTam As String = ""
        Try
            If iDate.Day < 10 Then
                strTam += "0" + iDate.Day.ToString
            Else
                strTam += iDate.Day.ToString
            End If
            strTam += "/"
            If iDate.Month < 10 Then
                strTam += "0" + iDate.Month.ToString
            Else
                strTam += iDate.Month.ToString
            End If
            strTam += "/" + iDate.Year.ToString
        Catch ex As Exception

        End Try
        Return strTam
    End Function
#End Region
#Region "LoadReport"
    Public Sub LoadReport(ByVal rpt As Object)
        Dim tbCurrent As CrystalDecisions.CrystalReports.Engine.Table
        Dim tliCurrent As CrystalDecisions.Shared.TableLogOnInfo
        Dim strServerName As String = ""
        Dim strDBName As String = ""
        Dim strUserID As String = ""
        Dim strPass As String = ""
        strServerName = gvProp_Server
        'strDBName = "RESTAURANT DATABASE"
        strDBName = gvProp_DataBase
        strUserID = gvProp_User
        strPass = gvProp_PassWord
        For Each tbCurrent In rpt.Database.Tables
            tliCurrent = tbCurrent.LogOnInfo
            With tliCurrent.ConnectionInfo
                .ServerName = strServerName
                .UserID = strUserID
                .Password = strPass
                .DatabaseName = strDBName
            End With
            tbCurrent.ApplyLogOnInfo(tliCurrent)
            'Set lai ten table ton kho tam
            If tbCurrent.Name.IndexOf("TBL_SOCHITIET") <> -1 Then
                tbCurrent.Location = strDBName + ".dbo.TBL_SOCHITIET" + gvStr_LocID
            End If
            If tbCurrent.Name.IndexOf("TBL_SOTONGHOP") <> -1 Then
                tbCurrent.Location = strDBName + ".dbo.TBL_SOTONGHOP" + gvStr_LocID
            End If
        Next tbCurrent
    End Sub
#End Region
#Region "Load Info into Report"
    Public Sub SubM_LoadInfoInReport(ByVal rpt As Object)
        rpt.SetParameterValue("Name", gvCls_Company.Name)
        rpt.SetParameterValue("Address", gvCls_Company.Address)
        rpt.SetParameterValue("Telephone", gvCls_Company.Phone)
        rpt.SetParameterValue("LocID", gvStr_LocID)
        rpt.SetParameterValue("Language", gvByte_Language)
    End Sub
#End Region
#Region "Đưa dữ liệu từ Datatable vào Listbox"
    Public Sub ImportsDataintoListBox(ByVal lst As ListBox, ByVal dataTB As DataTable, ByVal Index As Integer)
        lst.Items.Clear()
        Dim count As Integer = dataTB.Rows.Count
        If count = 0 Then
            lst.Text = ""
        Else
            Dim i As Integer
            For i = 0 To count - 1
                Dim row As DataRow
                row = dataTB.Rows(i)
                If row.RowState <> DataRowState.Deleted Then
                    lst.Items.Add(row(Index).ToString)
                End If
            Next i
        End If
    End Sub
#End Region
#Region "Đọc tiền 2"
    Public Function VND(ByVal BaoNhieu As Long) As String
        Dim KetQua, SoTien, Nhom, Chu, S1, S2, S3, Dich As String
        Dim N, J, Vitri As Byte, S As Double
        Dim Hang() As String = {"None", "trăm", "mươi", "gì đó"}
        Dim Doc() As String = {"None", "ngàn tỷ", "tỷ", "triệu", "ngàn", "đồng", ""}
        Dim Dem() As String = {"None", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"}
        If BaoNhieu = 0 Then
            KetQua = "Không đồng"
        Else
            GoTo LamViecDi
        End If
        VND = UCase(Left(KetQua, 1)) + Mid(KetQua, 2)
        Exit Function
LamViecDi:
        If BaoNhieu < 0 Then
            KetQua = "Trừ" & Space(1)
        Else
            KetQua = Space(0)
        End If
        SoTien = Format(BaoNhieu, "##############0.00")
        SoTien = Right(Space(15) & SoTien, 18)
        For N = 1 To 6
            Nhom = Mid(SoTien, N * 3 - 2, 3)
            If Nhom <> Space(3) Then
                Select Case Nhom
                    Case "000"
                        If N = 5 Then Chu = "đồng" & Space(1) Else Chu = Space(0)
                    Case ".00"
                        Chu = ""
                    Case Else
                        S1 = Left(Nhom, 1) : S2 = Mid(Nhom, 2, 1) : S3 = Right(Nhom, 1)
                        Chu = Space(0) : Hang(3) = Doc(N)
                        For J = 1 To 3
                            Dich = Space(0) : S = Val(Mid(Nhom, J, 1))
                            If S > 0 Then Dich = Dem(S) & Space(1) & Hang(J) & Space(1)
                            Select Case J
                                Case 2 And S = 1
                                    Dich = "mười" & Space(1)
                                Case 3 And S = 0 And Nhom <> Space(2) & "0"
                                    Dich = Hang(J) & Space(1)
                                Case 3 And S = 5 And S2 <> Space(1) And S2 <> "0"
                                    Dich = "l" & Mid(Dich, 2)
                                Case 2 And S = 0 And S3 <> "0"
                                    If (S1 >= "1" And S1 <= "9") Or (S1 = "0" And N = 5) Then Dich = "lẻ" & Space(1)
                            End Select
                            Chu = Chu & Dich
                        Next J
                End Select
                Vitri = InStr(1, Chu, "mười một", 1)
                If Vitri > 0 Then Mid(Chu, Vitri, 9) = "mươi mốt"
                KetQua = KetQua & Chu
            End If
        Next N
        If String.IsNullOrEmpty(KetQua) Then
            Return String.Empty
        End If
        Dim mvArrChr_KetQua As Char() = KetQua.ToCharArray()
        mvArrChr_KetQua(0) = Char.ToUpper(mvArrChr_KetQua(0))
        Return New String(mvArrChr_KetQua)
    End Function
#End Region
#Region "Kiểm tra 2 tiến trình trùng nhau"
    Public Function AppIsAlreadyRunning() As Boolean
        Try
            ' get the filename of the main module
            Dim moduleName As String = Process.GetCurrentProcess.MainModule.ModuleName
            ' discard the extension to get the process name
            Dim procName As String = System.IO.Path.GetFileNameWithoutExtension _
                (moduleName)
            ' return true if there are 2 or more processes with that name
            If Process.GetProcessesByName(procName).Length > 1 Then
                Return True
            End If
        Catch ex As Exception

        End Try
    End Function
#End Region
End Module
