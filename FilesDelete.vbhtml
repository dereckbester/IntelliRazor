@Code
    Dim FileName = Request("FileName")
    FileName = HttpUtility.UrlDecode(FileName)
    Dim FilesDirectory = "UploadedFiles"
    Dim Message = ""
    Dim MessageClass = ""

    'FileName = Path.GetFileName(uploadedFile.FileName)
    Dim FileToDel = Server.MapPath("~/App_Data/" & FilesDirectory & "/" & FileName)
    If (File.Exists(FileToDel)) Then
        'Delete File if exists
        Message = "File deleted."
        MessageClass = "success"
        File.Delete(FileToDel)
    Else
        Message = "File not found."
        MessageClass = "warning"
    End If

    Response.Redirect("Upload_File_Server?Message=" & HttpUtility.UrlEncode(Message) & "&Type=" & MessageClass)
End Code