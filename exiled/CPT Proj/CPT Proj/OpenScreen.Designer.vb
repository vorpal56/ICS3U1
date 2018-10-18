<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpenScreen))
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbloption1 = New System.Windows.Forms.Label
        Me.lbloption2 = New System.Windows.Forms.Label
        Me.lbloption4 = New System.Windows.Forms.Label
        Me.lbloption3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblBottomMessage = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 74.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(116, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 116)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exiled"
        '
        'lbloption1
        '
        Me.lbloption1.Font = New System.Drawing.Font("Consolas", 26.0!)
        Me.lbloption1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbloption1.Location = New System.Drawing.Point(16, 159)
        Me.lbloption1.Name = "lbloption1"
        Me.lbloption1.Size = New System.Drawing.Size(570, 60)
        Me.lbloption1.TabIndex = 1
        Me.lbloption1.Text = "Play"
        Me.lbloption1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbloption2
        '
        Me.lbloption2.Font = New System.Drawing.Font("Consolas", 26.0!)
        Me.lbloption2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbloption2.Location = New System.Drawing.Point(16, 219)
        Me.lbloption2.Name = "lbloption2"
        Me.lbloption2.Size = New System.Drawing.Size(570, 60)
        Me.lbloption2.TabIndex = 2
        Me.lbloption2.Text = "Tutorial"
        Me.lbloption2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbloption4
        '
        Me.lbloption4.Font = New System.Drawing.Font("Consolas", 26.0!)
        Me.lbloption4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbloption4.Location = New System.Drawing.Point(16, 339)
        Me.lbloption4.Name = "lbloption4"
        Me.lbloption4.Size = New System.Drawing.Size(570, 60)
        Me.lbloption4.TabIndex = 4
        Me.lbloption4.Text = "Quit"
        Me.lbloption4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbloption3
        '
        Me.lbloption3.Font = New System.Drawing.Font("Consolas", 26.0!)
        Me.lbloption3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbloption3.Location = New System.Drawing.Point(16, 279)
        Me.lbloption3.Name = "lbloption3"
        Me.lbloption3.Size = New System.Drawing.Size(570, 60)
        Me.lbloption3.TabIndex = 3
        Me.lbloption3.Text = "Credits"
        Me.lbloption3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'lblBottomMessage
        '
        Me.lblBottomMessage.Font = New System.Drawing.Font("Consolas", 16.0!)
        Me.lblBottomMessage.ForeColor = System.Drawing.Color.White
        Me.lblBottomMessage.Location = New System.Drawing.Point(94, 415)
        Me.lblBottomMessage.Name = "lblBottomMessage"
        Me.lblBottomMessage.Size = New System.Drawing.Size(418, 59)
        Me.lblBottomMessage.TabIndex = 5
        Me.lblBottomMessage.Text = "Press the ""UP"" key or ""DOWN"" key to choose the option"
        Me.lblBottomMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(600, 500)
        Me.Controls.Add(Me.lblBottomMessage)
        Me.Controls.Add(Me.lbloption4)
        Me.Controls.Add(Me.lbloption3)
        Me.Controls.Add(Me.lbloption2)
        Me.Controls.Add(Me.lbloption1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OpenScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exiled"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbloption1 As System.Windows.Forms.Label
    Friend WithEvents lbloption2 As System.Windows.Forms.Label
    Friend WithEvents lbloption4 As System.Windows.Forms.Label
    Friend WithEvents lbloption3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblBottomMessage As System.Windows.Forms.Label
End Class
