Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
    Sub isempty()
        Dim usermessage As String

        If TextBox1.Text = "" Then
            usermessage &= "please enter text, textbox 1" & vbNewLine
            TextBox1.Select()
        End If
        If TextBox2.Text = "" Then
            usermessage &= "please enter text, textbox 2" & vbNewLine
            TextBox2.Select()

        End If
    End Sub

End Class
