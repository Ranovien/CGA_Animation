Public Class Main
    Dim curx, cury, Vx, Vy, ax, ay, length As Integer
    Dim curpointerX, curpointerY As Integer
    Dim bit, bit2 As Bitmap
    Dim g As Graphics

    Private Sub MainLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        curx = 20
        cury = 20
        length = 10
        ax = 0
        ay = 0
        Vx = 5
        Vy = 5
        bit = New Bitmap(PictureBox.Width, PictureBox.Height)
        g = Graphics.FromImage(bit)
        pen = New Pen(Color.Black, 5)
        Display()
    End Sub

    Private Sub btnAccelerate_Click(sender As Object, e As EventArgs) Handles btnAccelerate.Click
        ay += 5
        ay += 5
    End Sub

    Private Sub Timer00_Tick(sender As Object, e As EventArgs) Handles Timer00.Tick
        curx += (Vx + ax)
        cury += (Vy + ay)
        If curx >= PictureBox.Width - length Then
            Vx = -Vx
            ax = -ax
        ElseIf curx <= PictureBox.Location.X Then
            Vx = -Vx
            ax = -ax
        End If
        If cury >= PictureBox.Height - length Then
            Vy = -Vy
            ay = -ay
        ElseIf cury <= PictureBox.Location.Y Then
            Vy = -Vy
            ay = -ay
        End If
        Display()
    End Sub

    Dim pen As Pen

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Timer00.Enabled = Not (Timer00.Enabled)
    End Sub

    Private Sub Display()
        g.Clear(Color.White)
        g.DrawRectangle(pen, curx, cury, length, length)
        PictureBox.Image = bit
    End Sub


End Class
