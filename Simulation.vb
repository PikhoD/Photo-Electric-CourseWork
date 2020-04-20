Public Class Simulation
    Public Const PlanckConstant As Double = 6.63 * 10 ^ -34 ' creates a constant called planck constant
    Dim IntensityCounter As Integer = 0 ' dimensions a variable called intensity counter 
    Dim IntensityValue ' dimensions a variable called intensity value 
    Dim ElectronList As New List(Of Electron) ' dimensions a list holding instances of a class called electron
    Dim PhotonList As New List(Of Photon) ' dimensions a list holding instances of a class called photon
    Dim ScrollBarValue As Integer ' dimensions a variable called scrollbarvalue
    Dim Counter As Integer ' dimensions a variable called counter
    Dim ThreadCounter As Integer = 0 ' dimensions a variable called thread counter#
    Dim RunBool As Boolean = False



    Structure colour
        Dim Redcolour As Byte
        Dim BlueColour As Byte
        Dim GreenColour As Byte
    End Structure
    Dim TheColours As colour

    Sub New() ' is called 


    End Sub
    Sub ChangeRunBool()
        If RunBool = False Then
            RunBool = True
        Else
            RunBool = False


        End If

    End Sub
    Public Sub SetThreadCounter(ByVal val As Byte)
        ThreadCounter = val
    End Sub

    Protected Sub CheckCollision()
        'Itteraste Over All Particles in the system and check collisions

        For looper = 0 To PhotonList.Count - 1

            For looper1 = 0 To ElectronList.Count - 1

                If looper > PhotonList.Count - 1 Then
                Else
                    If PhotonList(looper).Bounds.IntersectsWith(ElectronList(looper1).Bounds) Then

                        Decideinteraction(PhotonList(looper), ElectronList(looper1), looper, PhotonList)
                        Exit For

                    End If
                End If
            Next




        Next

    End Sub

    '   Protected Sub CheckInteractions()
    Public Sub ParticleMovement()

        For looper = 0 To PhotonList.Count - 1

            PhotonList(looper).PhotonMovement()

        Next
        For looper = 0 To ElectronList.Count - 1
            If ElectronList(looper).GetTrytoEscape = True Then
                ElectronList(looper).trytoescapemovement()
                System.Threading.Thread.Sleep(3)
            Else

                ElectronList(looper).ElectronMovment()

            End If




        Next

        System.Threading.Thread.Sleep(ThreadCounter)

    End Sub

    Public Sub CheckIfNothing()

        For looper = 0 To PhotonList.Count - 1



            If PhotonList(looper).Location.X > 769 Or PhotonList(looper).Location.Y > 587 Then
                DisposePhotons(PhotonList(looper), PhotonList, looper)
                'PhotonList(looper).Dispose()
                ' PhotonList(looper) = Nothing
                '  PhotonList.RemoveAt(looper)
                '   Debug.Print(PhotonList.Count)
                Exit For
            Else

            End If
            'CheckInteractions()


        Next
        '        For looper = 0 To ElectronList.Count - 1



        '     If ElectronList(looper).Location.X < 0 Then
        '    DisposeElectrons(ElectronList(looper), ElectronList, looper)
        'PhotonList(looper).Dispose()
        ' PhotonList(looper) = Nothing
        '  PhotonList.RemoveAt(looper)
        '   Debug.Print(PhotonList.Count)
        '    Exit For
        'Else

        '   End If
        'CheckInteractions()


        'Next

    End Sub
    Public Sub DisposePhotons(ByVal photonX As Photon, ByRef PhotonList As List(Of Photon), ByVal looper As Byte)


        photonX.Dispose()
        photonX = Nothing
        PhotonList.RemoveAt(looper)
        Debug.Print(PhotonList.Count)



    End Sub
    Public Sub DisposeElectrons(ByVal electronX As Electron, ByRef electronList As List(Of Electron), ByVal looper As Byte)


        electronX.Dispose()
        electronX = Nothing

        Debug.Print(electronList.Count)
        Counter += 1
        If Counter > 64 Then
            Counter = 0

        End If

    End Sub


    Protected Sub AddElectrons()


        For looper = 0 To 7 ' creates loop to run 8 consecutive times

            ElectronList.Add(New Electron(550 + (looper * 25), 360)) ' creates a new instance of electron giving the possition of the electron should be in aswell as putting the electron in a list
            ElectronList.Add(New Electron(550 + (looper * 25), 360 + 25)) ' creates a new instance of electron giving the possition of the electron should be in aswell as putting the electron in a list
            ElectronList.Add(New Electron(550 + (looper * 25), 360 + 50)) ' creates a new instance of electron giving the possition of the electron should be in aswell as putting the electron in a list
            ElectronList.Add(New Electron(550 + (looper * 25), 360 + 75)) ' creates a new instance of electron giving the possition of the electron should be in aswell as putting the electron in a list
            ElectronList.Add(New Electron(550 + (looper * 25), 360 + 100)) ' creates a new instance of electron giving the possition of the electron should be in aswell as putting the electron in a list
            ElectronList.Add(New Electron(550 + (looper * 25), 360 + 125)) ' creates a new instance of electron giving the possition of the electron should be in aswell as putting the electron in a list
            ElectronList.Add(New Electron(550 + (looper * 25), 360 + 150)) ' creates a new instance of electron giving the possition of the electron should be in aswell as putting the electron in a list
            ElectronList.Add(New Electron(770, 550))
            Debug.Print("adding new electron")
            SimulationForm.Update()
            Debug.Print("calling form update")

        Next

    End Sub
    Protected Sub AddPhtons()
        Dim Randomholder As Integer
        If IntensityCounter = IntensityValue Then

            For looper = 1 To 1
                Randomholder = RandomNumber(6)
                PhotonList.Add(New Photon(80 + (Randomholder * 20), looper * 50, TheColours.Redcolour, TheColours.BlueColour, TheColours.GreenColour, ScrollBarValue))
                SimulationForm.Update()

            Next
            IntensityCounter = 0
        Else
            IntensityCounter += 1

        End If

    End Sub
    Public Sub rebound(ByVal photonX As Photon)
        photonX.Rebound()
    End Sub

    Sub SetColoursAndEnergy(ByVal red As Integer, ByVal green As Integer, ByVal blue As Integer, ByVal ScrollBarValue1 As Integer)
        TheColours.Redcolour = red
        TheColours.BlueColour = blue
        TheColours.GreenColour = green
        ScrollBarValue = ScrollBarValue1


    End Sub
    Public Function RandomNumber(ByVal MaxNumber As Integer)
        Randomize()
        Dim value As Integer = CInt(Int((MaxNumber * Rnd()) + 1))
        Return value
    End Function


    Public Sub Run()


        TheColours.Redcolour = 125 ' changes a structure variable for the colours of the photon to 125


        AddElectrons()

        ' calls a subroutine called add electrons
        ' AddPhtons()
        For looper = 0 To 1000000000000
            If RunBool = False Then
                Application.DoEvents()

            Else
                Dim Counter As Int64
                If Counter = 10 Then
                    AddPhtons()
                    Counter = 0
                Else
                    Counter += 1


                End If

                CheckIfNothing()
                ParticleMovement()
                CheckCollision()
                RegenerateElectrons()
                Application.DoEvents()





            End If



        Next


    End Sub

    Public Sub ChangeWorkFunctionOfElectron(ByVal WorkFunction As Double)

        For looper1 = 0 To ElectronList.Count - 1

            ElectronList(looper1).SetWorkFunction(WorkFunction)
        Next
    End Sub


    Public Sub ChangeIntensityCounter(ByVal IntensityVal As Integer)

        IntensityValue = IntensityVal

        IntensityCounter = 0

    End Sub
    Public Sub RegenerateElectrons()


        For looper = 0 To ElectronList.Count - 1

            If ElectronList(looper).Location.X < 0 Then
                If ElectronList(looper).GetRegenerationCounter > 200 Then
                    ElectronList(looper).RegenerateElectron()
                    ElectronList(looper).setelectronregencountertozero()
                Else
                    ElectronList(looper).ADDTORegenCounter()

                End If

            End If



        Next




    End Sub



    Public Sub Decideinteraction(ByVal PhotonX As Photon, ByVal electronX As Electron, ByVal looper As Byte, ByRef photonlist As List(Of Photon))
        Dim randomholder As Byte
        If Not electronX.getvelocityval > 0 Then
            randomholder = RandomNumber(2)

            Dim ElectronKe As Double
            electronX.CalculateKineticEnergy(PhotonX.GetEnergy)
            ElectronKe = electronX.GetKineticEnergy
            If ElectronKe = 0 Then
                Select Case randomholder
                    Case Is = 1
                        PhotonX.Rebound()

                        SimulationForm.SetVelocityValue(0)

                    Case Is = 2
                        DisposePhotons(PhotonX, photonlist, looper)
                        electronX.SetTriedToEscapeAsTrue()
                End Select
            Else

                DisposePhotons(PhotonX, photonlist, looper)

                electronX.SetVelocityOfElectronx()
                electronX.SetElectronMovement()
                SimulationForm.SetVelocityValue(electronX.getvelocityval)
            End If

        End If

    End Sub

    '    ByVal photonX As Photon, ByRef PhotonList As List(Of Photon), ByVal looper As Byte

End Class
