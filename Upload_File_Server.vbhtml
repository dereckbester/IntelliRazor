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
                                <div class="form-group">
                                    <label>File input</label>
                                    <input type="file" accept="" name="FileUpload">
                                </div>
                                <button type="submit" class="btn btn-primary btn-sm">Upload File</button>
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
                                    @*<th>Path</th>*@
                                    <th>&nbsp;</th>
                                </tr>
                            </thead>
                            <tbody>
                                @code
                                    For Each File In FileList
                                        Dim FileName = System.IO.Path.GetFileName(File)
                                End Code
                                <tr>
                                    <td>@FileName</td>
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
    </div>
    <!-- /.row -->
</div>
<!-- /.container-fluid -->

@section Scripts
    <script>
        $('[data-toggle="tooltip"]').tooltip();
    </script>
End Section