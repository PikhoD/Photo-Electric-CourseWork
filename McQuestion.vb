Public Class McQuestion

    Private Shared NextQuestionID As Integer
    Private questionID As Byte
    Private questionText As String
    Private answers(3) As McAnswer
    Private Counter As Byte
    Sub New()





        For looper = 0 To 3
            answers(looper) = New McAnswer
        Next


    End Sub


    Public Sub SetQuestionId(ByVal QuesID As Byte)

        questionID = QuesID

    End Sub
    Public Function GetquestionID() As String

        Return questionID

    End Function
    Public Sub SetQuestionText(ByVal QuesText As String)
        questionText = QuesText
    End Sub
    Public Function GetQuesText() As String
        Return questionText

    End Function

    Public Sub SetMcAnswer(ByVal AnswerAndIfCorrect As String)
        If Counter > 2 Then
            Counter = 0
        Else


            Counter += 1


        End If
        answers(Counter).SetISCorrectAndAnswerText(AnswerAndIfCorrect)
    End Sub


    Public Shared Sub SetNextQuestionID(ByVal num As Integer)
        NextQuestionID = num




    End Sub
    Public Shared Function GetNextQuestionID() As Integer

        Return NextQuestionID


    End Function
    Public Function GetAnswer() As String


        If Counter > 2 Then
            Counter = 0
        Else


            Counter += 1


        End If
        Return answers(Counter).GetISCorrectAndAnswerText()





    End Function











End Class
