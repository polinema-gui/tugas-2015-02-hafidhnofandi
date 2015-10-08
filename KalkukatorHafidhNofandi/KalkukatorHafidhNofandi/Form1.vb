Public Class Form1
    Dim nilai1, nilai2 As Long
    Dim hasil As Double
    Dim operasi, txtnilai1, txtnilai2 As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "1"
            txthasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "1"
            txthasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "2"
            txtHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "2"
            txtHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "3"
            txtHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "3"
            txtHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "4"
            txtHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "4"
            txtHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "5"
            txtHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "5"
            txtHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "6"
            txtHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "6"
            txtHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "7"
            txtHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "7"
            txtHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "8"
            txtHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "8"
            txtHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "9"
            txtHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "9"
            txtHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If operasi = "" Then
            txtnilai1 = txtnilai1 + "0"
            txtHasil.Text = txtnilai1
        Else : txtnilai2 = txtnilai2 + "0"
            txtHasil.Text = txtnilai2
        End If
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        operasi = "+"
    End Sub

    Private Sub ButtonKurang_Click(sender As Object, e As EventArgs) Handles ButtonKurang.Click
        operasi = "-"
    End Sub

    Private Sub ButtonKali_Click(sender As Object, e As EventArgs) Handles ButtonKali.Click
        operasi = "x"
    End Sub

    Private Sub ButtonBagi_Click(sender As Object, e As EventArgs) Handles ButtonBagi.Click
        operasi = ":"
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        operasi = ""
        txtnilai1 = ""
        txtnilai2 = ""
        txtHasil.Clear()
    End Sub

    Private Sub ButtonHasil_Click(sender As Object, e As EventArgs) Handles ButtonHasil.Click
        nilai1 = Val(txtnilai1)
        nilai2 = Val(txtnilai2)
        If operasi = "+" Then
            hasil = nilai1 + nilai2
            txtHasil.Text = hasil
        ElseIf operasi = "-" Then
            hasil = nilai1 - nilai2
            txtHasil.Text = hasil
        ElseIf operasi = "x" Then
            hasil = nilai1 * nilai2
            txtHasil.Text = hasil
        ElseIf operasi = ":" Then
            hasil = nilai1 / nilai2
            txtHasil.Text = hasil
        End If



        operasi = ""
        txtnilai1 = ""
        txtnilai2 = ""
        txtnilai1 = Str$(hasil)
    End Sub
End Class
