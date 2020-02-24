<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.add = New System.Windows.Forms.Button()
        Me.cartlink = New System.Windows.Forms.Button()
        Me.checkout = New System.Windows.Forms.Button()
        Me.food1 = New System.Windows.Forms.Button()
        Me.food2 = New System.Windows.Forms.Button()
        Me.food3 = New System.Windows.Forms.Button()
        Me.food4 = New System.Windows.Forms.Button()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(12, 269)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(157, 71)
        Me.add.TabIndex = 0
        Me.add.Text = "ADD TO CART"
        Me.add.UseVisualStyleBackColor = True
        '
        'cartlink
        '
        Me.cartlink.Location = New System.Drawing.Point(213, 269)
        Me.cartlink.Name = "cartlink"
        Me.cartlink.Size = New System.Drawing.Size(157, 71)
        Me.cartlink.TabIndex = 1
        Me.cartlink.Text = "GO TO CART"
        Me.cartlink.UseVisualStyleBackColor = True
        '
        'checkout
        '
        Me.checkout.Location = New System.Drawing.Point(413, 269)
        Me.checkout.Name = "checkout"
        Me.checkout.Size = New System.Drawing.Size(157, 71)
        Me.checkout.TabIndex = 2
        Me.checkout.Text = "Checkout"
        Me.checkout.UseVisualStyleBackColor = True
        '
        'food1
        '
        Me.food1.Location = New System.Drawing.Point(631, 12)
        Me.food1.Name = "food1"
        Me.food1.Size = New System.Drawing.Size(157, 71)
        Me.food1.TabIndex = 3
        Me.food1.Text = "wings"
        Me.food1.UseVisualStyleBackColor = True
        '
        'food2
        '
        Me.food2.Location = New System.Drawing.Point(631, 89)
        Me.food2.Name = "food2"
        Me.food2.Size = New System.Drawing.Size(157, 71)
        Me.food2.TabIndex = 4
        Me.food2.Text = "pizza"
        Me.food2.UseVisualStyleBackColor = True
        '
        'food3
        '
        Me.food3.Location = New System.Drawing.Point(631, 166)
        Me.food3.Name = "food3"
        Me.food3.Size = New System.Drawing.Size(157, 71)
        Me.food3.TabIndex = 5
        Me.food3.Text = "fried rice"
        Me.food3.UseVisualStyleBackColor = True
        '
        'food4
        '
        Me.food4.Location = New System.Drawing.Point(631, 243)
        Me.food4.Name = "food4"
        Me.food4.Size = New System.Drawing.Size(157, 71)
        Me.food4.TabIndex = 6
        Me.food4.Text = "ice cream"
        Me.food4.UseVisualStyleBackColor = True
        '
        'Total
        '
        Me.Total.Location = New System.Drawing.Point(12, 243)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(558, 20)
        Me.Total.TabIndex = 10
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 75)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(558, 147)
        Me.ListBox1.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(470, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(425, 20)
        Me.TextBox2.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(467, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.food4)
        Me.Controls.Add(Me.food3)
        Me.Controls.Add(Me.food2)
        Me.Controls.Add(Me.food1)
        Me.Controls.Add(Me.checkout)
        Me.Controls.Add(Me.cartlink)
        Me.Controls.Add(Me.add)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents add As Button
    Friend WithEvents cartlink As Button
    Friend WithEvents checkout As Button
    Friend WithEvents food1 As Button
    Friend WithEvents food2 As Button
    Friend WithEvents food3 As Button
    Friend WithEvents food4 As Button
    Friend WithEvents Total As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
