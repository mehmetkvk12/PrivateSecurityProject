<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SifremiUnuttumFormu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SoruTBox = New System.Windows.Forms.TextBox()
        Me.CevapTBox = New System.Windows.Forms.TextBox()
        Me.SifreTBox = New System.Windows.Forms.TextBox()
        Me.TekrarTBox = New System.Windows.Forms.TextBox()
        Me.SifreGosterPBox = New System.Windows.Forms.PictureBox()
        Me.TekrarGosterPBox = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SifreGosterPBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TekrarGosterPBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(148, 185)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(264, 37)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(126, 31)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Değiştir"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(135, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(126, 31)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Vazgeç"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TekrarGosterPBox)
        Me.GroupBox1.Controls.Add(Me.SifreGosterPBox)
        Me.GroupBox1.Controls.Add(Me.TekrarTBox)
        Me.GroupBox1.Controls.Add(Me.SifreTBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 79)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Yeni Şifre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CevapTBox)
        Me.GroupBox2.Controls.Add(Me.SoruTBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 79)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Günevlik Sorusu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Güvenlik Sorusu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cevap:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Yeni Şifre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Yeni Şifre Tekrarı:"
        '
        'SoruTBox
        '
        Me.SoruTBox.Location = New System.Drawing.Point(108, 19)
        Me.SoruTBox.Name = "SoruTBox"
        Me.SoruTBox.ReadOnly = True
        Me.SoruTBox.Size = New System.Drawing.Size(271, 20)
        Me.SoruTBox.TabIndex = 2
        Me.SoruTBox.TabStop = False
        '
        'CevapTBox
        '
        Me.CevapTBox.Location = New System.Drawing.Point(108, 49)
        Me.CevapTBox.Name = "CevapTBox"
        Me.CevapTBox.Size = New System.Drawing.Size(271, 20)
        Me.CevapTBox.TabIndex = 3
        '
        'SifreTBox
        '
        Me.SifreTBox.Location = New System.Drawing.Point(108, 19)
        Me.SifreTBox.Name = "SifreTBox"
        Me.SifreTBox.Size = New System.Drawing.Size(173, 20)
        Me.SifreTBox.TabIndex = 4
        Me.SifreTBox.UseSystemPasswordChar = True
        '
        'TekrarTBox
        '
        Me.TekrarTBox.Location = New System.Drawing.Point(108, 49)
        Me.TekrarTBox.Name = "TekrarTBox"
        Me.TekrarTBox.Size = New System.Drawing.Size(173, 20)
        Me.TekrarTBox.TabIndex = 5
        Me.TekrarTBox.UseSystemPasswordChar = True
        '
        'SifreGosterPBox
        '
        Me.SifreGosterPBox.Image = Global.OzGu.My.Resources.Resources.goz
        Me.SifreGosterPBox.Location = New System.Drawing.Point(287, 19)
        Me.SifreGosterPBox.Name = "SifreGosterPBox"
        Me.SifreGosterPBox.Size = New System.Drawing.Size(25, 20)
        Me.SifreGosterPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.SifreGosterPBox.TabIndex = 6
        Me.SifreGosterPBox.TabStop = False
        Me.SifreGosterPBox.Tag = "1"
        '
        'TekrarGosterPBox
        '
        Me.TekrarGosterPBox.Image = Global.OzGu.My.Resources.Resources.goz
        Me.TekrarGosterPBox.Location = New System.Drawing.Point(287, 49)
        Me.TekrarGosterPBox.Name = "TekrarGosterPBox"
        Me.TekrarGosterPBox.Size = New System.Drawing.Size(25, 20)
        Me.TekrarGosterPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.TekrarGosterPBox.TabIndex = 7
        Me.TekrarGosterPBox.TabStop = False
        Me.TekrarGosterPBox.Tag = "2"
        '
        'SifremiUnuttumFormu
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(424, 234)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SifremiUnuttumFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Şifremi Unuttum ({0})"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SifreGosterPBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TekrarGosterPBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TekrarTBox As TextBox
    Friend WithEvents SifreTBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CevapTBox As TextBox
    Friend WithEvents SoruTBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SifreGosterPBox As PictureBox
    Friend WithEvents TekrarGosterPBox As PictureBox
End Class
