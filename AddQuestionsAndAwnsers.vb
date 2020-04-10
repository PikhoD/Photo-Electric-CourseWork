Public Class AddQuestionsAndAwnsers
    Dim CurrentQuestion As McQuestions

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AwnserATextBox.TextChanged

    End Sub


    Private Sub AddQuestionsAndAwnsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CurrentQuestion = New McQuestions
    End Sub
End Class