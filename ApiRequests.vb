Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Module ApiRequests
    'PI endpoint URL
    Private Const ApiUrl As String = "http://localhost:3000/api"

    'ubmit endpoint
    Public Class SubmissionData
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GitHubLink As String
        Public Property StopwatchTime As String
    End Class

    'ing endpoint
    Public Async Function PingAsync() As Task(Of Boolean)
        Dim response As String = Await GetRequestAsync("ping")
        Return response = "True"
    End Function

    'ubmit endpoint
    Public Async Function SubmitAsync(submission As SubmissionData) As Task(Of Boolean)
        Dim httpClient As New HttpClient()
        Dim jsonContent As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = Await httpClient.PostAsync(ApiUrl & "/store-data", content)
        Return response.IsSuccessStatusCode
    End Function

    'et endpoint
    Public Async Function GetAsync(index As Integer) As Task(Of String)
        Dim httpClient As New HttpClient()
        Dim response As HttpResponseMessage = Await httpClient.GetAsync(ApiUrl & "/get-data")
        If response.IsSuccessStatusCode Then
            Dim jsonData As String = Await response.Content.ReadAsStringAsync()
            Dim dataArray As List(Of SubmissionData) = JsonConvert.DeserializeObject(Of List(Of SubmissionData))(jsonData)
            If index < dataArray.Count Then
                Return JsonConvert.SerializeObject(dataArray(index), Formatting.Indented)
            Else
                Return "Not Found"
            End If
        Else
            Return "Error: " & response.StatusCode
        End If
    End Function

    'elper functions for GET requests
    Private Async Function GetRequestAsync(endpoint As String) As Task(Of String)
        Dim httpClient As New HttpClient()
        Dim request As New HttpRequestMessage(HttpMethod.Get, ApiUrl & "/" & endpoint)
        Dim response As HttpResponseMessage = Await httpClient.SendAsync(request)
        Return Await response.Content.ReadAsStringAsync()
    End Function
End Module