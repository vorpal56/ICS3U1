Public Class frmLevel2

    Dim bordersred(4) As PictureBox
    Dim bordersblue(3) As PictureBox
    Dim bordersgreen(3) As PictureBox
    Dim bordersyellow(4) As PictureBox
    Dim numboxred, numboxgreen, numboxblue, numboxyellow As Integer
    Dim upY, downY, leftX, rightX As Boolean
    Dim xmove, ymove, time As Double
    Dim picflashred, picflashgreen, picflashblue, picflashyellow As Integer
    Dim x As Integer = 508
    Dim y As Integer = 518

    Private Sub frmLevel2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        helpoption = 4
        TimerColourShow.Start()
        bordersred = New PictureBox() {picwallred1, picwallred3, picwallred2, picwallred4, picwallred5}
        bordersblue = New PictureBox() {picwallblue1, picwallblue2, picwallblue3, picwallblue4}
        bordersgreen = New PictureBox() {picwallgreen1, picwallgreen2, picwallgreen3, picwallgreen4}
        bordersyellow = New PictureBox() {picwallyellow1, picwallyellow2, picwallyellow3, picwallyellow4, picwallyellow5}
        For Each objred In Me.Controls
            If TypeOf objred Is PictureBox AndAlso objred.tag = "wallred" Then
                bordersred(numboxred) = objred
                numboxred += 1
            End If
        Next
        For Each objblue In Me.Controls
            If TypeOf objblue Is PictureBox AndAlso objblue.tag = "wallblue" Then
                bordersblue(numboxblue) = objblue
                numboxblue += 1
            End If
        Next
        For Each objgreen In Me.Controls
            If TypeOf objgreen Is PictureBox AndAlso objgreen.tag = "wallgreen" Then
                bordersgreen(numboxgreen) = objgreen
                numboxgreen += 1
            End If
        Next
        For Each objyellow In Me.Controls
            If TypeOf objyellow Is PictureBox AndAlso objyellow.tag = "wallyellow" Then
                bordersyellow(numboxyellow) = objyellow
                numboxyellow += 1
            End If
        Next
    End Sub

    Private Sub frmLevel2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If picCharacter1.Location.X >= 960 Then
            Level2Complete.Show()
            Me.Close()
        End If
        If picCharacter1.Bounds.IntersectsWith(picCheckPoint.Bounds) Then
            x = 90
            y = 270
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
        If e.KeyCode = Keys.Escape Then
            Help.Show()
            Me.Enabled = False
        End If
    End Sub

    Private Sub frmLevel2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
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

    Private Sub TimerRed1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRed1.Tick
        For Me.numboxred = 0 To 4
            If picCharacter1.Bounds.IntersectsWith(bordersred(numboxred).Bounds) Then
                picCharacter1.Location = New Point(x, y)
                If TimerRed2.Enabled = True And picflashred = 1 Then
                    picwallred1.Visible = True
                    picwallred3.Visible = True
                    picwallred2.Visible = True
                    picwallred4.Visible = True
                    picwallred5.Visible = True
                    Delay(1.2)
                    picwallred1.Visible = False
                    picwallred3.Visible = False
                    picwallred2.Visible = False
                    picwallred4.Visible = False
                    picwallred5.Visible = False
                End If
            End If
        Next
        Call xmovement(xmove)
        picCharacter1.Left -= xmove
        Call ymovement(ymove)
        picCharacter1.Top += ymove
    End Sub

    Private Sub TimerRed2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRed2.Tick
        picflashred = 0
        picflashred += 1
    End Sub

    Private Sub TimerBlue1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBlue1.Tick
        For Me.numboxblue = 0 To 3
            If picCharacter1.Bounds.IntersectsWith(bordersblue(numboxblue).Bounds) Then
                picCharacter1.Location = New Point(x, y)
                If TimerBlue2.Enabled = True And picflashblue = 1 Then
                    picwallblue1.Visible = True
                    picwallblue2.Visible = True
                    picwallblue3.Visible = True
                    picwallblue4.Visible = True
                    Delay(1.2)
                    picwallblue1.Visible = False
                    picwallblue2.Visible = False
                    picwallblue3.Visible = False
                    picwallblue4.Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub TimerBlue2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBlue2.Tick
        picflashblue = 0
        picflashblue += 1
    End Sub

    Private Sub TimerGreen1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGreen1.Tick
        For Me.numboxgreen = 0 To 3
            If picCharacter1.Bounds.IntersectsWith(bordersgreen(numboxgreen).Bounds) Then
                picCharacter1.Location = New Point(x, y)
                If TimerGreen2.Enabled = True And picflashgreen = 1 Then
                    picwallgreen1.Visible = True
                    picwallgreen2.Visible = True
                    picwallgreen3.Visible = True
                    picwallgreen4.Visible = True
                    Delay(1.2)
                    picwallgreen1.Visible = False
                    picwallgreen2.Visible = False
                    picwallgreen3.Visible = False
                    picwallgreen4.Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub TimerGreen2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGreen2.Tick
        picflashgreen = 0
        picflashgreen += 1
    End Sub

    Private Sub TimerYellow1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerYellow1.Tick
        For Me.numboxyellow = 0 To 4
            If picCharacter1.Bounds.IntersectsWith(bordersyellow(numboxyellow).Bounds) Then
                picCharacter1.Location = New Point(x, y)
                If TimerYellow2.Enabled = True And picflashyellow = 1 Then
                    picwallyellow1.Visible = True
                    picwallyellow2.Visible = True
                    picwallyellow3.Visible = True
                    picwallyellow4.Visible = True
                    picwallyellow5.Visible = True
                    Delay(1.2)
                    picwallyellow1.Visible = False
                    picwallyellow2.Visible = False
                    picwallyellow3.Visible = False
                    picwallyellow4.Visible = False
                    picwallyellow5.Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub TimerYellow2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerYellow2.Tick
        picflashyellow = 0
        picflashyellow += 1
    End Sub

    Private Sub TimerColourShow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerColourShow.Tick
        time += 1
        If time > 0 And time < 2.5 Then
            picwallred1.Visible = True
            picwallred3.Visible = True
            picwallred2.Visible = True
            picwallred4.Visible = True
            picwallred5.Visible = True
            '
            picwallblue1.Visible = True
            picwallblue2.Visible = True
            picwallblue3.Visible = True
            picwallblue4.Visible = True
            '
            picwallgreen1.Visible = True
            picwallgreen2.Visible = True
            picwallgreen3.Visible = True
            picwallgreen4.Visible = True
            '
            picwallyellow1.Visible = True
            picwallyellow2.Visible = True
            picwallyellow3.Visible = True
            picwallyellow4.Visible = True
            picwallyellow5.Visible = True
        ElseIf time > 2.5 And time < 4.5 Then
            TimerRed1.Start()
            TimerRed2.Start()
            TimerBlue1.Start()
            TimerBlue2.Start()
            TimerGreen1.Start()
            TimerGreen2.Start()
            TimerYellow1.Start()
            TimerYellow2.Start()
            '
            picwallred1.Visible = False
            picwallred3.Visible = False
            picwallred2.Visible = False
            picwallred4.Visible = False
            picwallred5.Visible = False
            '
            picwallblue1.Visible = False
            picwallblue2.Visible = False
            picwallblue3.Visible = False
            picwallblue4.Visible = False
            '
            picwallgreen1.Visible = False
            picwallgreen2.Visible = False
            picwallgreen3.Visible = False
            picwallgreen4.Visible = False
            '                    
            picwallyellow1.Visible = False
            picwallyellow2.Visible = False
            picwallyellow3.Visible = False
            picwallyellow4.Visible = False
            picwallyellow5.Visible = False
        End If
    End Sub
End Class