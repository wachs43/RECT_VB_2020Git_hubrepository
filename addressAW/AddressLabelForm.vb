'Alex Wachs
'RCET0265
'Spring 2020
'SIMPLE CALC
'RECT_VB_2020Git_hubrepository

Public Class AddressLabelForm
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayLabelButton.Click
        AddressLabel.Text &= vbNewLine & FirstNameBox.Text & " " & LastNameBox.Text & vbNewLine & StreetAddressBox.Text & vbNewLine & CityBox.Text & ", " & StateBox.Text & " " & ZIPBox.Text
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        AddressLabel.Text = ""
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
