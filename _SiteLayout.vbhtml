<!doctype html>
<html lang="en">
<head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="~/Content/bootstrap.min.css">
    <link rel="stylesheet" href="~/Content/font-awesome.min.css" />
    <link rel="stylesheet" href="~/Content/custom.css" />

    <title>IntelliRazor | @PageData("Title")</title>
</head>
<body>
    <nav class="navbar navbar-dark sticky-top bg-dark flex-md-nowrap p-0">
        <a class="navbar-brand col-sm-3 col-md-2 mr-0" href="~/Default"><i class="fa fa-apple" aria-hidden="true"></i> IntelliRazor</a>
        <input class="form-control form-control-dark w-100" type="text" placeholder="Search" aria-label="Search">
        <ul class="navbar-nav px-3">
            <li class="nav-item text-nowrap">
                <a class="nav-link" href="~/Default">Sign out</a>
            </li>
        </ul>
    </nav>

    <div class="container-fluid">
        <div class="row">
            <nav class="col-md-2 d-none d-md-block bg-light sidebar">
                <div class="sidebar-sticky">
                    <ul class="nav flex-column">
                        <li class="nav-item">
                            <a class="nav-link" data-toggle="collapse" href="#collapseExample" aria-expanded="true">
                                <i class="fa fa-code" aria-hidden="true"></i>
                                Scripts
                            </a>
                            <div class="collapse show" id="collapseExample">
                                <a class="nav-link" href="~/Code/Link_Check">
                                    <i class="fa fa-angle-right" aria-hidden="true"></i>
                                    Link Availibilty
                                </a>
                                <a class="nav-link" href="~/Default">
                                    <i class="fa fa-angle-right" aria-hidden="true"></i>
                                    Test #1
                                </a>
                                <a class="nav-link" href="~/Default">
                                    <i class="fa fa-angle-right" aria-hidden="true"></i>
                                    Test #2
                                </a>
                            </div>
                            <div class="dropdown-divider"></div>
                        </li>
                        @*<li class="nav-item">
                                <a class="nav-link" href="~/Default">
                                    <span data-feather="home"></span>
                                    Dashboard
                                </a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="~/Default">
                                    <span data-feather="file"></span>
                                    Orders
                                </a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="~/Default">
                                    <span data-feather="shopping-cart"></span>
                                    Products
                                </a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="~/Default">
                                    <span data-feather="users"></span>
                                    Customers
                                </a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="~/Default">
                                    <span data-feather="bar-chart-2"></span>
                                    Reports
                                </a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="~/Default">
                                    <span data-feather="layers"></span>
                                    Integrations
                                </a>
                            </li>*@
                    </ul>

                    @*<h6 class="sidebar-heading d-flex justify-content-between align-items-center px-3 mt-4 mb-1 text-muted">
                            <span>Saved reports</span>
                            <a class="d-flex align-items-center text-muted" href="~/Default">
                                <span data-feather="plus-circle"></span>
                            </a>
                        </h6>
                        <ul class="nav flex-column mb-2">
                            <li class="nav-item">
                                <a class="nav-link" href="~/Default">
                                    <span data-feather="file-text"></span>
                                    Current month
                                </a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="~/Default">
                                    <span data-feather="file-text"></span>
                                    Last quarter
                                </a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="~/Default">
                                    <span data-feather="file-text"></span>
                                    Social engagement
                                </a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="~/Default">
                                    <span data-feather="file-text"></span>
                                    Year-end sale
                                </a>
                            </li>
                        </ul>*@
                </div>
            </nav>

            <main role="main" class="col-md-9 ml-sm-auto col-lg-10 pt-3 px-4">
                @RenderBody
            </main>
        </div>
    </div>

    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="~/Scripts/jquery-3.0.0.slim.min.js"></script>
    <script src="~/Scripts/popper.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>

    @RenderSection("Scripts", required:=False)
</body>
</html>