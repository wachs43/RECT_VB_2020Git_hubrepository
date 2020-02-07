<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExampleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.usertextbox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 137)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'usertextbox
        '
        Me.usertextbox.Location = New System.Drawing.Point(206, 75)
        Me.usertextbox.Name = "usertextbox"
        Me.usertextbox.Size = New System.Drawing.Size(354, 20)
        Me.usertextbox.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(386, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 137)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.usertextbox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ExampleForm"
        Me.Text = "FormExample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents usertextbox As TextBox
    Friend WithEvents Button2 As Button
End Class
