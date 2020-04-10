Public Class Particle
    Inherits PictureBox
    Protected Energy As Double
    Protected PosX As Int16
    Protected PosY As Int16
    Protected VelocityX As Integer
    Protected velocityY As Integer
    Protected Const PlanckConstant As Double = 6.63 * 10 ^ -34


    Public Sub New(ByVal xpos As Integer, ByVal ypos As Integer, ByVal red As Integer, ByVal Green As Integer, ByVal blue As Integer, ByVal scrollBar As Integer)

        Debug.Print("constructing new Particle")

        Me.BackColor = Color.Aqua
        Me.Height = 20
        Me.Width = 20
        Me.SetParticleColour(red, Green, blue)
        Setlocation(xpos, ypos)
        CalculateEnergyValue(scrollBar)

        SimulationForm.Controls.Add(Me)

    End Sub

    Protected Sub Setlocation(ByVal Xpos As Integer, ByVal Ypos As Integer)

        Me.PosX = Xpos
        Me.PosY = Ypos
        Me.Location = New Point(Xpos, Ypos)

    End Sub
    Public Sub SetParticleColour(ByVal red As Integer, ByVal green As Integer, ByVal Blue As Integer)


        Me.BackColor = Color.FromArgb(red, green, Blue)

    End Sub
    Public Sub CalculateEnergyValue(ByVal FrequencyScrollBarValue As Integer)

        Energy = PlanckConstant * ((400 * 10 ^ 12) + (1.59 * FrequencyScrollBarValue * 10 ^ 12))
        Debug.Print((430 * 10 ^ 12) + (1.3 * FrequencyScrollBarValue * 10 ^ 12))

    End Sub





End Class
