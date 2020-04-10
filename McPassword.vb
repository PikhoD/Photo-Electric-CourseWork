Public Class McPassword
    Dim PasswordString As String
    Dim PasswordHash As String


    Sub New()





    End Sub
    Function GetPasswordHash() As String

        Return PasswordHash
    End Function
    Sub SetPasswordHash(ByVal PassHash As String)

        PasswordHash = PassHash

    End Sub
    Function GetPasswordString() As String
        Return PasswordString
    End Function
    Sub SetPasswordString(ByVal psswordString)
        PasswordString = psswordString
    End Sub


End Class
