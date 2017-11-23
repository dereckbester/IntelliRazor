@code
    'Dim myTime = DateTime.Now.TimeOfDay
    Dim newText As string = ""
    
    Dim senText As String = "This is a long string that we will try dereckbester@gmail.co.za to extract the email address from, it might exist anywhere in this string."
    Dim emailRegEx As New Regex("(\S+)@([^\.\s]+)(?:\.([^\.\s]+))+")
    Dim m As Match = emailRegEx.Match(senText)
    If m.Success Then
        newText = m.ToString
    End If
    
    'Dim mystr As String = newText
    'Dim cut_at As String = "@"
    'Dim x As Integer = InStr(mystr, cut_at)

    'Dim string_before As String = mystr.Substring(0, x - 1)
    'Dim string_after As String = mystr.Substring(x + cut_at.Length - 1)
    
    'Dim myString As String = New String("*"c, newText.Length)
    
    'Dim PrivateMail As String = ""
    
    Dim email = newText
    
    Dim obsfucated = _
        String.Join("@", email.Split("@"c).Select(Function(x, n) _
            If(n = 0, _
                x.Substring(0, System.Math.Min(2, x.Length)).PadRight(x.Length, "*"c), _
                x.Substring(x.Length - 4, 4).PadLeft(x.Length, "*"c))))

    'Dim test1 = s
    
    'Console.WriteLine(obsfucated)

End Code

@*<h1>Test Page @myTime</h1>
<hr />*@
<p>
    @obsfucated
</p>