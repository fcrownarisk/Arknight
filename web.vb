Imports System.Net.Http
Imports System.Threading.Tasks

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim client As New HttpClient()
        Try
            Dim response As HttpResponseMessage = Await client.GetAsync("https://ak.hypergryph.com/#index")
            Dim content As String = Await response.Content.ReadAsStringAsync()
            TextBox1.Text = content
        Catch ex As Exception
            MessageBox.Show("... ..." & ex.Message)
        End Try
    End Sub
End Class
