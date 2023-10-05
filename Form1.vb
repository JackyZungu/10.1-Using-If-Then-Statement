Public Class Form1
    Private Sub luck_Click(sender As Object, e As EventArgs) Handles luck.Click
        Dim myNum As Integer

        myNum = txtMyNumber.Text

        If myNum > 100 Then
            Label2.Text = "You win a lucky prize"
        End If
    End Sub
End Class
