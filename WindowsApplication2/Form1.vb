Public Class Form1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        On Error Resume Next

        If e.KeyChar = Chr(Keys.Enter) Then
            PictureBox1.BackgroundImage = Image.FromFile(TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
