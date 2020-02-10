Public Class FormCONTROLFORMS
    Private Sub EXITBUTTON_Click(sender As Object, e As EventArgs) Handles EXITBUTTON.Click
        Me.Close()
    End Sub

    Private Sub UPDATE_Click(sender As Object, e As EventArgs) Handles UPDATE.Click
        Dim DISPLAYTEXT As String

        DISPLAYTEXT = NAMETEXTBOX.Text & STREETTEXTBOX.Text & STATETEXTBOX.Text
        DisplayLabel.Text = DISPLAYTEXT

    End Sub


End Class