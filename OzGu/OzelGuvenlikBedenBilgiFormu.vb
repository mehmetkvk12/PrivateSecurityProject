Imports System.Data.SqlClient
Public Class OzelGuvenlikBedenBilgiFormu
    Private Sub OzelGuvenlikBedenBilgiFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OzelGuvenlikBilgileriniGetir()
        BedenOlcuBilgileriniGetir()
        OlcuBirimBilgileriniGetir()
        AtaveiliskiOlustur()
        NesneleriBagla()
    End Sub
    Private Sub OzelGuvenlikBilgileriniGetir()
        Dim SqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim Sorgu As String = "SELECT OGBT.*, GNBT.GuvenlikNoktasiAdi
SELECT *,CASE WHEN Cinsiyet=0 THEN 'Erkek' ELSE 'Kadın' END AS Cinsiyeti
FROM OzelGuvenlikBilgileriTablosu OGBT
INNER JOIN GuvenlikNoktasiBilgileriTablosu GNBT
ON OGBT.GuvenlikNoktasiKayitNo=GNBT.GuvenlikNoktasiKayitNo
Order By Adi, Soyadi"
        Dim OGBTSqlDA As New SqlDataAdapter(Sorgu, SqlBaglanti)
        Try
            SqlBaglanti.Open()
            OGBTSqlDA.Fill(OzGuVTDS, "OzelGuvenlikBilgileriTablosu")
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub

    Private Sub BedenOlcuBilgileriniGetir()
        Dim SqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM BedenOlcuTablosu"
        Dim OGBTSqlDA As New SqlDataAdapter(Sorgu, SqlBaglanti)
        Try
            SqlBaglanti.Open()
            OGBTSqlDA.Fill(OzGuVTDS, "BedenOlcuTablosu")
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub



    Private Sub OlcuBirimBilgileriniGetir()
        Dim SqlBaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM OlcuBirimTablosu"
        Dim OGBTSqlDA As New SqlDataAdapter(Sorgu, SqlBaglanti)
        Try
            SqlBaglanti.Open()
            OGBTSqlDA.Fill(OzGuVTDS, "OlcuBirimTablosu")
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub
    Private Sub AtaveiliskiOlustur()
        OzelGuvenlikBilgileriTablosuBS.DataSource = OzGuVTDS.Tables("OzelGuvenlikBilgileriTablosu")
        '************* İlişki Oluştur ********************
        ' sağ tıkla snipped > İnsert snipped > Data > Designer Ado.Net > Create A Datarelation
        Dim OzelGuvenlikBedenOlcu As New DataRelation("OzelGuvenlikBedenOlcuRelation",
                OzGuVTDS.Tables("OzelGuvenlikBilgileriTablosu").Columns("SicilNumarasi"),'Burda Sıra Önemli
                OzGuVTDS.Tables("BedenOlcuTablosu").Columns("SicilNumarasi"))

        OzGuVTDS.Relations.Add(OzelGuvenlikBedenOlcu)


        '**************************************************

        BedenOlcuTablosuBS.DataSource = OzelGuvenlikBilgileriTablosuBS
        BedenOlcuTablosuBS.DataMember = "OzelGuvenlikBedenOlcuRelation"  'İlişkinin adı

        BedenOlcuTablosuBS.DataSource = OzGuVTDS.Tables("OlcuBirimTablosu")
    End Sub
    Private Sub NesneleriBagla()


        ozelguvenlikdgv.AutoGenerateColumns = False
        bedenolcudgv.AutoGenerateColumns = False

        ozelguvenlikdgv.DataSource = OzelGuvenlikBilgileriTablosuBS
        bedenolcudgv.DataSource = BedenOlcuTablosuBS

        Dim OlcuBirimKolon As DataGridViewComboBoxColumn
        OlcuBirimKolon.DataPropertyName = "OlcuBirimNo"
        OlcuBirimKolon.DisplayMember = "OlcuBirimAdi"
        OlcuBirimKolon.ValueMember = "OlcuBirimNo"
        OlcuBirimKolon.DataSource = OlcuBirimTablosuBS

    End Sub
End Class