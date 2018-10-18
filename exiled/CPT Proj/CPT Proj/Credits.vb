Public Class Credits
    Private Sub Credits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'helpoptionCredits is declared in DelayFunction Module
        helpoptionCredits = 1
        lbloption1.BackColor = Color.DarkRed
        lblMessage2.Show()
    End Sub
    Private Sub Credits_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Application.Exit()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Hide()
            BringToFront()
            If helpoption = 1 Then
                OpenScreen.Show()
                OpenScreen.BringToFront()
            ElseIf helpoption = 2 And frmLevel1.Enabled = False Then
                frmLevel1.Enabled = True
                frmLevel1.BringToFront()
            ElseIf helpoption = 3 And frmLevel2.Enabled = False Then
                frmLevel2.Enabled = True
                frmLevel2.BringToFront()
            ElseIf helpoption = 4 And frmLevel3.Enabled = False Then
                frmLevel3.Enabled = True
                frmLevel3.BringToFront()
            ElseIf helpoption = 6 And frmLevel5.Enabled = False Then
                frmLevel5.Enabled = True
                frmLevel5.BringToFront()
            End If
        End If
    End Sub

    Private Sub lblCredits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCredits.Click

    End Sub
End Class