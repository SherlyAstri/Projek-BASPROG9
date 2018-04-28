Public Class form2

    Private Sub bt_hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_hitung.Click
        Dim a, b, c, d, ee, f, g, h, total, i As Single
        a = txt_tgskecilnilai.Text
        b = txt_tgskecilbobot.Text
        c = txt_tugasbesarnilai.Text
        d = txt_tugasbesarbobot.Text
        ee = txt_utsnilai.Text
        f = txt_utsbobot.Text
        g = txt_uasnilai.Text
        h = txt_uasbobot.Text

        i = b + d + f + h

        If i = 100 Then

            total = ((a * b) / 100) + ((c * d) / 100) + ((ee * f) / 100) + ((g * h) / 100)
            lbl_total.Text = total
            If lbl_total.Text > 80 Then
                lbl_grade.Text = "A"
            ElseIf lbl_total.Text > 70 Then
                lbl_grade.Text = "B"
            ElseIf lbl_total.Text > 60 Then
                lbl_grade.Text = "C"
            ElseIf lbl_total.Text > 50 Then
                lbl_grade.Text = "D"
            ElseIf lbl_total.Text < 50 Then
                lbl_grade.Text = "E"
            Else : lbl_grade.Text = "nilai anda tidak terdefinisi"
            End If
        Else
            MsgBox("bobot yang anda masukan salah", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub bt_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_keluar.Click
        Me.Close()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
