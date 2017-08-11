<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>IntelliRazor</title>

    <!-- Bootstrap -->
    <link href="~/Content/bootstrap-4.0.0-beta/css/bootstrap.min.css" rel="stylesheet">
    <link href="~/Content/font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet">
    <link href="~/css/custom2.css" rel="stylesheet">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="~/Scripts/html5shiv.min.js"></script>
      <script src="~/Scripts/respond.min.js"></script>
    <![endif]-->

</head>
<body>
    @*@RenderPage("~/Views/Nav.vbhtml")*@

    @*<div class="container">*@

        @RenderBody()

    @*</div>*@

    @*@RenderPage("~/Views/Footer.vbhtml")*@

    <!-- jQuery, Bootstrap & Other plugins -->
    <script src="~/Scripts/jquery-3.1.1.min.js"></script>
    <script src="~/Content/bootstrap-4.0.0-beta/js/bootstrap.min.js"></script>
    <script src="~/js/custom.js"></script>

    @RenderSection("Scripts", required:=False)
    <script>
        $(function () {
            var pgurl = "@Request.ServerVariables("SCRIPT_NAME")";

            $(".menuItem").each(function () {
                if (pgurl.toLowerCase() == $(this).attr("href").toLowerCase()) {
                    $(this).parent().addClass("active");
                }
            });
        });
    </script>
</body>
</html>