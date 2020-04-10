Public Class McUserName
    Shared AmountOfUsers As Byte
    Dim UserNameString As String
    Dim Password As McPassword
    Dim SecurityQuestions() As McSecurityQuestions


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
    Public Sub setpasswordHash(ByVal PasswordHash As String)

        Password.SetPasswordHash(PasswordHash)

    End Sub
    Public Function GetPassWordHash()

        Return Password.GetPasswordHash


    End Function
    Public Function GetSecurityQuestion()


    End Function
    Public Sub SetSecurityquestion(ByVal SecurityQuestion As String)


        'SecurityQuestion.set

    End Sub
    Public Function GetSecurityAnswerString()

    End Function
    Public Sub SetSecurityanswerString()

    End Sub


End Class
