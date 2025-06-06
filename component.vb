Imports Windows.System

' 适用于 UWP (Universal Windows Platform) 应用
Private Async Sub Button1_Click(sender As Object, e As RoutedEventArgs)
    Dim uri As New Uri("https://endfield.gryphline.com/")
    Await Launcher.LaunchUriAsync(uri)
End Sub
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 在窗体加载时导航到网站
        WebBrowser1.Navigate("https://endfield.gryphline.com/")
    End Sub
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 点击按钮导航到新网站
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub
End Class
