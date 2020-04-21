Public Class McUserName
    Shared AmountOfUsers As Byte
    Dim UserNameString As String
    Dim Password As McPassword
    Dim SecurityQuestions() As McSecurityQuestions
    Dim counter As Integer = 1
    Dim counter1 As Integer = 1



    Sub New()
        Password = New McPassword
        ReDim Preserve SecurityQuestions(1)
        For looper = 0 To 1
            SecurityQuestions(looper) = New McSecurityQuestions


        Next





    End Sub

    Public Function GetuserName()

        Return UserNameString

    End Function
    Public Sub SetUsernameString(ByVal usernme As String)
        UserNameString = usernme

    End Sub

    Public Function Getpassword()
        Return Password.GetPasswordString
    End Function
    Public Sub SetPasswordString(ByVal pssword As String)
        Password.SetPasswordString(pssword)
    End Sub


    'Public Function GetSecurityQuestion()
    ' Dim counter As Integer
    '  If counter > 2 Then
    'counter = 1
    '   Else
    '       SecurityQuestions(counter - 1).GetsecurityQuestionString()

    '        counter += 1


    '    End If


    '    End Function
    Public Sub SetSecurityquestionAndAnswer(ByVal SecurityQuestion As String, ByVal SecurityAnswer As String)


        If counter > 2 Then
            counter = 1
        Else




        End If
        SecurityQuestions(counter - 1).SetSecurityQuestionString(SecurityQuestion)
        SecurityQuestions(counter - 1).SetSecurityAnswerString(SecurityAnswer)
        counter += 1

    End Sub
    Public Function GetSecurityQuestionString()

        If counter > 2 Then
            counter = 1
        Else





        End If
        SecurityQuestions(counter - 1).GetsecurityQuestionString()

        counter += 1
    End Function
    Public Function GetSecurityAnswerString()
        If counter1 > 2 Then
            counter1 = 1
        Else





        End If
        SecurityQuestions(counter1 - 1).GetSecurityAnswerString()

        counter1 += 1

    End Function


End Class
