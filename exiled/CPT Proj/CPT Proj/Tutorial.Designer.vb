<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tutorial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tutorial))
        Me.lblCheckpointMessage = New System.Windows.Forms.Label
        Me.lblWallMessage = New System.Windows.Forms.Label
        Me.lblMessage = New System.Windows.Forms.Label
        Me.TimerBlue2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBlue1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRed1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRed2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerText = New System.Windows.Forms.Timer(Me.components)
        Me.lblWallMessage2 = New System.Windows.Forms.Label
        Me.picCharacter1 = New System.Windows.Forms.PictureBox
        Me.picwallblue1 = New System.Windows.Forms.PictureBox
        Me.picwallred2 = New System.Windows.Forms.PictureBox
        Me.picwallred1 = New System.Windows.Forms.PictureBox
        Me.picCheckpoint = New System.Windows.Forms.PictureBox
        Me.picEnd = New System.Windows.Forms.PictureBox
        CType(Me.picCharacter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picwallblue1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picwallred2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picwallred1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckpoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCheckpointMessage
        '
        Me.lblCheckpointMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblCheckpointMessage.Font = New System.Drawing.Font("Consolas", 16.0!)
        Me.lblCheckpointMessage.ForeColor = System.Drawing.Color.White
        Me.lblCheckpointMessage.Location = New System.Drawing.Point(197, 173)
        Me.lblCheckpointMessage.Name = "lblCheckpointMessage"
        Me.lblCheckpointMessage.Size = New System.Drawing.Size(196, 84)
        Me.lblCheckpointMessage.TabIndex = 37
        Me.lblCheckpointMessage.Text = "This is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a check point"
        Me.lblCheckpointMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCheckpointMessage.Visible = False
        '
        'lblWallMessage
        '
        Me.lblWallMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblWallMessage.Font = New System.Drawing.Font("Consolas", 16.0!)
        Me.lblWallMessage.ForeColor = System.Drawing.Color.White
        Me.lblWallMessage.Location = New System.Drawing.Point(188, 374)
        Me.lblWallMessage.Name = "lblWallMessage"
        Me.lblWallMessage.Size = New System.Drawing.Size(148, 192)
        Me.lblWallMessage.TabIndex = 35
        Me.lblWallMessage.Text = "These are red walls"
        Me.lblWallMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblWallMessage.Visible = False
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Consolas", 16.0!)
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(109, 28)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(473, 78)
        Me.lblMessage.TabIndex = 32
        Me.lblMessage.Text = "Welcome to the Tutorial"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMessage.Visible = False
        '
        'TimerBlue2
        '
        Me.TimerBlue2.Enabled = True
        '
        'TimerBlue1
        '
        Me.TimerBlue1.Enabled = True
        Me.TimerBlue1.Interval = 1
        '
        'TimerRed1
        '
        Me.TimerRed1.Enabled = True
        Me.TimerRed1.Interval = 1
        '
        'TimerRed2
        '
        Me.TimerRed2.Enabled = True
        '
        'TimerText
        '
        Me.TimerText.Interval = 1000
        '
        'lblWallMessage2
        '
        Me.lblWallMessage2.BackColor = System.Drawing.Color.Transparent
        Me.lblWallMessage2.Font = New System.Drawing.Font("Consolas", 16.0!)
        Me.lblWallMessage2.ForeColor = System.Drawing.Color.White
        Me.lblWallMessage2.Location = New System.Drawing.Point(492, 109)
        Me.lblWallMessage2.Name = "lblWallMessage2"
        Me.lblWallMessage2.Size = New System.Drawing.Size(148, 289)
        Me.lblWallMessage2.TabIndex = 41
        Me.lblWallMessage2.Text = "These are blue walls"
        Me.lblWallMessage2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblWallMessage2.Visible = False
        '
        'picCharacter1
        '
        Me.picCharacter1.BackColor = System.Drawing.Color.White
        Me.picCharacter1.Location = New System.Drawing.Point(33, 302)
        Me.picCharacter1.Name = "picCharacter1"
        Me.picCharacter1.Size = New System.Drawing.Size(10, 10)
        Me.picCharacter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCharacter1.TabIndex = 33
        Me.picCharacter1.TabStop = False
        '
        'picwallblue1
        '
        Me.picwallblue1.BackColor = System.Drawing.Color.DodgerBlue
        Me.picwallblue1.Location = New System.Drawing.Point(438, 109)
        Me.picwallblue1.Name = "picwallblue1"
        Me.picwallblue1.Size = New System.Drawing.Size(48, 398)
        Me.picwallblue1.TabIndex = 40
        Me.picwallblue1.TabStop = False
        Me.picwallblue1.Tag = "wallblue"
        Me.picwallblue1.Visible = False
        '
        'picwallred2
        '
        Me.picwallred2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picwallred2.Location = New System.Drawing.Point(646, 1)
        Me.picwallred2.Name = "picwallred2"
        Me.picwallred2.Size = New System.Drawing.Size(48, 516)
        Me.picwallred2.TabIndex = 38
        Me.picwallred2.TabStop = False
        Me.picwallred2.Tag = "wallred"
        Me.picwallred2.Visible = False
        '
        'picwallred1
        '
        Me.picwallred1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picwallred1.Location = New System.Drawing.Point(134, 133)
        Me.picwallred1.Name = "picwallred1"
        Me.picwallred1.Size = New System.Drawing.Size(48, 442)
        Me.picwallred1.TabIndex = 34
        Me.picwallred1.TabStop = False
        Me.picwallred1.Tag = "wallred"
        Me.picwallred1.Visible = False
        '
        'picCheckpoint
        '
        Me.picCheckpoint.BackColor = System.Drawing.Color.DarkKhaki
        Me.picCheckpoint.BackgroundImage = Global.CPT_Proj.My.Resources.Resources.CheckPoint
        Me.picCheckpoint.Location = New System.Drawing.Point(241, 275)
        Me.picCheckpoint.Name = "picCheckpoint"
        Me.picCheckpoint.Size = New System.Drawing.Size(95, 50)
        Me.picCheckpoint.TabIndex = 36
        Me.picCheckpoint.TabStop = False
        Me.picCheckpoint.Tag = "checkpoint"
        '
        'picEnd
        '
        Me.picEnd.BackColor = System.Drawing.Color.Black
        Me.picEnd.Location = New System.Drawing.Point(645, 517)
        Me.picEnd.Name = "picEnd"
        Me.picEnd.Size = New System.Drawing.Size(48, 58)
        Me.picEnd.TabIndex = 39
        Me.picEnd.TabStop = False
        '
        'Tutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(694, 576)
        Me.Controls.Add(Me.lblWallMessage2)
        Me.Controls.Add(Me.picCharacter1)
        Me.Controls.Add(Me.picwallblue1)
        Me.Controls.Add(Me.picwallred2)
        Me.Controls.Add(Me.lblCheckpointMessage)
        Me.Controls.Add(Me.picwallred1)
        Me.Controls.Add(Me.lblWallMessage)
        Me.Controls.Add(Me.picCheckpoint)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.picEnd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tutorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutorial"
        CType(Me.picCharacter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picwallblue1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picwallred2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picwallred1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckpoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCharacter1 As System.Windows.Forms.PictureBox
    Friend WithEvents picwallblue1 As System.Windows.Forms.PictureBox
    Friend WithEvents picwallred2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCheckpointMessage As System.Windows.Forms.Label
    Friend WithEvents picwallred1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblWallMessage As System.Windows.Forms.Label
    Friend WithEvents picCheckpoint As System.Windows.Forms.PictureBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents picEnd As System.Windows.Forms.PictureBox
    Friend WithEvents TimerBlue2 As System.Windows.Forms.Timer
    Friend WithEvents TimerBlue1 As System.Windows.Forms.Timer
    Friend WithEvents TimerRed1 As System.Windows.Forms.Timer
    Friend WithEvents TimerRed2 As System.Windows.Forms.Timer
    Friend WithEvents TimerText As System.Windows.Forms.Timer
    Friend WithEvents lblWallMessage2 As System.Windows.Forms.Label
End Class
