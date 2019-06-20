Public Class Form1


    Dim myenemies(2) As PictureBox
    Dim offset As Point



    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myenemies(0) = Me.enemy1
        myenemies(1) = Me.Enemy2
        myenemies(2) = Me.Enemy3


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For index = 0 To 2
            If Me.player.Bounds.IntersectsWith(myenemies(index).Bounds) Then
                myenemies(index).Visible = False

            End If
        Next
        
    End Sub

    Private Sub player_Click(sender As Object, e As EventArgs) Handles player.Click

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Offset = New Point(-e.X, -e.Y)

    End Sub

    Private Sub player_MouseMove(sender As Object, e As MouseEventArgs) Handles player.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim Pos As Point = Me.PointToClient(MousePosition)
            Pos.Offset(offset.X, offset.Y)
            player.Location = Pos
        End If



    End Sub
End Class
