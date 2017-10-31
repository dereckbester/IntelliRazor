
<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="~/favicon.ico">

    <title>Dashboard Template for Bootstrap</title>

    <!-- Bootstrap core CSS -->
    <link href="~/Assets/css/bootstrap.min.css" rel="stylesheet">
    <!-- Custom styles for this template -->
    <link href="~/Assets/css/dashboard.css" rel="stylesheet">
    <link href="~/Content/font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet">
</head>

<body>
    <header>
        <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
            <a class="navbar-brand" href="#">Dashboard</a>
            <button class="navbar-toggler d-lg-none" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarsExampleDefault">
                <ul class="navbar-nav mr-auto" id="menu">
                    <li class="nav-item active">
                        <a class="nav-link" href="#">Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Test 1</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Test 2</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Test 3</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Test 4</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Test 5</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Test 6</a>
                    </li>
                </ul>
            </div>
        </nav>
    </header>

    <div class="container-fluid">
        <nav class="col-sm-3 col-md-2 d-none d-sm-block bg-light sidebar">
            <ul class="nav nav-pills flex-column">
                <li class="nav-item">
                    <a class="nav-link" href="#" onclick="doLoader('#initLoader');">Call Loader</a>
                </li>
            </ul>
        </nav>

        <main role="main" class="col-sm-9 ml-sm-auto col-md-10 pt-3">
            <h1 class="text-center">Dashboard</h1>
            <section class="row">
                <div class="col" id="initLoader">
                    <h5 class="text-center">This content will most likely be replaced with content from Plugin...</h5>
                </div>
            </section>
        </main>
    </div>

    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="~/Assets/js/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script>window.jQuery || document.write('<script src="Scripts/jquery-3.1.1.min.js"><\/script>')</script>
    <script src="~/Assets/js/popper.min.js"></script>
    <script src="~/Assets/js/bootstrap.min.js"></script>
    <script src="~/Assets/plugins/custom-plugin.js"></script>
    <script>
        function doLoader(El){
            $(El).Loader();
        }

        $(function () {
            //$('#menu').animateMenu({ animatePadding: 30, defaultPadding: 10 });
        });
    </script>
</body>
</html>
