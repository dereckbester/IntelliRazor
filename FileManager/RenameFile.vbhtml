@Code
    If Not IsAjax Then
        Response.Write("Access denied.")
        Response.End()
    End If

    Dim FileName As String = Request("FileName")
    FileName = HttpUtility.UrlDecode(FileName)
End Code


    <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title">Rename File <small>@FileName</small></h4>
    </div>
    <div class="modal-body">
        <form class="form-horizontal">
            <div class="form-group">
                <label for="fileName" class="col-sm-2 control-label">File Name</label>
                <div class="col-sm-10">
                    <input type="text" class="form-control" id="fileName" value="@FileName" placeholder="File Name">
                </div>
            </div>
        </form>
    </div>
    <div class="modal-footer">
        <button type="button" class="btn btn-default btn-sm" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary btn-sm">Rename</button>
    </div>
