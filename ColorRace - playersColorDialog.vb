Public Class ColorRace_PlayersColorDialog

    Private Sub ColorRace_playersColorDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        player2TableLayoutPanel.Enabled = False
        player3TableLayoutPanel.Enabled = False
        player4TableLayoutPanel.Enabled = False

        player1Label.BackColor = ColorRace.playerColor.color1
        player1Color1Button.BackColor = ColorRace.playerColor.color1
        player1Color2Button.BackColor = ColorRace.playerColor.color2
        player1Color3Button.BackColor = ColorRace.playerColor.color3
        player1Color4Button.BackColor = ColorRace.playerColor.color4

        If ColorRace.playersNumber >= 2 Then

            player2TableLayoutPanel.Enabled = True
            player2Label.BackColor = ColorRace.playerColor.color2
            player2Color1Button.BackColor = ColorRace.playerColor.color1
            player2Color2Button.BackColor = ColorRace.playerColor.color2
            player2Color3Button.BackColor = ColorRace.playerColor.color3
            player2Color4Button.BackColor = ColorRace.playerColor.color4

        End If

        If ColorRace.playersNumber >= 3 Then

            player3TableLayoutPanel.Enabled = True
            player3Label.BackColor = ColorRace.playerColor.color3
            player3Color1Button.BackColor = ColorRace.playerColor.color1
            player3Color2Button.BackColor = ColorRace.playerColor.color2
            player3Color3Button.BackColor = ColorRace.playerColor.color3
            player3Color4Button.BackColor = ColorRace.playerColor.color4

        End If
        If ColorRace.playersNumber >= 4 Then

            player4TableLayoutPanel.Enabled = True
            player4Label.BackColor = ColorRace.playerColor.color4
            player4Color1Button.BackColor = ColorRace.playerColor.color1
            player4Color2Button.BackColor = ColorRace.playerColor.color2
            player4Color3Button.BackColor = ColorRace.playerColor.color3
            player4Color4Button.BackColor = ColorRace.playerColor.color4

        End If

        checkColors()

    End Sub

    Sub player1ButtonCliked(sender As Button, e As EventArgs) Handles player1Color1Button.Click, player1Color2Button.Click, player1Color3Button.Click, player1Color4Button.Click

        player1Label.BackColor = sender.BackColor
        checkColors()

    End Sub

    Sub player2ButtonCliked(sender As Button, e As EventArgs) Handles player2Color1Button.Click, player2Color2Button.Click, player2Color3Button.Click, player2Color4Button.Click

        player2Label.BackColor = sender.BackColor
        checkColors()

    End Sub

    Sub player3ButtonCliked(sender As Button, e As EventArgs) Handles player3Color1Button.Click, player3Color2Button.Click, player3Color3Button.Click, player3Color4Button.Click

        player3Label.BackColor = sender.BackColor
        checkColors()

    End Sub

    Sub player4ButtonCliked(sender As Button, e As EventArgs) Handles player4Color1Button.Click, player4Color2Button.Click, player4Color3Button.Click, player4Color4Button.Click

        player4Label.BackColor = sender.BackColor
        checkColors()

    End Sub

    Sub checkColors()

        If ColorRace.playersNumber = 1 Then

            okButton.Enabled = True

        ElseIf ColorRace.playersNumber = 2 Then

            If player1Label.BackColor <> player2Label.BackColor Then

                okButton.Enabled = True

            Else

                okButton.Enabled = False

            End If

        ElseIf ColorRace.playersNumber = 3 Then


            If player1Label.BackColor <> player2Label.BackColor And player1Label.BackColor <> player3Label.BackColor And
                player2Label.BackColor <> player3Label.BackColor Then

                okButton.Enabled = True

            Else

                okButton.Enabled = False

            End If

        ElseIf ColorRace.playersNumber = 4 Then


            If player1Label.BackColor <> player2Label.BackColor And player1Label.BackColor <> player3Label.BackColor And player1Label.BackColor <> player4Label.BackColor And
                player2Label.BackColor <> player3Label.BackColor And player2Label.BackColor <> player4Label.BackColor And
                player3Label.BackColor <> player4Label.BackColor Then

                okButton.Enabled = True

            Else

                okButton.Enabled = False

            End If

        End If

    End Sub

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click

        ColorRace.Players.Player1.color = getColor(player1Label)
        ColorRace.Players.Player1.colorString = getString(player1Label)

        If ColorRace.playersNumber >= 2 Then
            ColorRace.Players.Player2.color = getColor(player2Label)
            ColorRace.Players.Player2.colorString = getString(player2Label)
        Else
            ColorRace.Players.Player2.color = Color.White
            ColorRace.Players.Player2.colorString = "<No color>"
        End If

        If ColorRace.playersNumber >= 3 Then
            ColorRace.Players.Player3.color = getColor(player3Label)
            ColorRace.Players.Player3.colorString = getString(player3Label)
        Else
            ColorRace.Players.Player3.color = Color.White
            ColorRace.Players.Player3.colorString = "<No color>"
        End If

        If ColorRace.playersNumber >= 4 Then
            ColorRace.Players.Player4.color = getColor(player4Label)
            ColorRace.Players.Player4.colorString = getString(player4Label)
        Else
            ColorRace.Players.Player4.color = Color.White
            ColorRace.Players.Player4.colorString = "<No color>"
        End If

    End Sub

    ''' <summary>
    ''' Obtient la couleur du joueur
    ''' </summary>
    ''' <param name="playerLabel">Le label du joueur</param>
    ''' <returns></returns>
    Private Function getColor(playerLabel As Label)

        If playerLabel.BackColor = ColorRace.playerColor.color1 Then

            Return ColorRace.playerColor.color1

        ElseIf playerLabel.BackColor = ColorRace.playerColor.color2 Then

            Return ColorRace.playerColor.color2

        ElseIf playerLabel.BackColor = ColorRace.playerColor.color3 Then

            Return ColorRace.playerColor.color3

        ElseIf playerLabel.BackColor = ColorRace.playerColor.color4 Then

            Return ColorRace.playerColor.color4

        Else

            Return Color.White

        End If

    End Function

    ''' <summary>
    ''' Obtient la chaine de caractères qui représente la couleur du joueur
    ''' </summary>
    ''' <param name="playerLabel">Le label du joueur</param>
    ''' <returns></returns>
    Private Function getString(playerLabel As Label)

        If playerLabel.BackColor = ColorRace.playerColor.color1 Then

            Return ColorRace.playerColor.color1String

        ElseIf playerLabel.BackColor = ColorRace.playerColor.color2 Then

            Return ColorRace.playerColor.color2String

        ElseIf playerLabel.BackColor = ColorRace.playerColor.color3 Then

            Return ColorRace.playerColor.color3String

        ElseIf playerLabel.BackColor = ColorRace.playerColor.color4 Then

            Return ColorRace.playerColor.color4String

        Else

            Return "<No Color>"

        End If

    End Function
End Class