Imports Windows.System
Private Async Sub Button1_Click(sender As Object, e As RoutedEventArgs)
    Dim uri As New Uri("https://endfield.gryphline.com/")
    Await Launcher.LaunchUriAsync(uri)
End Sub
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://endfield.gryphline.com/")
    End Sub
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub
End Class
