Imports System.Math
Public Class Company


    Protected Name, Category As String
    Protected Balance, ReputationScore, AvgCostPerMeal, AvgPricePerMeal, DailyCosts, FamilyOutletCost, FastFoodOutletCost, NamedChefOutletCost, FuelCostPerUnit, BaseCostOfDelivery As Single
    Protected Outlets As New ArrayList
    Protected FamilyFoodOutletCapacity, FastFoodOutletCapacity, NamedChefOutletCapacity As Integer

    Public Sub New(ByVal Name As String, ByVal Category As String, ByVal Balance As Single, ByVal X As Integer, ByVal Y As Integer, ByVal FuelCostPerUnit As Single, ByVal BaseCostOfDelivery As Single)
        FamilyOutletCost = 1000
        FastFoodOutletCost = 2000
        NamedChefOutletCost = 15000
        FamilyFoodOutletCapacity = 150
        FastFoodOutletCapacity = 200
        NamedChefOutletCapacity = 50
        Me.Name = Name
        Me.Category = Category
        Me.Balance = Balance
        Me.FuelCostPerUnit = FuelCostPerUnit
        Me.BaseCostOfDelivery = BaseCostOfDelivery
        ReputationScore = 100
        DailyCosts = 100
        If Me.Category = "fast food" Then
            AvgCostPerMeal = 5
            AvgPricePerMeal = 10
            ReputationScore += Rnd() * 10 - 8
        ElseIf Me.Category = "family" Then
            AvgCostPerMeal = 12
            AvgPricePerMeal = 14
            ReputationScore += Rnd() * 30 - 5
        Else
            AvgCostPerMeal = 20
            AvgPricePerMeal = 40
            ReputationScore += Rnd() * 50
        End If
        OpenOutlet(X, Y)
    End Sub

    Public Function GetName() As String
        Return Name
    End Function

    Public Function GetNumberOfOutlets() As Integer
        Return Outlets.Count
    End Function

    Public Function GetReputationScore() As Single
        Return ReputationScore
    End Function

    Public Sub AlterDailyCosts(ByVal Change As Single)
        DailyCosts += Change
    End Sub

    Public Sub AlterAvgCostPerMeal(ByVal Change As Single)
        AvgCostPerMeal += Change
    End Sub

    Public Sub AlterFuelCostPerUnit(ByVal Change As Single)
        FuelCostPerUnit += Change
    End Sub

    Public Sub AlterReputation(ByVal Change As Single)
        ReputationScore += Change
    End Sub

    Public Sub NewDay()
        For Each O In Outlets
            O.NewDay()
        Next
    End Sub

    Public Sub AddVisitToNearestOutlet(ByVal X As Integer, ByVal Y As Integer)
        Dim NearestOutlet As Integer = 0
        Dim NearestOutletDistance, CurrentDistance As Single
        NearestOutletDistance = Sqrt((Outlets(0).GetX() - X) ^ 2 + (Outlets(0).GetY() - Y) ^ 2)
        For Current = 1 To Outlets.Count - 1
            CurrentDistance = Sqrt((Outlets(Current).GetX() - X) ^ 2 + (Outlets(Current).GetY() - Y) ^ 2)
            If CurrentDistance < NearestOutletDistance Then
                NearestOutletDistance = CurrentDistance
                NearestOutlet = Current
            End If
        Next
        Outlets(NearestOutlet).IncrementVisits()
    End Sub

    Public Function GetDetails() As String
        Dim Details As String = ""
        Details &= "Name: " & Name & Environment.NewLine & "Type of business: " & Category & Environment.NewLine
        Details &= "Current balance: " & Balance.ToString() & Environment.NewLine & "Average cost per meal: " & AvgCostPerMeal.ToString() & Environment.NewLine
        Details &= "Average price per meal: " & AvgPricePerMeal.ToString() & Environment.NewLine & "Daily costs: " & DailyCosts.ToString() & Environment.NewLine
        Details &= "Delivery costs: " & CalculateDeliveryCost().ToString() & Environment.NewLine & "Reputation: " & ReputationScore.ToString() & Environment.NewLine & Environment.NewLine
        Details &= "Number of outlets: " & Outlets.Count.ToString() & Environment.NewLine & "Outlets" & Environment.NewLine
        For Current = 1 To Outlets.Count
            Details &= Current.ToString() & ". " & Outlets(Current - 1).GetDetails() & Environment.NewLine
        Next
        Return Details
    End Function

    Public Function ProcessDayEnd() As String
        Dim Details As String = ""
        Dim ProfitLossFromOutlets As Single = 0
        Dim ProfitLossFromThisOutlet As Single = 0
        Dim DeliveryCosts As Single
        If Outlets.Count > 1 Then
            DeliveryCosts = BaseCostOfDelivery + CalculateDeliveryCost()
        Else
            DeliveryCosts = BaseCostOfDelivery
        End If
        Details &= "Daily costs for company: " & DailyCosts.ToString() & Environment.NewLine & "Cost for delivering produce to outlets: " & DeliveryCosts.ToString() & Environment.NewLine
        For Current = 0 To Outlets.Count - 1
            ProfitLossFromThisOutlet = Outlets(Current).CalculateDailyProfitLoss(AvgCostPerMeal, AvgPricePerMeal)
            Details &= "Outlet " & (Current + 1).ToString() & " profit/loss: " & ProfitLossFromThisOutlet.ToString() & Environment.NewLine
            ProfitLossFromOutlets += ProfitLossFromThisOutlet
        Next
        Details &= "Previous balance for company: " & Balance.ToString() & Environment.NewLine
        Balance += ProfitLossFromOutlets - DailyCosts - DeliveryCosts
        Details &= "New balance for company: " & Balance.ToString()
        Return Details
    End Function

    Public Function CloseOutlet(ByVal ID As Integer) As Boolean
        Dim CloseCompany As Boolean = False
        Outlets.RemoveAt(ID)
        If Outlets.Count = 0 Then
            CloseCompany = True
        End If
        Return CloseCompany
    End Function

    Public Sub ExpandOutlet(ByVal ID As Integer)
        Dim Change, Result As Integer
        Console.Write("Enter amount you would like to expand the capacity by: ")
        Change = Console.ReadLine()
        Result = Outlets(ID).AlterCapacity(Change)
        If Result = Change Then
            Console.WriteLine("Capacity adjusted.")
        Else
            Console.WriteLine("Only some of that capacity added, outlet now at maximum capacity.")
        End If
    End Sub

    Public Sub OpenOutlet(ByVal X As Integer, ByVal Y As Integer)
        Dim Capacity As Integer
        Dim YesOrNo As String
        Dim TempCarSpaceCapacity As Integer
        Dim tempIsDriveThrough As Integer

        Console.WriteLine("Is The Outlet car freindly or not Y For yes N For No")
        YesOrNo = UCase(Console.ReadLine)

        If Category = "fast food" Then
            Balance -= FastFoodOutletCost
            Capacity = FastFoodOutletCapacity
        ElseIf Category = "family" Then
            Balance -= FamilyOutletCost
            Capacity = FamilyFoodOutletCapacity
        Else
            Balance -= NamedChefOutletCost
            Capacity = NamedChefOutletCapacity
        End If

        If YesOrNo = "y" Then
            Console.WriteLine("What is the capacity of Parking in the CarFreindlyOutlet")
            TempCarSpaceCapacity = Console.ReadLine
            Console.WriteLine("Does It Have A Drive Through")
            YesOrNo = UCase(Console.ReadLine)
            If YesOrNo = "Y" Then
                tempIsDriveThrough = True
            Else
                tempIsDriveThrough = False

            End If

            Dim NewCarFreindlyOutlet As New CarFriendlyOutlet(X, Y, Capacity, TempCarSpaceCapacity, tempIsDriveThrough)


        Else
            Dim NewOutlet As New Outlet(X, Y, Capacity)
            Outlets.Add(NewOutlet)

        End If

    End Sub

    Private Function GetListOfOutlets() As ArrayList
        Dim Temp As New ArrayList
        For Current = 0 To Outlets.Count - 1
            Temp.Add(Current)
        Next
        Return Temp
    End Function

    Private Function GetDistanceBetweenTwoOutlets(ByVal Outlet1 As Integer, ByVal Outlet2 As Integer) As Single
        Return Sqrt((Outlets(Outlet1).GetX() - Outlets(Outlet2).GetX()) ^ 2 + (Outlets(Outlet1).GetY() - Outlets(Outlet2).GetY()) ^ 2)
    End Function

    Public Function CalculateDeliveryCost() As Single
        Dim ListOfOutlets As ArrayList = GetListOfOutlets()
        Dim TotalDistance As Single = 0
        Dim TotalCost As Single
        For Current = 0 To ListOfOutlets.Count - 2
            TotalDistance += GetDistanceBetweenTwoOutlets(ListOfOutlets(Current), ListOfOutlets(Current + 1))
        Next
        TotalCost = TotalDistance * FuelCostPerUnit
        Return TotalCost

    End Function




End Class

