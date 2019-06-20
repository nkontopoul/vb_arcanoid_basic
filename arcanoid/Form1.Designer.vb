<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.enemy1 = New System.Windows.Forms.PictureBox()
        Me.Enemy3 = New System.Windows.Forms.PictureBox()
        Me.Enemy2 = New System.Windows.Forms.PictureBox()
        Me.player = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'enemy1
        '
        Me.enemy1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.enemy1.Location = New System.Drawing.Point(67, 29)
        Me.enemy1.Name = "enemy1"
        Me.enemy1.Size = New System.Drawing.Size(100, 19)
        Me.enemy1.TabIndex = 0
        Me.enemy1.TabStop = False
        '
        'Enemy3
        '
        Me.Enemy3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Enemy3.Location = New System.Drawing.Point(331, 29)
        Me.Enemy3.Name = "Enemy3"
        Me.Enemy3.Size = New System.Drawing.Size(100, 19)
        Me.Enemy3.TabIndex = 1
        Me.Enemy3.TabStop = False
        '
        'Enemy2
        '
        Me.Enemy2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Enemy2.Location = New System.Drawing.Point(200, 29)
        Me.Enemy2.Name = "Enemy2"
        Me.Enemy2.Size = New System.Drawing.Size(100, 19)
        Me.Enemy2.TabIndex = 2
        Me.Enemy2.TabStop = False
        '
        'player
        '
        Me.player.BackColor = System.Drawing.Color.Coral
        Me.player.Location = New System.Drawing.Point(200, 194)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(100, 19)
        Me.player.TabIndex = 3
        Me.player.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 290)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.Enemy2)
        Me.Controls.Add(Me.Enemy3)
        Me.Controls.Add(Me.enemy1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents enemy1 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy3 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy2 As System.Windows.Forms.PictureBox
    Friend WithEvents player As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
