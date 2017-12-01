<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>@PageData("Title") - IntelliRazor</title>

    <!-- Bootstrap Core CSS -->
    <link href="~/Assets/css/bootstrap.min.css" rel="stylesheet">

    <!-- Bootstrap Datepicker -->
    <link href="~/Assets/css/datepicker.css" rel="stylesheet">

    <!-- MetisMenu CSS -->
    <link href="~/vendor/metisMenu/metisMenu.min.css" rel="stylesheet">

    <!-- Social Buttons CSS -->
    <link href="~/vendor/bootstrap-social/bootstrap-social.css" rel="stylesheet">

    <!-- DataTables CSS -->
    <link href="~/vendor/datatables-plugins/dataTables.bootstrap.css" rel="stylesheet">

    <!-- DataTables Responsive CSS -->
    <link href="~/vendor/datatables-responsive/dataTables.responsive.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="~/dist/css/sb-admin-2.css" rel="stylesheet">

    <!-- Morris Charts CSS -->
    <link href="~/vendor/morrisjs/morris.css" rel="stylesheet">

    <!-- Custom Fonts -->
    <link href="~/vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">

    <!-- Custom Styles -->
    <link href="~/Content/custom.css" rel="stylesheet" type="text/css">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

</head>

<body>

    <div id="wrapper">

        @RenderPage("~/Views/Nav_inc.vbhtml")

        <div id="page-wrapper">
            @RenderBody()
        </div>
        <!-- /#page-wrapper -->
    </div>
    <!-- /#wrapper -->

    <!-- jQuery -->
    <script src="../Assets/js/jquery-1.11.3.min.js"></script>
    <!-- Bootstrap Core JavaScript -->
    <script src="../Assets/js/bootstrap.min.js"></script>
    <!-- Metis Menu Plugin JavaScript -->
    <script src="../vendor/metisMenu/metisMenu.min.js"></script>
    <!-- Custom Theme JavaScript -->
    <script src="../dist/js/sb-admin-2.js"></script>

    <script src="../Assets/js/bootstrap-datepicker.js"></script>
    @*Search bar*@
    <script src="../Scripts/bootstrap3-typeahead.min.js"></script>

    <script defer>
        $('.input-group.date').datepicker({
            autoclose: true,
            todayHighlight: true,
            format: "d-M-yyyy",
            container: "body"
        });

        function refreshDates(){
            $('.input-group.date').datepicker('update');
        }

        /* Start Search */
        var $input = $('#globalSearch');
        $input.typeahead({
            autoSelect: true,
            minLength: 3,
            items: 20,
            delay: 500,
            highlight: true,
            displayKey: 'StoreName',
            source: function (query, process) {
                return $.getJSON('_Ajax/Search_Stores', { Search: query },
                    function (data) {
                        GUID = {};
                        Profile = {};
                        userLabels = [];
                        //build results dropdown
                        $.each(data, function () {
                            var StoreName = this.StoreName
                            var Search
                            if (this.Search) {
                                Search = " (" + this.Search + ")";
                            } else {
                                Search = "";
                            }
                            userLabels.push(this.StoreName + Search);
                            GUID[this.StoreName + Search] = this.GUID;
                            Profile[this.StoreName + Search] = this.Profile;
                        });
                        process(userLabels);
                    });
            },
            highlighter: function (item) {
                var StoreName = item;
                var query = this.query.replace(/[\-\[\]{}()*+?.,\\\^$|#\s]/g, '\\$&');
                //Highlight search text
                return item.replace(new RegExp('(' + query + ')', 'ig'), function ($1, match) {
                    return '<strong>' + match + '</strong>'
                });
            },
            updater: function (item) {
                var StoreGUID = GUID[item];
                var ProfileGUID = Profile[item];

                var request = $.ajax({
                    url: "_Ajax/Get_Profile_ID",
                    dataType: "json",
                    method: "GET",
                    data: { ProfileGUID: ProfileGUID },
                    cache: false,
                    async: true
                });
                request.done(function (data) {
                    if (data.Success == true) {
                        var ProfileID = data.ID;
                        // Process details and proceed to store detail page
                        storeDetail(StoreGUID, ProfileID, ProfileGUID);
                        return true;

                    } else if (data.Success == false) {
                        return false;
                    }
                });
                request.fail(function (jqXHR, textStatus) {
                    Notification(textStatus, "danger");
                });
            }
        });

        //When search is clicked, process search again.
        $(document).on("click", "input.typeahead", function () {
            $(this).trigger("input");
        });
    </script>

    @RenderSection("Scripts", required:=False)

</body>

</html>