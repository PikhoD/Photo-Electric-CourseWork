Public Class Electron
    Inherits Particle
    Private workFunction As Double
    Private Const Charge As Double = 1.6 * 10 ^ -19
    Private Const Mass As Double = 9.1 * 10 ^ -31
    Private Wavelength As Double
    Private velocityVal As Single
    Private boundary As Integer = PosX
    Private KineticEnergy As Double
    Private OriginalX As Integer
    Private OriginalY As Integer
    Private RegenerationCounter As Integer = 0
    Private trytoescape As Boolean = False
    Private trytoescapeCounter As Byte = 0




    Public Sub New(ByVal posx, ByVal posy)

        MyBase.New(posx, posy, 0, 0, 255, 0)
        OriginalX = posx
        OriginalY = posy


        Debug.Print("constructing new electron")


    End Sub


    Function GetCharge() As Double

        Return Charge


    End Function
    Function Getposx() As Integer
        Return PosX
    End Function
    Function GetPosY() As Integer
        Return PosY
    End Function


    Function GetMass() As Double


        Return Mass



    End Function


    Sub SetVelocityOfElectronx()




        velocityVal = ((2 * KineticEnergy) / Mass) ^ (1 / 2)





    End Sub

    Function GetWavelength() As Double
        Dim Momentum As Double
        Momentum = Mass * velocityVal
        Wavelength = PlanckConstant / Momentum

        Return Wavelength



    End Function

    Function GetXpos() As Integer

        Return PosX
    End Function
    Function GetYpos()

        Return PosY


    End Function
    Function GetBoundry()

        Return boundary


    End Function


    Sub CalculateKineticEnergy(ByVal EnergyOfPhoton As Double)

        KineticEnergy = EnergyOfPhoton - workFunction


        If KineticEnergy < 0 Then

            KineticEnergy = 0



        End If





    End Sub
    Function GetKineticEnergy()

        Return KineticEnergy

    End Function

    Sub ElectronMovment()

        If PosX < -100 Then
            VelocityX = 0


        Else


            Dim newPositionX As Int16 = PosX + VelocityX




                Me.Setlocation(newPositionX, PosY)

                SimulationForm.Update()
                System.Threading.Thread.Sleep(0)

            End If

    End Sub
    Sub SetWorkFunction(ByVal WorkFunctionValue As Double)


        workFunction = WorkFunctionValue




    End Sub


    Sub SetElectronMovement()

        VelocityX = -Int(velocityVal / 10000)




    End Sub
    Function getvelocityval() As Single
        Return velocityVal



    End Function
    Public Sub RegenerateElectron()
        Me.Location = New Point(OriginalX, OriginalY)
        Me.velocityVal = 0
        Me.VelocityX = 0
        PosX = OriginalX
        PosY = OriginalY
    End Sub
    Sub ADDTORegenCounter()
        RegenerationCounter += 1


    End Sub
    Function GetRegenerationCounter() As Byte

        Return RegenerationCounter

    End Function
    Sub setelectronregencountertozero()

        RegenerationCounter = 0

    End Sub
    Sub SetTriedToEscapeAsTrue()

        trytoescape = True



    End Sub
    Function GetTrytoEscape() As Boolean
        Return trytoescape

    End Function
    Sub trytoescapemovement()


        Select Case trytoescapeCounter
            Case Is = 0
                VelocityX = -24
                trytoescapeCounter += 1

                ElectronMovment()

            Case Is = 1
                VelocityX = -16
                trytoescapeCounter += 1
                ElectronMovment()

            Case Is = 2
                VelocityX = -8
                trytoescapeCounter += 1
                ElectronMovment()

            Case Is = 3
                VelocityX = 0
                trytoescapeCounter += 1
                ElectronMovment()

            Case Is = 4
                VelocityX = 8
                trytoescapeCounter += 1
                ElectronMovment()

            Case Is = 5
                VelocityX = 16

                trytoescapeCounter += 1

                ElectronMovment()

            Case Is = 6

                VelocityX = 24
                ElectronMovment()
                trytoescape = False
                trytoescapeCounter = 0
                VelocityX = 0
        End Select






    End Sub

End Class
