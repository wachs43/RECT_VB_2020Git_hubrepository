'Alex Wachs
'RCET0265
'Spring 2020
'SIMPLE CALC
'RECT_VB_2020Git_hubrepository


Public Class DinerMenuForm
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click

        Dim soupMessage As String
        soupMessage &= "~Soup of the Day~" & vbNewLine & "big joes mystery soup could be chicken could be not"
        DisplaySpecialLabel.Text = soupMessage
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click

        Dim saladMessage As String
        saladMessage &= "~green Salad~" & vbNewLine & "pure unadulterated GMOs for the fatest of leaves"
        DisplaySpecialLabel.Text = saladMessage
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click

        Dim fishMessage As String
        fishMessage &= "~floppy fish~" & vbNewLine & "so fresh the sims might still use it to slap each other.............................oh giver of A's hear my plae for a passing grade"
        DisplaySpecialLabel.Text = fishMessage
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
