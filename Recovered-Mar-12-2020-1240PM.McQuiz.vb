Public Class McQuiz
    Private questions() As McQuestion

    Sub New()




    End Sub
    Public Sub GetQuestions()

        '  FileOpen(1, "S:\PhotoElectric Effect\bin\Debug\McData", OpenMode.Input)



    End Sub
    Public Sub GetNextQuestion()
        Dim nextQues As Byte
        FileOpen(1, "A:\PhotoElectric Effect\bin\Debug\McData", OpenMode.Input)
        nextQues = LineInput(1)
        McQuestion.SetNextQuestion(nextQues)


        ReDim Preserve questions(nextQues - 1)


        For looper = 0 To nextQues - 1
            Dim temp As New McQuestion()
            temp.questionID = LineInput(1)
            questions(looper) = temp


        Next


    End Sub











End Class
