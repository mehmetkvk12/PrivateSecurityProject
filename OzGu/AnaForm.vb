Public Class AnaForm
    Private Kapat As Boolean = False
    Public Sub New()
        Dim GirisFormu As New LoginFormu
        If GirisFormu.ShowDialog(Me) <> DialogResult.OK Then
            Kapat = True
        End If
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub KapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KapatToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ÖzelGüvenlikKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖzelGüvenlikKaydıToolStripMenuItem.Click
        OzelGuvenlikKayitFormu.MdiParent = Me
        OzelGuvenlikKayitFormu.Show()

    End Sub

    Private Sub GüvenlikNoktasıListesiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GüvenlikNoktasıListesiToolStripMenuItem.Click
        GuvenlikNoktasiListeFormu.ShowDialog(Me)
        GuvenlikNoktasiListeFormu.Dispose()
    End Sub

    Private Sub AnaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Kapat Then
            Me.Close()
        End If
    End Sub

    Private Sub ÖzelGüvenlikBedenÖlçüBilgileriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖzelGüvenlikBedenÖlçüBilgileriToolStripMenuItem.Click
        OzelGuvenlikBedenBilgiFormu.MdiParent = Me
        OzelGuvenlikBedenBilgiFormu.Show()
        OzelGuvenlikBedenBilgiFormu.WindowState = FormWindowState.Maximized
    End Sub
End Class
