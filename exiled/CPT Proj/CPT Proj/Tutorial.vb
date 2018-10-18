Public Class Tutorial
    Dim upY, downY, leftX, rightX As Boolean
    Dim xmove, ymove, time, messagered, messageblue, messagechkpt As Double
    Dim bordersred(1) As PictureBox
    Dim numboxred As Integer
    Dim x As Integer = 30
    Dim y As Integer = 295
    Dim picflashred, picflashblue As Integer

    Private Sub Tutorial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        helpoption = 1
        TimerRed1.Stop()
        TimerRed2.Stop()
        TimerText.Start()
        bordersred = New PictureBox() {picwallred1, picwallred2}
        For Each objred In Me.Controls
            If TypeOf objred Is PictureBox AndAlso objred.tag = "wallred" Then
                bordersred(numboxred) = objred
                numboxred += 1
            End If
        Next
    End Sub

    Private Sub Tutorial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If picCharacter1.Location.X >= 655 Then
            TutorialComplete.Show()
            Me.Close()
        End If
        If e.KeyCode = Keys.Up Then
            upY = True
        End If
        If e.KeyCode = Keys.Down Then
            downY = True
        End If
        If e.KeyCode = Keys.Left Then
            leftX = True
        End If
        If e.KeyCode = Keys.Right Then
            rightX = True
        End If
    End Sub

    Private Sub Tutorial_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Up Then
            upY = False
        End If
        If e.KeyCode = Keys.Down Then
            downY = False
        End If
        If e.KeyCode = Keys.Left Then
            leftX = False
        End If
        If e.KeyCode = Keys.Right Then
            rightX = False
        End If
    End Sub

    Sub ymovement(ByRef ymove As Double)
        If upY = True Then
            If ymove > -2 Then
                ymove -= 0.3
            End If
        End If
        If upY = False Then
            If ymove < 0 Then
                ymove += 0.3
            End If
        End If
        If downY = True Then
            If ymove < 2 Then
                ymove += 0.3
            End If
        End If
        If downY = False Then
            If ymove > 0 Then
                ymove -= 0.3
            End If
        End If
    End Sub

    Sub xmovement(ByRef xmove As Double)
        If leftX = True Then
            If xmove < 2 Then
                xmove += 0.3
            End If
        End If
        If leftX = False Then
            If xmove > 0 Then
                xmove -= 0.3
            End If
        End If
        If rightX = True Then
            If xmove > -2 Then
                xmove -= 0.3
            End If
        End If
        If rightX = False Then
            If xmove < 0 Then
                xmove += 0.3
            End If
        End If
    End Sub

    Sub limitations(ByRef xmove As Double, ByRef ymove As Double)
        If picCharacter1.Location.X < 0 Then
            picCharacter1.Location = New Point(x, y)
        End If
        If picCharacter1.Location.Y < 0 Then
            picCharacter1.Location = New Point(x, y)
        ElseIf picCharacter1.Location.Y > 565 Then
            picCharacter1.Location = New Point(x, y)
        End If
    End Sub

    Private Sub TimerText_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerText.Tick
        time += 1
        If time >= 1 And time <= 3 Then
            lblMessage.Show()
        ElseIf time = 4 Then
            lblMessage.Hide()
        ElseIf time >= 5 And time <= 8 Then
            lblMessage.Show()
            lblMessage.ForeColor = Color.White
            lblMessage.Text = "To move your character, press the arrow keys"
        ElseIf time = 9 Then
            lblMessage.Hide()
            TimerRed1.Start()
            TimerRed2.Start()
        ElseIf time >= 10 And time <= 13 Then
            lblMessage.Show()
            lblMessage.ForeColor = Color.White
            lblMessage.Text = "Your objective is to get to the black square"
        Else
            lblMessage.Hide()
        End If
    End Sub

    Private Sub TimerRed1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRed1.Tick
        For Me.numboxred = 0 To 1
            If picCharacter1.Bounds.IntersectsWith(bordersred(numboxred).Bounds) Then
                picCharacter1.Location = New Point(x, y)
                messagered += 1
                If messagered = 1 Then
                    lblWallMessage.Show()
                    picwallred1.Show()
                    picwallred2.Show()
                    TimerRed1.Stop()
                    TimerRed2.Stop()
                    Delay(1.5)
                    lblWallMessage.Hide()
                    Delay(0.5)
                    lblWallMessage.Show()
                    lblWallMessage.Text = "When you hit them, you're put back to where you started"
                    Delay(2.5)
                    lblWallMessage.Hide()
                    picwallred1.Hide()
                    picwallred2.Show()
                    TimerRed1.Start()
                    TimerRed2.Start()
                End If
                If TimerRed2.Enabled = True And picflashred >= 1 Then
                    picwallred1.Visible = True
                    picwallred2.Visible = True
                    Delay(0.8)
                    picwallred1.Visible = False
                    picwallred2.Visible = False
                End If
            End If
        Next
        If picCharacter1.Bounds.IntersectsWith(picCheckpoint.Bounds) Then
            x = 290
            y = 300
            messagechkpt += 1
            If messagechkpt = 1 Then
                lblCheckpointMessage.Show()
                TimerRed1.Stop()
                TimerRed2.Stop()
                Delay(1.5)
                lblCheckpointMessage.Hide()
                TimerRed1.Start()
                TimerRed2.Start()
            End If
        End If
        Call xmovement(xmove)
        picCharacter1.Left -= xmove
        Call ymovement(ymove)
        picCharacter1.Top += ymove
        Call limitations(xmove, ymove)
    End Sub

    Private Sub TimerRed2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRed2.Tick
        picflashred = 0
        picflashred += 1
    End Sub

    Private Sub TimerBlue1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBlue1.Tick
        If picCharacter1.Bounds.IntersectsWith(picwallblue1.Bounds) Then
            picCharacter1.Location = New Point(x, y)
            messageblue += 1
            If messageblue = 1 Then
                lblWallMessage2.Show()
                picwallblue1.Show()
                TimerRed1.Stop()
                TimerRed1.Stop()
                Delay(1.5)
                lblWallMessage2.Hide()
                Delay(0.5)
                lblWallMessage2.Show()
                lblWallMessage2.Text = "They act like all other walls. When you hit them, you're put back to where you started"
                Delay(4)
                lblWallMessage2.Hide()
                picwallblue1.Hide()
                TimerRed1.Start()
                TimerRed2.Start()
            End If
            If TimerBlue2.Enabled = True And picflashblue = 1 Then
                picwallblue1.Show()
                Delay(0.8)
                picwallblue1.Hide()
            End If
        End If
    End Sub

    Private Sub TimerBlue2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBlue2.Tick
        picflashblue = 0
        picflashblue += 1
    End Sub
End Class