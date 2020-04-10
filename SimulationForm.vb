Public Class SimulationForm
    Structure colour
        Dim redcolour As Integer
        Dim greencolour As Integer
        Dim bluecolour As Integer

    End Structure
    Dim energy As Double
    Dim workFunction As Double
    Dim velocityvalue As Decimal
    Dim Thecolours As colour
    Public WithEvents FrequencyScrollBar As New HScrollBar
    Public WithEvents IntensityScrollBar As New HScrollBar
    Dim sim As Simulation
    Dim WorkFunctionBox As New ComboBox
    Dim WorkFunctionTextBox As New TextBox
    Dim WorkFunctionLabel As New Label
    Dim PhotonEnergyTextbox As New TextBox
    Dim PhotonEnergylabel As New Label
    Dim VelocityTextBox As New TextBox
    Dim VelocityLabel As New Label
    Dim LoadQuestionButton As New Button


    Sub FrequencyScrollBarScroll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frequency_bar_value As String = Str(FrequencyScrollBar.Value)





        Debug.Print("frequency bar value: " & frequency_bar_value)

        Select Case FrequencyScrollBar.Value
            Case 1 To 25
                Thecolours.redcolour = 125
                'RedTextBox.Text = FrequencyBar.Value
                ' ChangeTextBoxColour.BackColor = Color.FromArgb(TheColours.RedColour, TheColours.GreenColour, TheColours.BlueColour)

            Case 26 To 51
                Thecolours.redcolour = (FrequencyScrollBar.Value * 5)


            Case 52 To 102
                Thecolours.greencolour = (FrequencyScrollBar.Value - 51) * 5

            Case 103 To 153
                Thecolours.redcolour = 255 - (FrequencyScrollBar.Value - 102) * 5

            Case 154 To 204
                Thecolours.greencolour = 255 - (FrequencyScrollBar.Value - 153) * 5
                Thecolours.bluecolour = (FrequencyScrollBar.Value - 153) * 5



            Case 205 To 242


                Thecolours.redcolour = (FrequencyScrollBar.Value - 204) * 5
                Thecolours.bluecolour = 255


        End Select
        energy = (6.63 * 10 ^ -34 * ((400 * 10 ^ 12) + (1.59 * FrequencyScrollBar.Value * 10 ^ 12)))

        PhotonEnergyTextbox.Text = (energy / (1.6 * 10 ^ -19) & "eV")

        sim.SetColoursAndEnergy(Thecolours.redcolour, Thecolours.bluecolour, Thecolours.greencolour, FrequencyScrollBar.Value)
    End Sub
    Sub WorkFunctionBoxItemChange(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Select Case WorkFunctionBox.SelectedItem.ToString

            Case Is = "Calcium"
                workFunction = 4.64 * 10 ^ -19



            Case Is = "Cesium"
                workFunction = 3.36 * 10 ^ -19


            Case Is = "potassium"
                workFunction = 3.584 * 10 ^ -19

            Case Is = "Sodium"
                workFunction = 3.68 * 10 ^ -19



            Case Is = "Lithium"
                workFunction = 3.52 * 10 ^ -19










        End Select
        WorkFunctionTextBox.Text = workFunction / (1.6 * 10 ^ -19) & " eV"
        sim.ChangeWorkFunctionOfElectron(workFunction)

    End Sub

    Private Sub SimulationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'is called when the form is loaded



        FrequencyScrollBar.Height = 15 'change the height of the frequency scrollbar to 15
        FrequencyScrollBar.Width = 175 'change the width of the frequency scrollbar to 175

        FrequencyScrollBar.Value = 50 ' change the value of frequencyscrollbar to 50
        FrequencyScrollBar.Location = New Point(200, 30) 'change the position of the frequency scrollbar to 200,30


        FrequencyScrollBar.Maximum = 250 ' change the maximun value of the scrollbar to 250
        Me.Controls.Add(FrequencyScrollBar) ' add frequency scrollbar to the form

        AddHandler FrequencyScrollBar.Scroll, AddressOf FrequencyScrollBarScroll 'Gives the frequency scrollbar a sub routine to call when it is scrolled




        IntensityScrollBar.Height = 15 ' change the height of intensity scrollbar to 15
        IntensityScrollBar.Width = 175 ' change the height of intensity scrollbar to 175


        IntensityScrollBar.Location = New Point(200, 60) 'change the position of intensityscrollbar to 200,60


        IntensityScrollBar.Maximum = 15 ' change the maximun possible value of intensity scrollbar to 15
        Me.Controls.Add(IntensityScrollBar) ' Add intensity scrollbar

        AddHandler IntensityScrollBar.Scroll, AddressOf IntensityScrollBarScroll  'gives the intensity scrollbar a sub routine to call when it is scrolled












        WorkFunctionBox.Height = 20 'gives the workfunction box a height of 20
        WorkFunctionBox.Width = 75 ' gives the workfunction box a width of 70
        WorkFunctionBox.Items.Add("Cesium") 'adds the word cesium as a item
        WorkFunctionBox.Items.Add("Lithium") 'adds the word lithium as a item
        WorkFunctionBox.Items.Add("potassium") 'adds the word potassium as a item
        WorkFunctionBox.Items.Add("Calcium") 'adds the word calcium as a item
        WorkFunctionBox.Items.Add("Sodium") 'adds the word sodium as a item


        WorkFunctionBox.Location = New Point(400, 30) 'change the position of intensityscrollbar to 200,60

        Me.Controls.Add(WorkFunctionBox) ' Add intensity scrollbar

        AddHandler WorkFunctionBox.SelectedIndexChanged, AddressOf WorkFunctionBoxItemChange  'Gives the frequency scrollbar a sub routine to call when it is scrolled


        WorkFunctionBox.Enabled = False


        WorkFunctionTextBox.Height = 30
        WorkFunctionTextBox.Width = 140
        WorkFunctionTextBox.Location = New Point(500, 30)
        Me.Controls.Add(WorkFunctionTextBox)
        WorkFunctionTextBox.Enabled = False




        WorkFunctionLabel.Height = 30
        WorkFunctionLabel.Width = 140
        WorkFunctionLabel.Location = New Point(500, 10)
        WorkFunctionLabel.Text = "Workfunction Energy"
        Me.Controls.Add(WorkFunctionLabel)


        PhotonEnergyTextbox.Height = 30
        PhotonEnergyTextbox.Width = 140
        PhotonEnergyTextbox.Location = New Point(400, 80)
        Me.Controls.Add(PhotonEnergyTextbox)
        PhotonEnergyTextbox.Enabled = False





        PhotonEnergylabel.Height = 30
        PhotonEnergylabel.Width = 120
        PhotonEnergylabel.Location = New Point(400, 60)
        PhotonEnergylabel.Text = "photon Energy"
        Me.Controls.Add(PhotonEnergylabel)

        VelocityTextBox.Height = 30
        VelocityTextBox.Width = 140
        VelocityTextBox.Location = New Point(400, 120)
        Me.Controls.Add(VelocityTextBox)
        VelocityTextBox.Enabled = False





        VelocityLabel.Height = 30
        VelocityLabel.Width = 120
        VelocityLabel.Location = New Point(400, 100)
        VelocityLabel.Text = " MAX Velocity"
        Me.Controls.Add(VelocityLabel)



        LoadQuestionButton.Location = New Point(366, 368)
        LoadQuestionButton.Size = New Size(113, 80)
        LoadQuestionButton.Text = "Create Question"
        AddHandler LoadQuestionButton.Click, AddressOf LoadQuestionButton_Click

        Me.Controls.Add(LoadquestionButton)







    End Sub

    Private Sub loadQuestionButton_Click(sender As Object, e As EventArgs)
        Dim Loadquestion As New QuestionsAndAwnsersvb()
        Loadquestion.Show()
        Me.Hide()
        Loadquestion.LoadQuestion()
    End Sub

    Private Sub SimulationForm_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown ' a sub routine called when a button is pressed
        If e.KeyCode = Keys.Enter Then ' if the enter key is pressed then
            WorkFunctionBox.Enabled = True ' toggle on the workfunction box
            WorkFunctionTextBox.Enabled = True ' toggle on the workfunction Textbox
            PhotonEnergyTextbox.Enabled = True ' toggle on the photonEnergy TextBox
            VelocityTextBox.Enabled = True ' toggle on the velocity TextBox
            sim = New Simulation ' Create an instance of the class called sim

            sim.Run() ' calls the subroutine of the class called run

        End If

    End Sub
    Sub IntensityScrollBarScroll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sim.ChangeIntensityCounter(IntensityScrollBar.Value)
        sim.SetThreadCounter(IntensityScrollBar.Value)
        Debug.Print(IntensityScrollBar.Value)






    End Sub
    Sub SetVelocityValue(ByVal VelocityOfPhoton As Decimal)


        velocityvalue = VelocityOfPhoton

        VelocityTextBox.Text = velocityvalue & "m\s"


    End Sub




























End Class