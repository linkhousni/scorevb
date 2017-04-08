Imports System.IO

Public Class FDemarrer
    Dim ElseName1 As String = ""
    Dim ElseName2 As String = ""

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Demarrer_Jeu.Click

        Me.Visible = False
        Main.Show()
        If Me.CHK_autre.Checked Then
            ElseName1 = InputBox("Veuillez saisir le nom de la première équipe")
            Main.GB_EQUIP1.Text = ElseName1
            Main.BT_ScoreTiroir1.Text = ElseName1
            Main.LBL_EQUIP1.Text = ElseName1
            Main.PB_Drapeau2.Visible = False
            Me.CB_Equipe1.Enabled = False

            ElseName2 = InputBox("Veuillez saisir le nom de la deuxième équipe")
            Main.GB_EQUIP2.Text = ElseName2
            Main.BT_ScoreTiroir2.Text = ElseName2
            Main.LBL_EQUIP2.Text = ElseName2
            Main.PB_Drapeau1.Visible = False
            Me.CB_Equipe2.Enabled = False
        Else
            Main.GB_EQUIP1.Text = Me.CB_Equipe1.SelectedItem
            Main.GB_EQUIP2.Text = Me.CB_Equipe2.SelectedItem
            Main.BT_ScoreTiroir1.Text = Me.CB_Equipe1.SelectedItem
            Main.BT_ScoreTiroir2.Text = Me.CB_Equipe2.SelectedItem
            Main.LBL_EQUIP1.Text = Me.CB_Equipe1.SelectedItem
            Main.LBL_EQUIP2.Text = Me.CB_Equipe2.SelectedItem
            Main.PB_Drapeau2.Visible = True
            Main.PB_Drapeau1.Visible = True
        End If
        
       

        Main.LBL_Entete.Text = Me.TB_Entete.Text

        Select Case Me.CB_Equipe1.SelectedIndex
            Case 0
                Main.PB_Drapeau1.Image = My.Resources.angola
            Case 1
                Main.PB_Drapeau1.Image = My.Resources.benin
            Case 2
                Main.PB_Drapeau1.Image = My.Resources.Burkina_faso
            Case 3
                Main.PB_Drapeau1.Image = My.Resources.Burundi
            Case 4
                Main.PB_Drapeau1.Image = My.Resources.cameroun
            Case 5
                Main.PB_Drapeau1.Image = My.Resources.centrafrique
            Case 6
                Main.PB_Drapeau1.Image = My.Resources.comores
            Case 7
                Main.PB_Drapeau1.Image = My.Resources.congo
            Case 8
                Main.PB_Drapeau1.Image = My.Resources.cote_divoire
            Case 9
                Main.PB_Drapeau1.Image = My.Resources.djibouti
            Case 10
                Main.PB_Drapeau1.Image = My.Resources.Ethiopie
            Case 11
                Main.PB_Drapeau1.Image = My.Resources.gabon
            Case 12
                Main.PB_Drapeau1.Image = My.Resources.ghana
            Case 13
                Main.PB_Drapeau1.Image = My.Resources.guinee
            Case 14
                Main.PB_Drapeau1.Image = My.Resources.Guinee_Bissau
            Case 15
                Main.PB_Drapeau1.Image = My.Resources.guinee_equatoriale
            Case 16
                Main.PB_Drapeau1.Image = My.Resources.madagascar
            Case 17
                Main.PB_Drapeau1.Image = My.Resources.Mali
            Case 18
                Main.PB_Drapeau1.Image = My.Resources.mauritanie
            Case 19
                Main.PB_Drapeau1.Image = My.Resources.niger
            Case 20
                Main.PB_Drapeau1.Image = My.Resources.nigeria
            Case 21
                Main.PB_Drapeau1.Image = My.Resources.Rd_congo
            Case 22
                Main.PB_Drapeau1.Image = My.Resources.rwanda
            Case 23
                Main.PB_Drapeau1.Image = My.Resources.sao_tome_principe
            Case 24
                Main.PB_Drapeau1.Image = My.Resources.senegal
            Case 25
                Main.PB_Drapeau1.Image = My.Resources.Tchad
            Case 26
                Main.PB_Drapeau1.Image = My.Resources.togo
            Case 27
                Main.PB_Drapeau1.Image = My.Resources.Maroc

            Case Else
                'Main.PB_Drapeau1.Image = My.Resources.teamA
                ElseName1 = InputBox("Veuillez saisir le nom de la première équipe")
                Main.GB_EQUIP1.Text = ElseName1
                Main.BT_ScoreTiroir1.Text = ElseName1
                Main.LBL_EQUIP1.Text = ElseName1
                'MessageBox.Show("Pas d'image pour cette première équipe !")

        End Select

        Select Case Me.CB_Equipe2.SelectedIndex
            Case 0
                Main.PB_Drapeau2.Image = My.Resources.angola
            Case 1
                Main.PB_Drapeau2.Image = My.Resources.benin
            Case 2
                Main.PB_Drapeau2.Image = My.Resources.Burkina_faso
            Case 3
                Main.PB_Drapeau2.Image = My.Resources.Burundi
            Case 4
                Main.PB_Drapeau2.Image = My.Resources.cameroun
            Case 5
                Main.PB_Drapeau2.Image = My.Resources.centrafrique
            Case 6
                Main.PB_Drapeau2.Image = My.Resources.comores
            Case 7
                Main.PB_Drapeau2.Image = My.Resources.congo
            Case 8
                Main.PB_Drapeau2.Image = My.Resources.cote_divoire
            Case 9
                Main.PB_Drapeau2.Image = My.Resources.djibouti
            Case 10
                Main.PB_Drapeau2.Image = My.Resources.Ethiopie
            Case 11
                Main.PB_Drapeau2.Image = My.Resources.gabon
            Case 12
                Main.PB_Drapeau2.Image = My.Resources.ghana
            Case 13
                Main.PB_Drapeau2.Image = My.Resources.guinee
            Case 14
                Main.PB_Drapeau2.Image = My.Resources.Guinee_Bissau
            Case 15
                Main.PB_Drapeau2.Image = My.Resources.guinee_equatoriale
            Case 16
                Main.PB_Drapeau2.Image = My.Resources.madagascar
            Case 17
                Main.PB_Drapeau2.Image = My.Resources.Mali
            Case 18
                Main.PB_Drapeau2.Image = My.Resources.mauritanie
            Case 19
                Main.PB_Drapeau2.Image = My.Resources.niger
            Case 20
                Main.PB_Drapeau2.Image = My.Resources.nigeria
            Case 21
                Main.PB_Drapeau2.Image = My.Resources.Rd_congo
            Case 22
                Main.PB_Drapeau2.Image = My.Resources.rwanda
            Case 23
                Main.PB_Drapeau2.Image = My.Resources.sao_tome_principe
            Case 24
                Main.PB_Drapeau2.Image = My.Resources.senegal
            Case 25
                Main.PB_Drapeau2.Image = My.Resources.Tchad
            Case 26
                Main.PB_Drapeau2.Image = My.Resources.togo
            Case 27
                Main.PB_Drapeau2.Image = My.Resources.Maroc
            Case Else
                'Main.PB_Drapeau2.Image = My.Resources.teamB
                ElseName2 = InputBox("Veuillez saisir le nom de la deuxième équipe")
                Main.GB_EQUIP2.Text = ElseName2
                Main.BT_ScoreTiroir2.Text = ElseName2
                Main.LBL_EQUIP2.Text = ElseName2
                'MessageBox.Show("Pas d'image pour cette deuxième équipe !")

        End Select

    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.facebook.com/linkhousni")
    End Sub


    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Me.OFD_quizz.ShowDialog() Then
            Me.ListBox1.Items.Clear()
            Try
                    Me.ListBox1.Items.AddRange(File.ReadAllLines(OFD_quizz.FileName))
            Catch
                MsgBox("Aucun fichier texte choisi")
            Finally
                Me.ListBox1.Visible = False
            End Try
        End If

    End Sub

    Private Sub CHK_VoirQuestions_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_VoirQuestions.CheckedChanged
        If Me.CHK_VoirQuestions.Checked Then
            Me.ListBox1.Visible = True
        Else
            Me.ListBox1.Visible = False
        End If

    End Sub

    Private Sub CHK_autre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_autre.CheckedChanged
        If Me.CHK_autre.Checked Then
            Me.CB_Equipe1.Enabled = False
            Me.CB_Equipe2.Enabled = False
        Else
            Me.CB_Equipe1.Enabled = True
            Me.CB_Equipe2.Enabled = True

        End If
        
    End Sub

    Private Sub AProposDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProposDeToolStripMenuItem.Click
        MessageBox.Show("Programme developpé par Housni Issouffa sous licence Creative Common (C-C) BY")
    End Sub

    Private Sub AideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AideToolStripMenuItem.Click
        Dim str As String = ""
        For Each lettre As Char In My.Resources.Aide
            str += lettre
        Next
        MessageBox.Show(str)
    End Sub

    Private Sub FDemarrer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CB_Equipe1.SelectedIndex = 0
        Me.CB_Equipe2.SelectedIndex = 1

    End Sub
End Class