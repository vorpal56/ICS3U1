<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.lblhelp = New System.Windows.Forms.Label
        Me.lbloption2 = New System.Windows.Forms.Label
        Me.lbloption1 = New System.Windows.Forms.Label
        Me.lblMessage = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblMessage2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblhelp
        '
        Me.lblhelp.AutoSize = True
        Me.lblhelp.BackColor = System.Drawing.Color.DimGray
        Me.lblhelp.Font = New System.Drawing.Font("Consolas", 30.0!)
        Me.lblhelp.ForeColor = System.Drawing.Color.White
        Me.lblhelp.Location = New System.Drawing.Point(201, 24)
        Me.lblhelp.Name = "lblhelp"
        Me.lblhelp.Size = New System.Drawing.Size(108, 47)
        Me.lblhelp.TabIndex = 0
        Me.lblhelp.Text = "Help"
        '
        'lbloption2
        '
        Me.lbloption2.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.lbloption2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbloption2.Location = New System.Drawing.Point(16, 249)
        Me.lbloption2.Name = "lbloption2"
        Me.lbloption2.Size = New System.Drawing.Size(470, 60)
        Me.lbloption2.TabIndex = 8
        Me.lbloption2.Text = "Quit"
        Me.lbloption2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbloption1
        '
        Me.lbloption1.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.lbloption1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbloption1.Location = New System.Drawing.Point(16, 189)
        Me.lbloption1.Name = "lbloption1"
        Me.lbloption1.Size = New System.Drawing.Size(470, 60)
        Me.lbloption1.TabIndex = 7
        Me.lbloption1.Text = "Credits"
        Me.lbloption1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Consolas", 16.0!)
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMessage.Location = New System.Drawing.Point(44, 84)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(416, 87)
        Me.lblMessage.TabIndex = 9
        Me.lblMessage.Text = "Press the arrow keys to move your character and ""ESC"" to close this window"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'lblMessage2
        '
        Me.lblMessage2.AutoSize = True
        Me.lblMessage2.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.lblMessage2.ForeColor = System.Drawing.Color.White
        Me.lblMessage2.Location = New System.Drawing.Point(112, 336)
        Me.lblMessage2.Name = "lblMessage2"
        Me.lblMessage2.Size = New System.Drawing.Size(280, 22)
        Me.lblMessage2.TabIndex = 10
        Me.lblMessage2.Text = "This closes the entire game"
        Me.lblMessage2.Visible = False
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(500, 400)
        Me.Controls.Add(Me.lblMessage2)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lbloption2)
        Me.Controls.Add(Me.lbloption1)
        Me.Controls.Add(Me.lblhelp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Help"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblhelp As System.Windows.Forms.Label
    Friend WithEvents lbloption2 As System.Windows.Forms.Label
    Friend WithEvents lbloption1 As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblMessage2 As System.Windows.Forms.Label
End Class
