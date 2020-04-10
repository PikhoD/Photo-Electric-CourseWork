Public Class Settlement
    Protected StartNoOfHouseholds, XSize, YSize As Integer
    Protected Households As New ArrayList

    Public Sub New()
        XSize = 1000
        YSize = 1000
        StartNoOfHouseholds = 1000
        CreateHouseholds()
    End Sub

    Public Function GetNumberOfHouseholds() As Integer
        Return Households.Count
    End Function

    Public Function GetXSize() As Integer
        Return XSize
    End Function

    Public Function GetYSize() As Integer
        Return YSize
    End Function

    Public Sub GetRandomLocation(ByRef X As Integer, ByRef Y As Integer)





        X = Int(Rnd() * XSize)
        Y = Int(Rnd() * YSize)
        For looper = 0 To Households.Count - 1
            If X = Households(looper).GetX Then
                If Y = Households(looper).GetY Then

                    GetRandomLocation(X, Y)




                End If



            End If


        Next







    End Sub

    Protected Sub CreateHouseholds()
        For Count = 0 To StartNoOfHouseholds - 1
            AddHousehold()
        Next
    End Sub

    Public Sub AddHousehold()
        Dim X, Y As Integer
        GetRandomLocation(X, Y)





        Dim Temp As New Household(X, Y)
        Households.Add(Temp)
    End Sub

    Public Sub DisplayHouseholds()
        Console.WriteLine(Environment.NewLine & "**********************************")
        Console.WriteLine("*** Details of all households: ***")
        Console.WriteLine("**********************************" & Environment.NewLine)
        For Each H In Households
            Console.WriteLine(H.GetDetails())
        Next
        Console.WriteLine()
    End Sub

    Public Function FindOutIfHouseholdEatsOut(ByVal HouseholdNo As Integer, ByRef X As Integer, ByRef Y As Integer) As Boolean
        Dim EatOutRNo As Single = Rnd()
        X = Households(HouseholdNo).GetX()
        Y = Households(HouseholdNo).GetY()
        If EatOutRNo < Households(HouseholdNo).GetChanceEatOut() Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
