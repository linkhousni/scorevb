<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDemarrer
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BT_Demarrer_Jeu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Entete = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_Equipe1 = New System.Windows.Forms.ComboBox()
        Me.CB_Equipe2 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CHK_VoirQuestions = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CHK_autre = New System.Windows.Forms.CheckBox()
        Me.OFD_quizz = New System.Windows.Forms.OpenFileDialog()
        Me.PB_LOGO = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PB_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BT_Demarrer_Jeu
        '
        Me.BT_Demarrer_Jeu.BackColor = System.Drawing.Color.White
        Me.BT_Demarrer_Jeu.Location = New System.Drawing.Point(395, 383)
        Me.BT_Demarrer_Jeu.Name = "BT_Demarrer_Jeu"
        Me.BT_Demarrer_Jeu.Size = New System.Drawing.Size(75, 21)
        Me.BT_Demarrer_Jeu.TabIndex = 5
        Me.BT_Demarrer_Jeu.Text = "Démarrer"
        Me.BT_Demarrer_Jeu.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "En-tête :"
        '
        'TB_Entete
        '
        Me.TB_Entete.Location = New System.Drawing.Point(226, 51)
        Me.TB_Entete.Name = "TB_Entete"
        Me.TB_Entete.Size = New System.Drawing.Size(244, 20)
        Me.TB_Entete.TabIndex = 2
        Me.TB_Entete.Text = "Journée d'intégration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom de la première équipe :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nom de la deuxième équipe :"
        '
        'CB_Equipe1
        '
        Me.CB_Equipe1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Equipe1.FormattingEnabled = True
        Me.CB_Equipe1.Items.AddRange(New Object() {"Angola", "Benin", "Burkina Faso", "Burundi", "Cameroun", "Centrafrique", "Comores", "Congo", "Côte d'Ivoire", "Djibouti", "Ethiopie", "Gabon", "Ghana", "Guinée", "Guinée Bissau", "Guinée Equatoriale", "Madagascar", "Mali", "Mauritanie", "Niger", "Nigeria", "R.D. Congo", "Rwanda", "Sao Tomé et Principe", "Sénégal", "Tchad", "Togo"})
        Me.CB_Equipe1.Location = New System.Drawing.Point(226, 91)
        Me.CB_Equipe1.Name = "CB_Equipe1"
        Me.CB_Equipe1.Size = New System.Drawing.Size(244, 21)
        Me.CB_Equipe1.Sorted = True
        Me.CB_Equipe1.TabIndex = 0
        '
        'CB_Equipe2
        '
        Me.CB_Equipe2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Equipe2.FormattingEnabled = True
        Me.CB_Equipe2.Items.AddRange(New Object() {"Angola", "Benin", "Burkina Faso", "Burundi", "Cameroun", "Centrafrique", "Comores", "Congo", "Côte d'Ivoire", "Djibouti", "Ethiopie", "Gabon", "Ghana", "Guinée", "Guinée Bissau", "Guinée Equatoriale", "Madagascar", "Mali", "Mauritanie", "Niger", "Nigeria", "R.D. Congo", "Rwanda", "Sao Tomé et Principe", "Sénégal", "Tchad", "Togo"})
        Me.CB_Equipe2.Location = New System.Drawing.Point(226, 118)
        Me.CB_Equipe2.Name = "CB_Equipe2"
        Me.CB_Equipe2.Size = New System.Drawing.Size(244, 21)
        Me.CB_Equipe2.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(687, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.QuitterToolStripMenuItem.Text = "&Quitter"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AideToolStripMenuItem, Me.AProposDeToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'AProposDeToolStripMenuItem
        '
        Me.AProposDeToolStripMenuItem.Name = "AProposDeToolStripMenuItem"
        Me.AProposDeToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AProposDeToolStripMenuItem.Text = "A propos de..."
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(531, 387)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(92, 13)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Contacter l'éditeur"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.ForeColor = System.Drawing.Color.DimGray
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox1.Size = New System.Drawing.Size(414, 147)
        Me.ListBox1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(6, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Charger questions du quizz"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CHK_VoirQuestions
        '
        Me.CHK_VoirQuestions.AutoSize = True
        Me.CHK_VoirQuestions.Location = New System.Drawing.Point(186, 177)
        Me.CHK_VoirQuestions.Name = "CHK_VoirQuestions"
        Me.CHK_VoirQuestions.Size = New System.Drawing.Size(108, 17)
        Me.CHK_VoirQuestions.TabIndex = 4
        Me.CHK_VoirQuestions.Text = "Voir les questions"
        Me.CHK_VoirQuestions.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CHK_VoirQuestions)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 209)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Questions du Quizz"
        '
        'CHK_autre
        '
        Me.CHK_autre.AutoSize = True
        Me.CHK_autre.Location = New System.Drawing.Point(230, 145)
        Me.CHK_autre.Name = "CHK_autre"
        Me.CHK_autre.Size = New System.Drawing.Size(131, 17)
        Me.CHK_autre.TabIndex = 8
        Me.CHK_autre.Text = "Saisir d'autres équipes"
        Me.CHK_autre.UseVisualStyleBackColor = True
        '
        'OFD_quizz
        '
        Me.OFD_quizz.FileName = "OpenFileDialog1"
        '
        'PB_LOGO
        '
        Me.PB_LOGO.Image = Global.WindowsApplication1.My.Resources.Resources.Signature_MF
        Me.PB_LOGO.Location = New System.Drawing.Point(482, 163)
        Me.PB_LOGO.Name = "PB_LOGO"
        Me.PB_LOGO.Size = New System.Drawing.Size(193, 214)
        Me.PB_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_LOGO.TabIndex = 9
        Me.PB_LOGO.TabStop = False
        '
        'FDemarrer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(687, 413)
        Me.Controls.Add(Me.PB_LOGO)
        Me.Controls.Add(Me.CHK_autre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CB_Equipe2)
        Me.Controls.Add(Me.CB_Equipe1)
        Me.Controls.Add(Me.TB_Entete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BT_Demarrer_Jeu)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FDemarrer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options de démarrage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PB_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BT_Demarrer_Jeu As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_Entete As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CB_Equipe1 As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Equipe2 As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AProposDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CHK_VoirQuestions As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CHK_autre As System.Windows.Forms.CheckBox
    Friend WithEvents OFD_quizz As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PB_LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents AideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
