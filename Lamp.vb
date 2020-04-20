Public Class Lamp
    Inherits PictureBox
    Protected Image1 As Bitmap
    Sub New()      'New(ByVal InFilePath1 As String)
        Me.Image1 = New Bitmap("C:\Users\Daniel Pikho\Desktop\CourseWork Repo\Photo-Electric-CourseWork\bin\Debug\Lamp.PNG")
        Me.Image = Me.Image1
        Me.SizeMode = PictureBoxSizeMode.AutoSize


    End Sub



End Class
