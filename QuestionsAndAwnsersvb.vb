Public Class QuestionsAndAwnsersvb
    Dim quiz As New McQuiz
    Dim CheckQuestionAsButton As Button
    Dim CreateQuestionAsButton As Button
    Dim Question As McQuestion


    Public Structure Info
        Shared question As String
        Dim Answer As String
        Dim Correct As Boolean


    End Structure
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles AwnserATextBox.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CreateQuestionButton_Click(sender As Object, e As EventArgs)
        Dim InformationNeeded(3) As Info
        'can't use structure yet has to be seperate variables for now
        Info.question = QuestionTextBox.Text
        InformationNeeded(0).Answer = AwnserATextBox.Text
        InformationNeeded(0).Correct = CorrectCheckBoxA.Checked

        InformationNeeded(1).Answer = AwnserBTextBox.Text
        InformationNeeded(1).Correct = CorrectCheckBoxB.Checked
        InformationNeeded(2).Answer = AwnserCTextBox.Text
        InformationNeeded(2).Correct = CorrectCheckBoxC.Checked
        InformationNeeded(3).Answer = AwnserDTextBox.Text
        InformationNeeded(3).Correct = CorrectCheckBoxD.Checked


        quiz.CreateQuestion(InformationNeeded, Info.question)
        QuestionTextBox.Text = ""
        AwnserATextBox.Text = ""
        AwnserBTextBox.Text = ""
        AwnserCTextBox.Text = ""
        AwnserDTextBox.Text = ""
        MsgBox("Question Has BEEN CREATED!!!")
        'Make it so u can use the form for both creating and answering questions 
    End Sub

    Private Sub QuestionsAndAwnsersvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CorrectCheckBoxB.CheckedChanged
        If CorrectCheckBoxB.Checked = True Then
            CorrectCheckBoxC.Enabled = False
            CorrectCheckBoxD.Enabled = False
            CorrectCheckBoxA.Enabled = False

        Else

            CorrectCheckBoxC.Enabled = True
            CorrectCheckBoxD.Enabled = True
            CorrectCheckBoxA.Enabled = True
        End If



    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CorrectCheckBoxD.CheckedChanged
        If CorrectCheckBoxD.Checked = True Then
            CorrectCheckBoxC.Enabled = False
            CorrectCheckBoxB.Enabled = False
            CorrectCheckBoxA.Enabled = False

        Else

            CorrectCheckBoxC.Enabled = True
            CorrectCheckBoxB.Enabled = True
            CorrectCheckBoxA.Enabled = True
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CorrectCheckBoxC.CheckedChanged
        If CorrectCheckBoxC.Checked = True Then
            CorrectCheckBoxB.Enabled = False
            CorrectCheckBoxD.Enabled = False
            CorrectCheckBoxA.Enabled = False

        Else

            CorrectCheckBoxB.Enabled = True
            CorrectCheckBoxD.Enabled = True
            CorrectCheckBoxA.Enabled = True
        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CorrectCheckBoxA.CheckedChanged
        If CorrectCheckBoxA.Checked = True Then
            CorrectCheckBoxC.Enabled = False
            CorrectCheckBoxD.Enabled = False
            CorrectCheckBoxB.Enabled = False

        Else

            CorrectCheckBoxC.Enabled = True
            CorrectCheckBoxD.Enabled = True
            CorrectCheckBoxB.Enabled = True
        End If

    End Sub
    Public Sub DrawCreateQuestionButton()

        CreateQuestionButton = New Button
        CreateQuestionButton.Location = New Point(366, 368)
        CreateQuestionButton.Size = New Size(113, 80)
        CreateQuestionButton.Text = "Create Question"
        AddHandler CreateQuestionButton.Click, AddressOf CreateQuestionButton_Click

        Me.Controls.Add(CreateQuestionButton)

    End Sub
    Private Sub DrawCheckQuestionButton()
        CheckQuestionAsButton = New Button
        CheckQuestionAsButton.Location = New Point(366, 368)
        CheckQuestionAsButton.Size = New Size(113, 80)
        CheckQuestionAsButton.Text = "Check Question"
        AddHandler CheckQuestionAsButton.Click, AddressOf CheckQuestionAsButton_Click

        Me.Controls.Add(CheckQuestionAsButton)




    End Sub









    Sub LoadQuestion()

        Dim Question As McQuestion


        Question = New McQuestion
        Question = quiz.loadQuestion

        QuestionTextBox.Text = Question.GetQuesText & " " & Question.GetquestionID


    End Sub
    Private Sub CheckQuestionAsButton_Click(sender As Object, e As EventArgs)

    End Sub
End Class