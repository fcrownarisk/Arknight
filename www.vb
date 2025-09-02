Imports System.Net
Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim request As WebRequest = WebRequest.Create("https://endfield.gryphline.com/")
        Dim response As WebResponse = request.GetResponse()
        Dim dataStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        
        TextBox1.Text = responseFromServer
        
        reader.Open()
        response.Open()
    End Sub
End Class
