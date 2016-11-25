<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>IntelliRazor</title>

    <!-- Bootstrap -->
    <link href="~/css/Themes/Slate.min.css" rel="stylesheet">
    <link href="~/css/custom.css" rel="stylesheet">
    <!-- Charts CSS -->
    <link rel="stylesheet" href="~/Content/chartist-js/chartist.min.css">
    <link rel="stylesheet" href="~/Content/charts.css">
    <link rel="stylesheet" href="~/Content/chartist-js/chartist-plugin-tooltip.css">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->

    <!-- Charts JS -->
    <script src="~/Content/chartist-js/chartist.min.js"></script>
    <script src="~/Content/chartist-js/chartist-plugin-tooltip.min.js"></script>
    <script src="~/Content/chartist-js/chartist-plugin-legend.js"></script>
</head>
<body>

    @RenderPage("~/Views/Nav.vbhtml")

    @RenderBody()

    @RenderPage("~/Views/Footer.vbhtml")

    <!-- jQuery, Bootstrap & Other plugins -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="~/js/bootstrap.min.js"></script>

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