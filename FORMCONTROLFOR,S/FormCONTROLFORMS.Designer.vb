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
        Me.STATELABEL = New System.Windows.Forms.Label()
        Me.STREETLABEL = New System.Windows.Forms.Label()
        Me.NAME = New System.Windows.Forms.Label()
        Me.STATETEXTBOX = New System.Windows.Forms.TextBox()
        Me.STREETTEXTBOX = New System.Windows.Forms.TextBox()
        Me.NAMETEXTBOX = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.USERINPUTE.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EXITBUTTON
        '
        Me.EXITBUTTON.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.EXITBUTTON.Location = New System.Drawing.Point(617, 290)
        Me.EXITBUTTON.Name = "EXITBUTTON"
        Me.EXITBUTTON.Size = New System.Drawing.Size(128, 85)
        Me.EXITBUTTON.TabIndex = 0
        Me.EXITBUTTON.Text = "E&XIT"
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
        Me.USERINPUTE.Controls.Add(Me.STATELABEL)
        Me.USERINPUTE.Controls.Add(Me.STREETLABEL)
        Me.USERINPUTE.Controls.Add(Me.NAME)
        Me.USERINPUTE.Controls.Add(Me.STATETEXTBOX)
        Me.USERINPUTE.Controls.Add(Me.STREETTEXTBOX)
        Me.USERINPUTE.Controls.Add(Me.NAMETEXTBOX)
        Me.USERINPUTE.Location = New System.Drawing.Point(36, 29)
        Me.USERINPUTE.Name = "USERINPUTE"
        Me.USERINPUTE.Size = New System.Drawing.Size(269, 236)
        Me.USERINPUTE.TabIndex = 4
        Me.USERINPUTE.TabStop = False
        '
        'STATELABEL
        '
        Me.STATELABEL.AutoSize = True
        Me.STATELABEL.Location = New System.Drawing.Point(6, 95)
        Me.STATELABEL.Name = "STATELABEL"
        Me.STATELABEL.Size = New System.Drawing.Size(42, 13)
        Me.STATELABEL.TabIndex = 9
        Me.STATELABEL.Text = "STATE"
        '
        'STREETLABEL
        '
        Me.STREETLABEL.AutoSize = True
        Me.STREETLABEL.Location = New System.Drawing.Point(6, 56)
        Me.STREETLABEL.Name = "STREETLABEL"
        Me.STREETLABEL.Size = New System.Drawing.Size(50, 13)
        Me.STREETLABEL.TabIndex = 8
        Me.STREETLABEL.Text = "STREET"
        '
        'NAME
        '
        Me.NAME.AutoSize = True
        Me.NAME.Location = New System.Drawing.Point(6, 16)
        Me.NAME.Name = "NAME"
        Me.NAME.Size = New System.Drawing.Size(38, 13)
        Me.NAME.TabIndex = 7
        Me.NAME.Text = "NAME"
        '
        'STATETEXTBOX
        '
        Me.STATETEXTBOX.Location = New System.Drawing.Point(6, 111)
        Me.STATETEXTBOX.Name = "STATETEXTBOX"
        Me.STATETEXTBOX.Size = New System.Drawing.Size(257, 20)
        Me.STATETEXTBOX.TabIndex = 7
        '
        'STREETTEXTBOX
        '
        Me.STREETTEXTBOX.Location = New System.Drawing.Point(6, 72)
        Me.STREETTEXTBOX.Name = "STREETTEXTBOX"
        Me.STREETTEXTBOX.Size = New System.Drawing.Size(257, 20)
        Me.STREETTEXTBOX.TabIndex = 7
        '
        'NAMETEXTBOX
        '
        Me.NAMETEXTBOX.Location = New System.Drawing.Point(6, 33)
        Me.NAMETEXTBOX.Name = "NAMETEXTBOX"
        Me.NAMETEXTBOX.Size = New System.Drawing.Size(257, 20)
        Me.NAMETEXTBOX.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(329, 271)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(269, 148)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(33, 271)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(272, 148)
        Me.DisplayLabel.TabIndex = 7
        '
        'FormCONTROLFORMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.EXITBUTTON
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.USERINPUTE)
        Me.Controls.Add(Me.USERSELECTION)
        Me.Controls.Add(Me.UPDATE)
        Me.Controls.Add(Me.GO)
        Me.Controls.Add(Me.EXITBUTTON)

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
    Friend WithEvents STATETEXTBOX As TextBox
    Friend WithEvents STREETTEXTBOX As TextBox
    Friend WithEvents NAMETEXTBOX As TextBox
    Friend WithEvents STATELABEL As Label
    Friend WithEvents STREETLABEL As Label
    Friend WithEvents NAME As Label
    Friend WithEvents DisplayLabel As Label
End Class
