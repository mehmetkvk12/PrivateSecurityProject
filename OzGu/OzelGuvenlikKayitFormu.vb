Imports System.Data.SqlClient
Public Class OzelGuvenlikKayitFormu
    Private OzelGuvenlikBilgileriSqlDA As SqlDataAdapter
    Private Sub OzelGuvenlikKayitFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlBaglanti As New SqlConnection(SqlBaglantiCumlesi())
        Try
            SqlBaglanti.Open()
            GuvenlikNoktasiBilgileriniGetir()
            'Sorguda ki ,CASE WHEN Cinsiyet=0 THEN 1 ELSE 0 END AS NotCinsiyet Cinsiyet alanının tersi olan bir alan oluşturmak için yazıldı
            'İhtiyacınız yoksa bu alanı yazmaya gerek yoktur. Biz RadioButton kullanacağımız için yazdık ComboBox kullansak gerek olmazdı.
            Dim Sorgu As String = "SELECT *,CASE WHEN Cinsiyet=0 THEN 1 ELSE 0 END AS NotCinsiyet FROM OzelGuvenlikBilgileriTablosu ORDER BY Adi,Soyadi"

            OzelGuvenlikBilgileriSqlDA = New SqlDataAdapter(Sorgu, SqlBaglanti)

            'Kayıt Ekleme,Güncelleme ve Silme İşlemlerinde kullanılacak Komutları SQLDataAdapter nesnesine ekle
            Dim SqlKomutOlustrurucu As New SqlCommandBuilder(OzelGuvenlikBilgileriSqlDA)
            OzelGuvenlikBilgileriSqlDA.InsertCommand = SqlKomutOlustrurucu.GetInsertCommand
            OzelGuvenlikBilgileriSqlDA.UpdateCommand = SqlKomutOlustrurucu.GetUpdateCommand
            OzelGuvenlikBilgileriSqlDA.DeleteCommand = SqlKomutOlustrurucu.GetDeleteCommand
            'Tablodaki kayıtları DataSet nesnesi içine tablo olarak ekle
            OzelGuvenlikBilgileriSqlDA.Fill(OzGuVTDS, "OzelGuvenlikBilgileriTablosu")
            'DataSet nesnesine eklediğimiz tablo ile BindingSource nesnemizi ilişkilendiriyoruz.
            OzelGuvenlikBilgileriTablosuBS.DataSource = OzGuVTDS.Tables("OzelGuvenlikBilgileriTablosu")
            'GuvenlikNoktasiKayıtNumarasiCBox içinde GuvenlikNoktasiBilgileriTablosu içindeki kayıtları görüntülemek için
            NesneleriBagla()
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu.Lütfen Sistem Yöneticiniz ile bağlantı kurunuz. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub
    Private Sub NesneleriBagla()
        'NesneAdi.DataBindings.Add("Bağlantı Kurulacak Özellik", BindingSource Adı, "Tablodaki Alan Adı")
        TCKimlikNoTBox.DataBindings.Add("Text", OzelGuvenlikBilgileriTablosuBS, "TCKimlikNo")
        AdiTBox.DataBindings.Add("Text", OzelGuvenlikBilgileriTablosuBS, "Adi")
        SoyadiTBox.DataBindings.Add("Text", OzelGuvenlikBilgileriTablosuBS, "Soyadi")
        BabaAdiTBox.DataBindings.Add("Text", OzelGuvenlikBilgileriTablosuBS, "BabaAdi")
        DogumYeriTBox.DataBindings.Add("Text", OzelGuvenlikBilgileriTablosuBS, "DogumYeri")
        DogumTarihiDTP.DataBindings.Add("Value", OzelGuvenlikBilgileriTablosuBS, "DogumTarihi", True)
        AdresiTBox.DataBindings.Add("Text", OzelGuvenlikBilgileriTablosuBS, "Adresi")
        KanGrubuCBox.DataBindings.Add("SelectedItem", OzelGuvenlikBilgileriTablosuBS, "KanGrubu")
        TelefonTBox.DataBindings.Add("Text", OzelGuvenlikBilgileriTablosuBS, "Telefon")

        'Cinsiyet alanını bağla
        KadinRBtn.DataBindings.Add("Checked", OzelGuvenlikBilgileriTablosuBS, "Cinsiyet", True)
        ErkekRBtn.DataBindings.Add("Checked", OzelGuvenlikBilgileriTablosuBS, "NotCinsiyet", True) 'Select ile oluşturulan alan

        'GuvenlikNoktasiKayıtNumarasiCBox için Gerekli Bağlantılar (LookUpComBox Yapma)
        GuvenlikNoktasiKayitNoCBox.DataBindings.Add("SelectedValue", OzelGuvenlikBilgileriTablosuBS, "GuvenlikNoktasiKayitNo")
        'Diğer tablodan bilgilerin gelmesi ve ComboBox'ta görüntülenmesini sağlayan kodlar
        GuvenlikNoktasiKayitNoCBox.DataSource = GuvenlikNoktasiBilgileriTablosuBS
        GuvenlikNoktasiKayitNoCBox.DisplayMember = "GuvenlikNoktasiAdi" 'Kullanıcının görmesini istediğimiz alanı yazıyoruz
        GuvenlikNoktasiKayitNoCBox.ValueMember = "GuvenlikNoktasiKayitNo"
        'Ana tablo ile ilişkili olan anı yazıyoruz. DataBindings'te SelectedValue ile bağladığımız alan ile ilişkili alan yazılacak.
    End Sub
    Private Sub GuvenlikNoktasiBilgileriniGetir()
        Dim SqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM GuvenlikNoktasiBilgileriTablosu"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        SqlBaglanti.Open()
        If Not OzGuVTDS.Tables.Contains("GuvenlikNoktasiBilgileriTablosu") Then
            OzGuVTDS.Tables.Add("GuvenlikNoktasiBilgileriTablosu")
        Else
            OzGuVTDS.Tables("GuvenlikNoktasiBilgileriTablosu").Clear()
        End If
        OzGuVTDS.Tables("GuvenlikNoktasiBilgileriTablosu").Load(SqlKomut.ExecuteReader)
        GuvenlikNoktasiBilgileriTablosuBS.DataSource = OzGuVTDS.Tables("GuvenlikNoktasiBilgileriTablosu")
    End Sub

    Private Sub ilkBtn_Click(sender As Object, e As EventArgs) Handles ilkBtn.Click
        OzelGuvenlikBilgileriTablosuBS.MoveFirst()
    End Sub

    Private Sub OncekiBtn_Click(sender As Object, e As EventArgs) Handles OncekiBtn.Click
        OzelGuvenlikBilgileriTablosuBS.MovePrevious()
    End Sub

    Private Sub SonrakiBtn_Click(sender As Object, e As EventArgs) Handles SonrakiBtn.Click
        OzelGuvenlikBilgileriTablosuBS.MoveNext()
    End Sub

    Private Sub SonBtn_Click(sender As Object, e As EventArgs) Handles SonBtn.Click
        OzelGuvenlikBilgileriTablosuBS.MoveLast()
    End Sub

    Private Sub YeniBtn_Click(sender As Object, e As EventArgs) Handles YeniBtn.Click
        OzelGuvenlikBilgileriTablosuBS.AddNew()
        'Vazgeç ve Kaydet Butonlarının Tag özeliklerini 1 olarak değiştirdik
        For Each Btn As Button In ButonlarTLP.Controls.OfType(Of Button)
            If Btn.Tag <> 1 Then
                Btn.Enabled = False
            Else
                Btn.Enabled = True
            End If
        Next
    End Sub
    Private Sub ButonlariKullan()
        For Each Btn As Button In ButonlarTLP.Controls.OfType(Of Button)
            Btn.Enabled = True
        Next
    End Sub
    Private Sub VazgecBtn_Click(sender As Object, e As EventArgs) Handles VazgecBtn.Click
        'BindingSource üzerindeki mevcut aktif kaydın bilgilerine ulaşmak
        Dim Satir As DataRowView = OzelGuvenlikBilgileriTablosuBS.Current
        Dim AdiSoyadi As String = Satir("Adi") & " " & Satir("Soyadi") 'Parantez içine tablodaki alan adını yazarak bilgi okunabilir.
        Dim Mesaj As String = String.Format("{0} isimli Özel Güvenliğe ait bilgiler üzerinde yaptığınız değişiklikleri iptal etmek istiyor musunuz?", AdiSoyadi)
        If MessageBox.Show(Mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            OzelGuvenlikBilgileriTablosuBS.CancelEdit()
            ButonlariKullan()
        End If
    End Sub

    Private Sub SilBtn_Click(sender As Object, e As EventArgs) Handles SilBtn.Click
        Dim Satir As DataRowView = OzelGuvenlikBilgileriTablosuBS.Current
        Dim Mesaj As String = String.Format("{0} {1} isimli Özel Güvenliği silmek istediğinize emin misiniz?", Satir("Adi"), Satir("Soyadi"))
        If MessageBox.Show(Mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            OzelGuvenlikBilgileriTablosuBS.RemoveCurrent()
            VTyeKaydet()
        End If
    End Sub
    Private Sub VTyeKaydet()
        Try
            Me.Validate()
            OzelGuvenlikBilgileriTablosuBS.EndEdit()
            If OzelGuvenlikBilgileriSqlDA.Update(OzGuVTDS, "OzelGuvenlikBilgileriTablosu") > 0 Then
                MessageBox.Show("Yapılan tüm değişiklikler başarı ile kaydedildi.", "Bilgi")
                ButonlariKullan()
            End If
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        End Try
    End Sub

    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        VTyeKaydet()
    End Sub
End Class