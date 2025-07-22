Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class LoginFormu
    Private Hak As Integer = 3
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Hak -= 1
        Dim KullaniciAdi As String = UsernameTextBox.Text
        Dim Sifre As String = HashAlgoritma(PasswordTextBox.Text, MD5.Create)

        Dim Sorgu As String = "Select * From KullaniciTablosu WHERE KullaniciAdi=@KullaniciAdi And Sifre=@Sifre"
        Dim SqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        'SQL Sorgusunda parametre de�i�kenleri oldu�undan (@ ile ba�layan kelimeler) �al��t�rmadan �nce
        'bu parametre de�i�kenleri tan�mlanmal� ve de�er atamas� yap�lmal�d�r.
        SqlKomut.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = KullaniciAdi
        SqlKomut.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = Sifre
        Dim Tablo As New DataTable
        Try
            SqlBaglanti.Open()
            Tablo.Load(SqlKomut.ExecuteReader)
            If Hak >= 0 AndAlso Tablo.Rows.Count = 1 AndAlso
                (Tablo.Rows(0)("KullaniciAdi") = KullaniciAdi And Tablo.Rows(0)("Sifre") = Sifre) Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            ElseIf Hak > 0 Then
                MessageBox.Show("Kullan�c� Ad� veya �ifre hatal�. Tekrar deneyiniz.", "Hata")
            Else
                MessageBox.Show("Bir �ok kez hatal� giri� yapt�n�z program kapat�lacak.", "Hata")
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("Hata olu�tu. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try

    End Sub
    Private Sub UnuttumLinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UnuttumLinkLbl.LinkClicked
        Dim KAdi As String = UsernameTextBox.Text
        Dim SqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM KullaniciTablosu WHERE KullaniciAdi=@KullaniciAdi"
        Dim KullaniciSqlDA As New SqlDataAdapter(Sorgu, SqlBaglanti)
        KullaniciSqlDA.SelectCommand.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar, 20).Value = KAdi
        Dim Tablo As New DataTable
        Try
            SqlBaglanti.Open()
            KullaniciSqlDA.Fill(Tablo)
            If Tablo.Rows.Count = 1 AndAlso Tablo.Rows(0)("KullaniciAdi") = KAdi Then
                SifremiUnuttumFormu.KKayitNo = Tablo.Rows(0)("KullaniciKayitNo")
                SifremiUnuttumFormu.KAdi = Tablo.Rows(0)("KullaniciAdi")
                SifremiUnuttumFormu.Soru = Tablo.Rows(0)("GuvenlikSorusu")
                SifremiUnuttumFormu.Cevap = Tablo.Rows(0)("Cevap")
                If SifremiUnuttumFormu.ShowDialog Then
                    SifremiUnuttumFormu.Dispose()
                End If
            Else
                MessageBox.Show("Girmi� oldu�unuz kullan�c� bulunamad�. Tekrar deneyiniz.")
            End If
        Catch ex As Exception
            MessageBox.Show("Hata olu�tu. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
