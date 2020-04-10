Public Class simulation
    Protected SimulationSettlement As Settlement
    Protected NoOfCompanies As Integer
    Protected FuelCostPerUnit, BaseCostForDelivery As Single
    Protected Companies As New ArrayList

    Public Sub New()
        FuelCostPerUnit = 0.0098
        BaseCostForDelivery = 100
        Dim Choice As String
        Console.Write("Enter L for a large settlement,S for a smallSettlement and anything else for a normal size settlement: ")
        Choice = UCase(Console.ReadLine())

        Dim ExtraX, ExtraY, ExtraHouseholds As Integer
        Try

            If Choice = "L" Then


                Console.Write("Enter additional amount to add to X size of settlement: ")
                ExtraX = Console.ReadLine()
                Console.Write("Enter additional amount to add to Y size of settlement: ")
                ExtraY = Console.ReadLine()
                Console.Write("Enter additional number of households to add to settlement: ")
                ExtraHouseholds = Console.ReadLine()
                SimulationSettlement = New LargeSettlement(ExtraX, ExtraY, ExtraHouseholds)
            ElseIf Choice = "S" Then
                Console.WriteLine("Enter A value you want to Decrease to the X size of the settlement")
                ExtraX = Console.ReadLine
                Console.WriteLine("Enter A value you want to decrease to the y size of the settlement")


            Else
                SimulationSettlement = New Settlement()
            End If

        Catch ex As Exception

            MsgBox("Enter An Integer Not A String")



        End Try

        Dim numeric As Boolean = True


        Do Until numeric = False

            Console.Write("Enter D for default companies, anything else to add your own start companies: ")

            If IsNumeric(Console.ReadLine) = False Then
                Choice = Console.ReadLine()
                numeric = False

            Else
                MsgBox("Enter A string")
                Console.Clear()

            End If
        Loop
        numeric = True



        If Choice = "D" Then
            NoOfCompanies = 3
            Dim Company1 As New Company("AQA Burgers", "fast food", 100000, 200, 203, FuelCostPerUnit, BaseCostForDelivery)
            Companies.Add(Company1)
            Companies(0).OpenOutlet(300, 987)
            Companies(0).OpenOutlet(500, 500)
            Companies(0).OpenOutlet(305, 303)
            Companies(0).OpenOutlet(874, 456)
            Companies(0).OpenOutlet(23, 408)
            Companies(0).OpenOutlet(412, 318)
            Dim Company2 As New Company("Ben Thor Cuisine", "named chef", 100400, 390, 800, FuelCostPerUnit, BaseCostForDelivery)
            Companies.Add(Company2)
            Dim Company3 As New Company("Paltry Poultry", "fast food", 25000, 800, 390, FuelCostPerUnit, BaseCostForDelivery)
            Companies.Add(Company3)
            Companies(2).OpenOutlet(400, 390)
            Companies(2).OpenOutlet(820, 370)
            Companies(2).OpenOutlet(800, 600)
        Else
            Console.Write("Enter number of companies that exist at start of simulation: ")
            NoOfCompanies = Console.ReadLine()
            For Count = 1 To NoOfCompanies
                AddCompany()
            Next
        End If
    End Sub

    Public Sub DisplayMenu()
        Console.WriteLine(Environment.NewLine & "*********************************")
        Console.WriteLine("**********    MENU     **********")
        Console.WriteLine("*********************************")
        Console.WriteLine("1. Display details of households")
        Console.WriteLine("2. Display details of companies")
        Console.WriteLine("3. Modify company")
        Console.WriteLine("4. Add new company")
        Console.WriteLine("6. Advance to next day")
        Console.WriteLine("Q. Quit")
        Console.Write(Environment.NewLine & "Enter your choice: ")
    End Sub

    Private Sub DisplayCompaniesAtDayEnd()
        Dim Details As String
        Console.WriteLine(Environment.NewLine & "**********************")
        Console.WriteLine("***** Companies: *****")
        Console.WriteLine("**********************" & Environment.NewLine)
        For Each C In Companies
            Console.WriteLine(C.GetName())
            Console.WriteLine()
            Details = C.ProcessDayEnd()
            Console.WriteLine(Details & Environment.NewLine)
        Next
    End Sub

    Private Sub ProcessAddHouseholdsEvent()
        Dim NoOfNewHouseholds As Integer = Int(Rnd() * 4) + 1
        For Count = 1 To NoOfNewHouseholds
            SimulationSettlement.AddHousehold()
        Next
        Console.WriteLine(NoOfNewHouseholds.ToString() & " new households have been added to the settlement.")
    End Sub

    Private Sub ProcessCostOfFuelChangeEvent()
        Dim FuelCostChange As Single = (Int(Rnd() * 9) + 1) / 10
        Dim UpOrDown As Integer = Int(Rnd() * 2)
        Dim CompanyNo As Integer = Int(Rnd() * Companies.Count)
        If UpOrDown = 0 Then
            Console.WriteLine("The cost of fuel has gone up by " & FuelCostChange.ToString() & " for " & Companies(CompanyNo).GetName())
        Else
            Console.WriteLine("The cost of fuel has gone down by " & FuelCostChange.ToString() & " for " & Companies(CompanyNo).GetName())
            FuelCostChange *= -1
        End If
        Companies(CompanyNo).AlterFuelCostPerUnit(FuelCostChange)
    End Sub

    Private Sub ProcessReputationChangeEvent()
        Dim ReputationChange As Single = (Int(Rnd() * 9) + 1) / 10
        Dim UpOrDown As Integer = Int(Rnd() * 2)
        Dim CompanyNo As Integer = Int(Rnd() * Companies.Count)
        If UpOrDown = 0 Then
            Console.WriteLine("The reputation of " & Companies(CompanyNo).GetName() & " has gone up by " & ReputationChange.ToString())
        Else
            Console.WriteLine("The reputation of " & Companies(CompanyNo).GetName() & " has gone down by " & ReputationChange.ToString())
            ReputationChange *= -1
        End If
        Companies(CompanyNo).AlterReputation(ReputationChange)
    End Sub

    Private Sub ProcessCostChangeEvent()
        Dim CostToChange As Integer = Int(Rnd() * 2)
        Dim UpOrDown As Integer = Int(Rnd() * 2)
        Dim CompanyNo As Integer = Int(Rnd() * Companies.Count)
        Dim AmountOfChange As Single
        If CostToChange = 0 Then
            AmountOfChange = (Int(Rnd() * 19) + 1) / 10
            If UpOrDown = 0 Then
                Console.WriteLine("The daily costs for " & Companies(CompanyNo).GetName() & " have gone up by " & AmountOfChange.ToString())
            Else
                Console.WriteLine("The daily costs for " & Companies(CompanyNo).GetName() & " have gone down by " & AmountOfChange.ToString())
                AmountOfChange *= -1
            End If
            Companies(CompanyNo).AlterDailyCosts(AmountOfChange)
        Else
            AmountOfChange = Int((Rnd() * 9) + 1) / 10
            If UpOrDown = 0 Then
                Console.WriteLine("The average cost of a meal for " & Companies(CompanyNo).GetName() & " has gone up by " & AmountOfChange.ToString())
            Else
                Console.WriteLine("The average cost of a meal for " & Companies(CompanyNo).GetName() & " has gone down by " & AmountOfChange.ToString())
                AmountOfChange *= -1
            End If
            Companies(CompanyNo).AlterAvgCostPerMeal(AmountOfChange)
        End If
    End Sub

    Private Sub DisplayEventsAtDayEnd()
        Console.WriteLine(Environment.NewLine & "***********************")
        Console.WriteLine("*****   Events:   *****")
        Console.WriteLine("***********************" & Environment.NewLine)
        Dim EventRanNo As Single
        EventRanNo = Rnd()
        If EventRanNo < 0.25 Then
            EventRanNo = Rnd()
            If EventRanNo < 0.25 Then
                ProcessAddHouseholdsEvent()
            End If
            EventRanNo = Rnd()
            If EventRanNo < 0.5 Then
                ProcessCostOfFuelChangeEvent()
            End If
            EventRanNo = Rnd()
            If EventRanNo < 0.5 Then
                ProcessReputationChangeEvent()
            End If
            EventRanNo = Rnd()
            If EventRanNo >= 0.5 Then
                ProcessCostChangeEvent()
            End If
        Else
            Console.WriteLine("No events.")
        End If
    End Sub

    Public Sub ProcessDayEnd()
        Dim TotalReputation As Single = 0
        Dim Reputations As New ArrayList
        Dim CompanyRNo, Current, LoopMax, X, Y As Integer
        For Each C In Companies
            C.NewDay()
            TotalReputation += C.GetReputationScore()
            Reputations.Add(TotalReputation)
        Next
        LoopMax = SimulationSettlement.GetNumberOfHouseholds() - 1
        For Counter = 0 To LoopMax
            If SimulationSettlement.FindOutIfHouseholdEatsOut(Counter, X, Y) Then
                CompanyRNo = Int(Rnd() * (Int(TotalReputation) + 1))
                Current = 0
                While Current < Reputations.Count
                    If CompanyRNo < Reputations(Current) Then
                        Companies(Current).AddVisitToNearestOutlet(X, Y)
                        Exit While
                    End If
                    Current += 1
                End While
            End If
        Next
        'Reputation score is calculated for each company
        'A random integer is created involving a repuutation score cap (capping the hieghest achievable generated number)
        'the larger the generated reputation score the higher the likley hood of a bigger number bieng picked
        'companies generated numbers are compared the 1 with the highest reputation for 
        DisplayCompaniesAtDayEnd()
        DisplayEventsAtDayEnd()
    End Sub

    Public Sub AddCompany()
        Dim Balance, X, Y As Integer
        Dim CompanyName, TypeOfCompany As String
        Console.Write("Enter a name for the company: ")
        CompanyName = Console.ReadLine()
        Console.Write("Enter the starting balance for the company: ")
        Balance = Console.ReadLine()
        Do
            Console.Write("Enter 1 for a fast food company, 2 for a family company or 3 for a named chef company: ")
            TypeOfCompany = Console.ReadLine()
        Loop Until TypeOfCompany = "1" Or TypeOfCompany = "2" Or TypeOfCompany = "3"
        If TypeOfCompany = "1" Then
            TypeOfCompany = "fast food"
        ElseIf TypeOfCompany = "2" Then
            TypeOfCompany = "family"
        Else
            TypeOfCompany = "named chef"
        End If
        SimulationSettlement.GetRandomLocation(X, Y)
        Dim NewCompany As New Company(CompanyName, TypeOfCompany, Balance, X, Y, FuelCostPerUnit, BaseCostForDelivery)
        Companies.Add(NewCompany)
    End Sub

    Public Function GetIndexOfCompany(ByVal CompanyName As String) As Integer
        Dim Index As Integer = -1
        For Current = 0 To Companies.Count - 1
            If Companies(Current).GetName().ToLower() = CompanyName.ToLower() Then
                Return Current
            End If
        Next
        Return Index
    End Function

    Public Sub ModifyCompany(ByVal Index As Integer)
        Dim Choice As String
        Dim OutletIndex, X, Y As Integer
        Dim CloseCompany As Boolean
        Console.WriteLine(Environment.NewLine & "*********************************")
        Console.WriteLine("*******  MODIFY COMPANY   *******")
        Console.WriteLine("*********************************")
        Console.WriteLine("1. Open new outlet")
        Console.WriteLine("2. Close outlet")
        Console.WriteLine("3. Expand outlet")
        Console.Write(Environment.NewLine & "Enter your choice: ")
        Choice = Console.ReadLine()
        Console.WriteLine()
        If Choice = "2" Or Choice = "3" Then
            Console.Write("Enter ID of outlet: ")
            OutletIndex = Console.ReadLine()
            If OutletIndex > 0 And OutletIndex <= Companies(Index).GetNumberOfOutlets() Then
                If Choice = "2" Then
                    CloseCompany = Companies(Index).CloseOutlet(OutletIndex - 1)
                    If CloseCompany Then
                        Console.WriteLine("That company has now closed down as it has no outlets.")
                        Companies.RemoveAt(Index)
                    End If
                Else
                    Companies(Index).ExpandOutlet(OutletIndex - 1)
                End If
            Else
                Console.WriteLine("Invalid outlet ID.")
            End If
        ElseIf Choice = "1" Then
            Console.Write("Enter X coordinate for new outlet: ")
            X = Console.ReadLine()
            Console.Write("Enter Y coordinate for new outlet: ")
            Y = Console.ReadLine()
            If X >= 0 And X < SimulationSettlement.GetXSize() And Y >= 0 And Y < SimulationSettlement.GetYSize() Then
                Companies(Index).OpenOutlet(X, Y)
            Else
                Console.WriteLine("Invalid coordinates.")
            End If
        End If
        Console.WriteLine()
    End Sub

    Public Sub DisplayCompanies()
        Console.WriteLine(Environment.NewLine & "*********************************")
        Console.WriteLine("*** Details of all companies: ***")
        Console.WriteLine("*********************************" & Environment.NewLine)
        For Each C In Companies
            Console.WriteLine(C.GetDetails() & Environment.NewLine)
        Next
        Console.WriteLine()
    End Sub

    Public Sub Run()
        Dim Choice As String = ""
        Dim Index As Integer
        While Choice <> "Q"
            DisplayMenu()
            Choice = Console.ReadLine()
            Select Case Choice
                Case "1"
                    SimulationSettlement.DisplayHouseholds()
                Case "2"
                    DisplayCompanies()
                Case "3"
                    Dim CompanyName As String
                    Do
                        Console.Write("Enter company name: ")
                        CompanyName = Console.ReadLine()
                        Index = GetIndexOfCompany(CompanyName)
                    Loop Until Index <> -1
                    ModifyCompany(Index)
                Case "4"
                    AddCompany()
                Case "6"
                    ProcessDayEnd()
                Case "Q"
                    Console.WriteLine("Simulation finished, press Enter to close.")
                    Console.ReadLine()
            End Select
        End While
    End Sub
End Class

