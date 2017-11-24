@Code
    Layout = "~/Views/_Main.vbhtml"
    PageData("Title") = "File Management"

    Dim Message As String = ""
    Dim MessageClass As String = ""

    If Request("Type") <> "" Then
        Message = Request("Message")
        Message = HttpUtility.UrlDecode(Message)
        If Request("Type") = "success" Then
            MessageClass = "alert-success"
        ElseIf Request("Type") = "warning" Then
            MessageClass = "alert-warning"
        End If
    End If

    Dim FilesDirectory = "UploadedFiles"

    If (IsPost) Then
        Try
            Dim fileName = ""
            Dim fileSavePath = ""
            Dim uploadedFile = Request.Files("FileUpload")

            fileName = Path.GetFileName(uploadedFile.FileName)
            fileSavePath = Server.MapPath("~/App_Data/" & FilesDirectory & "/" & fileName)
            If (File.Exists(fileSavePath)) Then
                'File exists
                Message = "File already exists."
                MessageClass = "alert-warning"
            Else
                'File does not exist, continue with upload
                uploadedFile.SaveAs(fileSavePath)

                Message = "<strong><em>" & fileName & "</em></strong>" & " has been uploaded to server"
                MessageClass = "alert-success"
            End If
        Catch ex As Exception
            Message = "Select a file to upload."
            MessageClass = "alert-warning"
        End Try
    End If

    Dim FileList As Array
    Dim FileListCount As Integer = 0

    Try
        FileList = Directory.GetFiles(Server.MapPath("~/App_Data/" & FilesDirectory & "/"))
        FileListCount = Directory.GetFiles(Server.MapPath("~/App_Data/" & FilesDirectory & "/")).Count
    Catch ex As Exception
        FileList = Nothing
        FileListCount = 0
    End Try
End Code

<div class="container-fluid">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">@PageData("Title")</h1>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    Upload file to Server with VB Razor
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-12">
                            @code
                                If Message <> "" Then
                            End code
                            <div class="alert @MessageClass" role="alert">@Html.Raw(Message)</div>
                            @code
                                End If
                            End Code
                            <form id="myForm" method="post" enctype="multipart/form-data" action="">
                                <div class="input-group">
                                    <label class="input-group-btn">
                                        <span class="btn btn-primary">
                                            Browse&hellip; <input type="file" name="FileUpload" style="display: none;" multiple>
                                        </span>
                                    </label>
                                    <input type="text" class="form-control" readonly>
                                    <label class="input-group-btn">
                                        <button type="submit" class="btn btn-primary">Upload File</button>
                                    </label>
                                </div>
                            </form>
                        </div>
                    </div>
                    <!-- /.row (nested) -->
                </div>
                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-12 -->

        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    Files
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    @code
                        If Not IsNothing(FileList) Then
                            If FileListCount > 0 Then
                    End Code
                    <div class="table-responsive">
                        <table class="table table-hover">
                            <thead>
                                <tr>
                                    <th>File Name</th>
                                    <th>File Type</th>
                                    <th>&nbsp;</th>
                                </tr>
                            </thead>
                            <tbody>
                                @code
                                    For Each File In FileList
                                        Dim FileName = System.IO.Path.GetFileName(File)
                                End Code
                                <tr>
                                    <td>@FileName &nbsp;<a href="#" onclick="FileRename('@HttpUtility.UrlEncode(FileName)', '@HttpUtility.UrlEncode(File)'); return false;" data-toggle="tooltip" title="Rename File"><i class="fa fa-pencil"></i></a></td>
                                    <td>@Path.GetExtension(FileName)</td>
                                    @*<td>@File</td>*@
                                    <td class="text-right">
                                        <a href="~/FilesDelete?FileName=@HttpUtility.UrlEncode(FileName)" class="btn btn-danger btn-xs" data-toggle="tooltip" title="Delete File">
                                            <i class="fa fa-times"></i>
                                        </a>
                                    </td>
                                </tr>
                                @code
                                    Next
                                End Code
                            </tbody>
                        </table>
                    </div>
                    @code
                        Else
                    End code
                    <div class="alert alert-info" role="alert">No files available.</div>
                    @code
                            End If
                        End If
                    End Code
                    <!-- /.table-responsive -->
                </div>
                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-12 -->

        <!-- Rename File Modal -->

        <div class="modal fade" tabindex="-1" role="dialog" id="RenameFile">
            <div class="modal-dialog modal-md" role="document">
                <div class="modal-content">
                </div><!-- /.modal-content -->
            </div><!-- /.modal-dialog -->
        </div><!-- /.modal -->

    </div>
    <!-- /.row -->
</div>
<!-- /.container-fluid -->

@section Scripts
    <script>
        var _Loader = "<p class='text-center' style='padding: 20px; margin: 0;'><i class='fa fa-spinner fa-spin'></i> Loading...</p>";

        function FileRename(FileName, FilePath) {
            var _El = $("#RenameFile").find(".modal-content");
            $("#RenameFile").modal("show");
            var request = $.ajax({
                method: "GET",
                dataType: "text",
                url: "FileManager/RenameFile",
                data: { FileName: FileName, FilePath: FilePath, Rename: 0 },
                beforeSend: function () {
                    _El.html(_Loader);
                }
            }).done(function (d) {
                setTimeout(function () {
                    _El.html(d);
                }, 1000); //delay just to show loading element
            });
        }

        function doRenameFile(Rename) {
            var _El = $("#RenameFile").find(".modal-content");
            var _FilePath = $("#filePath").val();
            var _FileName = $("#fileName").val();

            $("#RenameFile").modal("show");

            var request = $.ajax({
                method: "GET",
                dataType: "text",
                url: "FileManager/RenameFile",
                data: { FileName: _FileName, FilePath: _FilePath, Rename: Rename },
                beforeSend: function () {
                    _El.html(_Loader);
                }
            }).done(function (d) {
                setTimeout(function () {
                    _El.html(d);
                }, 1000); //delay just to show loading element
            });
        }

        $(function () {

            $('[data-toggle="tooltip"]').tooltip();

            // We can attach the `fileselect` event to all file inputs on the page
            $(document).on('change', ':file', function () {
                var input = $(this),
                    numFiles = input.get(0).files ? input.get(0).files.length : 1,
                    label = input.val().replace(/\\/g, '/').replace(/.*\//, '');
                input.trigger('fileselect', [numFiles, label]);
            });

            // We can watch for our custom `fileselect` event like this
            $(document).ready(function () {
                $(':file').on('fileselect', function (event, numFiles, label) {

                    var input = $(this).parents('.input-group').find(':text'),
                        log = numFiles > 1 ? numFiles + ' files selected' : label;

                    if (input.length) {
                        input.val(log);
                    } else {
                        if (log) alert(log);
                    }

                });
            });

        });
    </script>
End Section