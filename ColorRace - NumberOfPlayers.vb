Public Class ColorRace_NumberOfPlayers

    'PlayerButtons

    Private Sub numberPlayerButton_Click(sender As Object, e As EventArgs) Handles onePlayerButton.Click, twoPlayersButton.Click, threePlayersButton.Click, fourPlayersButton.Click
        ColorRace.playersNumber = sender.Tag
    End Sub

End Class