@Code
    If Not IsAjax Then
        Response.Write("ACCESS DENIED!")
        Response.End()
    End If

    Dim SearchString As String
    SearchString = Request("Search")

    'Query to be placed here, either Web-Service or DataBase Call. Pass "SearchString". Ajax results values will have to be updated that gets returned.


End Code