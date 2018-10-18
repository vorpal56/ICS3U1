<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditsLevel5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreditsLevel5))
        Me.lbloption1 = New System.Windows.Forms.Label
        Me.lblMessage2 = New System.Windows.Forms.Label
        Me.lblMessage = New System.Windows.Forms.Label
        Me.lbloption2 = New System.Windows.Forms.Label
        Me.lblCredits = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lbloption1
        '
        Me.lbloption1.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.lbloption1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbloption1.Location = New System.Drawing.Point(11, 262)
        Me.lbloption1.Name = "lbloption1"
        Me.lbloption1.Size = New System.Drawing.Size(576, 60)
        Me.lbloption1.TabIndex = 18
        Me.lbloption1.Text = "Play Again"
        Me.lbloption1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMessage2
        '
        Me.lblMessage2.AutoSize = True
        Me.lblMessage2.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.lblMessage2.ForeColor = System.Drawing.Color.White
        Me.lblMessage2.Location = New System.Drawing.Point(160, 405)
        Me.lblMessage2.Name = "lblMessage2"
        Me.lblMessage2.Size = New System.Drawing.Size(280, 22)
        Me.lblMessage2.TabIndex = 17
        Me.lblMessage2.Text = "This closes the entire game"
        Me.lblMessage2.Visible = False
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Consolas", 16.0!)
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMessage.Location = New System.Drawing.Point(13, 93)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(576, 157)
        Me.lblMessage.TabIndex = 16
        Me.lblMessage.Text = resources.GetString("lblMessage.Text")
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbloption2
        '
        Me.lbloption2.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.lbloption2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbloption2.Location = New System.Drawing.Point(11, 322)
        Me.lbloption2.Name = "lbloption2"
        Me.lbloption2.Size = New System.Drawing.Size(576, 60)
        Me.lbloption2.TabIndex = 15
        Me.lbloption2.Text = "Quit"
        Me.lbloption2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.BackColor = System.Drawing.Color.DimGray
        Me.lblCredits.Font = New System.Drawing.Font("Consolas", 30.0!)
        Me.lblCredits.ForeColor = System.Drawing.Color.White
        Me.lblCredits.Location = New System.Drawing.Point(216, 28)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(174, 47)
        Me.lblCredits.TabIndex = 14
        Me.lblCredits.Text = "Credits"
        '
        'Timer1
        '
        '
        'CreditsLevel5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(600, 460)
        Me.Controls.Add(Me.lbloption1)
        Me.Controls.Add(Me.lblMessage2)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lbloption2)
        Me.Controls.Add(Me.lblCredits)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreditsLevel5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreditsLevel5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbloption1 As System.Windows.Forms.Label
    Friend WithEvents lblMessage2 As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lbloption2 As System.Windows.Forms.Label
    Friend WithEvents lblCredits As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
