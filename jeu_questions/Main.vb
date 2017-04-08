
Public Class Main

    'Dim MonCurseur

    Dim NomFinaliste1 As String
    Dim NomFinaliste2 As String
    Dim MaQuestion As Integer = 0
    Dim Grisatre As Byte = 0
    Dim retirer As Boolean = False
    Dim scoreA As Byte = 0
    Dim scoreB As Byte = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.ONGLET_FINALE.Visible = True
        Me.ControlBox = False
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        'Me.BackColor = Color.FromArgb(&HFF013E50)
        Me.TabPage1.BackColor = Color.FromArgb(&HFF013E50)
        'Me.BT_DEMARRER.Visible = False
        'Me.BT_Arreter.Visible = False
        'Me.BT_RAZero.Visible = False
        'TabPage5.Cursor = Moncurseur

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Yo t'es en train de fermer la fenêtre, t'es sûr de vouloir continuer ?", 36, "Quitter") = MsgBoxResult.Yes Then
            FDemarrer.Show()
            Me.Close()

        End If
    End Sub

    Private Sub BT_DEMARRER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_DEMARRER.Click
        'Mise en marche du compte à rebours
        If Me.LBL_TIME.Visible = True Then
            Me.TIM_TIMER.Start()
        Else
            Me.TIM_TIROIR.Start()
        End If
        If retirer = True Then
            Grisatre += 1
            If Me.PB_indicGauche.Visible = True And Me.PB_indicDroite.Visible = False Then
                Me.PB_indicDroite.Visible = True
                Me.PB_indicGauche.Visible = False
            ElseIf Me.PB_indicGauche.Visible = False And Me.PB_indicDroite.Visible = True Then
                Me.PB_indicDroite.Visible = False
                Me.PB_indicGauche.Visible = True
            End If
        End If
        retirer = False

        If Grisatre = 1 Then
            Me.LBL_T1.Text = "2"
        ElseIf Grisatre = 2 Then
            Me.LBL_T1.Text = "1"
        End If


    End Sub

    Private Sub TIM_TIMER_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIM_TIMER.Tick
        If Me.LBL_TIME.Text = "0" Then
            Me.TIM_TIMER.Stop()

        Else
            Me.LBL_TIME.Text = Me.LBL_TIME.Text - 1
        End If
    End Sub

    Private Sub BT_EFFACER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_EFFACER.Click
        Me.TXT_BAS.Text = ""
        Me.TXT_DROITE.Text = ""
        Me.TXT_GAUCHE.Text = ""
        Me.TXT_HAUT.Text = ""
        Me.RB_3.Checked = True
        Me.LBL_TIME.Text = "60"


    End Sub

    Private Sub BT_3A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_3A.Click
        scoreA += 3
        Me.LBL_SCOREFINAL1.Text = scoreA
        Me.LBL_scoretiroir1.Text = scoreA
    End Sub

    Private Sub BT_2A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_2A.Click
        scoreA += 2
        Me.LBL_SCOREFINAL1.Text = scoreA

        Me.LBL_scoretiroir1.Text = scoreA
    End Sub

    Private Sub BT_1A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_1A.Click
        scoreA += 1
        Me.LBL_SCOREFINAL1.Text = scoreA

        Me.LBL_scoretiroir1.Text = scoreA
    End Sub

    Private Sub BT_3B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_3B.Click
        scoreB += 3
        Me.LBL_SCOREFINAL2.Text = scoreB
        Me.LBL_scoretiroir2.Text = scoreB
    End Sub

    Private Sub BT_2B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_2B.Click
        scoreB += 2
        Me.LBL_SCOREFINAL2.Text = scoreB
        Me.LBL_scoretiroir2.Text = scoreB
    End Sub

    Private Sub BT_1B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_1B.Click
        scoreB += 1
        Me.LBL_SCOREFINAL2.Text = scoreB

        Me.LBL_scoretiroir2.Text = scoreB
        Me.LBL_scoretiroir2.Text = scoreB
    End Sub

    Private Sub LBL_RESULT_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_RESULT.DoubleClick
        Me.LBL_CHIF1.Text = ""
        Me.LBL_CHIF2.Text = ""
        Me.LBL_CHIF3.Text = ""
        Me.LBL_CHIF4.Text = ""
        Me.LBL_RESULT.Text = ""
        Me.LBL_info1.Visible = False
        Me.LBL_CHIF1.Text = InputBox("Premier chiffre donné")
        Me.LBL_CHIF2.Text = InputBox("Deuxième chiffre donné")
        Me.LBL_CHIF3.Text = InputBox("Troisième Chiffre donné")
        Me.LBL_CHIF4.Text = InputBox("Quatrième chiffre donné")
        Me.LBL_RESULT.Text = InputBox("Chiffre résultat à trouver")
        Me.RB_4.Checked = True
        Me.LBL_TIME.Text = "90"
    End Sub

    Private Sub RB_off_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_off.CheckedChanged

        Me.BT_DEMARRER.Visible = False
        Me.BT_Arreter.Visible = False
        Me.BT_RAZero.Visible = False
        Me.LBL_TIME.Visible = False


    End Sub

    Private Sub RB_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_4.CheckedChanged
        Me.BT_DEMARRER.Visible = True
        Me.BT_Arreter.Visible = True
        Me.BT_RAZero.Visible = True
        Me.LBL_TIME.Visible = True
        Me.LBL_TIME.Text = "90"
    End Sub

    Private Sub TIM_4SUITE_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIM_4SUITE.Tick
        If Me.LBL_4suite.Text = "0" Then
            Me.TIM_4SUITE.Stop()
        Else
            Me.LBL_4suite.Text = Me.LBL_4suite.Text - 1
        End If
        If CUR4.Visible = True Then
            Me.TIM_4SUITE.Stop()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.LBL_4suite.Text = "45"
        Me.TIM_4SUITE.Enabled = False
        S0.Visible = True
        S1.Visible = True
        S2.Visible = True
        S3.Visible = True
        S4.Visible = True
        CUR0.Visible = True
        CUR1.Visible = False
        CUR2.Visible = False
        CUR3.Visible = False
        CUR4.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'début compte à rebours 4 à la suite
        Me.TIM_4SUITE.Start()
    End Sub

    Private Sub BT_UP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_UP.Click
        If S0.Visible = True And CUR0.Visible = True Then
            S0.Visible = False
            CUR0.Visible = False
            CUR1.Visible = True
        Else
            If S1.Visible = True And CUR1.Visible = True Then
                S1.Visible = False
                CUR0.Visible = False
                CUR1.Visible = False
                CUR2.Visible = True
            Else
                If S2.Visible = True And CUR2.Visible = True Then
                    S2.Visible = False
                    CUR0.Visible = False
                    CUR1.Visible = False
                    CUR2.Visible = False
                    CUR3.Visible = True
                Else
                    If S3.Visible = True And CUR3.Visible = True Then
                        S3.Visible = False
                        CUR0.Visible = False
                        CUR1.Visible = False
                        CUR2.Visible = False
                        CUR3.Visible = False
                        CUR4.Visible = True
                    Else
                        If CUR0.Visible = True And S0.Visible = False Then
                            CUR0.Visible = False
                            CUR1.Visible = True
                        Else
                            If CUR1.Visible = True And S1.Visible = False Then
                                CUR0.Visible = False
                                CUR1.Visible = False
                                CUR2.Visible = True
                            Else
                                If CUR2.Visible = True And S2.Visible = False Then
                                    CUR0.Visible = False
                                    CUR1.Visible = False
                                    CUR2.Visible = False
                                    CUR3.Visible = True
                                Else
                                    If CUR3.Visible = True And S3.Visible = False Then
                                        CUR3.Visible = False
                                        CUR4.Visible = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BT_DOWN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_DOWN.Click
        CUR0.Visible = True
        CUR1.Visible = False
        CUR2.Visible = False
        CUR3.Visible = False
        CUR4.Visible = False
    End Sub

    Private Sub BT_QNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_QNext.Click
        Me.RB_2.Checked = True
        Me.LBL_TIME.Text = "15"
        Me.LBL_REP1.BackColor = Color.Black
        Me.LBL_REP2.BackColor = Color.Black
        Me.LBL_REP3.BackColor = Color.Black
        Me.LBL_REP4.BackColor = Color.Black

        MaQuestion += 1
        Display_Dialog()

    End Sub

    Private Sub LBL_REP1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_REP1.DoubleClick
        Me.LBL_REP1.BackColor = Color.Lime
    End Sub

    Private Sub LBL_REP2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_REP2.DoubleClick
        Me.LBL_REP2.BackColor = Color.Lime
    End Sub

    Private Sub LBL_REP3_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_REP3.DoubleClick
        Me.LBL_REP3.BackColor = Color.Lime
    End Sub

    Private Sub LBL_REP4_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_REP4.DoubleClick
        Me.LBL_REP4.BackColor = Color.Lime
    End Sub

    Sub Display_Dialog()

        'Questions et reponses du QUIZ
        Try
            Select Case MaQuestion
                Case 1

                    Me.LBL_QUESTION.Text = "Q" & MaQuestion & " - " & FDemarrer.ListBox1.Items(0)
                    Me.LBL_REP1.Text = FDemarrer.ListBox1.Items(1)
                    Me.LBL_REP2.Text = FDemarrer.ListBox1.Items(2)
                    Me.LBL_REP3.Text = FDemarrer.ListBox1.Items(3)
                    Me.LBL_REP4.Text = FDemarrer.ListBox1.Items(4)
                Case 2

                    Me.LBL_QUESTION.Text = "Q" & MaQuestion & " - " & FDemarrer.ListBox1.Items(5)
                    Me.LBL_REP1.Text = FDemarrer.ListBox1.Items(6)
                    Me.LBL_REP2.Text = FDemarrer.ListBox1.Items(7)
                    Me.LBL_REP3.Text = FDemarrer.ListBox1.Items(8)
                    Me.LBL_REP4.Text = FDemarrer.ListBox1.Items(9)
                Case 3

                    Me.LBL_QUESTION.Text = "Q" & MaQuestion & " - " & FDemarrer.ListBox1.Items(10)
                    Me.LBL_REP1.Text = FDemarrer.ListBox1.Items(11)
                    Me.LBL_REP2.Text = FDemarrer.ListBox1.Items(12)
                    Me.LBL_REP3.Text = FDemarrer.ListBox1.Items(13)
                    Me.LBL_REP4.Text = FDemarrer.ListBox1.Items(14)
                Case 4

                    Me.LBL_QUESTION.Text = "Q" & MaQuestion & " - " & FDemarrer.ListBox1.Items(15)
                    Me.LBL_REP1.Text = FDemarrer.ListBox1.Items(16)
                    Me.LBL_REP2.Text = FDemarrer.ListBox1.Items(17)
                    Me.LBL_REP3.Text = FDemarrer.ListBox1.Items(18)
                    Me.LBL_REP4.Text = FDemarrer.ListBox1.Items(19)

                    'Case 7
                    '    Me.LBL_QUESTION.Text = "Q" & MaQuestion & " - " & FDemarrer.ListBox1.Items(30)
                    '    Me.LBL_REP1.Text = FDemarrer.ListBox1.Items(31)
                    '    Me.LBL_REP2.Text = FDemarrer.ListBox1.Items(32)
                    '    Me.LBL_REP3.Text = FDemarrer.ListBox1.Items(33)
                    '    Me.LBL_REP4.Text = FDemarrer.ListBox1.Items(34)
                Case Else
                    MessageBox.Show("Fin des questions")

            End Select
        Catch
            MsgBox("Hé hé t'as oublié un truc, Aucun fichier texte n'a été séléctionné au démarrage de la partie,ferme cette fenêtre et charge les questions depuis un fichier (.txt)")
        End Try
    End Sub

    Private Sub BT_Arreter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Arreter.Click
        'Arreter le compte à rebours
        If Me.LBL_TIME.Visible = True Then
            Me.TIM_TIMER.Enabled = False
        Else
            Me.TIM_TIROIR.Enabled = False
            retirer = True
        End If


    End Sub

    Private Sub BT_RAZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_RAZero.Click
        'Initialisation du compte à rebours
        Grisatre = 0
        If Me.LBL_TIME.Visible = True Then
            Me.TIM_TIMER.Stop()
        Else
            Me.TIM_TIROIR.Stop()
            Me.PB_TimeTiroir.Value = PB_TimeTiroir.Minimum
            Me.LBL_T1.Text = "3"
            Me.LBL_T1.BackColor = Color.DarkOrange
            Me.PB_indicGauche.Visible = True
            Me.PB_indicDroite.Visible = True
            retirer = False
        End If

        If Me.RB_1.Checked Then
            Me.LBL_TIME.Text = "10"
        ElseIf Me.RB_2.Checked Then
            Me.LBL_TIME.Text = "15"
        ElseIf Me.RB_3.Checked Then
            Me.LBL_TIME.Text = "60"
        ElseIf Me.RB_4.Checked Then
            Me.LBL_TIME.Text = "90"
        End If


    End Sub

    Private Sub LBL_SCOREFINAL1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_SCOREFINAL1.DoubleClick
        Try
            scoreA = InputBox("Rectification")
                Me.LBL_SCOREFINAL1.Text = scoreA
        Catch
            scoreA = scoreA + 0
        End Try
    End Sub

    Private Sub LBL_SCOREFINAL2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_SCOREFINAL2.DoubleClick
        Try
            scoreB = InputBox("Rectification")
            Me.LBL_SCOREFINAL2.Text = scoreB
        Catch
            scoreB = scoreB + 0
        End Try
    End Sub

    Private Sub RB_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_3.CheckedChanged
        Me.BT_DEMARRER.Visible = True
        Me.BT_Arreter.Visible = True
        Me.BT_RAZero.Visible = True
        Me.LBL_TIME.Visible = True
        Me.LBL_TIME.Text = "60"
    End Sub

    Private Sub RB_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_2.CheckedChanged
        Me.BT_DEMARRER.Visible = True
        Me.BT_Arreter.Visible = True
        Me.BT_RAZero.Visible = True
        Me.LBL_TIME.Visible = True
        Me.LBL_TIME.Text = "15"
    End Sub

    Private Sub RB_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_1.CheckedChanged
        Me.BT_DEMARRER.Visible = True
        Me.BT_Arreter.Visible = True
        Me.BT_RAZero.Visible = True
        Me.LBL_TIME.Visible = True
        Me.LBL_TIME.Text = "10"
    End Sub

    Private Sub TIM_TIROIR_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIM_TIROIR.Tick
        If PB_TimeTiroir.Value = PB_TimeTiroir.Maximum Then
            Me.TIM_TIROIR.Stop()
            Me.LBL_T1.Text = "0"
            Me.LBL_T1.BackColor = Color.Red
        Else
            PB_TimeTiroir.Value += 1
        End If

    End Sub

    Private Sub LBL_TIME_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_TIME.DoubleClick
        Me.LBL_TIME.Visible = False
    End Sub

    Private Sub LBL_REP1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_REP1.Click
        Me.LBL_REP1.BackColor = Color.Cyan
    End Sub

    Private Sub LBL_REP3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_REP3.Click
        Me.LBL_REP3.BackColor = Color.Cyan
    End Sub

    Private Sub LBL_REP2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_REP2.Click
        Me.LBL_REP2.BackColor = Color.Cyan
    End Sub

    Private Sub LBL_REP4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_REP4.Click
        Me.LBL_REP4.BackColor = Color.Cyan
    End Sub

    Private Sub PB_indicDroite_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_indicDroite.DoubleClick
        If Me.PB_indicGauche.Visible = True Then
            Me.PB_indicDroite.Visible = False
        End If
    End Sub

    Private Sub PB_indicGauche_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_indicGauche.DoubleClick
        If Me.PB_indicDroite.Visible = True Then
            Me.PB_indicGauche.Visible = False
        End If
    End Sub

    Private Sub BT_ScoreTiroir1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ScoreTiroir1.Click
        scoreA += Val(Me.LBL_T1.Text)
        Me.LBL_scoretiroir1.Text = scoreA
        Me.LBL_SCOREFINAL1.Text = scoreA

    End Sub

    Private Sub BT_ScoreTiroir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ScoreTiroir2.Click
        scoreB += Val(Me.LBL_T1.Text)
        Me.LBL_scoretiroir2.Text = scoreB
        Me.LBL_SCOREFINAL2.Text = scoreB
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.LBL_scoretiroir1.Text = scoreA
        Me.LBL_scoretiroir2.Text = scoreB
        Me.Button2.Visible = False
    End Sub

    Private Sub BT_Effacer2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Effacer2.Click
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.LBL_Info2.Visible = False
    End Sub

    Private Sub GB_EQUIP1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GB_EQUIP1.MouseHover
        BT_1A.Visible = True
        BT_2A.Visible = True
        BT_3A.Visible = True
    End Sub

    Private Sub TabPage1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.MouseEnter
        BT_1A.Visible = False
        BT_2A.Visible = False
        BT_3A.Visible = False
        'Améliration avec une fonction et des controles en parametre byval et optional
        BT_1B.Visible = False
        BT_2B.Visible = False
        BT_3B.Visible = False
    End Sub

    Private Sub GB_EQUIP2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GB_EQUIP2.MouseHover
        BT_1B.Visible = True
        BT_2B.Visible = True
        BT_3B.Visible = True
    End Sub

    Private Sub TXT_GAUCHE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_GAUCHE.TextChanged
        Me.LBL_COMPTEUR1.Text = Me.TXT_GAUCHE.TextLength
        Me.TXT_GAUCHE.Text.ToUpper()
    End Sub

    Private Sub TXT_DROITE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DROITE.TextChanged
        Me.LBL_COMPTEUR2.Text = Me.TXT_DROITE.TextLength
    End Sub

    Private Sub TXT_BAS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_BAS.TextChanged
        Me.LBL_COMPTEUR3.Text = Me.TXT_BAS.TextLength
    End Sub
End Class
