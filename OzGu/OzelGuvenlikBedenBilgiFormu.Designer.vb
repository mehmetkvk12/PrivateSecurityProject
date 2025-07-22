<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OzelGuvenlikBedenBilgiFormu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OzelGuvenlikBedenBilgiFormu))
        Me.OzGuVTDS = New System.Data.DataSet()
        Me.OzelGuvenlikBilgileriTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.BedenOlcuTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OlcuBirimTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ozelguvenlikdgv = New System.Windows.Forms.DataGridView()
        Me.bedenolcudgv = New System.Windows.Forms.DataGridView()
        Me.OlcuBirimNoC = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.OlcusuC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OlcuBirimTuruC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AciklamaC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BedenOlcusuKayitNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOSicilNumarasiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCKimlikNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoyadiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BabaAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CinsiyetiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DogumYeriC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DogumTarihiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuvenlikNoktasiAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SicilNumarasiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.OzGuVTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OzelGuvenlikBilgileriTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedenOlcuTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OlcuBirimTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ozelguvenlikdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bedenolcudgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OzGuVTDS
        '
        Me.OzGuVTDS.DataSetName = "NewDataSet"
        '
        'ozelguvenlikdgv
        '
        Me.ozelguvenlikdgv.AllowUserToAddRows = False
        Me.ozelguvenlikdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ozelguvenlikdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TCKimlikNoC, Me.AdiC, Me.SoyadiC, Me.BabaAdiC, Me.CinsiyetiC, Me.DogumYeriC, Me.DogumTarihiC, Me.AdresiC, Me.GuvenlikNoktasiAdiC, Me.SicilNumarasiC})
        Me.ozelguvenlikdgv.Location = New System.Drawing.Point(12, 12)
        Me.ozelguvenlikdgv.Name = "ozelguvenlikdgv"
        Me.ozelguvenlikdgv.ReadOnly = True
        Me.ozelguvenlikdgv.Size = New System.Drawing.Size(824, 129)
        Me.ozelguvenlikdgv.TabIndex = 0
        '
        'bedenolcudgv
        '
        Me.bedenolcudgv.AllowUserToAddRows = False
        Me.bedenolcudgv.AllowUserToDeleteRows = False
        Me.bedenolcudgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bedenolcudgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OlcuBirimNoC, Me.OlcusuC, Me.OlcuBirimTuruC, Me.AciklamaC, Me.BedenOlcusuKayitNoC, Me.BOSicilNumarasiC})
        Me.bedenolcudgv.Location = New System.Drawing.Point(12, 147)
        Me.bedenolcudgv.Name = "bedenolcudgv"
        Me.bedenolcudgv.ReadOnly = True
        Me.bedenolcudgv.Size = New System.Drawing.Size(529, 293)
        Me.bedenolcudgv.TabIndex = 1
        '
        'OlcuBirimNoC
        '
        Me.OlcuBirimNoC.HeaderText = "Ölçü Birimi"
        Me.OlcuBirimNoC.Name = "OlcuBirimNoC"
        Me.OlcuBirimNoC.ReadOnly = True
        '
        'OlcusuC
        '
        Me.OlcusuC.DataPropertyName = "Olcusu"
        Me.OlcusuC.HeaderText = "Beden Ölçüsü"
        Me.OlcusuC.Name = "OlcusuC"
        Me.OlcusuC.ReadOnly = True
        '
        'OlcuBirimTuruC
        '
        Me.OlcuBirimTuruC.DataPropertyName = "OlcuBirimTuru"
        Me.OlcuBirimTuruC.HeaderText = "Birim Türü"
        Me.OlcuBirimTuruC.Name = "OlcuBirimTuruC"
        Me.OlcuBirimTuruC.ReadOnly = True
        '
        'AciklamaC
        '
        Me.AciklamaC.DataPropertyName = "Aciklama"
        Me.AciklamaC.HeaderText = "Açıklama"
        Me.AciklamaC.Name = "AciklamaC"
        Me.AciklamaC.ReadOnly = True
        '
        'BedenOlcusuKayitNoC
        '
        Me.BedenOlcusuKayitNoC.DataPropertyName = "BedenOlcusuKayitNo"
        Me.BedenOlcusuKayitNoC.HeaderText = "Beden Ölçüsü Kayıt No"
        Me.BedenOlcusuKayitNoC.Name = "BedenOlcusuKayitNoC"
        Me.BedenOlcusuKayitNoC.ReadOnly = True
        Me.BedenOlcusuKayitNoC.Visible = False
        '
        'BOSicilNumarasiC
        '
        Me.BOSicilNumarasiC.DataPropertyName = "SicilNumarasi"
        Me.BOSicilNumarasiC.HeaderText = "Sicil Numarası"
        Me.BOSicilNumarasiC.Name = "BOSicilNumarasiC"
        Me.BOSicilNumarasiC.ReadOnly = True
        Me.BOSicilNumarasiC.Visible = False
        '
        'TCKimlikNoC
        '
        Me.TCKimlikNoC.DataPropertyName = "TCKimlikNo"
        Me.TCKimlikNoC.HeaderText = "TC Kimlik Numarası"
        Me.TCKimlikNoC.Name = "TCKimlikNoC"
        Me.TCKimlikNoC.ReadOnly = True
        '
        'AdiC
        '
        Me.AdiC.DataPropertyName = "Adi"
        Me.AdiC.HeaderText = "Adı "
        Me.AdiC.Name = "AdiC"
        Me.AdiC.ReadOnly = True
        '
        'SoyadiC
        '
        Me.SoyadiC.DataPropertyName = "Soyadi"
        Me.SoyadiC.HeaderText = "Soyadı"
        Me.SoyadiC.Name = "SoyadiC"
        Me.SoyadiC.ReadOnly = True
        '
        'BabaAdiC
        '
        Me.BabaAdiC.DataPropertyName = "BabaAdi"
        Me.BabaAdiC.HeaderText = "Baba Adı"
        Me.BabaAdiC.Name = "BabaAdiC"
        Me.BabaAdiC.ReadOnly = True
        '
        'CinsiyetiC
        '
        Me.CinsiyetiC.DataPropertyName = "Cinsiyeti"
        Me.CinsiyetiC.HeaderText = "Cinsiyet"
        Me.CinsiyetiC.Name = "CinsiyetiC"
        Me.CinsiyetiC.ReadOnly = True
        '
        'DogumYeriC
        '
        Me.DogumYeriC.DataPropertyName = "DogumYeri"
        Me.DogumYeriC.HeaderText = "Doğum Yeri"
        Me.DogumYeriC.Name = "DogumYeriC"
        Me.DogumYeriC.ReadOnly = True
        '
        'DogumTarihiC
        '
        Me.DogumTarihiC.DataPropertyName = "DogumTarihi"
        Me.DogumTarihiC.HeaderText = "Doğum Tarihi"
        Me.DogumTarihiC.Name = "DogumTarihiC"
        Me.DogumTarihiC.ReadOnly = True
        '
        'AdresiC
        '
        Me.AdresiC.DataPropertyName = "Adresi"
        Me.AdresiC.HeaderText = "Adresi"
        Me.AdresiC.Name = "AdresiC"
        Me.AdresiC.ReadOnly = True
        '
        'GuvenlikNoktasiAdiC
        '
        Me.GuvenlikNoktasiAdiC.DataPropertyName = "GuvenlikNoktasiAdi"
        Me.GuvenlikNoktasiAdiC.HeaderText = "Güvenlik Noktası"
        Me.GuvenlikNoktasiAdiC.Name = "GuvenlikNoktasiAdiC"
        Me.GuvenlikNoktasiAdiC.ReadOnly = True
        '
        'SicilNumarasiC
        '
        Me.SicilNumarasiC.DataPropertyName = "SicilNumarasi"
        Me.SicilNumarasiC.HeaderText = "Sicil Numarası"
        Me.SicilNumarasiC.Name = "SicilNumarasiC"
        Me.SicilNumarasiC.ReadOnly = True
        Me.SicilNumarasiC.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(611, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 58)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OzelGuvenlikBedenBilgiFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 437)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bedenolcudgv)
        Me.Controls.Add(Me.ozelguvenlikdgv)
        Me.Name = "OzelGuvenlikBedenBilgiFormu"
        Me.Text = "Özel Guvenlik Beden Ölçüsü Bilgileri"
        CType(Me.OzGuVTDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OzelGuvenlikBilgileriTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedenOlcuTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OlcuBirimTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ozelguvenlikdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bedenolcudgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OzGuVTDS As DataSet
    Friend WithEvents OzelGuvenlikBilgileriTablosuBS As BindingSource
    Friend WithEvents BedenOlcuTablosuBS As BindingSource
    Friend WithEvents OlcuBirimTablosuBS As BindingSource
    Friend WithEvents ozelguvenlikdgv As DataGridView
    Friend WithEvents bedenolcudgv As DataGridView
    Friend WithEvents OlcuBirimNoC As DataGridViewComboBoxColumn
    Friend WithEvents OlcusuC As DataGridViewTextBoxColumn
    Friend WithEvents OlcuBirimTuruC As DataGridViewTextBoxColumn
    Friend WithEvents AciklamaC As DataGridViewTextBoxColumn
    Friend WithEvents BedenOlcusuKayitNoC As DataGridViewTextBoxColumn
    Friend WithEvents BOSicilNumarasiC As DataGridViewTextBoxColumn
    Friend WithEvents TCKimlikNoC As DataGridViewTextBoxColumn
    Friend WithEvents AdiC As DataGridViewTextBoxColumn
    Friend WithEvents SoyadiC As DataGridViewTextBoxColumn
    Friend WithEvents BabaAdiC As DataGridViewTextBoxColumn
    Friend WithEvents CinsiyetiC As DataGridViewTextBoxColumn
    Friend WithEvents DogumYeriC As DataGridViewTextBoxColumn
    Friend WithEvents DogumTarihiC As DataGridViewTextBoxColumn
    Friend WithEvents AdresiC As DataGridViewTextBoxColumn
    Friend WithEvents GuvenlikNoktasiAdiC As DataGridViewTextBoxColumn
    Friend WithEvents SicilNumarasiC As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
