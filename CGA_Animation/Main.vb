Public Class Main
    Dim curx, cury, Vx, Vy As Integer
    Dim curpointerX, curpointerY As Integer
    Dim bit, bit2 As Bitmap
    Dim g As Graphics

    Private Sub Timer00_Tick(sender As Object, e As EventArgs) Handles Timer00.Tick

        curx += Vx
        cury += Vy
        If curx >= PictureBox.Width Then
            Vx = -Vx
        ElseIf curx <= PictureBox.Location.X Then
            Vx = -Vx
        End If
        If cury >= PictureBox.Height Then
            Vy = -Vy
        ElseIf cury <= PictureBox.Location.Y Then
            Vy = -Vy
        End If
        Display()
    End Sub

    Dim pen As Pen

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Timer00.Enabled = Enabled
    End Sub

    Dim lenght As Integer

    Private Sub MainLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        curx = 20
        cury = 20
        lenght = 10
        Vx = 5
        Vy = 5
        bit = New Bitmap(PictureBox.Width, PictureBox.Height)
        g = Graphics.FromImage(bit)
        pen = New Pen(Color.Black, 5)
        Display()
    End Sub

    Private Sub Display()
        g.Clear(Color.White)
        g.DrawRectangle(pen, curx, cury, lenght, lenght)
        PictureBox.Image = bit
    End Sub





End Class
