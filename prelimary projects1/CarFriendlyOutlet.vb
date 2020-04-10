Class CarFriendlyOutlet
    Inherits Outlet
    Private CarSpaces As Integer
    Private IsDriveThru As Boolean




    Sub New(ByVal XCoOrd As Integer, ByVal YCoOrd As Integer, ByVal MaxBaseCapacity As Integer, ByVal Spaces As Integer, ByVal CandDriveThru As Boolean)
        MyBase.New(XCoOrd, YCoOrd, MaxBaseCapacity)
        DailyCosts = DailyCosts * 1.06

    End Sub
    Function GetXCord() As Integer
        Return XCoord


    End Function
    Function GetYCord() As Integer
        Return YCoord
    End Function
    Function GetCarSpaces()
        Return CarSpaces
    End Function
    Function GetIsDriveThru() As Boolean
        Return IsDriveThru



    End Function








End Class
