Public Class McSecurityQuestions
    Private SecurityAnswer As McSecurityAnswer
    Private SecurityQuestionString As String
    Sub New()






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




End Class
