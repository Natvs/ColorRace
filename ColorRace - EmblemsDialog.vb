Public Class ColorRace_EmblemsDialog

    Private Sub ColorRace_EmblemsDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        okButton.Enabled = False

        initializeAll()

        player1Label.BackColor = ColorRace.Players.Player1.color
        player1Emblem1Button.Text = ColorRace.emblems.emblem1.name
        player1Emblem2Button.Text = ColorRace.emblems.emblem2.name
        player1Emblem3Button.Text = ColorRace.emblems.emblem3.name
        player1Emblem4Button.Text = ColorRace.emblems.emblem4.name
        player1DescriptionLabel.Text = "La description de l'emblème s'affiche ici"

        If ColorRace.playersNumber >= 2 Then

            player2Label.BackColor = ColorRace.Players.Player2.color
            player2Emblem1Button.Text = ColorRace.emblems.emblem1.name
            player2Emblem2Button.Text = ColorRace.emblems.emblem2.name
            player2Emblem3Button.Text = ColorRace.emblems.emblem3.name
            player2Emblem4Button.Text = ColorRace.emblems.emblem4.name
            player2DescriptionLabel.Text = "La description de l'emblème s'affiche ici"

            If ColorRace.playersNumber >= 3 Then

                player3Label.BackColor = ColorRace.Players.Player3.color
                player3Emblem1Button.Text = ColorRace.emblems.emblem1.name
                player3Emblem2Button.Text = ColorRace.emblems.emblem2.name
                player3Emblem3Button.Text = ColorRace.emblems.emblem3.name
                player3Emblem4Button.Text = ColorRace.emblems.emblem4.name
                player3DescriptionLabel.Text = "La description de l'emblème s'affiche ici"

                If ColorRace.playersNumber >= 4 Then

                    player4Label.BackColor = ColorRace.Players.Player4.color
                    player4Emblem1Button.Text = ColorRace.emblems.emblem1.name
                    player4Emblem2Button.Text = ColorRace.emblems.emblem2.name
                    player4Emblem3Button.Text = ColorRace.emblems.emblem3.name
                    player4Emblem4Button.Text = ColorRace.emblems.emblem4.name
                    player4DescriptionLabel.Text = "La description de l'emblème s'affiche ici"

                End If

            End If

        End If

    End Sub

    Sub initializeAll()

        ColorRace.Players.Player1.emblemID = 0
        player1Label.BackColor = Color.White
        player1Emblem1Button.Text = ""
        player1Emblem2Button.Text = ""
        player1Emblem3Button.Text = ""
        player1Emblem4Button.Text = ""
        player1Emblem1Button.BackColor = Color.White
        player1Emblem2Button.BackColor = Color.White
        player1Emblem3Button.BackColor = Color.White
        player1Emblem4Button.BackColor = Color.White
        player1DescriptionLabel.Text = ""

        ColorRace.Players.Player2.emblemID = 0
        player2Label.BackColor = Color.White
        player2Emblem1Button.Text = ""
        player2Emblem2Button.Text = ""
        player2Emblem3Button.Text = ""
        player2Emblem4Button.Text = ""
        player2Emblem1Button.BackColor = Color.White
        player2Emblem2Button.BackColor = Color.White
        player2Emblem3Button.BackColor = Color.White
        player2Emblem4Button.BackColor = Color.White
        player2DescriptionLabel.Text = ""

        ColorRace.Players.Player3.emblemID = 0
        player3Label.BackColor = Color.White
        player3Emblem1Button.Text = ""
        player3Emblem2Button.Text = ""
        player3Emblem3Button.Text = ""
        player3Emblem4Button.Text = ""
        player3Emblem1Button.BackColor = Color.White
        player3Emblem2Button.BackColor = Color.White
        player3Emblem3Button.BackColor = Color.White
        player3Emblem4Button.BackColor = Color.White
        player3DescriptionLabel.Text = ""

        ColorRace.Players.Player4.emblemID = 0
        player4Label.BackColor = Color.White
        player4Emblem1Button.Text = ""
        player4Emblem2Button.Text = ""
        player4Emblem3Button.Text = ""
        player4Emblem4Button.Text = ""
        player4Emblem1Button.BackColor = Color.White
        player4Emblem2Button.BackColor = Color.White
        player4Emblem3Button.BackColor = Color.White
        player4Emblem4Button.BackColor = Color.White
        player4DescriptionLabel.Text = ""

    End Sub

    Sub colorRace_player1EmblemClicked(sender As Button, e As EventArgs) Handles player1Emblem1Button.Click, player1Emblem2Button.Click, player1Emblem3Button.Click, player1Emblem4Button.Click

        player1Emblem1Button.BackColor = Color.White
        player1Emblem2Button.BackColor = Color.White
        player1Emblem3Button.BackColor = Color.White
        player1Emblem4Button.BackColor = Color.White

        If sender Is player1Emblem1Button Then

            ColorRace.Players.Player1.emblemID = ColorRace.emblems.emblem1.ID

        ElseIf sender Is player1Emblem2Button Then

            ColorRace.Players.Player1.emblemID = ColorRace.emblems.emblem2.ID

        ElseIf sender Is player1Emblem3Button Then

            ColorRace.Players.Player1.emblemID = ColorRace.emblems.emblem3.ID

        ElseIf sender Is player1Emblem4Button Then

            ColorRace.Players.Player1.emblemID = ColorRace.emblems.emblem4.ID

        End If

        sender.BackColor = ColorRace.Players.Player1.color
        player1DescriptionLabel.Text = ColorRace.emblems.getDescription(ColorRace.emblems.getEmblem(ColorRace.Players.Player1.ID))
        checkEmblemChosen()

    End Sub

    Sub colorRace_player2EmblemClicked(sender As Button, e As EventArgs) Handles player2Emblem1Button.Click, player2Emblem2Button.Click, player2Emblem3Button.Click, player2Emblem4Button.Click

        player2Emblem1Button.BackColor = Color.White
        player2Emblem2Button.BackColor = Color.White
        player2Emblem3Button.BackColor = Color.White
        player2Emblem4Button.BackColor = Color.White

        If sender Is player2Emblem1Button Then

            ColorRace.Players.Player2.emblemID = ColorRace.emblems.emblem1.ID

        ElseIf sender Is player2Emblem2Button Then

            ColorRace.Players.Player2.emblemID = ColorRace.emblems.emblem2.ID

        ElseIf sender Is player2Emblem3Button Then

            ColorRace.Players.Player2.emblemID = ColorRace.emblems.emblem3.ID

        ElseIf sender Is player2Emblem4Button Then

            ColorRace.Players.Player2.emblemID = ColorRace.emblems.emblem4.ID

        End If

        sender.BackColor = ColorRace.Players.Player2.color
        player2DescriptionLabel.Text = ColorRace.emblems.getDescription(ColorRace.emblems.getEmblem(ColorRace.Players.Player2.ID))
        checkEmblemChosen()

    End Sub

    Sub colorRace_player3EmblemClicked(sender As Button, e As EventArgs) Handles player3Emblem1Button.Click, player3Emblem2Button.Click, player3Emblem3Button.Click, player3Emblem4Button.Click

        player3Emblem1Button.BackColor = Color.White
        player3Emblem2Button.BackColor = Color.White
        player3Emblem3Button.BackColor = Color.White
        player3Emblem4Button.BackColor = Color.White

        If sender Is player3Emblem1Button Then

            ColorRace.Players.Player3.emblemID = ColorRace.emblems.emblem1.ID

        ElseIf sender Is player3Emblem2Button Then

            ColorRace.Players.Player3.emblemID = ColorRace.emblems.emblem2.ID

        ElseIf sender Is player3Emblem3Button Then

            ColorRace.Players.Player3.emblemID = ColorRace.emblems.emblem3.ID

        ElseIf sender Is player3Emblem4Button Then

            ColorRace.Players.Player3.emblemID = ColorRace.emblems.emblem4.ID

        End If

        sender.BackColor = ColorRace.Players.Player3.color
        player3DescriptionLabel.Text = ColorRace.emblems.getDescription(ColorRace.emblems.getEmblem(ColorRace.Players.Player3.ID))
        checkEmblemChosen()

    End Sub

    Sub colorRace_player4EmblemClicked(sender As Button, e As EventArgs) Handles player4Emblem1Button.Click, player4Emblem2Button.Click, player4Emblem3Button.Click, player4Emblem4Button.Click

        player4Emblem1Button.BackColor = Color.White
        player4Emblem2Button.BackColor = Color.White
        player4Emblem3Button.BackColor = Color.White
        player4Emblem4Button.BackColor = Color.White

        If sender Is player4Emblem1Button Then

            ColorRace.Players.Player4.emblemID = ColorRace.emblems.emblem1.ID

        ElseIf sender Is player4Emblem2Button Then

            ColorRace.Players.Player4.emblemID = ColorRace.emblems.emblem2.ID

        ElseIf sender Is player4Emblem3Button Then

            ColorRace.Players.Player4.emblemID = ColorRace.emblems.emblem3.ID

        ElseIf sender Is player4Emblem4Button Then

            ColorRace.Players.Player4.emblemID = ColorRace.emblems.emblem4.ID

        End If

        sender.BackColor = ColorRace.Players.Player4.color
        player4DescriptionLabel.Text = ColorRace.emblems.getDescription(ColorRace.emblems.getEmblem(ColorRace.Players.Player4.ID))
        checkEmblemChosen()

    End Sub

    Sub checkEmblemChosen()

        If ColorRace.playersNumber = 1 Then

            If ColorRace.Players.Player1.emblemID <> 0 Then

                okButton.Enabled = True

            End If

        ElseIf ColorRace.playersNumber = 2 Then

            If ColorRace.Players.Player1.emblemID <> 0 And ColorRace.Players.Player2.emblemID <> 0 Then

                okButton.Enabled = True

            End If

        ElseIf ColorRace.playersNumber = 3 Then

            If ColorRace.Players.Player1.emblemID <> 0 And ColorRace.Players.Player2.emblemID <> 0 And ColorRace.Players.Player3.emblemID <> 0 Then

                okButton.Enabled = True

            End If

        ElseIf ColorRace.playersNumber = 4 Then

            If ColorRace.Players.Player1.emblemID <> 0 And ColorRace.Players.Player2.emblemID <> 0 And ColorRace.Players.Player3.emblemID <> 0 And ColorRace.Players.Player4.emblemID <> 0 Then

                okButton.Enabled = True

            End If

        End If

    End Sub
End Class