Public Class McSecurityQuestions
    Private SecurityAnswer As McSecurityAnswer
    Private SecurityQuestionString As String
    Sub New()


        SecurityAnswer = New McSecurityAnswer



    End Sub
    Sub SetSecurityQuestionString(ByVal scurityques As String)
        SecurityQuestionString = scurityques

    End Sub
    Function GetsecurityQuestionString()
        Return SecurityQuestionString
    End Function
    Function GetSecurityAnswerString()
        Return SecurityAnswer.GetSecurityAnswerString()

    End Function

    Sub SetSecurityAnswerString(ByVal SecAnswer As String)

        SecurityAnswer.SetSecurityAnswerString(SecAnswer)

    End Sub




End Class
