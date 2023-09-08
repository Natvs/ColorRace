Public Class ColorRace_Winner

    Public Sub ShowWinner(color As Color)
        Show()
        BackColor = color

        Dim colorToWrite As String

        If color = Color.Blue Then
            colorToWrite = "bleu"
        ElseIf color = Color.Green Then
            colorToWrite = "vert"
        ElseIf color = Color.Red Then
            colorToWrite = "rouge"
        ElseIf color = Color.Yellow Then
            colorToWrite = "jaune"
        Else
            colorToWrite = "aucune couleur"
        End If

        winnerLabel.Text = "Le joueur " + colorToWrite + " a gagné !!!"
    End Sub

    Private Sub reenitializeButton_Click(sender As Object, e As EventArgs) Handles reenitializeButton.Click
        ColorRace.exitGame()
    End Sub
End Class