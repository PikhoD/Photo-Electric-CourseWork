Public Class EnterUserNameAndPasswordvb
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UserNameTextBox.TextChanged

    End Sub

    Private Sub AccessButton_Click(sender As Object, e As EventArgs) Handles AccessButton.Click
        Dim looper As Integer = 1
        Dim UserName As String
        Dim Password As String
        Dim Access As Boolean
        UserName = UserNameTextBox.Text & "U"
        Password = PasswordTextBox.Text & "p"
        FileOpen(1, "F:\PhotoElectric Effect\bin\Debug\QuestionsAndAwnsers.txt", OpenMode.Input)



        Do Until EOF(1) = True

            If UserName = LineInput(looper) Then
                looper += 1
                If Password = LineInput(looper) Then
                    Access = True
                Else
                    looper -= 1



                End If




            Else

                looper += 2

            End If



        Loop




        FileClose(1)

        If Access = True Then
            MsgBox("AccessGranted")


        End If

    End Sub
End Class