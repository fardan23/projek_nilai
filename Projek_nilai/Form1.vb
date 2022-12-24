Public Class Form1


    Private Sub btnproses_Click(sender As Object, e As EventArgs) Handles btnproses.Click
        Txtnilaiakhir.Text = Val((Txttugas.Text) * 50 / 100) + Val((Txtulanganharian.Text) * 20 / 100) + Val((Txtulangansmt.Text) * 30 / 100)
        If Txtnilaiakhir.Text > 85 Then
            Txtnilaihuruf.Text = "A"
        ElseIf Txtnilaiakhir.Text > 75 Then
            Txtnilaihuruf.Text = "B"
        ElseIf Txtnilaiakhir.Text > 60 Then
            Txtnilaihuruf.Text = "C"
        Else
            Txtnilaihuruf.Text = "D"
        End If
    End Sub
End Class
