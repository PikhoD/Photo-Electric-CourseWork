Public Class Form2

    Dim Startbutton As New Button


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Startbutton.Height = 80
        Startbutton.Width = 130
        Startbutton.Text = "Start Simulation"

        Startbutton.Location = New Point(200, 100)


        Me.Controls.Add(Startbutton)

        AddHandler Startbutton.Click, AddressOf StartButtonClick




    End Sub


    Sub StartButtonClick()



        Dim SimForm As New SimulationForm
        SimForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CreateAccountButton.Click
        Dim CreateACC As New CreateUsernameAndPasword
        CreateACC.Show()
        Me.Hide()

    End Sub

    Private Sub CreateQuestionButton_Click(sender As Object, e As EventArgs) Handles CreateQuestionButton.Click
        Dim CreateQuestion As New QuestionsAndAwnsersvb
        CreateQuestion.DrawCreateQuestionButton()
        CreateQuestion.Show()
        Me.Hide()

    End Sub
End Class