Public Class OpenScreen
    Dim key, upY, downY As Boolean
    Dim valY As Integer

    Private Sub OpenScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor.Dispose()

        helpoption = 1
        valY = 4
        upY = True
        downY = True
        key = True
        Timer1.Start()
    End Sub

    Private Sub OpenScreen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If key = True Then
            If upY = True Then
                If e.KeyCode = Keys.Down Then
                    If valY > 1 And valY < 5 Then
                        valY -= 1
                    Else
                        valY = 4
                    End If
                End If
            End If
        End If
        If key = True Then
            If downY = True Then
                If e.KeyCode = Keys.Up Then
                    If valY > 0 And valY < 4 Then
                        valY += 1
                    Else
                        valY = 1
                    End If
                End If
            End If
        End If
        If e.KeyCode = Keys.Enter And valY = 4 Then
            'choose the form you want to skip to for testing / get too frustrated and move onto the next level
            Me.Hide()
            'frmLevel1.Show()
            'frmLevel2.Show()
            'frmLevel3.Show()
            'frmLevel4.Show()
            'frmLevel5.Show()
        ElseIf e.KeyCode = Keys.Enter And valY = 3 Then
            Me.Hide()
            Tutorial.Show()
        ElseIf e.KeyCode = Keys.Enter And valY = 2 Then
            Me.Hide()
            Credits.Show()
            Credits.BringToFront()
        ElseIf e.KeyCode = Keys.Enter And valY = 1 Then
            Application.Exit()
        ElseIf e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If key = True Then
            If valY = 4 Then
                lbloption1.BackColor = Color.DarkRed
                lbloption2.BackColor = Color.DimGray
                lbloption3.BackColor = Color.DimGray
                lbloption4.BackColor = Color.DimGray
            ElseIf valY = 3 Then
                lbloption1.BackColor = Color.DimGray
                lbloption2.BackColor = Color.DodgerBlue
                lbloption3.BackColor = Color.DimGray
                lbloption4.BackColor = Color.DimGray
            ElseIf valY = 2 Then
                lbloption1.BackColor = Color.DimGray
                lbloption2.BackColor = Color.DimGray
                lbloption3.BackColor = Color.Green
                lbloption4.BackColor = Color.DimGray
            ElseIf valY = 1 Then
                lbloption1.BackColor = Color.DimGray
                lbloption2.BackColor = Color.DimGray
                lbloption3.BackColor = Color.DimGray
                lbloption4.BackColor = Color.Gold
            End If
        End If
    End Sub
End Class