Public Class form1

    Private Sub bt_hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_hitung.Click
        Dim a, b, c As Single
        a = txt_nilai1.Text
        b = txt_nilai2.Text
        c = txt_nilai3.Text

        lbl_rataan1.Text = (a + b + c) / 3

        If lbl_rataan1.Text > 80 Then
            lbl_hadiah1.Text = "Rp.10.000.000"
        ElseIf lbl_rataan1.Text > 70 Then
            lbl_hadiah1.Text = "Rp.7.500.000"
        Else : lbl_hadiah1.Text = " Anda mendapatkan sertifikat"
        End If
    End Sub

    Private Sub bt_ulang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ulang.Click
        txt_nama.Clear()
        txt_nilai1.Clear()
        txt_nilai2.Clear()
        txt_nilai3.Clear()
        lbl_rataan1.ResetText()
        lbl_hadiah1.ResetText()
    End Sub
End Class