Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class SifremiUnuttumFormu
    Public KKayitNo As Integer
    Public KAdi, Soru, Cevap As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim YeniCevap As String = HashAlgoritma(CevapTBox.Text, MD5.Create)
        Dim Sifre As String = Nothing

        If Cevap <> YeniCevap Then
            MessageBox.Show("Güvenlik Sorusuna vermiş olduğunuz cevabınız hatalı.", "Hata")
            Exit Sub
        End If

        If SifreKontrol(SifreTBox.Text) Then
            Sifre = HashAlgoritma(SifreTBox.Text, MD5.Create)
        Else
            MessageBox.Show("Şifreniz 5-15 karakter uzunluğunda olmalı, En az 1 Büyük, 1 Küçük karakter ve rakam içermelidir.", "Hata")
            Exit Sub
        End If

        If Sifre <> HashAlgoritma(TekrarTBox.Text, MD5.Create) Then
            MessageBox.Show("Şifre ve Şifre Tekrarı uyuşmuyor.", "Hata")
            Exit Sub
        End If

        Dim SqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim Sorgu As String = "UPDATE KullaniciTablosu SET Sifre=@Sifre WHERE KullaniciKayitNo=@KKNo"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        SqlKomut.Parameters.Add("@Sifre", SqlDbType.NVarChar, 128).Value = Sifre
        SqlKomut.Parameters.Add("@KKNo", SqlDbType.Int).Value = KKayitNo
        Try
            SqlBaglanti.Open()
            If SqlKomut.ExecuteNonQuery > 0 Then
                MessageBox.Show("Yeni şifre işlemi başarı ile gerçekleşti. Yeni şifreniz ile giriş yapabilirsiniz.", "Bilgi")
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try

    End Sub

    Private Sub SifreGosterPBox_MouseDown(sender As Object, e As MouseEventArgs) Handles TekrarGosterPBox.MouseDown, SifreGosterPBox.MouseDown
        Dim KontrolPBox As PictureBox = sender
        If KontrolPBox.Tag = 1 Then
            SifreTBox.UseSystemPasswordChar = False
        End If
        If KontrolPBox.Tag = 2 Then
            TekrarTBox.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub SifreGosterPBox_MouseUp(sender As Object, e As MouseEventArgs) Handles TekrarGosterPBox.MouseUp, SifreGosterPBox.MouseUp
        SifreTBox.UseSystemPasswordChar = True
        TekrarTBox.UseSystemPasswordChar = True
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SifremiUnuttumFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = String.Format(Me.Text, KAdi)
        SoruTBox.Text = Soru
        CevapTBox.Focus()
    End Sub
End Class
