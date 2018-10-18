<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level5Complete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level5Complete))
        Me.lblMessage2 = New System.Windows.Forms.Label
        Me.lbloption2 = New System.Windows.Forms.Label
        Me.lbloption1 = New System.Windows.Forms.Label
        Me.lblComplete = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerText = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblMessage2
        '
        Me.lblMessage2.AutoSize = True
        Me.lblMessage2.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.lblMessage2.ForeColor = System.Drawing.Color.White
        Me.lblMessage2.Location = New System.Drawing.Point(112, 246)
        Me.lblMessage2.Name = "lblMessage2"
        Me.lblMessage2.Size = New System.Drawing.Size(280, 22)
        Me.lblMessage2.TabIndex = 15
        Me.lblMessage2.Text = "This closes the entire game"
        Me.lblMessage2.Visible = False
        '
        'lbloption2
        '
        Me.lbloption2.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.lbloption2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbloption2.Location = New System.Drawing.Point(15, 167)
        Me.lbloption2.Name = "lbloption2"
        Me.lbloption2.Size = New System.Drawing.Size(470, 60)
        Me.lbloption2.TabIndex = 14
        Me.lbloption2.Text = "Quit"
        Me.lbloption2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbloption1
        '
        Me.lbloption1.Font = New System.Drawing.Font("Consolas", 26.0!)
        Me.lbloption1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbloption1.Location = New System.Drawing.Point(15, 97)
        Me.lbloption1.Name = "lbloption1"
        Me.lbloption1.Size = New System.Drawing.Size(470, 60)
        Me.lbloption1.TabIndex = 13
        Me.lbloption1.Text = "Credits"
        Me.lbloption1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComplete
        '
        Me.lblComplete.AutoSize = True
        Me.lblComplete.BackColor = System.Drawing.Color.DimGray
        Me.lblComplete.Font = New System.Drawing.Font("Consolas", 30.0!)
        Me.lblComplete.ForeColor = System.Drawing.Color.White
        Me.lblComplete.Location = New System.Drawing.Point(55, 34)
        Me.lblComplete.Name = "lblComplete"
        Me.lblComplete.Size = New System.Drawing.Size(394, 47)
        Me.lblComplete.TabIndex = 12
        Me.lblComplete.Text = "Level 5 Complete!"
        '
        'Timer1
        '
        '
        'TimerText
        '
        Me.TimerText.Interval = 300
        '
        'Level5Complete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.Controls.Add(Me.lblMessage2)
        Me.Controls.Add(Me.lbloption2)
        Me.Controls.Add(Me.lbloption1)
        Me.Controls.Add(Me.lblComplete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Level5Complete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level5Complete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage2 As System.Windows.Forms.Label
    Friend WithEvents lbloption2 As System.Windows.Forms.Label
    Friend WithEvents lbloption1 As System.Windows.Forms.Label
    Friend WithEvents lblComplete As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TimerText As System.Windows.Forms.Timer
End Class
