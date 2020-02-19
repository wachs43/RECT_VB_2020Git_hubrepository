Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim usermessage As String

        usermessage = validatestring(TextBox3.Text) & vbNewLine

        usermessage = validatestring(TextBox2.Text) & vbNewLine

        usermessage = validatestring(TextBox1.Text) & vbNewLine

        If usermessage <> "" Then


        End If

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

        If TextBox3.Text = "" Then
            usermessage &= "please enter text, textbox 3" & vbNewLine
            TextBox3.Select()
        End If

    End Sub

    Function validatestring(stringtotest As String) As String

        Dim statusmessage As String

        If stringtotest = "" Then
            statusmessage &= "empty"
        End If

        Return statusmessage

    End Function

End Class
