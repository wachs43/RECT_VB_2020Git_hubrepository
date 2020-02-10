<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCONTROLFORMS
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
        Me.EXITBUTTON = New System.Windows.Forms.Button()
        Me.GO = New System.Windows.Forms.Button()
        Me.UPDATE = New System.Windows.Forms.Button()
        Me.USERSELECTION = New System.Windows.Forms.GroupBox()
        Me.USERINPUTE = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.USERINPUTE.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EXITBUTTON
        '
        Me.EXITBUTTON.Location = New System.Drawing.Point(617, 290)
        Me.EXITBUTTON.Name = "EXITBUTTON"
        Me.EXITBUTTON.Size = New System.Drawing.Size(128, 85)
        Me.EXITBUTTON.TabIndex = 0
        Me.EXITBUTTON.Text = "EXIT"
        Me.EXITBUTTON.UseVisualStyleBackColor = True
        '
        'GO
        '
        Me.GO.Location = New System.Drawing.Point(617, 29)
        Me.GO.Name = "GO"
        Me.GO.Size = New System.Drawing.Size(128, 85)
        Me.GO.TabIndex = 1
        Me.GO.Text = "GO"
        Me.GO.UseVisualStyleBackColor = True
        '
        'UPDATE
        '
        Me.UPDATE.Location = New System.Drawing.Point(617, 159)
        Me.UPDATE.Name = "UPDATE"
        Me.UPDATE.Size = New System.Drawing.Size(128, 85)
        Me.UPDATE.TabIndex = 2
        Me.UPDATE.Text = "UPDATE"
        Me.UPDATE.UseVisualStyleBackColor = True
        '
        'USERSELECTION
        '
        Me.USERSELECTION.Location = New System.Drawing.Point(329, 29)
        Me.USERSELECTION.Name = "USERSELECTION"
        Me.USERSELECTION.Size = New System.Drawing.Size(269, 236)
        Me.USERSELECTION.TabIndex = 3
        Me.USERSELECTION.TabStop = False
        '
        'USERINPUTE
        '
        Me.USERINPUTE.Controls.Add(Me.TextBox3)
        Me.USERINPUTE.Controls.Add(Me.TextBox2)
        Me.USERINPUTE.Controls.Add(Me.TextBox1)
        Me.USERINPUTE.Location = New System.Drawing.Point(36, 29)
        Me.USERINPUTE.Name = "USERINPUTE"
        Me.USERINPUTE.Size = New System.Drawing.Size(269, 236)
        Me.USERINPUTE.TabIndex = 4
        Me.USERINPUTE.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(6, 85)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(257, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(257, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(257, 20)
        Me.TextBox1.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(36, 290)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(562, 148)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'FormCONTROLFORMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.USERINPUTE)
        Me.Controls.Add(Me.USERSELECTION)
        Me.Controls.Add(Me.UPDATE)
        Me.Controls.Add(Me.GO)
        Me.Controls.Add(Me.EXITBUTTON)
        Me.Name = "FormCONTROLFORMS"
        Me.Text = "USERCONTROLINTERFACE"
        Me.USERINPUTE.ResumeLayout(False)
        Me.USERINPUTE.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EXITBUTTON As Button
    Friend WithEvents GO As Button
    Friend WithEvents UPDATE As Button
    Friend WithEvents USERSELECTION As GroupBox
    Friend WithEvents USERINPUTE As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
