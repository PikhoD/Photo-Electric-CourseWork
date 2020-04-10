<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.CreateAccountButton = New System.Windows.Forms.Button()
        Me.CreateQuestionButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CreateAccountButton
        '
        Me.CreateAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CreateAccountButton.Location = New System.Drawing.Point(200, 259)
        Me.CreateAccountButton.Name = "CreateAccountButton"
        Me.CreateAccountButton.Size = New System.Drawing.Size(130, 80)
        Me.CreateAccountButton.TabIndex = 0
        Me.CreateAccountButton.Text = "Create Account"
        Me.CreateAccountButton.UseVisualStyleBackColor = True
        '
        'CreateQuestionButton
        '
        Me.CreateQuestionButton.Location = New System.Drawing.Point(200, 361)
        Me.CreateQuestionButton.Name = "CreateQuestionButton"
        Me.CreateQuestionButton.Size = New System.Drawing.Size(130, 77)
        Me.CreateQuestionButton.TabIndex = 1
        Me.CreateQuestionButton.Text = "CreateQuestion"
        Me.CreateQuestionButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 450)
        Me.Controls.Add(Me.CreateQuestionButton)
        Me.Controls.Add(Me.CreateAccountButton)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CreateAccountButton As Button
    Friend WithEvents CreateQuestionButton As Button
End Class
