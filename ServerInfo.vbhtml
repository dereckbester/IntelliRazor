@Code
    Layout = "~/Views/_V4.vbhtml"
    PageData("Title") = "Server Info"
    
    Dim Time = DateTime.Now.TimeOfDay
End Code

<!--wrapper start-->
<div class="wrapper" id="wrapper">
    @*<div class="container-fluid">
        <div class="row">
            <div class="col">
                <hr />
                <h3 class="text-center">
                    @PageData("Title")
                    <small class="text-muted">@Time</small>
                </h3>
                <hr />
            </div>
        </div>
    </div>*@
    <div class="container">
        <div class="row">
            <div class="col">
                <h3 class="text-center">
                    Server Request Variables
                </h3>
                <hr />
                <table border="1">
                    <tr>
                        <td>Requested URL</td>
                        <td>Relative Path</td>
                        <td>Full Path</td>
                        <td>HTTP Request Type</td>
                    </tr>
                    <tr>
                        <td>@Request.Url</td>
                        <td>@Request.FilePath</td>
                        <td>@Request.MapPath(Request.FilePath)</td>
                        <td>@Request.RequestType</td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <h3 class="text-center">
                    Server Info
                </h3>
                <hr />
                @ServerInfo.GetHtml()
            </div>
        </div>
    </div>
</div>
