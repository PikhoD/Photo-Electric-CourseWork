Class Household
    Protected ChanceEatOutPerDay As Single
    Protected XCoord, YCoord, ID As Integer
    Protected Shared NextID As Integer = 1

    Public Sub New(ByVal X As Integer, ByVal Y As Integer)
        XCoord = X
        YCoord = Y

        ID = NextID
        NextID += 1
    End Sub

    Public Function GetDetails() As String
        Dim Details As String
        Details = ID.ToString() & "     Coordinates: (" & XCoord.ToString() & ", " & YCoord.ToString() & ")     Eat out probability: " & ChanceEatOutPerDay.ToString()
        Return Details
    End Function

    Public Function GetChanceEatOut() As Single
        Return ChanceEatOutPerDay
    End Function

    Public Function GetX() As Integer
        Return XCoord
    End Function

    Public Function GetY() As Integer
        Return YCoord
    End Function
End Class