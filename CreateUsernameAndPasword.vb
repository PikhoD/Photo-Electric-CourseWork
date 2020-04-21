Public Class CreateUsernameAndPasword
    Dim UserName As String
    Dim Password As String
    Dim SecurityQues(1) As String
    Dim SecurityAns(1) As String
    Dim CanCreateAccount As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FinishedMakingAccountButton.Click

        Dim accounts As New McAccount




        If RetypePasswordTextbox.Text <> PaswordTextbox.Text Then

            MsgBox("What you have entered in the passwordTextBoxes do not match")
            CanCreateAccount = False


        End If
        If PaswordTextbox.Text = "" Then

            MsgBox("You Have not Entered a  password in the password textbox")

            CanCreateAccount = False

        End If


        accounts.extractAllinfo()

        '    If accounts.BinarySearchUserName(UserNameTextBox.Text) <> -1 Then
        '   MsgBox("Username Has Already been Used please enter another one")
        '  CanCreateAccount = False
        ' UserNameTextBox.Text = ""

        'End If
        If CanCreateAccount = True Then
            SecurityQues(0) = SecurityquesTextbox.Text
            SecurityQues(1) = SecurityquesTextbox1.Text
            SecurityAns(0) = SecurityAnsTextbox.Text
            SecurityAns(1) = SecurityAnsTextbox1.Text


            accounts.AddAnAccount(UserNameTextBox.Text, PaswordTextbox.Text, SecurityQues, SecurityAns)
            MsgBox("ACCOUNTS BEEN ADDED")
        End If

        CanCreateAccount = True








    End Sub

    Private Sub CreateUsernameAndPasword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub UserNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UserNameTextBox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub SecurityquesTextbox_TextChanged(sender As Object, e As EventArgs) Handles SecurityquesTextbox.TextChanged

    End Sub
End Class