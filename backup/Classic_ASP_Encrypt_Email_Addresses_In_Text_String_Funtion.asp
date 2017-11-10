<%
    'Function to encrypt Email Addresses in String - Ninja Deedz :)
    Public Function EncryptAddresses(textString)
        Dim cut_at 
        cut_at = "@"

        Dim re, matches, Img, Str, Str2

        OrigStr = textString
        NewStr = Replace(OrigStr, ";", " ")

        Set re = new RegExp
        re.IgnoreCase = true
        re.Global = true
        re.Pattern = "(\S+)@([^\.\s]+)(?:\.([^\.\s]+))+"
        Set Matches  = re.Execute(NewStr)
        Email = ""

        Dim x
        Dim string_before, string_after

        For each Item in Matches
            Email = Item.Value

            x = InStr(Email, cut_at)

            string_before = Mid(Email, 1,x - 1)

            cut_string_before = Mid(string_before, 1, Len(string_before))
            cut_string_beforeP1 = Left(cut_string_before, 2)
            cut_string_beforeP2 = Right(cut_string_before, Len(cut_string_before)-2)
            encryptedStr1 = Left(cut_string_beforeP2, 0) & String(Len(cut_string_beforeP2), "*")

            string_after = Mid(Email, x + 1)

            cut_string_after = Mid(string_after, 1, Len(string_after))
            cut_string_afterP1 = Left(cut_string_after, Len(cut_string_after)-4)
            cut_string_afterP2 = Right(cut_string_after, 4)
            encryptedStr2 = Left(cut_string_afterP1, 0) & String(Len(cut_string_afterP1), "*")

            EncryptedEmail = cut_string_beforeP1 & encryptedStr1 & "@" & encryptedStr2 & cut_string_afterP2 'Encrypted Email Address

            OrigStr = Replace(OrigStr,Email,EncryptedEmail)
        Next
        EncryptAddresses = OrigStr
    End Function

    OrigStr = "This is a long string that we will try testings@gmail.co.za to extract the email test@test.com;information@testdomain.com;john@doe.com address from, it might exist anywhere in this string."
    
    Response.write(EncryptAddresses(OrigStr))
%>