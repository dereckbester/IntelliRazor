@Code
    Layout = "~/_SiteLayout.vbhtml"
    PageData("Title") = "Check Link Availabilty"

    Dim URL As String = Request("URL")
End Code

<div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pb-2 mb-3 border-bottom">
    <h1 class="h2">@PageData("Title")</h1>
</div>
<form class="form-inline" method="post">
    <div class="form-group mb-2">
        <label>Full URL Required</label>
    </div>
    <div class="form-group mx-sm-3 mb-2">
        <label for="URL" class="sr-only">Password</label>
        <input type="text" class="form-control" name="URL" id="URL" value="" placeholder="http://www.test.com/">
    </div>
    <button type="submit" class="btn btn-primary mb-2">Submit</button>
</form>
@code
    If URL <> "" And IsPost() Then
        Dim StatusText As String = IIf(Settings.CheckAddress(URL), "Online", "Offline")
        Dim StatusIcon As String = IIf(Settings.CheckAddress(URL), "<i class=""fa fa-power-off text-success"" aria-hidden=""true""></i>", "<i class=""fa fa-power-off text-danger"" aria-hidden=""true""></i>")
End Code
<h3><small>URL Status: </small>@Html.Raw(StatusIcon) @StatusText</h3>
<p>
    <a href="@URL" target="_blank">@URL&nbsp;</a><br />
</p>
@code
    Else
End code
<div class="alert alert-info" role="alert">
    No URL provided.
</div>
@code
    End If
End Code