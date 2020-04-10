Public Class McQuestions
    'Private QuestionId As Byte
    Private QuestionText As String
    Private PossibleAnswers() As McAnswer
    Public Sub New()
        MsgBox("Making New Question")
        ReDim PossibleAnswers(3)
        For looper = 0 To 3
            Dim Temp As New McAnswer
            Me.PossibleAnswers(looper) = Temp
        Next

        Me.PossibleAnswers(0).AwnserText = "Leeds"

    End Sub



End Class
