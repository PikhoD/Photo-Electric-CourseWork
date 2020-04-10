<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateUsernameAndPasword
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
        Me.FinishedMakingAccountButton = New System.Windows.Forms.Button()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PaswordTextbox = New System.Windows.Forms.TextBox()
        Me.RetypePasswordTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FinishedMakingAccountButton
        '
        Me.FinishedMakingAccountButton.Location = New System.Drawing.Point(553, 167)
        Me.FinishedMakingAccountButton.Name = "FinishedMakingAccountButton"
        Me.FinishedMakingAccountButton.Size = New System.Drawing.Size(181, 63)
        Me.FinishedMakingAccountButton.TabIndex = 0
        Me.FinishedMakingAccountButton.Text = "Create Account"
        Me.FinishedMakingAccountButton.UseVisualStyleBackColor = True
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Location = New System.Drawing.Point(289, 127)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(194, 20)
        Me.UserNameTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'PaswordTextbox
        '
        Me.PaswordTextbox.Location = New System.Drawing.Point(289, 185)
        Me.PaswordTextbox.Name = "PaswordTextbox"
        Me.PaswordTextbox.Size = New System.Drawing.Size(194, 20)
        Me.PaswordTextbox.TabIndex = 3
        '
        'RetypePasswordTextbox
        '
        Me.RetypePasswordTextbox.Location = New System.Drawing.Point(289, 251)
        Me.RetypePasswordTextbox.Name = "RetypePasswordTextbox"
        Me.RetypePasswordTextbox.Size = New System.Drawing.Size(194, 20)
        Me.RetypePasswordTextbox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Retype Pasword"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Please type in a username a password For your account"
        '
        'CreateUsernameAndPasword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RetypePasswordTextbox)
        Me.Controls.Add(Me.PaswordTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(Me.FinishedMakingAccountButton)
        Me.Name = "CreateUsernameAndPasword"
        Me.Text = "CreateUsernameAndPasword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FinishedMakingAccountButton As Button
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PaswordTextbox As TextBox
    Friend WithEvents RetypePasswordTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
