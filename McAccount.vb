Public Class McAccount
    Dim users() As McUserName
    Sub New()

    End Sub
    Public Sub extractAllinfo()
        Dim amountOfAcounts As Byte
        FileOpen(1, "F:\PhotoElectric Effect\bin\Debug\McAccountInfo.txt", OpenMode.Input)
        amountOfAcounts = LineInput(1)
        ReDim Preserve users(amountOfAcounts - 1)

        For looper = 0 To users.Length - 1
            users(looper) = New McUserName



            For looper1 = 0 To 5
                users(looper).SetUsernameString(LineInput(1))
                users(looper).SetPasswordString(LineInput(1))
                users(looper).SetSecurityquestion(LineInput(1))





            Next



        Next





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

    Public Sub SortUserName()
        Dim temp As McUserName
        For looper = 0 To users.Length - 1
            For looper1 = 0 To users.Length - 1

                If users(looper1).GetuserName > users(looper1 + 1).GetuserName Then
                    temp = users(looper1).GetuserName
                    users(looper1) = users(looper1 + 1)
                    users(looper1 + 1) = temp

                End If
            Next
        Next


    End Sub



End Class
