Imports WinFormsAppSne.ApiRequests

Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form3

    Private Async Sub Button2_ClickAsync(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name As String = TextBox1.Text
        Dim email As String = TextBox2.Text
        Dim phone As String = TextBox3.Text
        Dim githubLink As String = TextBox4.Text
        Dim stopwatchTime As String = TextBox5.Text

        Dim submission As New ApiRequests.SubmissionData()
        submission.Name = name
        submission.Email = email
        submission.Phone = phone
        submission.GitHubLink = githubLink
        submission.StopwatchTime = stopwatchTime

        'end a POST request to your backend to store the data
        Dim httpClient As New HttpClient()
        Dim jsonContent As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

        Try
            Dim response As HttpResponseMessage = Await httpClient.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Data stored successfully!")
            Else
                MessageBox.Show("Error storing data: " & response.StatusCode)
            End If
        Catch ex As Exception
            MessageBox.Show("Error storing data: " & ex.Message)
        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class