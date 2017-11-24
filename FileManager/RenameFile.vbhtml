@Code
    If Not IsAjax Then
        Response.Write("Access denied.")
        Response.End()
    End If

    Dim Message As String = ""
    Dim FileName As String = Request("FileName")
    FileName = HttpUtility.UrlDecode(FileName)
    Dim FilePath As String = Request("FilePath")
    FilePath = HttpUtility.UrlDecode(FilePath)
    Dim Rename As Boolean = False
    Rename = Request("Rename")

    If Rename = True Then
        Try
            My.Computer.FileSystem.RenameFile(FilePath, FileName)
            Message = "Successfully renamed file."
        Catch ex As Exception
            Message = "Something went wrong while renaming the file."
        End Try

    End If
End Code


<div class="modal-header">
    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
    <h4 class="modal-title">Rename File <small>@FileName</small></h4>
</div>
<div class="modal-body">
    @code
        If Message <> "" Then
    End code
    <div class="alert alert-info" role="alert">@Html.Raw(Message)</div>
    @code
        End If
    End Code
    <form class="form-horizontal" id="renameFrm">
        <div class="form-group">
            <input type="hidden" id="filePath" value="@FilePath">
            <label for="fileName" class="col-sm-2 control-label">File Name</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="fileName" value="@FileName" placeholder="File Name">
            </div>
        </div>
    </form>
</div>
<div class="modal-footer">
    <button type="button" class="btn btn-default btn-sm" data-dismiss="modal">Close</button>
    <button type="button" class="btn btn-primary btn-sm" onclick="doRenameFile(1); return false;">Rename</button>
</div>