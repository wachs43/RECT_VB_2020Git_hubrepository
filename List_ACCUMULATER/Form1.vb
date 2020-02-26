Public Class Form1
    Private Sub ListBoxForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'DataListBox
        FirstNameTextBox.Text = "Elmer"
        LastNameTextBox.Text = "Fudd"

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        DataListBox.Items.Add(FirstNameTextBox.Text & " " & LastNameTextBox.Text)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DataListBox.Items.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DataListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataListBox.SelectedIndexChanged
        Me.Text = DataListBox.SelectedIndex.ToString
        ' TODO add selected to first name And last name text box

    End Sub

End Class
