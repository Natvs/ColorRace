Structure ColorRace

    ''' <summary>
    ''' Obtient l'ID du jeu de course de couleurs
    ''' </summary>
    Shared ReadOnly ID As String = "colorRace"

    ''' <summary>
    ''' Définit si l'accès à la course de couleurs est autorisé
    ''' </summary>
    Shared access As Boolean

    ''' <summary>
    ''' Tabelau représentant les 32 cases (la case 1 est celle de départ des pions bleus)
    ''' </summary>
    Shared caseList(32) As Object

    ''' <summary>
    ''' Définit le nombre de joueur dans la partie
    ''' </summary>
    Shared playersNumber As Integer

    ''' <summary>
    ''' Actualise tous les comporsants ainsi que toutes les variables pour un début de jeu
    ''' </summary>
    Shared Sub StartNewGame()
        UupdateArray()
        UpdateCasesVariables()

        ColorRace_NumberOfPlayers.ShowDialog()
        ColorRace_playersColorDialog.ShowDialog()
        ColorRace_EmblemsDialog.ShowDialog()

        Players.Player1.leftPawns = Players.defaultPawns
        Players.Player1.leftMoves = Moves.defaultMoves
        Players.Player1.totalMovements = Moves.defaultTotalMoves
        Players.Player1.ranch.BackColor = Players.Player1.color
        Players.Player1.scale1.BackColor = Players.Player1.color
        Players.Player1.scale2.BackColor = Players.Player1.color
        Players.Player1.scale3.BackColor = Players.Player1.color

        Players.Player2.leftPawns = Players.defaultPawns
        Players.Player2.leftMoves = Moves.defaultMoves
        Players.Player2.totalMovements = Moves.defaultTotalMoves
        Players.Player2.ranch.BackColor = Players.Player2.color
        Players.Player2.scale1.BackColor = Players.Player2.color
        Players.Player2.scale2.BackColor = Players.Player2.color
        Players.Player2.scale3.BackColor = Players.Player2.color

        Players.Player3.leftPawns = Players.defaultPawns
        Players.Player3.leftMoves = Moves.defaultMoves
        Players.Player3.totalMovements = Moves.defaultTotalMoves
        Players.Player3.ranch.BackColor = Players.Player3.color
        Players.Player3.scale1.BackColor = Players.Player3.color
        ColorRace.Players.Player3.scale2.BackColor = ColorRace.Players.Player3.color
        ColorRace.Players.Player3.scale3.BackColor = ColorRace.Players.Player3.color

        ColorRace.Players.Player4.leftPawns = ColorRace.Players.defaultPawns
        ColorRace.Players.Player4.leftMoves = ColorRace.Moves.defaultMoves
        ColorRace.Players.Player4.totalMovements = ColorRace.Moves.defaultTotalMoves
        ColorRace.Players.Player4.ranch.BackColor = ColorRace.Players.Player4.color
        ColorRace.Players.Player4.scale1.BackColor = ColorRace.Players.Player4.color
        ColorRace.Players.Player4.scale2.BackColor = ColorRace.Players.Player4.color
        ColorRace.Players.Player4.scale3.BackColor = ColorRace.Players.Player4.color

        ColorRace.Players.playerID = ColorRace.Players.Player1.ID
        ColorRace.Players.newTurn(ColorRace.Players.playerID)

    End Sub

    ''' <summary>
    ''' Initalise les variables qui contiennent les cases principales pour chaque joueur
    ''' </summary>
    Shared Sub UpdateCasesVariables()

        ColorRace.Players.Player1.ranch = ColorRace_MainForm.player1Ranch
        ColorRace.Players.Player1.startCase = ColorRace_MainForm.case1
        ColorRace.Players.Player1.startScale = ColorRace_MainForm.case32
        ColorRace.Players.Player1.scale1 = ColorRace_MainForm.player1Scale1
        ColorRace.Players.Player1.scale2 = ColorRace_MainForm.player1Scale2
        ColorRace.Players.Player1.scale3 = ColorRace_MainForm.player1Scale3

        ColorRace.Players.Player2.ranch = ColorRace_MainForm.player2Ranch
        ColorRace.Players.Player2.startCase = ColorRace_MainForm.case9
        ColorRace.Players.Player2.startScale = ColorRace_MainForm.case8
        ColorRace.Players.Player2.scale1 = ColorRace_MainForm.player2Scale1
        ColorRace.Players.Player2.scale2 = ColorRace_MainForm.player2Scale2
        ColorRace.Players.Player2.scale3 = ColorRace_MainForm.player2Scale3

        ColorRace.Players.Player3.ranch = ColorRace_MainForm.player3Ranch
        ColorRace.Players.Player3.startCase = ColorRace_MainForm.case17
        ColorRace.Players.Player3.startScale = ColorRace_MainForm.case16
        ColorRace.Players.Player3.scale1 = ColorRace_MainForm.player3Scale1
        ColorRace.Players.Player3.scale2 = ColorRace_MainForm.player3Scale2
        ColorRace.Players.Player3.scale3 = ColorRace_MainForm.player3Scale3

        ColorRace.Players.Player4.ranch = ColorRace_MainForm.player4Ranch
        ColorRace.Players.Player4.startCase = ColorRace_MainForm.case25
        ColorRace.Players.Player4.startScale = ColorRace_MainForm.case24
        ColorRace.Players.Player4.scale1 = ColorRace_MainForm.player4Scale1
        ColorRace.Players.Player4.scale2 = ColorRace_MainForm.player4Scale2
        ColorRace.Players.Player4.scale3 = ColorRace_MainForm.player4Scale3

    End Sub

    ''' <summary>
    ''' Initialise toutes les données avant la fermeture du jeu
    ''' </summary>
    Shared Sub exitGame()
        ColorRace.Players.playerID = Nothing

        ColorRace.Players.Player1.leftPawns = 0
        ColorRace.Players.Player1.leftMoves = 0
        ColorRace.Players.Player1.emblemID = 0
        ColorRace.Players.Player1.ranch.BackColor = Color.White
        ColorRace.Players.Player1.scale1.BackColor = Color.White
        ColorRace.Players.Player1.scale2.BackColor = Color.White
        ColorRace.Players.Player1.scale3.BackColor = Color.White

        ColorRace.Players.Player2.leftPawns = 0
        ColorRace.Players.Player2.leftMoves = 0
        ColorRace.Players.Player2.emblemID = 0
        ColorRace.Players.Player2.ranch.BackColor = Color.White
        ColorRace.Players.Player2.scale1.BackColor = Color.White
        ColorRace.Players.Player2.scale2.BackColor = Color.White
        ColorRace.Players.Player2.scale3.BackColor = Color.White

        ColorRace.Players.Player3.leftPawns = 0
        ColorRace.Players.Player3.leftMoves = 0
        ColorRace.Players.Player3.emblemID = 0
        ColorRace.Players.Player3.ranch.BackColor = Color.White
        ColorRace.Players.Player3.scale1.BackColor = Color.White
        ColorRace.Players.Player3.scale2.BackColor = Color.White
        ColorRace.Players.Player3.scale3.BackColor = Color.White

        ColorRace.Players.Player4.leftPawns = 0
        ColorRace.Players.Player4.leftMoves = 0
        ColorRace.Players.Player4.emblemID = 0
        ColorRace.Players.Player4.ranch.BackColor = Color.White
        ColorRace.Players.Player4.scale1.BackColor = Color.White
        ColorRace.Players.Player4.scale2.BackColor = Color.White
        ColorRace.Players.Player4.scale3.BackColor = Color.White

        ColorRace_MainForm.Close()
        ColorRace_NumberOfPlayers.Close()
        ColorRace_PlayersColorDialog.Close()
        ColorRace_Winner.Close()
    End Sub

    ''' <summary>
    ''' Actualise le tableau représentant les cases de jeu
    ''' </summary>
    Shared Sub UupdateArray()
        ColorRace.caseList(1) = ColorRace_MainForm.case1
        ColorRace.caseList(2) = ColorRace_MainForm.case2
        ColorRace.caseList(3) = ColorRace_MainForm.case3
        ColorRace.caseList(4) = ColorRace_MainForm.case4
        ColorRace.caseList(5) = ColorRace_MainForm.case5
        ColorRace.caseList(6) = ColorRace_MainForm.case6
        ColorRace.caseList(7) = ColorRace_MainForm.case7
        ColorRace.caseList(8) = ColorRace_MainForm.case8
        ColorRace.caseList(9) = ColorRace_MainForm.case9
        ColorRace.caseList(10) = ColorRace_MainForm.case10
        ColorRace.caseList(11) = ColorRace_MainForm.case11
        ColorRace.caseList(12) = ColorRace_MainForm.case12
        ColorRace.caseList(13) = ColorRace_MainForm.case13
        ColorRace.caseList(14) = ColorRace_MainForm.case14
        ColorRace.caseList(15) = ColorRace_MainForm.case15
        ColorRace.caseList(16) = ColorRace_MainForm.case16
        ColorRace.caseList(17) = ColorRace_MainForm.case17
        ColorRace.caseList(18) = ColorRace_MainForm.case18
        ColorRace.caseList(19) = ColorRace_MainForm.case19
        ColorRace.caseList(20) = ColorRace_MainForm.case20
        ColorRace.caseList(21) = ColorRace_MainForm.case21
        ColorRace.caseList(22) = ColorRace_MainForm.case22
        ColorRace.caseList(23) = ColorRace_MainForm.case23
        ColorRace.caseList(24) = ColorRace_MainForm.case24
        ColorRace.caseList(25) = ColorRace_MainForm.case25
        ColorRace.caseList(26) = ColorRace_MainForm.case26
        ColorRace.caseList(27) = ColorRace_MainForm.case27
        ColorRace.caseList(28) = ColorRace_MainForm.case28
        ColorRace.caseList(29) = ColorRace_MainForm.case29
        ColorRace.caseList(30) = ColorRace_MainForm.case30
        ColorRace.caseList(31) = ColorRace_MainForm.case31
        ColorRace.caseList(32) = ColorRace_MainForm.case32
    End Sub

    Structure Moves

        Structure Check

            ''' <summary>
            ''' Obtient le nombre de mouvements requis pour bouger un pion
            ''' </summary>
            Shared ReadOnly requiredMovesToMove As Integer = 1

            ''' <summary>
            ''' Obtient le nombre de mouvements requis pour sortir un pion
            ''' </summary>
            Shared ReadOnly requiredMovesToGoOut As Integer = 5

            ''' <summary>
            ''' Obtient le nombre de mouvements requis pour monter à l'échelle
            ''' </summary>
            Shared ReadOnly requiredMovesToGoInScale As Integer = 2

            ''' <summary>
            ''' Obtient la valeur indiquant si le joueur peut monter à l'échelle
            ''' </summary>
            ''' <param name="playerID">L'ID du joueur</param>
            ''' <returns>La valeur indiquant si le joueur peut monter à l'échelle</returns>
            Shared Function canGoUpInScale(playerID As Integer)

                If ColorRace.Players.getLeftMoves(playerID) >= ColorRace.Moves.Check.requiredMovesToGoInScale Then

                    Return True

                Else

                    Return False

                End If

            End Function

            ''' <summary>
            ''' Obtient la valeur indiquant si le joueur peut bouger un pion
            ''' </summary>
            ''' <param name="playerID">L'ID du joueur</param>
            ''' <returns>La valeur indiquant si le joueur peut bouger un pion</returns>
            Shared Function canMove(playerID As Integer)

                If ColorRace.Players.getLeftMoves(playerID) >= ColorRace.Moves.Check.requiredMovesToMove Then

                    Return True

                Else

                    Return False

                End If

            End Function

            ''' <summary>
            ''' Obtient la valeur indiquant si le joueur peut sortir un pion
            ''' </summary>
            ''' <param name="playerID">L'ID du joueur</param>
            ''' <returns>La valeur indiquant si le joueur peut sortir un pion</returns>
            Shared Function canGoOut(playerID As Integer)

                If ColorRace.Players.getLeftMoves(playerID) >= ColorRace.Moves.Check.requiredMovesToGoOut Then

                    Return True

                Else

                    Return False

                End If

            End Function

        End Structure

        ''' <summary>
        ''' Obtient le nombre de mouvements par défaut à chaque début de partie
        ''' </summary>
        Shared ReadOnly defaultMoves As Integer = 0

        ''' <summary>
        ''' Obtient le nombre maximum de mouvement pouvant être stockés par défaut
        ''' </summary>
        Shared ReadOnly defaultTotalMoves As Integer = 10

        ''' <summary>
        ''' Obtient le nombre maximum de mouvements qu'un joueur peut obtenir dans un tours
        ''' </summary>
        Shared ReadOnly maxMovesWon As Integer = 5

        ''' <summary>
        ''' Définit le nombre de mouvements restants pour le joueur
        ''' </summary>
        ''' <param name="moves">Le nombre de mouvements restants pour le joueur</param>
        Shared Sub setLeftMoves(playerID As Integer, moves As Integer)

            If playerID = ColorRace.Players.Player1.ID Then
                ColorRace.Players.Player1.leftMoves = moves
            ElseIf playerID = ColorRace.Players.Player2.ID Then
                ColorRace.Players.Player2.leftMoves = moves
            ElseIf playerID = ColorRace.Players.Player3.ID Then
                ColorRace.Players.Player3.leftMoves = moves
            ElseIf playerID = ColorRace.Players.Player4.ID Then
                ColorRace.Players.Player4.leftMoves = moves
            End If

            ColorRace.Moves.updateLeftMoves(playerID)

        End Sub

        ''' <summary>
        ''' Retire des mouvements au joueur
        ''' </summary>
        ''' <param name="playerID">L'ID du joueur</param>
        ''' <param name="moves">Le nombre de mouvements à retirer au joueur</param>
        Shared Sub removeLeftMoves(playerID As Integer, moves As Integer)

            If playerID = ColorRace.Players.Player1.ID Then
                ColorRace.Players.Player1.leftMoves = ColorRace.Players.Player1.leftMoves - moves
            ElseIf playerID = ColorRace.Players.Player2.ID Then
                ColorRace.Players.Player2.leftMoves = ColorRace.Players.Player2.leftMoves - moves
            ElseIf playerID = ColorRace.Players.Player3.ID Then
                ColorRace.Players.Player3.leftMoves = ColorRace.Players.Player3.leftMoves - moves
            ElseIf playerID = ColorRace.Players.Player4.ID Then
                ColorRace.Players.Player4.leftMoves = ColorRace.Players.Player4.leftMoves - moves
            End If

            ColorRace.Moves.updateLeftMoves(playerID)

        End Sub

        ''' <summary>
        ''' Ajoute des mouvements au joueur
        ''' </summary>
        ''' <param name="playerID">L'ID du joueur</param>
        ''' <param name="moves">Le nombre de mouvements à ajouter</param>
        Shared Sub addLeftMoves(playerID As Integer, moves As Integer)

            If playerID = ColorRace.Players.Player1.ID Then
                ColorRace.Players.Player1.leftMoves = ColorRace.Players.Player1.leftMoves + moves
                If ColorRace.Players.Player1.leftMoves > ColorRace.Players.Player1.totalMovements Then
                    ColorRace.Players.Player1.leftMoves = ColorRace.Players.Player1.totalMovements
                End If
            ElseIf playerID = ColorRace.Players.Player2.ID Then
                ColorRace.Players.Player2.leftMoves = ColorRace.Players.Player2.leftMoves + moves
                If ColorRace.Players.Player2.leftMoves > ColorRace.Players.Player2.totalMovements Then
                    ColorRace.Players.Player2.leftMoves = ColorRace.Players.Player2.totalMovements
                End If
            ElseIf playerID = ColorRace.Players.Player3.ID Then
                ColorRace.Players.Player3.leftMoves = ColorRace.Players.Player3.leftMoves + moves
                If ColorRace.Players.Player3.leftMoves > ColorRace.Players.Player3.totalMovements Then
                    ColorRace.Players.Player3.leftMoves = ColorRace.Players.Player3.totalMovements
                End If
            ElseIf playerID = ColorRace.Players.Player4.ID Then
                ColorRace.Players.Player4.leftMoves = ColorRace.Players.Player4.leftMoves + moves
                If ColorRace.Players.Player4.leftMoves > ColorRace.Players.Player4.totalMovements Then
                    ColorRace.Players.Player4.leftMoves = ColorRace.Players.Player4.totalMovements
                End If
            End If

            ColorRace.Moves.updateLeftMoves(playerID)

        End Sub

        ''' <summary>
        ''' Actualise le label qui indique le nombre de mouvements restants
        ''' </summary>
        ''' <param name="playerID"></param>
        Shared Sub updateLeftMoves(playerID)

            ColorRace_MainForm.leftMovesLabel.Text = ColorRace.Players.getLeftMoves(playerID).ToString

        End Sub

        ''' <summary>
        ''' Sort un pion. Vérifie que le ranch cliqué correspond à celui du joueur
        ''' </summary>
        ''' <param name="playerID">L'ID du joueur</param>
        Shared Sub newPawn(playerID As Integer, ranchClicked As Label)

            Dim releasedPawn As Boolean = False

            If playerID = ColorRace.Players.Player1.ID Then

                If ColorRace.Moves.Check.canGoOut(ColorRace.Players.Player1.ID) And ranchClicked Is ColorRace.Players.Player1.ranch And ColorRace.Players.Player1.leftPawns > 0 Then

                    releasedPawn = True
                    ColorRace.Moves.checkEatedPawn(ColorRace.Players.Player1.startCase)
                    ColorRace.Players.Player1.leftPawns = ColorRace.Players.Player1.leftPawns - 1
                    ColorRace.Players.Player1.ranch.Text = ColorRace.Players.Player1.leftPawns.ToString
                    ColorRace.Players.Player1.startCase.BackColor = ColorRace.Players.Player1.color
                    ColorRace.Moves.removeLeftMoves(ColorRace.Players.playerID, ColorRace.Moves.Check.requiredMovesToGoOut)

                End If

            ElseIf playerID = ColorRace.Players.Player2.ID Then

                If ColorRace.Moves.Check.canGoOut(ColorRace.Players.Player2.ID) And ranchClicked Is ColorRace.Players.Player2.ranch And ColorRace.Players.Player2.leftPawns > 0 Then

                    releasedPawn = True
                    ColorRace.Moves.checkEatedPawn(ColorRace.Players.Player2.startCase)
                    ColorRace.Players.Player2.leftPawns = ColorRace.Players.Player2.leftPawns - 1
                    ColorRace.Players.Player2.ranch.Text = ColorRace.Players.Player2.leftPawns.ToString
                    ColorRace.Players.Player2.startCase.BackColor = ColorRace.Players.Player2.color
                    ColorRace.Moves.removeLeftMoves(ColorRace.Players.playerID, ColorRace.Moves.Check.requiredMovesToGoOut)

                End If

            ElseIf playerID = ColorRace.Players.Player3.ID Then

                If ColorRace.Moves.Check.canGoOut(ColorRace.Players.Player3.ID) And ranchClicked Is ColorRace.Players.Player3.ranch And ColorRace.Players.Player3.leftPawns > 0 Then

                    releasedPawn = True
                    ColorRace.Moves.checkEatedPawn(ColorRace.Players.Player3.startCase)
                    ColorRace.Players.Player3.leftPawns = ColorRace.Players.Player3.leftPawns - 1
                    ColorRace.Players.Player3.ranch.Text = ColorRace.Players.Player3.leftPawns.ToString
                    ColorRace.Players.Player3.startCase.BackColor = ColorRace.Players.Player3.color
                    ColorRace.Moves.removeLeftMoves(ColorRace.Players.playerID, ColorRace.Moves.Check.requiredMovesToGoOut)

                End If

            ElseIf playerID = ColorRace.Players.Player4.ID Then

                If ColorRace.Moves.Check.canGoOut(ColorRace.Players.Player4.ID) And ranchClicked Is ColorRace.Players.Player4.ranch And ColorRace.Players.Player4.leftPawns > 0 Then

                    releasedPawn = True
                    ColorRace.Moves.checkEatedPawn(ColorRace.Players.Player4.startCase)
                    ColorRace.Players.Player4.leftPawns = ColorRace.Players.Player4.leftPawns - 1
                    ColorRace.Players.Player4.ranch.Text = ColorRace.Players.Player4.leftPawns.ToString
                    ColorRace.Players.Player4.startCase.BackColor = ColorRace.Players.Player4.color
                    ColorRace.Moves.removeLeftMoves(ColorRace.Players.playerID, ColorRace.Moves.Check.requiredMovesToGoOut)

                End If

            End If

            If releasedPawn = True Then

                If ColorRace.emblems.getEmblem(ColorRace.Players.playerID) = ColorRace.emblems.emblem4.ID Then

                    ColorRace.Moves.addLeftMoves(ColorRace.Players.playerID, ColorRace.emblems.emblem4.wonMovements)
                    ColorRace_MainForm.emblemLabel.Text = "+ " + ColorRace.emblems.emblem4.wonMovements.ToString + " mouvement(s)"

                End If

            End If

        End Sub

        ''' <summary>
        ''' Avance le pion d'une case en vérfiant que le pion cliqué appartient au joueur
        ''' </summary>
        ''' <param name="caseClicked">La case cliquée</param>
        ''' <param name="NextCase">La case suivant la case cliquée</param>
        Shared Sub movePawn(caseClicked As PictureBox, NextCase As PictureBox)

            If ColorRace.Players.playerID = ColorRace.Players.Player1.ID Then

                If caseClicked Is ColorRace.Players.Player1.startScale And ColorRace.Players.Player1.startScale.BackColor = ColorRace.Players.Player1.color And ColorRace.Moves.Check.canGoUpInScale(ColorRace.Players.Player1.ID) = True Then

                    ColorRace.Moves.moveInScale(ColorRace.Players.Player1.scale1, ColorRace.Players.Player1.scale2, ColorRace.Players.Player1.scale3, ColorRace.Players.Player1.startScale)
                    ColorRace.Moves.removeLeftMoves(ColorRace.Players.playerID, ColorRace.Moves.Check.requiredMovesToGoInScale)

                ElseIf ColorRace.Moves.Check.canMove(ColorRace.Players.Player1.ID) = True And caseClicked.BackColor = ColorRace.Players.Player1.color Then

                    checkEatedPawn(NextCase)
                    NextCase.BackColor = ColorRace.Players.Player1.color
                    caseClicked.BackColor = Color.White
                    ColorRace.Moves.removeLeftMoves(ColorRace.Players.playerID, ColorRace.Moves.Check.requiredMovesToMove)

                End If

            ElseIf ColorRace.Players.playerID = ColorRace.Players.Player2.ID Then

                If caseClicked Is ColorRace.Players.Player2.startScale And ColorRace.Players.Player2.startScale.BackColor = ColorRace.Players.Player2.color And ColorRace.Moves.Check.canGoUpInScale(ColorRace.Players.Player2.ID) = True Then

                    ColorRace.Moves.moveInScale(ColorRace.Players.Player2.scale1, ColorRace.Players.Player2.scale2, ColorRace.Players.Player2.scale3, ColorRace.Players.Player2.startScale)
                    ColorRace.Moves.removeLeftMoves(ColorRace.Players.playerID, ColorRace.Moves.Check.requiredMovesToGoInScale)

                ElseIf ColorRace.Moves.Check.canMove(ColorRace.Players.Player2.ID) = True And caseClicked.BackColor = ColorRace.Players.Player2.color Then

                    checkEatedPawn(NextCase)
                    NextCase.BackColor = ColorRace.Players.Player2.color
                    caseClicked.BackColor = Color.White
                    ColorRace.Moves.removeLeftMoves(ColorRace.Players.playerID, ColorRace.Moves.Check.requiredMovesToMove)

                End If

            ElseIf ColorRace.Players.playerID = ColorRace.Players.Player3.ID Then

                If caseClicked Is ColorRace.Players.Player3.startScale And ColorRace.Players.Player3.startScale.BackColor = ColorRace.Players.Player3.color And ColorRace.Moves.Check.canGoUpInScale(ColorRace.Players.Player3.ID) = True Then

                    ColorRace.Moves.moveInScale(ColorRace.Players.Player3.scale1, ColorRace.Players.Player3.scale2, ColorRace.Players.Player3.scale3, ColorRace.Players.Player3.startScale)
                    ColorRace.Moves.removeLeftMoves(ColorRace.Players.playerID, ColorRace.Moves.Check.requiredMovesToGoInScale)

                ElseIf ColorRace.Moves.Check.canMove(ColorRace.Players.Player3.ID) = True And caseClicked.BackColor = ColorRace.Players.Player3.color Then

                    checkEatedPawn(NextCase)
                    NextCase.BackColor = ColorRace.Players.Player3.color
                    caseClicked.BackColor = Color.White
                    ColorRace.Moves.removeLeftMoves(ColorRace.Players.playerID, ColorRace.Moves.Check.requiredMovesToMove)

                End If

            ElseIf ColorRace.Players.playerID = ColorRace.Players.Player4.ID Then

                If caseClicked Is ColorRace.Players.Player4.startScale And ColorRace.Players.Player4.startScale.BackColor = ColorRace.Players.Player4.color And ColorRace.Moves.Check.canGoUpInScale(ColorRace.Players.Player4.ID) = True Then

                    ColorRace.Moves.moveInScale(ColorRace.Players.Player4.scale1, ColorRace.Players.Player4.scale2, ColorRace.Players.Player4.scale3, ColorRace.Players.Player4.startScale)
                    ColorRace.Moves.removeLeftMoves(ColorRace.Players.playerID, ColorRace.Moves.Check.requiredMovesToGoInScale)

                ElseIf ColorRace.Moves.Check.canMove(ColorRace.Players.Player4.ID) = True And caseClicked.BackColor = ColorRace.Players.Player4.color Then

                    checkEatedPawn(NextCase)
                    NextCase.BackColor = ColorRace.Players.Player4.color
                    caseClicked.BackColor = Color.White
                    ColorRace.Moves.removeLeftMoves(ColorRace.Players.playerID, ColorRace.Moves.Check.requiredMovesToMove)

                End If

            End If

        End Sub

        ''' <summary>
        ''' Mange un pion s'il y en a un sur la case suivante
        ''' </summary>
        ''' <param name="nextCase"></param>
        Shared Sub checkEatedPawn(nextCase)
            Dim pawnEated As Boolean = False
            If nextCase.BackColor = ColorRace.Players.Player1.color Then
                pawnEated = True
                ColorRace.Players.Player1.leftPawns = ColorRace.Players.Player1.leftPawns + 1
                ColorRace.Players.Player1.ranch.Text = ColorRace.Players.Player1.leftPawns.ToString
                If ColorRace.Players.Player1.emblemID = ColorRace.emblems.emblem2.ID Then
                    ColorRace.Moves.addLeftMoves(ColorRace.Players.Player1.ID, ColorRace.emblems.emblem2.wonMovements)
                End If
            End If
            If ColorRace.playersNumber >= 2 Then
                If nextCase.BackColor = ColorRace.Players.Player2.color Then
                    pawnEated = True
                    ColorRace.Players.Player2.leftPawns = ColorRace.Players.Player2.leftPawns + 1
                    ColorRace.Players.Player2.ranch.Text = ColorRace.Players.Player2.leftPawns.ToString
                    If ColorRace.Players.Player2.emblemID = ColorRace.emblems.emblem2.ID Then
                        ColorRace.Moves.addLeftMoves(ColorRace.Players.Player2.ID, ColorRace.emblems.emblem2.wonMovements)
                    End If
                End If
            End If
            If ColorRace.playersNumber >= 3 Then
                If nextCase.BackColor = ColorRace.Players.Player3.color Then
                    pawnEated = True
                    ColorRace.Players.Player3.leftPawns = ColorRace.Players.Player3.leftPawns + 1
                    ColorRace.Players.Player3.ranch.Text = ColorRace.Players.Player3.leftPawns.ToString
                    If ColorRace.Players.Player3.emblemID = ColorRace.emblems.emblem2.ID Then
                        ColorRace.Moves.addLeftMoves(ColorRace.Players.Player3.ID, ColorRace.emblems.emblem2.wonMovements)
                    End If
                End If
            End If
            If ColorRace.playersNumber >= 4 Then
                If nextCase.BackColor = ColorRace.Players.Player4.color Then
                    pawnEated = True
                    ColorRace.Players.Player4.leftPawns = ColorRace.Players.Player4.leftPawns + 1
                    ColorRace.Players.Player4.ranch.Text = ColorRace.Players.Player4.leftPawns.ToString
                    If ColorRace.Players.Player4.emblemID = ColorRace.emblems.emblem2.ID Then
                        ColorRace.Moves.addLeftMoves(ColorRace.Players.Player4.ID, ColorRace.emblems.emblem2.wonMovements)
                    End If
                End If
            End If

            If pawnEated = True Then

                If ColorRace.emblems.getEmblem(ColorRace.Players.playerID) = ColorRace.emblems.emblem1.ID Then
                    ColorRace.Moves.addLeftMoves(ColorRace.Players.playerID, ColorRace.emblems.emblem1.wonMovements)
                    ColorRace_MainForm.emblemLabel.Text = "+ " + ColorRace.emblems.emblem1.wonMovements.ToString + " mouvement(s)"
                End If

            End If

        End Sub

        ''' <summary>
        ''' Avance le pion d'une case à l'échelle
        ''' </summary>
        ''' <param name="scale1">Le premier palier de l'échelle du jouer</param>
        ''' <param name="scale2">Le deuxième palier de l'échelle du jouer</param>
        ''' <param name="scale3">Le troisième palier de l'échelle du jouer</param>
        ''' <param name="startCase">La case cliquée</param>
        Shared Sub moveInScale(scale1 As Label, scale2 As Label, scale3 As Label, startCase As PictureBox)

            If scale1.BackColor = ColorRace.Players.getColor(ColorRace.Players.playerID) Then

                startCase.BackColor = Color.White
                scale1.BackColor = Color.White

            ElseIf scale2.BackColor = ColorRace.Players.getColor(ColorRace.Players.playerID) Then

                startCase.BackColor = Color.White
                scale2.BackColor = Color.White

            ElseIf scale3.BackColor = ColorRace.Players.getColor(ColorRace.Players.playerID) Then

                startCase.BackColor = Color.White
                scale3.BackColor = Color.White

            Else

                startCase.BackColor = Color.White
                ColorRace_MainForm.WinnerCase.BackColor = ColorRace.Players.getColor(ColorRace.Players.playerID)
                ColorRace_Winner.ShowWinner(ColorRace.Players.getColor(ColorRace.Players.playerID))

            End If

        End Sub

    End Structure

    Structure playerColor

        Shared ReadOnly color1 As Color = Color.Blue
        Shared ReadOnly color1String As String = "bleu"
        Shared ReadOnly color2 As Color = Color.Red
        Shared ReadOnly color2String As String = "rouge"
        Shared ReadOnly color3 As Color = Color.Yellow
        Shared ReadOnly color3String As String = "jaune"
        Shared ReadOnly color4 As Color = Color.Green
        Shared ReadOnly color4String As String = "vert"

    End Structure

    Structure emblems

        ''' <summary>
        ''' Obtient l'ID de l'emblème de joueur
        ''' </summary>
        ''' <param name="playerID">L'ID du joueur</param>
        ''' <returns>L'ID de l'emblème du joueur</returns>
        Shared Function getEmblem(playerID As Integer)

            If playerID = ColorRace.Players.Player1.ID Then
                Return ColorRace.Players.Player1.emblemID
            ElseIf playerID = ColorRace.Players.Player2.ID Then
                Return ColorRace.Players.Player2.emblemID
            ElseIf playerID = ColorRace.Players.Player3.ID Then
                Return ColorRace.Players.Player3.emblemID
            ElseIf playerID = ColorRace.Players.Player4.ID Then
                Return ColorRace.Players.Player4.emblemID
            Else
                Return 0
            End If

        End Function

        ''' <summary>
        ''' Obtient le nom de l'emblème
        ''' </summary>
        ''' <param name="emblemID">L'ID de l'emblème</param>
        ''' <returns>Le nom de l'emblème</returns>
        Shared Function getEmblemName(emblemID As Integer)

            If emblemID = ColorRace.emblems.emblem1.ID Then

                Return ColorRace.emblems.emblem1.name

            ElseIf emblemID = ColorRace.emblems.emblem2.ID Then

                Return ColorRace.emblems.emblem2.name

            ElseIf emblemID = ColorRace.emblems.emblem3.ID Then

                Return ColorRace.emblems.emblem3.name

            ElseIf emblemID = ColorRace.emblems.emblem4.ID Then

                Return ColorRace.emblems.emblem4.name

            Else

                Return ""

            End If

        End Function

        ''' <summary>
        ''' Obtient la description de l'emblème
        ''' </summary>
        ''' <param name="emblemID">L'ID de l'emblème</param>
        ''' <returns>La description de l'emblème</returns>
        Shared Function getDescription(emblemID As Integer)

            If emblemID = ColorRace.emblems.emblem1.ID Then

                Return ColorRace.emblems.emblem1.description

            ElseIf emblemID = ColorRace.emblems.emblem2.ID Then

                Return ColorRace.emblems.emblem2.description

            ElseIf emblemID = ColorRace.emblems.emblem3.ID Then

                Return ColorRace.emblems.emblem3.description

            ElseIf emblemID = ColorRace.emblems.emblem4.ID Then

                Return ColorRace.emblems.emblem4.description

            Else

                Return ""

            End If

        End Function

        Structure emblem1

            ''' <summary>
            ''' Obtient l'ID de l'emblème 1
            ''' </summary>
            Shared ReadOnly ID As Integer = 1

            ''' <summary>
            ''' Obtient le nom de l'emblème 1
            ''' </summary>
            Shared ReadOnly name As String = "Assassin"

            ''' <summary>
            ''' Obtient le nombre de mouvements gagnés lorqu'un pion est mangé
            ''' </summary>
            Shared ReadOnly wonMovements As Integer = 2

            ''' <summary>
            ''' Obtient la description de l'emblème 1
            ''' </summary>
            Shared ReadOnly description As String = "A chaque fois que vous mangez un pion, vous gagnez " + ColorRace.emblems.emblem1.wonMovements.ToString + " mouvement(s)."

        End Structure

        Structure emblem2

            ''' <summary>
            ''' Obtient l'ID de l'emblème 2
            ''' </summary>
            Shared ReadOnly ID As Integer = 2

            ''' <summary>
            ''' Obtient le nom de l'emblème 2
            ''' </summary>
            Shared ReadOnly name As String = "Vengeance"

            ''' <summary>
            ''' Obtient le nombre de mouvements gagnés lorqu'un pion est mangé
            ''' </summary>
            Shared ReadOnly wonMovements As Integer = 5

            ''' <summary>
            ''' Obtient la description de l'emblème 2
            ''' </summary>
            Shared ReadOnly description As String = "A chaque fois qu'un de vos pions est mangé, vous gagnez " + ColorRace.emblems.emblem2.wonMovements.ToString + " mouvement(s)."

        End Structure

        Structure emblem3

            ''' <summary>
            ''' Obtient l'ID de l'emblème 3
            ''' </summary>
            Shared ReadOnly ID As Integer = 3

            ''' <summary>
            ''' Obtient le nom de l'emblème 3
            ''' </summary>
            Shared ReadOnly name As String = "Accélération"

            ''' <summary>
            ''' Obtient la chance que le joueur gagne des mouvements à chaque tour
            ''' </summary>
            Shared ReadOnly wonMovementsProbability As Integer = 2

            ''' <summary>
            ''' Obtient le nombre de mouvements gagnés à chaque tour
            ''' </summary>
            Shared ReadOnly wonMovements As Integer = 1

            ''' <summary>
            ''' Obtient la description de l'emblème 3
            ''' </summary>
            Shared ReadOnly description As String = "A chacun de vos tours, vous avez 1 chance sur " + ColorRace.emblems.emblem3.wonMovementsProbability.ToString + " de gagner " + ColorRace.emblems.emblem3.wonMovements.ToString + " mouvement(s)."

        End Structure

        Structure emblem4

            ''' <summary>
            ''' Obtient l'ID de l'emblème 4
            ''' </summary>
            Shared ReadOnly ID As Integer = 4

            ''' <summary>
            ''' Obtient le nom de l'emblème 4
            ''' </summary>
            Shared ReadOnly name As String = "Sortie boostée"

            ''' <summary>
            ''' Obtient le nombre de mouvements gagnés lorqu'un pion est sortie
            ''' </summary>
            Shared ReadOnly wonMovements As Integer = 5

            ''' <summary>
            ''' Obtient la description de l'emblème 1
            ''' </summary>
            Shared ReadOnly description As String = "A chaque fois que vous sortez un pion, vous gagnez " + ColorRace.emblems.emblem4.wonMovements.ToString + " mouvement(s)."

        End Structure

    End Structure

    Structure Players

        ''' <summary>
        ''' Représente l'ID du joueur
        ''' </summary>
        Shared playerID As Integer

        ''' <summary>
        ''' Obtient le nombre de pions de chaque joueur
        ''' </summary>
        Shared ReadOnly defaultPawns As Integer = 4

        ''' <summary>
        ''' Obtient le nombre de pions restants pour un joueur
        ''' </summary>
        ''' <param name="playerID">L'ID du joueur</param>
        ''' <returns>Le nombre de pions restants à l'écurie pour le joueur</returns>
        Shared Function getLeftPawns(playerID As Integer)

            If playerID = ColorRace.Players.Player1.ID Then
                Return ColorRace.Players.Player1.leftPawns
            ElseIf playerID = ColorRace.Players.Player2.ID Then
                Return ColorRace.Players.Player2.leftPawns
            ElseIf playerID = ColorRace.Players.Player3.ID Then
                Return ColorRace.Players.Player3.leftPawns
            ElseIf playerID = ColorRace.Players.Player4.ID Then
                Return ColorRace.Players.Player4.leftPawns
            Else
                Return 0
            End If

        End Function

        ''' <summary>
        ''' Obtient le nombre de mouvements restants pour le joueur
        ''' </summary>
        ''' <param name="playerID">L'ID du joueur</param>
        ''' <returns>Le nombre de mouvements restants pour le le joueur</returns>
        Shared Function getLeftMoves(playerID As Integer)

            If playerID = ColorRace.Players.Player1.ID Then
                Return ColorRace.Players.Player1.leftMoves
            ElseIf playerID = ColorRace.Players.Player2.ID Then
                Return ColorRace.Players.Player2.leftMoves
            ElseIf playerID = ColorRace.Players.Player3.ID Then
                Return ColorRace.Players.Player3.leftMoves
            ElseIf playerID = ColorRace.Players.Player4.ID Then
                Return ColorRace.Players.Player4.leftMoves
            Else
                Return 0
            End If
        End Function

        ''' <summary>
        ''' Obtient la couleur du joueur
        ''' </summary>
        ''' <param name="playerID">L'ID du joueur</param>
        ''' <returns>La couleur correspondant au joueur</returns>
        Shared Function getColor(playerID As String)

            If playerID = ColorRace.Players.Player1.ID Then

                Return ColorRace.Players.Player1.color

            ElseIf playerID = ColorRace.Players.Player2.ID Then

                Return ColorRace.Players.Player2.color

            ElseIf playerID = ColorRace.Players.Player3.ID Then

                Return ColorRace.Players.Player3.color

            ElseIf playerID = ColorRace.Players.Player4.ID Then

                Return ColorRace.Players.Player4.color

            Else

                Return Color.Black

            End If

        End Function

        ''' <summary>
        ''' Obtient la chaine de caractères correspondant à l'ID du joueur
        ''' </summary>
        ''' <param name="playerID">L'ID du joueur</param>
        ''' <returns>La chaine de caractères correspondant à l'ID</returns>
        Shared Function getString(playerID As Integer)

            If playerID = ColorRace.Players.Player1.ID Then

                Return ColorRace.Players.Player1.colorString

            ElseIf playerID = ColorRace.Players.Player2.ID Then

                Return ColorRace.Players.Player2.colorString

            ElseIf playerID = ColorRace.Players.Player3.ID Then

                Return ColorRace.Players.Player3.colorString

            ElseIf playerID = ColorRace.Players.Player4.ID Then

                Return ColorRace.Players.Player4.colorString

            Else

                Return Nothing

            End If

        End Function

        ''' <summary>
        ''' Obtient l'ID du joueur suivant le joueur actuel
        ''' </summary>
        ''' <returns>L'ID du joueur suivant</returns>
        Shared Function nextPlayer()

            If ColorRace.playersNumber = 1 Then
                Return ColorRace.Players.Player1.ID
            ElseIf ColorRace.playersNumber = 2 Then
                If ColorRace.Players.playerID = ColorRace.Players.Player1.ID Then
                    Return ColorRace.Players.Player2.ID
                ElseIf ColorRace.Players.playerID = ColorRace.Players.Player2.ID Then
                    Return ColorRace.Players.Player1.ID
                Else
                    Return 0
                End If
            ElseIf ColorRace.playersNumber = 3 Then
                If ColorRace.Players.playerID = ColorRace.Players.Player1.ID Then
                    Return ColorRace.Players.Player2.ID
                ElseIf ColorRace.Players.playerID = ColorRace.Players.Player2.ID Then
                    Return ColorRace.Players.Player3.ID
                ElseIf ColorRace.Players.playerID = ColorRace.Players.Player3.ID Then
                    Return ColorRace.Players.Player1.ID
                Else
                    Return 0
                End If
            ElseIf ColorRace.playersNumber = 4 Then
                If ColorRace.Players.playerID = ColorRace.Players.Player1.ID Then
                    Return ColorRace.Players.Player2.ID
                ElseIf ColorRace.Players.playerID = ColorRace.Players.Player2.ID Then
                    Return ColorRace.Players.Player3.ID
                ElseIf ColorRace.Players.playerID = ColorRace.Players.Player3.ID Then
                    Return ColorRace.Players.Player4.ID
                ElseIf ColorRace.Players.playerID = ColorRace.Players.Player4.ID Then
                    Return ColorRace.Players.Player1.ID
                Else
                    Return 0
                End If
            Else
                Return 0
            End If

        End Function

        ''' <summary>
        ''' Crée un nouveau tour pour le joueur
        ''' </summary>
        ''' <param name="playerID">L'ID du joueur</param>
        Shared Sub newTurn(playerID As Integer)

            ColorRace_MainForm.infoTableLayoutPanel.BackColor = ColorRace.Players.getColor(playerID)
            ColorRace_MainForm.playerLabel.Text = "Joueur " + ColorRace.Players.playerID.ToString

            ColorRace_MainForm.emblemLabel.Text = ColorRace.emblems.getEmblemName(ColorRace.emblems.getEmblem(ColorRace.Players.playerID))

            ColorRace_MainForm.goOutPawnPriceLabel.Text = ColorRace.Moves.Check.requiredMovesToGoOut.ToString
            ColorRace_MainForm.movePawnPriceLabel.Text = ColorRace.Moves.Check.requiredMovesToMove.ToString
            ColorRace_MainForm.goInScalePriceLabel.Text = ColorRace.Moves.Check.requiredMovesToGoInScale.ToString

            ColorRace.Moves.updateLeftMoves(playerID)

            ColorRace_MainForm.dicesButton.Enabled = True

        End Sub

        Structure Player1

            ''' <summary>
            ''' Obtient l'ID du joueur 1
            ''' </summary>
            Shared ReadOnly ID As Integer = 1

            ''' <summary>
            ''' Obtient la couleur du joueur 1
            ''' </summary>
            Shared color As Color

            ''' <summary>
            ''' Obtient la chaine de caractères correspondantes à la couleur du joueur 1
            ''' </summary>
            Shared colorString As String

            ''' <summary>
            ''' Obtient l'emblème de joueur 1
            ''' </summary>
            Shared emblemID As String

            ''' <summary>
            ''' Obtient le nombre de pions restants à l'écurie pour le joueur 1
            ''' </summary>
            Shared leftPawns As Integer

            ''' <summary>
            ''' Obtient le nombre de mouvements restants pour le joueur 1
            ''' </summary>
            Shared leftMoves As Integer

            ''' <summary>
            ''' Obtient le nombre total de mouvements pouvant être stockés pour le joueur 1
            ''' </summary>
            Shared totalMovements As Integer

            ''' <summary>
            ''' Obtient le ranch du joueur 1
            ''' </summary>
            Shared ranch As Label = ColorRace_MainForm.player1Ranch

            ''' <summary>
            ''' Obtient la case de départ du joueur 1
            ''' </summary>
            Shared startCase As PictureBox = ColorRace_MainForm.case1

            ''' <summary>
            ''' Obtient la case à la base de l'échelle du joueur 1
            ''' </summary>
            Shared startScale As PictureBox = ColorRace_MainForm.case32

            ''' <summary>
            ''' Obtient le premier palier de l'échelle du joueur 1
            ''' </summary>
            Shared scale1 As Label = ColorRace_MainForm.player1Scale1

            ''' <summary>
            ''' Obtient le deuxième palier de l'échelle du joueur 1
            ''' </summary>
            Shared scale2 As Label = ColorRace_MainForm.player1Scale2

            ''' <summary>
            ''' Obtient le troisième palier de l'échelle du joueur 1
            ''' </summary>
            Shared scale3 As Label = ColorRace_MainForm.player1Scale3

        End Structure

        Structure Player2

            ''' <summary>
            ''' Obtient l'ID du joueur 2
            ''' </summary>
            Shared ReadOnly ID As Integer = 2

            ''' <summary>
            ''' Obtient la couleur du joueur 2
            ''' </summary>
            Shared color As Color

            ''' <summary>
            ''' Obtient la chaine de caractères correspondantes à la couleur du joueur 2
            ''' </summary>
            Shared colorString As String

            ''' <summary>
            ''' Obtient l'emblème de joueur 1
            ''' </summary>
            Shared emblemID As String

            ''' <summary>
            ''' Obtient le nombre de pions restants à l'écurie pour le joueur 2
            ''' </summary>
            Shared leftPawns As Integer

            ''' <summary>
            ''' Obtient le nombre de mouvements restants pour le joueur 2
            ''' </summary>
            Shared leftMoves As Integer

            ''' <summary>
            ''' Obtient le nombre total de mouvements pouvant être stockés pour le joueur 2
            ''' </summary>
            Shared totalMovements As Integer

            ''' <summary>
            ''' Obtient le ranch du joueur 2
            ''' </summary>
            Shared ranch As Label = ColorRace_MainForm.player2Ranch

            ''' <summary>
            ''' Obtient la case de départ du joueur 2
            ''' </summary>
            Shared startCase As PictureBox = ColorRace_MainForm.case9

            ''' <summary>
            ''' Obtient la case à la base de l'échelle du joueur 2
            ''' </summary>
            Shared startScale As PictureBox = ColorRace_MainForm.case8

            ''' <summary>
            ''' Obtient le premier palier de l'échelle du joueur 2
            ''' </summary>
            Shared scale1 As Label = ColorRace_MainForm.player2Scale1

            ''' <summary>
            ''' Obtient le deuxième palier de l'échelle du joueur 2
            ''' </summary>
            Shared scale2 As Label = ColorRace_MainForm.player2Scale2

            ''' <summary>
            ''' Obtient le troisième palier de l'échelle du joueur 2
            ''' </summary>
            Shared scale3 As Label = ColorRace_MainForm.player2Scale3

        End Structure

        Structure Player3

            ''' <summary>
            ''' Obtient l'ID du joueur 3
            ''' </summary>
            Shared ReadOnly ID As Integer = 3

            ''' <summary>
            ''' Obtient la couleur du joueur 3
            ''' </summary>
            Shared color As Color

            ''' <summary>
            ''' Obtient la chaine de caractères correspondantes à la couleur du joueur 3
            ''' </summary>
            Shared colorString As String

            ''' <summary>
            ''' Obtient l'emblème de joueur 1
            ''' </summary>
            Shared emblemID As String

            ''' <summary>
            ''' Obtient le nombre de pions restants à l'écurie pour le joueur 3
            ''' </summary>
            Shared leftPawns As Integer

            ''' <summary>
            ''' Obtient le nombre de mouvements restants pour le joueur 3
            ''' </summary>
            Shared leftMoves As Integer

            ''' <summary>
            ''' Obtient le nombre total de mouvements pouvant être stockés pour le joueur 3
            ''' </summary>
            Shared totalMovements As Integer

            ''' <summary>
            ''' Obtient le ranch du joueur 3
            ''' </summary>
            Shared ranch As Label = ColorRace_MainForm.player3Ranch

            ''' <summary>
            ''' Obtient la case de départ du joueur 3
            ''' </summary>
            Shared startCase As PictureBox = ColorRace_MainForm.case17

            ''' <summary>
            ''' Obtient la case à la base de l'échelle du joueur 1
            ''' </summary>
            Shared startScale As PictureBox = ColorRace_MainForm.case16

            ''' <summary>
            ''' Obtient le premier palier de l'échelle du joueur 3
            ''' </summary>
            Shared scale1 As Label = ColorRace_MainForm.player3Scale1

            ''' <summary>
            ''' Obtient le deuxième palier de l'échelle du joueur 3
            ''' </summary>
            Shared scale2 As Label = ColorRace_MainForm.player3Scale2

            ''' <summary>
            ''' Obtient le troisième palier de l'échelle du joueur 3
            ''' </summary>
            Shared scale3 As Label = ColorRace_MainForm.player3Scale3

        End Structure

        Structure Player4

            ''' <summary>
            ''' Obtient l'ID du joueur 4
            ''' </summary>
            Shared ReadOnly ID As Integer = 4

            ''' <summary>
            ''' Obtient la couleur du joueur 4
            ''' </summary>
            Shared color As Color

            ''' <summary>
            ''' Obtient la chaine de caractères correspondantes à la couleur du joueur 4
            ''' </summary>
            Shared colorString As String

            ''' <summary>
            ''' Obtient l'emblème de joueur 1
            ''' </summary>
            Shared emblemID As String

            ''' <summary>
            ''' Obtient le nombre de pions restants à l'écurie pour le joueur 4
            ''' </summary>
            Shared leftPawns As Integer

            ''' <summary>
            ''' Obtient le nombre de mouvements restants pour le joueur 4
            ''' </summary>
            Shared leftMoves As Integer

            ''' <summary>
            ''' Obtient le nombre total de mouvements pouvant être stockés pour le joueur 4
            ''' </summary>
            Shared totalMovements As Integer

            ''' <summary>
            ''' Obtient le ranch du joueur 1
            ''' </summary>
            Shared ranch As Label

            ''' <summary>
            ''' Obtient la case de départ du joueur 4
            ''' </summary>
            Shared startCase As PictureBox

            ''' <summary>
            ''' Obtient la case à la base de l'échelle du joueur 1
            ''' </summary>
            Shared startScale As PictureBox

            ''' <summary>
            ''' Obtient le premier palier de l'échelle du joueur 4
            ''' </summary>
            Shared scale1 As Label

            ''' <summary>
            ''' Obtient le deuxième palier de l'échelle du joueur 4
            ''' </summary>
            Shared scale2 As Label

            ''' <summary>
            ''' Obtient le troisième palier de l'échelle du joueur 4
            ''' </summary>
            Shared scale3 As Label

        End Structure

    End Structure

End Structure


