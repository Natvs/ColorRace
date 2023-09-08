Public Class ColorRace_MainForm

    'RanchCLicked

    Sub ranchCLicked(sender As Object, e As EventArgs) Handles player1Ranch.Click, player4Ranch.Click, player2Ranch.Click, player3Ranch.Click

        ColorRace.Moves.newPawn(ColorRace.Players.playerID, sender)

    End Sub

    'CaseClicked

    Private Sub caseCLicked(sender As Object, e As EventArgs) Handles case1.Click, case2.Click, case3.Click, case4.Click, case5.Click, case6.Click, case7.Click, case8.Click, case9.Click, case10.Click, case11.Click, case12.Click, case13.Click, case14.Click, case15.Click, case16.Click, case17.Click, case18.Click, case19.Click, case20.Click, case21.Click, case22.Click, case23.Click, case24.Click, case25.Click, case26.Click, case27.Click, case28.Click, case29.Click, case30.Click, case31.Click, case32.Click

        Dim numberCase, numberCase2 As Integer

        numberCase = sender.Tag

        If numberCase = 32 Then
            numberCase2 = 1
        Else
            numberCase2 = numberCase + 1
        End If

        ColorRace.Moves.movePawn(ColorRace.caseList(numberCase), ColorRace.caseList(numberCase2))

    End Sub

    'Quit

    Private Sub quitButton_Click(sender As Object, e As EventArgs) Handles quitButton.Click
        ColorRace.exitGame()
    End Sub

    'Player turn
    Private Sub dicesButton_Click(sender As Object, e As EventArgs) Handles dicesButton.Click

        dicesButton.Enabled = False

        Dim diceRandom As New Random
        Dim emblem3Random As New Random

        ColorRace.Moves.addLeftMoves(ColorRace.Players.playerID, diceRandom.Next(1, ColorRace.Moves.maxMovesWon + 1))

        If ColorRace.emblems.getEmblem(ColorRace.Players.playerID) = ColorRace.emblems.emblem3.ID Then

            If diceRandom.Next(1, ColorRace.emblems.emblem3.wonMovementsProbability + 1) = 1 Then

                ColorRace.Moves.addLeftMoves(ColorRace.Players.playerID, ColorRace.emblems.emblem3.wonMovements)
                emblemLabel.Text = "+ " + ColorRace.emblems.emblem3.wonMovements.ToString + " mouvement(s)"

            End If

        End If

        leftMovesLabel.Text = ColorRace.Players.getLeftMoves(ColorRace.Players.playerID).ToString
    End Sub

    Private Sub endTurnButton_Click(sender As Object, e As EventArgs) Handles endTurnButton.Click
        ColorRace.Players.playerID = ColorRace.Players.nextPlayer
        ColorRace.Players.newTurn(ColorRace.Players.playerID)
    End Sub
End Class