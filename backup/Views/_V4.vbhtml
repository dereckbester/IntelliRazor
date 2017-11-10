<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>IntelliRazor - @PageData("Title")</title>

    <!-- Bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">
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

    @RenderPage("~/Views/_V4_Nav.vbhtml")
    
    @RenderBody()

    @*@RenderPage("~/Views/Footer.vbhtml")*@

    <!-- jQuery, Bootstrap & Other plugins -->
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
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