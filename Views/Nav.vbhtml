<!-- Fixed navbar -->
<nav class="navbar navbar-default navbar-fixed-top">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="~/Index">IntelliRazor</a>
        </div>
        <div id="navbar" class="collapse navbar-collapse">
            <ul class="nav navbar-nav">
                <li><a class="menuItem" href="~/Index"><i class="fa fa-home" aria-hidden="true"></i>&nbsp;Home</a></li>
                <li><a class="menuItem" href="~/Development"><i class="fa fa-bug" aria-hidden="true"></i>&nbsp;Development</a></li>
                <li><a class="menuItem" href="~/FontAwesome"><i class="fa fa-bug" aria-hidden="true"></i>&nbsp;FontAwesome</a></li>
                @*<li><a href="#about">About</a></li>
                    <li><a href="#contact">Contact</a></li>*@
                @*<li class="dropdown">
    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><i class="fa fa-bug" aria-hidden="true"></i>&nbsp;Tests <span class="caret"></span></a>
    <ul class="dropdown-menu">
        <li><a href="~/Tests/SMS_Validation" class="menuItem"><i class="fa fa-mobile" aria-hidden="true"></i>&nbsp;SMS Validation</a></li>
        <li><a href="#">Another action</a></li>
            <li><a href="#">Something else here</a></li>
            <li role="separator" class="divider"></li>
            <li class="dropdown-header">Nav header</li>
            <li><a href="#">Separated link</a></li>
            <li><a href="#">One more separated link</a></li>
                    </ul>
                </li>*@
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"><i class="fa fa-line-chart" aria-hidden="true"></i>&nbsp;Charts <span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="~/Charts/Pie_Chart" class="menuItem"><i class="fa fa-pie-chart" aria-hidden="true"></i>&nbsp;Pie Chart</a></li>
                    </ul>
                </li>
            </ul>
        </div><!--/.nav-collapse -->
    </div>
</nav>