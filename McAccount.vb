Public Class McAccount
    Dim users() As McUserName
    Sub New()

    End Sub
    Public Sub extractAllinfo()
        Dim amountOfAcounts As Byte
        FileOpen(1, "C:\Users\Daniel Pikho\Desktop\CourseWork Repo\Photo-Electric-CourseWork\bin\Debug\McAccountInfo.txt", OpenMode.Input)
        amountOfAcounts = LineInput(1)
        ReDim Preserve users(amountOfAcounts - 1)

        For looper = 0 To users.Length - 1
            users(looper) = New McUserName




            users(looper).SetUsernameString(LineInput(1))
                users(looper).SetPasswordString(LineInput(1))


            users(looper).SetSecurityquestionAndAnswer(LineInput(1), LineInput(1))
            users(looper).SetSecurityquestionAndAnswer(LineInput(1), LineInput(1))





        Next

        FileClose(1)



    End Sub

    Dim Ub As Integer
    Public Function BinarySearchUserName(ByVal UserNameToBeSearched As String) As Integer
        Dim Lb As Integer
        Dim MidPoint As Integer
        Dim found As Boolean

        Ub = users.Length - 1
        Lb = 0
        Do While Ub <> Lb
            Do While found = False

                MidPoint = ((Ub + Lb) \ 2) + 1

                If users(MidPoint).GetuserName = UserNameToBeSearched Then
                    found = True
                ElseIf users(MidPoint).GetuserName > UserNameToBeSearched Then
                    Ub = MidPoint - 1

                ElseIf users(MidPoint).GetuserName < UserNameToBeSearched Then

                    Lb = MidPoint + 1
                End If



            Loop




        Loop
        If found = True Then

            Return MidPoint
        Else
            Return -1


        End If

    End Function

    Public Sub SortUserNames()
        Dim temp As New McUserName
        For looper = 0 To users.Length - 1
            For looper1 = 0 To users.Length - 2

                If users(looper1).GetuserName > users(looper1 + 1).GetuserName Then
                    temp = users(looper1)
                    users(looper1) = users(looper1 + 1)
                    users(looper1 + 1) = temp

                End If
            Next
        Next


    End Sub
    Public Sub AddAnAccount(ByVal UserName As String, ByVal password As String, ByVal SecurityQuestions() As String, ByVal SecurityAnswers() As String)
        Dim Temp As New McUserName
        ReDim Preserve users(users.Length)
        Temp.SetUsernameString(UserName)
        Temp.SetPasswordString(password)
        Temp.SetSecurityquestionAndAnswer(SecurityQuestions(0), SecurityAnswers(0))
        Temp.SetSecurityquestionAndAnswer(SecurityQuestions(1), SecurityAnswers(1))
        users(users.Length - 1) = Temp
        SortUserNames()

        LoadUsernames()




    End Sub

    Public Sub LoadUsernames()
        Dim amountOfAcounts As Byte = users.Length
        FileOpen(1, "C:\Users\Daniel Pikho\Desktop\CourseWork Repo\Photo-Electric-CourseWork\bin\Debug\McAccountInfo.txt", OpenMode.Output)

        PrintLine(1, amountOfAcounts)
        For looper = 0 To users.Length - 1
            PrintLine(1, users(looper).GetuserName)
            PrintLine(1, users(looper).Getpassword)
            For looper1 = 0 To 1
                PrintLine(1, users(looper).GetSecurityQuestionString)
                PrintLine(1, users(looper).GetSecurityAnswerString)


            Next
        Next

        FileClose(1)



    End Sub


End Class
