Public Class CreditsLevel5
    Dim key, upY, downY As Boolean
    Dim valY As Integer

    Private Sub CreditsLevel5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        valY = 2
        upY = True
        downY = True
        key = True
        Timer1.Start()
    End Sub

    Private Sub CreditsLevel5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
            Application.Restart()
        ElseIf valY = 2 Then
            lblMessage2.Hide()
        ElseIf e.KeyCode = Keys.Enter And valY = 1 Then
            Application.Exit()
        ElseIf valY = 1 Then
            lblMessage2.Show()
        End If
        If e.KeyCode = Keys.Escape Then
            Application.Restart()
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