Public Class McQuiz
    Structure Info
        Shared question As String
        Dim Answer As String
        Dim Correct As Boolean
    End Structure
    Private questions() As McQuestion


    Sub New() 'ByVal CreateQuestion As Boolean

        ExtractQuestionAndAnswers()


    End Sub
    Public Sub GetQuestions()

        '  FileOpen(1, "S:\PhotoElectric Effect\bin\Debug\McData.txt", OpenMode.Input)



    End Sub
    Public Sub ExtractQuestionAndAnswers()
        Dim nextQuesID As Byte
        FileOpen(1, "F:\PhotoElectric Effect\bin\Debug\McData.txt", OpenMode.Input)

        nextQuesID = LineInput(1)



        ReDim Preserve questions(nextQuesID - 1)

        McQuestion.SetNextQuestionID(nextQuesID)
        For looper = 0 To nextQuesID - 1
            Dim temp As New McQuestion()
            setQuestionInfo(temp, LineInput(1), LineInput(1))
            For looper1 = 0 To 3
                SetanswerInfo(temp, LineInput(1))
            Next

            questions(looper) = temp
            MsgBox(questions(looper).GetquestionID & questions(looper).GetQuesText)


        Next

        FileClose(1)






    End Sub



    Public Sub ChangeQuestionSize(ByVal number As Byte)

        ReDim Preserve questions(number)


    End Sub

    Public Sub setQuestionInfo(ByRef temp As McQuestion, ByVal string1 As String, ByVal String2 As String)


        temp.SetQuestionId(string1)
        temp.SetQuestionText(String2)


    End Sub
    Public Sub SetanswerInfo(ByRef temp As McQuestion, ByVal text1 As String)
        temp.SetMcAnswer(text1)



    End Sub
    Public Sub CreateQuestion(ByVal Informationneeded() As QuestionsAndAwnsersvb.Info, ByVal question As String)
        Dim Temp As New McQuestion
        Dim TempString As String
        Dim NextQuesID As Integer
        Info.question = question

        NextQuesID = McQuestion.GetNextQuestionID
        ChangeQuestionSize(NextQuesID)
        McQuestion.SetNextQuestionID(NextQuesID + 1)
        setQuestionInfo(Temp, NextQuesID, Info.question)
        For looper3 = 0 To 3
            TempString = SetAnswersIntoCorrectFormat(Informationneeded(looper3).Answer, Informationneeded(looper3).Correct)
            Temp.SetMcAnswer(TempString)
        Next
        questions(NextQuesID) = Temp


        LoadQuestionandAnswersIntoFiles()
    End Sub
    Public Sub LoadQuestionandAnswersIntoFiles()
        Dim NextQuesId As String
        Dim QuesId As String
        Dim quesText As String
        Dim Answer As String
        NextQuesId = McQuestion.GetNextQuestionID
        FileOpen(1, "F:\PhotoElectric Effect\bin\Debug\McData.txt", OpenMode.Output)
        PrintLine(1, NextQuesId)
        For looper = 0 To questions.Length - 1
            QuesId = questions(looper).GetquestionID
            PrintLine(1, QuesId)
            quesText = questions(looper).GetQuesText
            PrintLine(1, quesText)
            For looper1 = 0 To 3

                Answer = questions(looper).GetAnswer
                PrintLine(1, Answer)
            Next
        Next

        FileClose(1)

    End Sub
    Public Function SetAnswersIntoCorrectFormat(ByVal answer As String, ByVal correct As Boolean) As String
        Dim correctHolder As String
        If correct = True Then
            correctHolder = "TRUE"
        Else
            correctHolder = "FALSE"

        End If
        Return (answer & "," & correctHolder)
    End Function

    Public Function loadQuestion() As McQuestion


        Dim RandomNo As Integer
        RandomNo = RandomNumber(questions.Length) - 1
   


        Return questions(RandomNo)








    End Function

    Public Function RandomNumber(ByVal MaxNumber As Integer)
        Randomize()
        Dim value As Integer = (Int((MaxNumber * Rnd()) + 1))
        Return value
    End Function
    'Public Function GeneratePos() As Byte()
    'Dim pos(3) As Byte
    'Dim AlreadyHave As Boolean
    'Dim no As Byte
    'Dim counter As Byte
    ' Do Until pos(3) <> Nothing
    '   If AlreadyHave = False Then
    '        pos(counter) = no
    '         counter += 1
    '      End If
    '       AlreadyHave = False
    '        For looper = 0 To 3
    '             no = Random


    'Next

    '      Loop
    '   End Function





End Class


