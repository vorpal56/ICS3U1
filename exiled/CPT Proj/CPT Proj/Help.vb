Public Class Help
    Dim key, upY, downY As Boolean
    Dim valY As Integer

    Private Sub Help_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        valY = 2
        upY = True
        downY = True
        key = True
        Timer1.Start()
    End Sub

    Private Sub Help_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If key = True Then
            If upY = True Then
                If e.KeyCode = Keys.Down Then
                    If valY > 1 And valY < 3 Then
                        valY -= 1
                    Else
                        valY = 2
                    End If
                End If
            End If
        End If
        If key = True Then
            If downY = True Then
                If e.KeyCode = Keys.Up Then
                    If valY > 0 And valY < 2 Then
                        valY += 1
                    Else
                        valY = 1
                    End If
                End If
            End If
        End If

        If e.KeyCode = Keys.Enter And valY = 2 Then
            Me.Hide()
            Credits.Show()
        ElseIf valY = 2 Then
            lblMessage2.Hide()
        ElseIf e.KeyCode = Keys.Enter And valY = 1 Then
            Application.Exit()
        ElseIf valY = 1 Then
            lblMessage2.Show()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            If helpoption = 1 Then 'helpoption is declared in DelayFunction Module
                OpenScreen.Show()
                OpenScreen.BringToFront()
            ElseIf helpoption = 2 Then
                Tutorial.Show()
                Tutorial.BringToFront()
            ElseIf helpoption = 3 And frmLevel1.Enabled = False Then
                frmLevel1.Enabled = True
                frmLevel1.BringToFront()
            ElseIf helpoption = 4 And frmLevel2.Enabled = False Then
                frmLevel2.Enabled = True
                frmLevel2.BringToFront()
            ElseIf helpoption = 5 And frmLevel3.Enabled = False Then
                frmLevel3.Enabled = True
                frmLevel3.BringToFront()
            ElseIf helpoption = 6 And frmLevel4.Enabled = False Then
                frmLevel4.Enabled = True
                frmLevel4.BringToFront()
            ElseIf helpoption = 7 And frmLevel5.Enabled = False Then
                frmLevel5.Enabled = True
                frmLevel5.BringToFront()
            ElseIf helpoptionCredits = 1 Then
                Credits.Show()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If key = True Then
            If valY = 2 Then
                lbloption1.BackColor = Color.DarkRed
                lbloption2.BackColor = Color.DimGray
            ElseIf valY = 1 Then
                lbloption1.BackColor = Color.DimGray
                lbloption2.BackColor = Color.DodgerBlue
            End If
        End If
    End Sub

End Class