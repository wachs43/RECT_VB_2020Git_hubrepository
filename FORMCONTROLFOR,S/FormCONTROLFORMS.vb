Public Class FormCONTROLFORMS
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles EXITBUTTON.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UPDATE.Click
        Dim displayText As String

        displayText = NAMETEXTBOX.Text & vbNewLine & STREETTEXTBOX.Text & vbNewLine & STATETEXTBOX.Text

        DisplayLabel.Text = displayText

    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GO.Click

        If CheckBox1.Checked = True Then
            DisplayLabel.Text = NAMETEXTBOX.Text
        End If

    End Sub

    Private Sub FormControlsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        RadioButton1.Checked = True

    End Sub

End Class