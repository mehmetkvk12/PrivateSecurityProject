Imports System.Data.SqlClient
Public Class GuvenlikNoktasiListeFormu
    Public GuvenlikNoktasiKNo As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If GuvenlikNoktasiBilgileriDGV.SelectedRows.Count = 1 Then
            'DataGridView'den seçilen satırın bilgilerini okuma
            Dim DGVSatir As DataGridViewRow = GuvenlikNoktasiBilgileriDGV.SelectedRows(0)
            'GuvenlikNoktasiBilgileriDGV'nin MultiSelect özelliğini False yaptığımızdan birden fazla seçim yapılamaz
            GuvenlikNoktasiKNo = DGVSatir.Cells("GuvenlikNoktasiKayitNoC").Value
            'GuvenlikNoktasiKayitNoC DataGridView'de sütuna verdiğimiz isim tablodaki alan adı değil
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Öncelikle bir güvenlik noktası seçmelisiniz.", "Uyarı")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub GuvenlikNoktasiListeFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM GuvenlikNoktasiBilgileriTablosu ORDER BY GuvenlikNoktasiAdi"
        Dim GuvenlikNoktasiBilgileriTablosuSqlDA As New SqlDataAdapter(Sorgu, SqlBaglanti)
        Try
            SqlBaglanti.Open()
            GuvenlikNoktasiBilgileriTablosuSqlDA.Fill(OzguVTDS, "GuvenlikNoktasiBilgileriTablosu")
            GuvenlikNoktasiBilgileriTablosuBS.DataSource = OzguVTDS.Tables("GuvenlikNoktasiBilgileriTablosu")
            OzelGuvenlikBilgileriniGetir()
            NesneleriBagla()
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu.Lütfen Sistem Yöneticiniz ile bağlantı kurunuz. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub
    Private Sub OzelGuvenlikBilgileriniGetir()
        Dim SqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim Sorgu As String = "SELECT *,Adi+' '+Soyadi AS AdiSoyadi FROM OzelGuvenlikBilgileriTablosu"
        Dim SqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        If Not OzguVTDS.Tables.Contains("OzelGuvenlikBilgileriTablosu") Then
            OzguVTDS.Tables.Add("OzelGuvenlikBilgileriTablosu")
        Else
            OzguVTDS.Tables("OzelGuvenlikBilgileriTablosu").Clear()
        End If
        SqlBaglanti.Open()
        OzguVTDS.Tables("OzelGuvenlikBilgileriTablosu").Load(SqlKomut.ExecuteReader)
        OzelGuvenlikBilgileriTablosuBS.DataSource = OzguVTDS.Tables("OzelGuvenlikBilgileriTablosu")
        SqlBaglanti.Close()
    End Sub
    Private Sub NesneleriBagla()
        GuvenlikNoktasiBilgileriDGV.AutoGenerateColumns = False

        'Kolon Türü DataGridViewComboBoxColumn olan GuvenlikSefiSicilNumrasiC alanını bağlama
        GuvenlikSefiSicilNumarasiC.DataSource = OzelGuvenlikBilgileriTablosuBS
        GuvenlikSefiSicilNumarasiC.DisplayMember = "AdiSoyadi"
        GuvenlikSefiSicilNumarasiC.ValueMember = "SicilNumarasi"

        GuvenlikNoktasiBilgileriDGV.DataSource = GuvenlikNoktasiBilgileriTablosuBS
    End Sub


    Private Sub AraBtn_Click(sender As Object, e As EventArgs) Handles AraBtn.Click
        'BindingSource üzerinde arama yapmak
        '1. Yöntem BindingSource'e Filtre Uygulamak
        GuvenlikNoktasiBilgileriTablosuBS.Filter = String.Format("GuvenlikNoktasiAdi LIKE '%{0}%'", GuvenlikNoktasiAdiTBox.Text)

        '2. Yöntem BindingSource içinde arama yapmak
        'Dim SiraNo As Integer = GuvenlikNoktasiBilgileriTablosuBS.Find("GuvenlikNoktasiAdi", GuvenlikNoktasiAdiTBox.Text)
        'If SiraNo <> -1 Then
        'GuvenlikNoktasiBilgileriDGV.Rows(SiraNo).Selected = True 'Bu iki satırdan birini kullanın
        'GuvenlikNoktasiBilgileriTablosuBS.Position = SiraNo 'Bu iki satırdan birini kullanın
        'End If
    End Sub
End Class
