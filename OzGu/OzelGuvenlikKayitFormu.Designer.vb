<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OzelGuvenlikKayitFormu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OzelGuvenlikKayitFormu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TCKimlikNoTBox = New System.Windows.Forms.TextBox()
        Me.AdiTBox = New System.Windows.Forms.TextBox()
        Me.SoyadiTBox = New System.Windows.Forms.TextBox()
        Me.BabaAdiTBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GuvenlikNoktasiKayitNoCBox = New System.Windows.Forms.ComboBox()
        Me.KanGrubuCBox = New System.Windows.Forms.ComboBox()
        Me.TelefonTBox = New System.Windows.Forms.TextBox()
        Me.AdresiTBox = New System.Windows.Forms.TextBox()
        Me.CinsiyetGBox = New System.Windows.Forms.GroupBox()
        Me.ErkekRBtn = New System.Windows.Forms.RadioButton()
        Me.KadinRBtn = New System.Windows.Forms.RadioButton()
        Me.DogumTarihiDTP = New System.Windows.Forms.DateTimePicker()
        Me.DogumYeriTBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OzGuVTDS = New System.Data.DataSet()
        Me.ButonlarTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.SilBtn = New System.Windows.Forms.Button()
        Me.VazgecBtn = New System.Windows.Forms.Button()
        Me.YeniBtn = New System.Windows.Forms.Button()
        Me.SonBtn = New System.Windows.Forms.Button()
        Me.SonrakiBtn = New System.Windows.Forms.Button()
        Me.OncekiBtn = New System.Windows.Forms.Button()
        Me.ilkBtn = New System.Windows.Forms.Button()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.OzelGuvenlikBilgileriTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuvenlikNoktasiBilgileriTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.CinsiyetGBox.SuspendLayout()
        CType(Me.OzGuVTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButonlarTLP.SuspendLayout()
        CType(Me.OzelGuvenlikBilgileriTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuvenlikNoktasiBilgileriTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TC Kimlik Numarası:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Adı:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Soyadı:"
        '
        'TCKimlikNoTBox
        '
        Me.TCKimlikNoTBox.Location = New System.Drawing.Point(229, 97)
        Me.TCKimlikNoTBox.Name = "TCKimlikNoTBox"
        Me.TCKimlikNoTBox.Size = New System.Drawing.Size(159, 20)
        Me.TCKimlikNoTBox.TabIndex = 11
        '
        'AdiTBox
        '
        Me.AdiTBox.Location = New System.Drawing.Point(229, 133)
        Me.AdiTBox.Name = "AdiTBox"
        Me.AdiTBox.Size = New System.Drawing.Size(229, 20)
        Me.AdiTBox.TabIndex = 12
        '
        'SoyadiTBox
        '
        Me.SoyadiTBox.Location = New System.Drawing.Point(229, 169)
        Me.SoyadiTBox.Name = "SoyadiTBox"
        Me.SoyadiTBox.Size = New System.Drawing.Size(229, 20)
        Me.SoyadiTBox.TabIndex = 13
        '
        'BabaAdiTBox
        '
        Me.BabaAdiTBox.Location = New System.Drawing.Point(229, 205)
        Me.BabaAdiTBox.Name = "BabaAdiTBox"
        Me.BabaAdiTBox.Size = New System.Drawing.Size(229, 20)
        Me.BabaAdiTBox.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(59, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Baba Adı:"
        '
        'GuvenlikNoktasiKayitNoCBox
        '
        Me.GuvenlikNoktasiKayitNoCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GuvenlikNoktasiKayitNoCBox.FormattingEnabled = True
        Me.GuvenlikNoktasiKayitNoCBox.Location = New System.Drawing.Point(229, 528)
        Me.GuvenlikNoktasiKayitNoCBox.Name = "GuvenlikNoktasiKayitNoCBox"
        Me.GuvenlikNoktasiKayitNoCBox.Size = New System.Drawing.Size(414, 21)
        Me.GuvenlikNoktasiKayitNoCBox.TabIndex = 21
        '
        'KanGrubuCBox
        '
        Me.KanGrubuCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KanGrubuCBox.FormattingEnabled = True
        Me.KanGrubuCBox.Items.AddRange(New Object() {"0 Rh (+)", "0 Rh (-)", "A Rh (+)", "A Rh (-)", "B Rh (+)", "B Rh (-)", "AB Rh (+)", "AB Rh (-)"})
        Me.KanGrubuCBox.Location = New System.Drawing.Point(229, 492)
        Me.KanGrubuCBox.Name = "KanGrubuCBox"
        Me.KanGrubuCBox.Size = New System.Drawing.Size(121, 21)
        Me.KanGrubuCBox.TabIndex = 20
        '
        'TelefonTBox
        '
        Me.TelefonTBox.Location = New System.Drawing.Point(229, 452)
        Me.TelefonTBox.Name = "TelefonTBox"
        Me.TelefonTBox.Size = New System.Drawing.Size(151, 20)
        Me.TelefonTBox.TabIndex = 19
        '
        'AdresiTBox
        '
        Me.AdresiTBox.Location = New System.Drawing.Point(229, 347)
        Me.AdresiTBox.Multiline = True
        Me.AdresiTBox.Name = "AdresiTBox"
        Me.AdresiTBox.Size = New System.Drawing.Size(414, 86)
        Me.AdresiTBox.TabIndex = 18
        '
        'CinsiyetGBox
        '
        Me.CinsiyetGBox.Controls.Add(Me.ErkekRBtn)
        Me.CinsiyetGBox.Controls.Add(Me.KadinRBtn)
        Me.CinsiyetGBox.Location = New System.Drawing.Point(229, 298)
        Me.CinsiyetGBox.Name = "CinsiyetGBox"
        Me.CinsiyetGBox.Size = New System.Drawing.Size(121, 38)
        Me.CinsiyetGBox.TabIndex = 17
        Me.CinsiyetGBox.TabStop = False
        '
        'ErkekRBtn
        '
        Me.ErkekRBtn.AutoSize = True
        Me.ErkekRBtn.Location = New System.Drawing.Point(61, 13)
        Me.ErkekRBtn.Name = "ErkekRBtn"
        Me.ErkekRBtn.Size = New System.Drawing.Size(53, 17)
        Me.ErkekRBtn.TabIndex = 1
        Me.ErkekRBtn.TabStop = True
        Me.ErkekRBtn.Text = "&Erkek"
        Me.ErkekRBtn.UseVisualStyleBackColor = True
        '
        'KadinRBtn
        '
        Me.KadinRBtn.AutoSize = True
        Me.KadinRBtn.Location = New System.Drawing.Point(3, 13)
        Me.KadinRBtn.Name = "KadinRBtn"
        Me.KadinRBtn.Size = New System.Drawing.Size(52, 17)
        Me.KadinRBtn.TabIndex = 0
        Me.KadinRBtn.TabStop = True
        Me.KadinRBtn.Text = "&Kadın"
        Me.KadinRBtn.UseVisualStyleBackColor = True
        '
        'DogumTarihiDTP
        '
        Me.DogumTarihiDTP.Location = New System.Drawing.Point(229, 272)
        Me.DogumTarihiDTP.Name = "DogumTarihiDTP"
        Me.DogumTarihiDTP.Size = New System.Drawing.Size(200, 20)
        Me.DogumTarihiDTP.TabIndex = 16
        '
        'DogumYeriTBox
        '
        Me.DogumYeriTBox.Location = New System.Drawing.Point(229, 239)
        Me.DogumYeriTBox.Name = "DogumYeriTBox"
        Me.DogumYeriTBox.Size = New System.Drawing.Size(229, 20)
        Me.DogumYeriTBox.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(59, 531)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Görevli Olduğu Güvenlik Noktası:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(59, 459)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Telefonu:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 495)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Kan Grubu:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Adresi:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Cinsiyeti:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Doğum Tarihi:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Doğum Yeri:"
        '
        'OzGuVTDS
        '
        Me.OzGuVTDS.DataSetName = "NewDataSet"
        '
        'ButonlarTLP
        '
        Me.ButonlarTLP.ColumnCount = 8
        Me.ButonlarTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.ButonlarTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.ButonlarTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.ButonlarTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.ButonlarTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.ButonlarTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.ButonlarTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.ButonlarTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50328!))
        Me.ButonlarTLP.Controls.Add(Me.SilBtn, 6, 0)
        Me.ButonlarTLP.Controls.Add(Me.VazgecBtn, 5, 0)
        Me.ButonlarTLP.Controls.Add(Me.YeniBtn, 4, 0)
        Me.ButonlarTLP.Controls.Add(Me.SonBtn, 3, 0)
        Me.ButonlarTLP.Controls.Add(Me.SonrakiBtn, 2, 0)
        Me.ButonlarTLP.Controls.Add(Me.OncekiBtn, 1, 0)
        Me.ButonlarTLP.Controls.Add(Me.ilkBtn, 0, 0)
        Me.ButonlarTLP.Controls.Add(Me.KaydetBtn, 7, 0)
        Me.ButonlarTLP.Location = New System.Drawing.Point(62, 12)
        Me.ButonlarTLP.Name = "ButonlarTLP"
        Me.ButonlarTLP.RowCount = 1
        Me.ButonlarTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ButonlarTLP.Size = New System.Drawing.Size(764, 66)
        Me.ButonlarTLP.TabIndex = 22
        '
        'SilBtn
        '
        Me.SilBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SilBtn.Image = CType(resources.GetObject("SilBtn.Image"), System.Drawing.Image)
        Me.SilBtn.Location = New System.Drawing.Point(573, 3)
        Me.SilBtn.Name = "SilBtn"
        Me.SilBtn.Size = New System.Drawing.Size(89, 60)
        Me.SilBtn.TabIndex = 7
        Me.SilBtn.Text = "Sil"
        Me.SilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SilBtn.UseVisualStyleBackColor = True
        '
        'VazgecBtn
        '
        Me.VazgecBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VazgecBtn.Image = Global.OzGu.My.Resources.Resources.vazgec
        Me.VazgecBtn.Location = New System.Drawing.Point(478, 3)
        Me.VazgecBtn.Name = "VazgecBtn"
        Me.VazgecBtn.Size = New System.Drawing.Size(89, 60)
        Me.VazgecBtn.TabIndex = 5
        Me.VazgecBtn.Tag = "1"
        Me.VazgecBtn.Text = "Vazgeç"
        Me.VazgecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.VazgecBtn.UseVisualStyleBackColor = True
        '
        'YeniBtn
        '
        Me.YeniBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.YeniBtn.Image = Global.OzGu.My.Resources.Resources.ekle
        Me.YeniBtn.Location = New System.Drawing.Point(383, 3)
        Me.YeniBtn.Name = "YeniBtn"
        Me.YeniBtn.Size = New System.Drawing.Size(89, 60)
        Me.YeniBtn.TabIndex = 4
        Me.YeniBtn.Text = "Yeni Kayıt"
        Me.YeniBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.YeniBtn.UseVisualStyleBackColor = True
        '
        'SonBtn
        '
        Me.SonBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SonBtn.Image = Global.OzGu.My.Resources.Resources.son
        Me.SonBtn.Location = New System.Drawing.Point(288, 3)
        Me.SonBtn.Name = "SonBtn"
        Me.SonBtn.Size = New System.Drawing.Size(89, 60)
        Me.SonBtn.TabIndex = 3
        Me.SonBtn.Text = "Son Kayıt"
        Me.SonBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SonBtn.UseVisualStyleBackColor = True
        '
        'SonrakiBtn
        '
        Me.SonrakiBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SonrakiBtn.Image = Global.OzGu.My.Resources.Resources.sonraki
        Me.SonrakiBtn.Location = New System.Drawing.Point(193, 3)
        Me.SonrakiBtn.Name = "SonrakiBtn"
        Me.SonrakiBtn.Size = New System.Drawing.Size(89, 60)
        Me.SonrakiBtn.TabIndex = 2
        Me.SonrakiBtn.Text = "Sonraki Kayıt"
        Me.SonrakiBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SonrakiBtn.UseVisualStyleBackColor = True
        '
        'OncekiBtn
        '
        Me.OncekiBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OncekiBtn.Image = Global.OzGu.My.Resources.Resources.onceki
        Me.OncekiBtn.Location = New System.Drawing.Point(98, 3)
        Me.OncekiBtn.Name = "OncekiBtn"
        Me.OncekiBtn.Size = New System.Drawing.Size(89, 60)
        Me.OncekiBtn.TabIndex = 1
        Me.OncekiBtn.Text = "Önceki Kayıt"
        Me.OncekiBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.OncekiBtn.UseVisualStyleBackColor = True
        '
        'ilkBtn
        '
        Me.ilkBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ilkBtn.Image = Global.OzGu.My.Resources.Resources.ilk
        Me.ilkBtn.Location = New System.Drawing.Point(3, 3)
        Me.ilkBtn.Name = "ilkBtn"
        Me.ilkBtn.Size = New System.Drawing.Size(89, 60)
        Me.ilkBtn.TabIndex = 0
        Me.ilkBtn.Text = "İlk Kayıt"
        Me.ilkBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ilkBtn.UseVisualStyleBackColor = True
        '
        'KaydetBtn
        '
        Me.KaydetBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KaydetBtn.Image = Global.OzGu.My.Resources.Resources.kaydet
        Me.KaydetBtn.Location = New System.Drawing.Point(668, 3)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(93, 60)
        Me.KaydetBtn.TabIndex = 8
        Me.KaydetBtn.Tag = "1"
        Me.KaydetBtn.Text = "Kaydet"
        Me.KaydetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.KaydetBtn.UseVisualStyleBackColor = True
        '
        'OzelGuvenlikKayitFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1487, 561)
        Me.Controls.Add(Me.ButonlarTLP)
        Me.Controls.Add(Me.BabaAdiTBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GuvenlikNoktasiKayitNoCBox)
        Me.Controls.Add(Me.KanGrubuCBox)
        Me.Controls.Add(Me.TelefonTBox)
        Me.Controls.Add(Me.AdresiTBox)
        Me.Controls.Add(Me.CinsiyetGBox)
        Me.Controls.Add(Me.DogumTarihiDTP)
        Me.Controls.Add(Me.DogumYeriTBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SoyadiTBox)
        Me.Controls.Add(Me.AdiTBox)
        Me.Controls.Add(Me.TCKimlikNoTBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OzelGuvenlikKayitFormu"
        Me.Text = "Özel Güvenlik Görevlisi Kayıt"
        Me.CinsiyetGBox.ResumeLayout(False)
        Me.CinsiyetGBox.PerformLayout()
        CType(Me.OzGuVTDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButonlarTLP.ResumeLayout(False)
        CType(Me.OzelGuvenlikBilgileriTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuvenlikNoktasiBilgileriTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TCKimlikNoTBox As TextBox
    Friend WithEvents AdiTBox As TextBox
    Friend WithEvents SoyadiTBox As TextBox
    Friend WithEvents BabaAdiTBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GuvenlikNoktasiKayitNoCBox As ComboBox
    Friend WithEvents KanGrubuCBox As ComboBox
    Friend WithEvents TelefonTBox As TextBox
    Friend WithEvents AdresiTBox As TextBox
    Friend WithEvents CinsiyetGBox As GroupBox
    Friend WithEvents ErkekRBtn As RadioButton
    Friend WithEvents KadinRBtn As RadioButton
    Friend WithEvents DogumTarihiDTP As DateTimePicker
    Friend WithEvents DogumYeriTBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents OzGuVTDS As DataSet
    Friend WithEvents OzelGuvenlikBilgileriTablosuBS As BindingSource
    Friend WithEvents GuvenlikNoktasiBilgileriTablosuBS As BindingSource
    Friend WithEvents ButonlarTLP As TableLayoutPanel
    Friend WithEvents VazgecBtn As Button
    Friend WithEvents YeniBtn As Button
    Friend WithEvents SonBtn As Button
    Friend WithEvents SonrakiBtn As Button
    Friend WithEvents OncekiBtn As Button
    Friend WithEvents ilkBtn As Button
    Friend WithEvents SilBtn As Button
    Friend WithEvents KaydetBtn As Button
End Class
