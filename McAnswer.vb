Public Class McAnswer
    Private IsCorrect As Boolean
    Private AnswerText As String
    Private Position As Byte

    Public Sub New()

    End Sub

    Public Sub SetIsCorrect(ByVal ISOrNot As Boolean)
        IsCorrect = ISOrNot


    End Sub

    Public Sub SetAnswerText(ByVal ansText As String)
        AnswerText = ansText
    End Sub
    Public Sub SetPosition(ByVal Pos As Byte)

        Position = Pos


    End Sub
    Public Function GetIsCorrect()

        Return IsCorrect
    End Function
    Public Function GetAnswerText()
        Return AnswerText

    End Function
    Public Function GetPosition()
        Return Position


    End Function
    Public Sub SetISCorrectAndAnswerText(ByVal text As String)
        Dim CommaPos As Byte
        Dim IsOrNot As Boolean
        Dim Answer As String
        Dim TrueOrFalse As String
        CommaPos = InStr(text, ",")
        Answer = Mid(text, 1, (CommaPos - 1))

        SetAnswerText(Answer)
        TrueOrFalse = Mid(text, CommaPos + 1, text.Length - (CommaPos - 1))
        If TrueOrFalse = "TRUE" Then
            IsOrNot = True
        Else
            IsOrNot = False
        End If
        SetIsCorrect(IsOrNot)

    End Sub
    Public Function GetISCorrectAndAnswerText()
        Dim CorrectHolder As String
        Dim AnswerHolder As String

        If GetIsCorrect() = True Then

            CorrectHolder = "TRUE"
        Else
            CorrectHolder = "FALSE"

        End If
        AnswerHolder = GetAnswerText()

        Return AnswerHolder & "," & CorrectHolder

    End Function
    Public Shared Function SetINTOCorrectFormat() As String







    End Function





End Class
