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
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet">
    <link href="~/css/custom.css" rel="stylesheet">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    @RenderPage("~/Views/Nav.vbhtml")

    <div class="container">
        <div class="row">
            <div class="col-sm-3 col-md-3 sidebar">
                <ul class="nav nav-sidebar">
                    <li><a class="active" href="~/Development/SMS_Validation">SMS Validation</a></li>
                    <li><a href="#">Coming Soon...</a></li>
                    <li><a href="#">Coming Soon...</a></li>
                    <li><a href="#">Coming Soon...</a></li>
                </ul>
                <ul class="nav nav-sidebar">
                    <li><a href="#">Coming Soon...</a></li>
                    <li><a href="#">Coming Soon...</a></li>
                    <li><a href="#">Coming Soon...</a></li>
                    <li><a href="#">Coming Soon...</a></li>
                    <li><a href="#">Coming Soon...</a></li>
                </ul>
                <ul class="nav nav-sidebar">
                    <li><a href="#">Coming Soon...</a></li>
                    <li><a href="#">Coming Soon...</a></li>
                    <li><a href="#">Coming Soon...</a></li>
                </ul>
            </div>

            <div class="col-sm-9 col-md-9 main">
                <div class="alert alert-success alertMsg" id="alert-success" role="alert" style="display: none;"></div>
                <div class="alert alert-info alertMsg" id="alert-info" role="alert" style="display: none;"></div>
                <div class="alert alert-warning alertMsg" id="alert-warning" role="alert" style="display: none;"></div>
                <div class="alert alert-danger alertMsg" id="alert-danger" role="alert" style="display: none;"></div>

                @RenderBody()
            </div>
        </div>
    </div>

    @RenderPage("~/Views/Footer.vbhtml")

    <!-- jQuery, Bootstrap & Other plugins -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="~/js/bootstrap.min.js"></script>
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