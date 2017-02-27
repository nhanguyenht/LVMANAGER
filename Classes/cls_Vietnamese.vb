Public Structure Chu
    Public D9 As Boolean
    Public UODau As Boolean
    Public UOA As Boolean
    Public amDau As String
    Public nguyenAm As String
    Public amCuoi As String
    Public vitriDau As Integer
    Public vitriThanhPhan As Integer
    Public trungdau As Integer
    Public dau As cls_Vietnamese.Dau
    Public moc As Char
    Public Sub Reset()
        Me.vitriThanhPhan = 0
        Me.D9 = Me.UOA = Me.UODau = False
        Me.amDau = Me.nguyenAm = Me.amCuoi = ""
        Me.dau = cls_Vietnamese.Dau.Thanh
        Me.moc = "-"c
        Me.vitriDau = Me.trungdau = -1
    End Sub
End Structure
Public Class cls_Vietnamese
    Public Enum Dau
        Thanh
        Sac
        Huyen
        Nga
        Hoi
        Nang
    End Enum
    Public Enum DinhNghiaKieuGo
        AThanh6 = 7
        AThanh8 = 13
        DauMuChungAOE = 6
        DThanhD = 14
        EThanh6 = 8
        hoi = 4
        huyen = 2
        khongDau = 0
        nang = 5
        nga = 3
        Null = -1
        OThanh6 = 9
        sac = 1
        UOASimple = 11
        UThanh7OThanh7 = 12
        UThanh7OThanh7AThanh8 = 10
    End Enum
    Private mvArrStr_AmDau As String() = New String() {"r", "d", "gi", "v", "ch", "tr", _
     "s", "x", "l", "n", "qu", "b", _
     "`c", "/k", "`g", "/gh", "h", "kh", _
     "m", "`ng", "/ngh", "nh", "p", "ph", _
     "t", "th"}
    Private mvBol_KytuDDau As Boolean
    Public bangMa As String()
    Public boDauKieuMoi As Boolean
    Public chu As Chu
    Private i As Integer
    Public kieuGo As Char()
    Private kq As Integer
    Public ktChinhTa As Integer
    Private mocCu As Char
    Private phuAmCuoi As String() = New String() {"c", "ch", "m", "n", "ng", "nh", _
     "p", "t"}
    Private s As String
    Private sacNang As String() = New String() {"c", "ch", "p", "t"}
    Private stringChinhTa As String
    Private value As String
    Private van As String() = New String() {"a", "^", "a", "-", "a", "(", _
     "ac", "^", "ac", "-", "ac", "(", _
     "ach", "-", "ai", "-", "ak", "(", _
     "am", "^", "am", "-", "am", "(", _
     "an", "^", "an", "-", "an", "(", _
     "ang", "^", "ang", "-", "ang", "(", _
     "anh", "-", "ao", "-", "ap", "^", _
     "ap", "-", "ap", "(", "at", "^", _
     "at", "-", "at", "(", "au", "^", _
     "au", "-", "ay", "^", "ay", "-", _
     "e", "^", "e", "-", "ec", "-", _
     "ech", "^", "em", "^", "em", "-", _
     "en", "^", "en", "-", "eng", "-", _
     "eng", "^", "enh", "^", "eo", "-", _
     "ep", "^", "ep", "-", "et", "^", _
     "et", "-", "eu", "^", "i", "-", _
     "ia", "-", "ich", "-", "iec", "^", _
     "iem", "^", "ien", "^", "ieng", "^", _
     "iep", "^", "iet", "^", "ieu", "^", _
     "im", "-", "in", "-", "inh", "-", _
     "ip", "-", "it", "-", "iu", "-", _
     "o", "^", "o", "-", "o", "*", _
     "oa", "-", "oac", "-", "oac", "(", _
     "oach", "-", "oai", "-", "oan", "-", _
     "oan", "(", "oang", "-", "oang", "(", _
     "oanh", "-", "oap", "-", "oat", "-", _
     "oat", "-", "oat", "(", "oay", "-", _
     "oc", "^", "oc", "-", "oe", "-", _
     "oeo", "-", "oet", "-", "oi", "^", _
     "oi", "-", "oi", "*", "om", "^", _
     "om", "-", "om", "*", "on", "^", _
     "on", "-", "on", "*", "ong", "^", _
     "ong", "-", "ooc", "-", "op", "^", _
     "op", "-", "op", "*", "ot", "^", _
     "ot", "-", "ot", "*", "u", "-", _
     "u", "*", "ua", "-", "ua", "*", _
     "uan", "^", "uang", "^", "uat", "^", _
     "uay", "^", "uc", "-", "uc", "*", _
     "ue", "^", "uech", "^", "uenh", "^", _
     "ui", "-", "ui", "*", "um", "-", _
     "um", "*", "un", "-", "ung", "-", _
     "ung", "*", "uo", "*", "uoc", "^", _
     "uoc", "*", "uoi", "^", "uoi", "*", _
     "uom", "^", "uom", "*", "uon", "^", _
     "uon", "*", "uong", "^", "uong", "*", _
     "uop", "*", "uot", "^", "uot", "*", _
     "uou", "*", "up", "-", "ut", "-", _
     "ut", "*", "uu", "*", "uy", "-", _
     "uych", "-", "uyen", "^", "uyet", "^", _
     "uynh", "-", "uyp", "-", "uyu", "-", _
     "uyt", "-", "y", "-", "ych", "-", _
     "yem", "^", "yen", "^", "yet", "^", _
     "yeu", "^", "ynh", "-", "yt", "-"}
    Public vanChiIE As Boolean
    Private viTriDauMoc As DinhNghiaKieuGo
    Private Sub KiemTraViTriDau()
        If Me.chu.nguyenAm.Length = 1 Then
            Me.chu.vitriDau = 0
        ElseIf Me.chu.nguyenAm.Length = 2 Then
            If (Me.chu.nguyenAm(0) = "a"c) OrElse (Me.chu.nguyenAm(0) = "A"c) Then
                If ((Me.chu.nguyenAm(1) <> "e"c) AndAlso (Me.chu.nguyenAm(1) <> "E"c)) OrElse ((Me.chu.nguyenAm(1) <> "a"c) AndAlso (Me.chu.nguyenAm(1) <> "A"c)) Then
                    Me.chu.vitriDau = 0
                Else
                    Me.chu.vitriDau = -1
                End If
            ElseIf (Me.chu.nguyenAm(0) = "e"c) OrElse (Me.chu.nguyenAm(0) = "E"c) Then
                If (((Me.chu.nguyenAm(1) = "o"c) OrElse (Me.chu.nguyenAm(1) = "O"c)) OrElse ((Me.chu.nguyenAm(1) = "u"c) OrElse (Me.chu.nguyenAm(1) = "U"c))) OrElse ((Me.chu.nguyenAm(1) = "y"c) OrElse (Me.chu.nguyenAm(1) = "Y"c)) Then
                    Me.chu.vitriDau = 0
                Else
                    Me.chu.vitriDau = -1
                End If
            ElseIf (Me.chu.nguyenAm(0) = "i"c) OrElse (Me.chu.nguyenAm(0) = "I"c) Then
                If (Me.chu.nguyenAm(1) = "e"c) OrElse (Me.chu.nguyenAm(1) = "E"c) Then
                    Me.chu.vitriDau = 1
                ElseIf ((Me.chu.nguyenAm(1) = "u"c) OrElse (Me.chu.nguyenAm(1) = "U"c)) OrElse ((Me.chu.nguyenAm(1) = "a"c) OrElse (Me.chu.nguyenAm(1) = "A"c)) Then
                    Me.chu.vitriDau = 0
                Else
                    Me.chu.vitriDau = -1
                End If
            ElseIf (Me.chu.nguyenAm(0) = "o"c) OrElse (Me.chu.nguyenAm(0) = "O"c) Then
                If ((Me.chu.nguyenAm(1) = "a"c) OrElse (Me.chu.nguyenAm(1) = "A"c)) OrElse ((Me.chu.nguyenAm(1) = "e"c) OrElse (Me.chu.nguyenAm(1) = "E"c)) Then
                    If ((Me.chu.amCuoi.Length > 0) OrElse Me.boDauKieuMoi) OrElse ((Me.chu.moc = "^"c) OrElse (Me.chu.moc = "("c)) Then
                        Me.chu.vitriDau = 1
                    Else
                        Me.chu.vitriDau = 0
                    End If
                ElseIf (Me.chu.nguyenAm(1) = "i"c) OrElse (Me.chu.nguyenAm(1) = "I"c) Then
                    Me.chu.vitriDau = 0
                ElseIf (Me.chu.nguyenAm(1) = "o"c) OrElse (Me.chu.nguyenAm(1) = "O"c) Then
                    Me.chu.vitriDau = 1
                Else
                    Me.chu.vitriDau = -1
                End If
            ElseIf (Me.chu.nguyenAm(0) = "u"c) OrElse (Me.chu.nguyenAm(0) = "U"c) Then
                If (Me.chu.nguyenAm(1) = "a"c) OrElse (Me.chu.nguyenAm(1) = "A"c) Then
                    If ((Me.chu.amCuoi.Length > 0) OrElse (Me.chu.moc = "^"c)) OrElse (Me.chu.moc = "("c) Then
                        Me.chu.vitriDau = 1
                    Else
                        Me.chu.vitriDau = 0
                    End If
                ElseIf (Me.chu.nguyenAm(1) = "e"c) OrElse (Me.chu.nguyenAm(1) = "E"c) Then
                    Me.chu.vitriDau = 1
                ElseIf ((Me.chu.nguyenAm(1) = "i"c) OrElse (Me.chu.nguyenAm(1) = "I"c)) OrElse ((Me.chu.nguyenAm(1) = "u"c) OrElse (Me.chu.nguyenAm(1) = "U"c)) Then
                    Me.chu.vitriDau = 0
                ElseIf (Me.chu.nguyenAm(1) = "y"c) OrElse (Me.chu.nguyenAm(1) = "Y"c) Then
                    If (Me.chu.amCuoi.Length > 0) OrElse Me.boDauKieuMoi Then
                        Me.chu.vitriDau = 1
                    Else
                        Me.chu.vitriDau = 0
                    End If
                ElseIf (Me.chu.nguyenAm(1) = "o"c) OrElse (Me.chu.nguyenAm(1) = "O"c) Then
                    Me.chu.vitriDau = 1
                Else
                    Me.chu.vitriDau = -1
                End If
            ElseIf (Me.chu.nguyenAm(0) = "y"c) OrElse (Me.chu.nguyenAm(0) = "Y"c) Then
                Me.chu.vitriDau = 1
            Else
                Me.chu.vitriDau = -1
            End If
        ElseIf Me.chu.nguyenAm.Length = 3 Then
            Select Case Me.chu.nguyenAm.Substring(0, 3).ToLower()
                Case "uye"
                    Me.chu.vitriDau = 2
                    Return

                Case "uou", "ieu", "oai", "uay", "oay", "uoi", _
                 "uya", "yeu", "oeo", "uyu"
                    Me.chu.vitriDau = 1
                    Return
            End Select
            Me.chu.vitriDau = -1
        Else
            Me.chu.vitriDau = -1
        End If
    End Sub
End Class