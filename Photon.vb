Public Class Photon
    Inherits Particle


    Private Frequency As Double
    Public Sub New(ByVal posx, ByVal posy, ByVal red, ByVal green, ByVal blue, ByVal ScrollBarValue)

        MyBase.New(posx, posy, red, green, blue, ScrollBarValue)
        VelocityX = 3
        VelocityY = 3




    End Sub

    Sub SetEnergy(ByVal Frequency As Double)


        Energy = PlanckConstant * Frequency



    End Sub
    Function GetEnergy() As Double
        Return energy

    End Function
    Sub SetFrequencyOfPhoton(ByVal FrequencyValue As Double)


        Frequency = FrequencyValue


    End Sub
    Function GetFrequencyValue() As Double



        Return Frequency


    End Function
    Public Function protectedGetVelocityX() As Integer
        Return VelocityX


    End Function

    Public Sub ChangeVelocityX(ByVal Velocity As Integer)
        VelocityX = Velocity

    End Sub

    Public Sub ChangeVelocityY(ByVal Velocity As Integer)
        VelocityY = Velocity

    End Sub

    Public Sub PhotonMovement()




        Dim newPositionX As Int16 = PosX + VelocityX
            Dim newPositionY As Int16 = PosY + velocityY



        Me.Setlocation(newPositionX, newPositionY)

            SimulationForm.Update()






    End Sub
    Function GetXpos() As Integer

        Return PosX
    End Function

    Function GetYpos() As Integer

        Return PosY


    End Function

    Function Rebound() As Integer

        VelocityX = -VelocityX

        Return VelocityX
    End Function





End Class
