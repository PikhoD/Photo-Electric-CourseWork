Public Class CreateUsernameAndPasword
    Dim UserName As String
    Dim Password As String
    Dim CanCreateAccount As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FinishedMakingAccountButton.Click





        If RetypePasswordTextbox.Text <> PaswordTextbox.Text Then

            MsgBox("What you have entered in the passwordTextBoxes do not match")
            CanCreateAccount = False


        End If
        If PaswordTextbox.Text = "" Then

            MsgBox("You Have not Entered a  password in the password textbox")

            CanCreateAccount = False

        End If

        If CanCreateAccount = True Then
            UserName = UserNameTextBox.Text

            Password = PaswordTextbox.Text


            FileOpen(1, "F:\PhotoElectric Effect\bin\Debug\UserNameAndPasswordList.txt", OpenMode.Append)
            PrintLine(1, UserName & "U")
            PrintLine(1, Password & "p")

            FileClose(1)




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
End Class