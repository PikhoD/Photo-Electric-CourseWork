Public Class Menu
    Public WithEvents FrequencyScrollBar As ScrollBar
    Public Sub New()


        FrequencyScrollBar.Location = New Point(10, 200)
        FrequencyScrollBar.Size = New Size(175, 15)
        FrequencyScrollBar.Value = 50
        FrequencyScrollBar.Location = New Point(200, 30)
        FrequencyScrollBar.Size = New Size(15, 175)
        FrequencyScrollBar.Value = 50

        SimulationForm.Controls.Add(FrequencyScrollBar)




    End Sub







End Class
