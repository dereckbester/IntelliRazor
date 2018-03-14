Imports System.IO
Imports System.Net
Imports System.Web.Helpers

Public Class Settings
    Public Shared Function CheckAddress(ByVal url As String) As Boolean
        Dim request = WebRequest.Create(url)
        request.Timeout = 1000

        Dim SendStatus As Integer = -1

        Try
            Dim myWebResponse = CType(request.GetResponse(), HttpWebResponse)
            If myWebResponse.StatusCode = HttpStatusCode.Accepted Or myWebResponse.StatusCode = 200 Then
                Return True
            Else
                Return False
            End If
        Catch e As WebException
            Return False
        End Try
    End Function
End Class
