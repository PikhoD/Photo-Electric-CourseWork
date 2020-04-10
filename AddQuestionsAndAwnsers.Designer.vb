<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddQuestionsAndAwnsers
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
        Me.AddQustionButton = New System.Windows.Forms.Button()
        Me.QuestionTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.AwnserDTextBox = New System.Windows.Forms.TextBox()
        Me.AwnserATextBox = New System.Windows.Forms.TextBox()
        Me.AwnserBTextBox = New System.Windows.Forms.TextBox()
        Me.AwnserTextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'AddQustionButton
        '
        Me.AddQustionButton.Location = New System.Drawing.Point(470, 376)
        Me.AddQustionButton.Name = "AddQustionButton"
        Me.AddQustionButton.Size = New System.Drawing.Size(106, 66)
        Me.AddQustionButton.TabIndex = 0
        Me.AddQustionButton.Text = "Create Questions"
        Me.AddQustionButton.UseVisualStyleBackColor = True
        '
        'QuestionTextBox
        '
        Me.QuestionTextBox.Location = New System.Drawing.Point(105, 50)
        Me.QuestionTextBox.Multiline = True
        Me.QuestionTextBox.Name = "QuestionTextBox"
        Me.QuestionTextBox.Size = New System.Drawing.Size(410, 48)
        Me.QuestionTextBox.TabIndex = 1
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(162, 367)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(246, 86)
        Me.TextBox7.TabIndex = 7
        '
        'AwnserDTextBox
        '
        Me.AwnserDTextBox.Location = New System.Drawing.Point(33, 246)
        Me.AwnserDTextBox.Multiline = True
        Me.AwnserDTextBox.Name = "AwnserDTextBox"
        Me.AwnserDTextBox.Size = New System.Drawing.Size(246, 86)
        Me.AwnserDTextBox.TabIndex = 4
        '
        'AwnserATextBox
        '
        Me.AwnserATextBox.Location = New System.Drawing.Point(33, 128)
        Me.AwnserATextBox.Multiline = True
        Me.AwnserATextBox.Name = "AwnserATextBox"
        Me.AwnserATextBox.Size = New System.Drawing.Size(246, 86)
        Me.AwnserATextBox.TabIndex = 2
        '
        'AwnserBTextBox
        '
        Me.AwnserBTextBox.Location = New System.Drawing.Point(330, 128)
        Me.AwnserBTextBox.Multiline = True
        Me.AwnserBTextBox.Name = "AwnserBTextBox"
        Me.AwnserBTextBox.Size = New System.Drawing.Size(246, 86)
        Me.AwnserBTextBox.TabIndex = 3
        '
        'AwnserTextBox
        '
        Me.AwnserTextBox.Location = New System.Drawing.Point(330, 246)
        Me.AwnserTextBox.Multiline = True
        Me.AwnserTextBox.Name = "AwnserTextBox"
        Me.AwnserTextBox.Size = New System.Drawing.Size(246, 86)
        Me.AwnserTextBox.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(198, 220)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "True"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(198, 344)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "True"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(495, 220)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox3.TabIndex = 10
        Me.CheckBox3.Text = "True"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(495, 344)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox4.TabIndex = 11
        Me.CheckBox4.Text = "True"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'AddQuestionsAndAwnsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 519)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.AwnserTextBox)
        Me.Controls.Add(Me.AwnserDTextBox)
        Me.Controls.Add(Me.AwnserBTextBox)
        Me.Controls.Add(Me.AwnserATextBox)
        Me.Controls.Add(Me.QuestionTextBox)
        Me.Controls.Add(Me.AddQustionButton)
        Me.Name = "AddQuestionsAndAwnsers"
        Me.Text = "AddQuestionsAndAwnsers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddQustionButton As System.Windows.Forms.Button
    Friend WithEvents QuestionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents AwnserDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AwnserATextBox As System.Windows.Forms.TextBox
    Friend WithEvents AwnserBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AwnserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
End Class
