Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyName As String
        MyName = InputBox("Please insert your name")
        lblName.Text = MyName
        lblExtract.Text = Mid(MyName, 2, 5)



    End Sub
End Class
