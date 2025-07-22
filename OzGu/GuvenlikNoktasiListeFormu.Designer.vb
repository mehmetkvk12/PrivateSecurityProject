<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuvenlikNoktasiListeFormu
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OzguVTDS = New System.Data.DataSet()
        Me.GuvenlikNoktasiBilgileriDGV = New System.Windows.Forms.DataGridView()
        Me.GuvenlikNoktasiKayitNoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuvenlikNoktasiAdiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuvenlikNoktasiAdresiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuvenlikNoktasiTelefonC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuvenlikNoktasiizinTarihiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuvenlikNoktasiizinNumarasiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuvenlikNoktasiPersonelSayisiC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuvenlikSefiSicilNumarasiC = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GuvenlikNoktasiAdiTBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AraBtn = New System.Windows.Forms.Button()
        Me.GuvenlikNoktasiBilgileriTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.OzelGuvenlikBilgileriTablosuBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.OzguVTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuvenlikNoktasiBilgileriDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuvenlikNoktasiBilgileriTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OzelGuvenlikBilgileriTablosuBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(689, 276)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(246, 39)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(117, 33)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Tamam"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(126, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(117, 33)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Vazgeç"
        '
        'OzguVTDS
        '
        Me.OzguVTDS.DataSetName = "NewDataSet"
        '
        'GuvenlikNoktasiBilgileriDGV
        '
        Me.GuvenlikNoktasiBilgileriDGV.AllowUserToAddRows = False
        Me.GuvenlikNoktasiBilgileriDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GuvenlikNoktasiBilgileriDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.GuvenlikNoktasiBilgileriDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GuvenlikNoktasiBilgileriDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GuvenlikNoktasiKayitNoC, Me.GuvenlikNoktasiAdiC, Me.GuvenlikNoktasiAdresiC, Me.GuvenlikNoktasiTelefonC, Me.GuvenlikNoktasiizinTarihiC, Me.GuvenlikNoktasiizinNumarasiC, Me.GuvenlikNoktasiPersonelSayisiC, Me.GuvenlikSefiSicilNumarasiC})
        Me.GuvenlikNoktasiBilgileriDGV.Location = New System.Drawing.Point(15, 45)
        Me.GuvenlikNoktasiBilgileriDGV.MultiSelect = False
        Me.GuvenlikNoktasiBilgileriDGV.Name = "GuvenlikNoktasiBilgileriDGV"
        Me.GuvenlikNoktasiBilgileriDGV.ReadOnly = True
        Me.GuvenlikNoktasiBilgileriDGV.RowHeadersVisible = False
        Me.GuvenlikNoktasiBilgileriDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GuvenlikNoktasiBilgileriDGV.Size = New System.Drawing.Size(920, 225)
        Me.GuvenlikNoktasiBilgileriDGV.TabIndex = 1
        '
        'GuvenlikNoktasiKayitNoC
        '
        Me.GuvenlikNoktasiKayitNoC.DataPropertyName = "GuvenlikNoktasiKayitNo"
        Me.GuvenlikNoktasiKayitNoC.HeaderText = "Güvenlik Noktası Kayıt No"
        Me.GuvenlikNoktasiKayitNoC.Name = "GuvenlikNoktasiKayitNoC"
        Me.GuvenlikNoktasiKayitNoC.ReadOnly = True
        Me.GuvenlikNoktasiKayitNoC.Visible = False
        '
        'GuvenlikNoktasiAdiC
        '
        Me.GuvenlikNoktasiAdiC.DataPropertyName = "GuvenlikNoktasiAdi"
        Me.GuvenlikNoktasiAdiC.HeaderText = "Güvenlik Noktası Adı"
        Me.GuvenlikNoktasiAdiC.Name = "GuvenlikNoktasiAdiC"
        Me.GuvenlikNoktasiAdiC.ReadOnly = True
        Me.GuvenlikNoktasiAdiC.Width = 250
        '
        'GuvenlikNoktasiAdresiC
        '
        Me.GuvenlikNoktasiAdresiC.DataPropertyName = "GuvenlikNoktasiAdresi"
        Me.GuvenlikNoktasiAdresiC.HeaderText = "Güvenlik Noktası Adresi"
        Me.GuvenlikNoktasiAdresiC.Name = "GuvenlikNoktasiAdresiC"
        Me.GuvenlikNoktasiAdresiC.ReadOnly = True
        Me.GuvenlikNoktasiAdresiC.Width = 300
        '
        'GuvenlikNoktasiTelefonC
        '
        Me.GuvenlikNoktasiTelefonC.DataPropertyName = "GuvenlikNoktasiTelefon"
        Me.GuvenlikNoktasiTelefonC.HeaderText = "Telefon"
        Me.GuvenlikNoktasiTelefonC.Name = "GuvenlikNoktasiTelefonC"
        Me.GuvenlikNoktasiTelefonC.ReadOnly = True
        Me.GuvenlikNoktasiTelefonC.Width = 70
        '
        'GuvenlikNoktasiizinTarihiC
        '
        Me.GuvenlikNoktasiizinTarihiC.DataPropertyName = "GuvenlikNoktasiizinTarihi"
        Me.GuvenlikNoktasiizinTarihiC.HeaderText = "İzin Tarihi"
        Me.GuvenlikNoktasiizinTarihiC.Name = "GuvenlikNoktasiizinTarihiC"
        Me.GuvenlikNoktasiizinTarihiC.ReadOnly = True
        '
        'GuvenlikNoktasiizinNumarasiC
        '
        Me.GuvenlikNoktasiizinNumarasiC.DataPropertyName = "GuvenlikNoktasiizinNumarasi"
        Me.GuvenlikNoktasiizinNumarasiC.HeaderText = "İzin Numarası"
        Me.GuvenlikNoktasiizinNumarasiC.Name = "GuvenlikNoktasiizinNumarasiC"
        Me.GuvenlikNoktasiizinNumarasiC.ReadOnly = True
        '
        'GuvenlikNoktasiPersonelSayisiC
        '
        Me.GuvenlikNoktasiPersonelSayisiC.DataPropertyName = "GuvenlikNoktasiPersonelSayisi"
        Me.GuvenlikNoktasiPersonelSayisiC.HeaderText = "Personel Sayısı"
        Me.GuvenlikNoktasiPersonelSayisiC.Name = "GuvenlikNoktasiPersonelSayisiC"
        Me.GuvenlikNoktasiPersonelSayisiC.ReadOnly = True
        Me.GuvenlikNoktasiPersonelSayisiC.Width = 70
        '
        'GuvenlikSefiSicilNumarasiC
        '
        Me.GuvenlikSefiSicilNumarasiC.DataPropertyName = "GuvenlikSefiSicilNumarasi"
        Me.GuvenlikSefiSicilNumarasiC.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.GuvenlikSefiSicilNumarasiC.HeaderText = "Güvenlik Şefi"
        Me.GuvenlikSefiSicilNumarasiC.Name = "GuvenlikSefiSicilNumarasiC"
        Me.GuvenlikSefiSicilNumarasiC.ReadOnly = True
        Me.GuvenlikSefiSicilNumarasiC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GuvenlikSefiSicilNumarasiC.Width = 150
        '
        'GuvenlikNoktasiAdiTBox
        '
        Me.GuvenlikNoktasiAdiTBox.Location = New System.Drawing.Point(125, 18)
        Me.GuvenlikNoktasiAdiTBox.Name = "GuvenlikNoktasiAdiTBox"
        Me.GuvenlikNoktasiAdiTBox.Size = New System.Drawing.Size(454, 20)
        Me.GuvenlikNoktasiAdiTBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Güvenlik Noktası Adı:"
        '
        'AraBtn
        '
        Me.AraBtn.FlatAppearance.BorderSize = 0
        Me.AraBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AraBtn.Image = Global.OzGu.My.Resources.Resources.ara
        Me.AraBtn.Location = New System.Drawing.Point(579, 12)
        Me.AraBtn.Name = "AraBtn"
        Me.AraBtn.Size = New System.Drawing.Size(57, 31)
        Me.AraBtn.TabIndex = 3
        Me.AraBtn.Text = "Ara"
        Me.AraBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AraBtn.UseVisualStyleBackColor = True
        '
        'GuvenlikNoktasiListeFormu
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(947, 327)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AraBtn)
        Me.Controls.Add(Me.GuvenlikNoktasiAdiTBox)
        Me.Controls.Add(Me.GuvenlikNoktasiBilgileriDGV)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GuvenlikNoktasiListeFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Güvenlik Noktası Listesi"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.OzguVTDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuvenlikNoktasiBilgileriDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuvenlikNoktasiBilgileriTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OzelGuvenlikBilgileriTablosuBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OzguVTDS As DataSet
    Friend WithEvents GuvenlikNoktasiBilgileriTablosuBS As BindingSource
    Friend WithEvents GuvenlikNoktasiBilgileriDGV As DataGridView
    Friend WithEvents OzelGuvenlikBilgileriTablosuBS As BindingSource
    Friend WithEvents GuvenlikNoktasiKayitNoC As DataGridViewTextBoxColumn
    Friend WithEvents GuvenlikNoktasiAdiC As DataGridViewTextBoxColumn
    Friend WithEvents GuvenlikNoktasiAdresiC As DataGridViewTextBoxColumn
    Friend WithEvents GuvenlikNoktasiTelefonC As DataGridViewTextBoxColumn
    Friend WithEvents GuvenlikNoktasiizinTarihiC As DataGridViewTextBoxColumn
    Friend WithEvents GuvenlikNoktasiizinNumarasiC As DataGridViewTextBoxColumn
    Friend WithEvents GuvenlikNoktasiPersonelSayisiC As DataGridViewTextBoxColumn
    Friend WithEvents GuvenlikSefiSicilNumarasiC As DataGridViewComboBoxColumn
    Friend WithEvents GuvenlikNoktasiAdiTBox As TextBox
    Friend WithEvents AraBtn As Button
    Friend WithEvents Label1 As Label
End Class
