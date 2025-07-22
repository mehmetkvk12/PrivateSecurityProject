<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaForm
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
        Me.AnaMenu = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖzelGüvenlikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖzelGüvenlikKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GüvenlikNoktasıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GüvenlikNoktasıKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GüvenlikNoktasıListesiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖzelGüvenlikBedenÖlçüBilgileriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnaMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'AnaMenu
        '
        Me.AnaMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.ÖzelGüvenlikToolStripMenuItem, Me.GüvenlikNoktasıToolStripMenuItem})
        Me.AnaMenu.Location = New System.Drawing.Point(0, 0)
        Me.AnaMenu.Name = "AnaMenu"
        Me.AnaMenu.Size = New System.Drawing.Size(800, 24)
        Me.AnaMenu.TabIndex = 1
        Me.AnaMenu.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KapatToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "&Program"
        '
        'KapatToolStripMenuItem
        '
        Me.KapatToolStripMenuItem.Name = "KapatToolStripMenuItem"
        Me.KapatToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.KapatToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.KapatToolStripMenuItem.Text = "&Kapat"
        '
        'ÖzelGüvenlikToolStripMenuItem
        '
        Me.ÖzelGüvenlikToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖzelGüvenlikKaydıToolStripMenuItem, Me.ÖzelGüvenlikBedenÖlçüBilgileriToolStripMenuItem})
        Me.ÖzelGüvenlikToolStripMenuItem.Name = "ÖzelGüvenlikToolStripMenuItem"
        Me.ÖzelGüvenlikToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.ÖzelGüvenlikToolStripMenuItem.Text = "Özel &Güvenlik"
        '
        'ÖzelGüvenlikKaydıToolStripMenuItem
        '
        Me.ÖzelGüvenlikKaydıToolStripMenuItem.Name = "ÖzelGüvenlikKaydıToolStripMenuItem"
        Me.ÖzelGüvenlikKaydıToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.ÖzelGüvenlikKaydıToolStripMenuItem.Text = "Özel Güvenlik &Kaydı-"
        '
        'GüvenlikNoktasıToolStripMenuItem
        '
        Me.GüvenlikNoktasıToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GüvenlikNoktasıKaydıToolStripMenuItem, Me.ToolStripMenuItem1, Me.GüvenlikNoktasıListesiToolStripMenuItem})
        Me.GüvenlikNoktasıToolStripMenuItem.Name = "GüvenlikNoktasıToolStripMenuItem"
        Me.GüvenlikNoktasıToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.GüvenlikNoktasıToolStripMenuItem.Text = "Güvenlik &Noktası"
        '
        'GüvenlikNoktasıKaydıToolStripMenuItem
        '
        Me.GüvenlikNoktasıKaydıToolStripMenuItem.Name = "GüvenlikNoktasıKaydıToolStripMenuItem"
        Me.GüvenlikNoktasıKaydıToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.GüvenlikNoktasıKaydıToolStripMenuItem.Text = "Güvenlik Noktası &Kaydı"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(195, 6)
        '
        'GüvenlikNoktasıListesiToolStripMenuItem
        '
        Me.GüvenlikNoktasıListesiToolStripMenuItem.Name = "GüvenlikNoktasıListesiToolStripMenuItem"
        Me.GüvenlikNoktasıListesiToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.GüvenlikNoktasıListesiToolStripMenuItem.Text = "Güvenlik Noktası &Listesi"
        '
        'ÖzelGüvenlikBedenÖlçüBilgileriToolStripMenuItem
        '
        Me.ÖzelGüvenlikBedenÖlçüBilgileriToolStripMenuItem.Name = "ÖzelGüvenlikBedenÖlçüBilgileriToolStripMenuItem"
        Me.ÖzelGüvenlikBedenÖlçüBilgileriToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.ÖzelGüvenlikBedenÖlçüBilgileriToolStripMenuItem.Text = "Özel Güvenlik Beden Ölçü Bilgileri"
        '
        'AnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AnaMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.AnaMenu
        Me.Name = "AnaForm"
        Me.Text = "ÖzGü Özel Güvenlik Kayıt ve Takip Sistemi"
        Me.AnaMenu.ResumeLayout(False)
        Me.AnaMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AnaMenu As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KapatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÖzelGüvenlikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÖzelGüvenlikKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GüvenlikNoktasıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GüvenlikNoktasıKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents GüvenlikNoktasıListesiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÖzelGüvenlikBedenÖlçüBilgileriToolStripMenuItem As ToolStripMenuItem
End Class
