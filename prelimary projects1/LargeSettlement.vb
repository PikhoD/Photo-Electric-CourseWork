Public Class LargeSettlement
    Inherits Settlement
    Public Sub New(ByVal ExtraXSize As Integer, ByVal ExtraYSize As Integer, ByVal ExtraHouseholds As Integer)
        MyBase.New()
        Me.XSize += ExtraXSize
        Me.YSize += ExtraYSize
        Me.StartNoOfHouseholds += ExtraHouseholds
        For Count = 1 To ExtraHouseholds
            AddHousehold()
        Next
    End Sub
End Class
