Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        'Set variables
        Dim bytToRoll As Byte
        Dim bytNumRolls As Byte
        Dim bytDieRoll As Byte

        'Get input
        bytToRoll = Convert.ToByte(nudToRoll.Text)

        'Set loop, roll dice, and output numbers rolled
        rtbDiceRolls.Clear()
        Do While bytDieRoll <> bytToRoll
            bytDieRoll = Int(Rnd() * 6 + 1)
            rtbDiceRolls.AppendText(bytDieRoll.ToString & vbNewLine)
            bytNumRolls += 1
        Loop
        'Output number of rolls
        lblNumRolls.Text = "Number of jelly donut rolls: " & bytNumRolls.ToString
    End Sub
End Class

' changed number of rolls to number of donut rolls to intentionally create pull request conflict