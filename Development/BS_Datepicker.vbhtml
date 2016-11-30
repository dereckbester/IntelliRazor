@Code
    Layout = "~/Views/_DevLayout.vbhtml"
    PageData("Title") = "Bootstrap Datepicker"
    
    'From Date
    Dim FromDateSP As String
    FromDateSP = Request("FromDate")
    If FromDateSP = "" Then
        If Session("FromDate") = "" Then
            FromDateSP = Date.Today.ToString("yyyy-MM-dd")
        Else
            FromDateSP = Session("FromDate")
        End If
        Session("FromDate") = FromDateSP
    Else
        Session("FromDate") = FromDateSP
        FromDateSP = Session("FromDate")
    End If
    
    'To Date
    Dim ToDateSP As String
    ToDateSP = Request("ToDate")
    If ToDateSP = "" Then
        If Session("ToDate") = "" Then
            ToDateSP = Date.Today.ToString("yyyy-MM-dd")
        Else
            ToDateSP = Session("ToDate")
        End If
        Session("ToDate") = ToDateSP
    Else
        Session("ToDate") = ToDateSP
        ToDateSP = Session("ToDate")
    End If
End Code
<link href="~/Content/bs-datepicker/css/datepicker.css" rel="stylesheet">
<!-- Begin page content -->
<div class="page-header">
    <h1>Bootstrap Datepicker</h1>
    <p>
        From &amp; To Date.<br />
        To Date's max Date must be Today.Now()<br />
        From Date cannot exceed To Date.<br />
        From &amp; To Date Difference cannot exceed more than 7days.
    </p>
    <code>
        * bootstrap-datepicker.js <br />
        * Repo: https://github.com/eternicode/bootstrap-datepicker/ <br />
        * Demo: http://eternicode.github.io/bootstrap-datepicker/ <br />
        * Docs: http://bootstrap-datepicker.readthedocs.org/ <br />
        * Forked from http://www.eyecon.ro/bootstrap-datepicker
    </code>
</div>

<form class="form-inline" action="@Request.ServerVariables("SCRIPT_NAME")" method="post">
    <div class="pull-left" style="width:190px; margin-right: 5px;">
        <div class="input-group date">
            <input type="text" class="form-control" name="FromDate" value="@Session("FromDate")" placeholder="Select Date From">
            <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
        </div>
    </div>

    <div class="pull-left" style="width:190px; margin-right: 5px;">
        <div class="input-group date">
            <input type="text" class="form-control" name="ToDate" value="@Session("ToDate")" placeholder="Select Date To">
            <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
        </div>
    </div>

    <div class="btn-group pull-left" role="group" style="margin-right:5px;">
        <button type="button" onclick="PreviousDay();" class="btn btn-default" data-tooltip title="Previous Day"><span class="glyphicon glyphicon-circle-arrow-left"></span></button>
        <button type="button" onclick="Today();" class="btn btn-default">Today</button>
        <button type="button" onclick="NextDay();" class="btn btn-default" data-tooltip title="Next Day"><span class="glyphicon glyphicon-circle-arrow-right"></span></button>
    </div>

    <button type="submit" class="btn btn-primary">Submit</button>
</form>



@Section Scripts
    <script src="~/Content/bs-datepicker/js/bootstrap-datepicker.js"></script>
    <script>
        //function showUser() { }

        $(function () {
            $('[name="FromDate"]').datepicker({
                format: "yyyy-mm-dd",
                todayHighlight: true,
                onSelect: function (e) {
                    alert("selected")
                    //var date = $('[name="FromDate"]').datepicker('getDate');
                    //date.setTime(date.getTime() + (1000 * 60 * 60 * 24 * 6));
                    //$('[name="ToDate"]').datepicker('option', 'maxDate', date);
                    //$('[name="ToDate"]').datepicker('option', 'minDate', $('[name="FromDate"]').datepicker('getDate'));
                    //showUser();
                },
                minDate: -90,
                maxDate: "+1D"
            });

            $('[name="ToDate"]').datepicker({
                format: "yyyy-mm-dd",
                todayHighlight: true,
                //onSelect: showUser,
                minDate: -90,
                maxDate: "+1D"
            });
        });

        //$('#datepicker').on("changeDate", function () {
        //    $('#my_hidden_input').val(
        //        $('#datepicker').datepicker('getFormattedDate')
        //    );
        //});
            @*$('.input-group.date').datepicker({
        format: "yyyy-mm-dd",
        multidate: false,
        autoclose: true,
        todayHighlight: true,
        endDate: "@Date.Today.ToString("yyyy-MM-dd")"
        });

        var startDate = new Date('01/01/2012');
        var FromEndDate = new Date();
        var ToEndDate = "@Date.Today.ToString("yyyy-MM-dd")"

        //ToEndDate.setDate(ToEndDate.getDate() + 365);

        $('[name="FromDate"]').datepicker({
            format: "yyyy-mm-dd",
            //weekStart: 1,
            //startDate: '01/01/2012',
            endDate: FromEndDate,
            todayHighlight: true,
            autoclose: true
        }).on('changeDate', function (selected) {
                startDate = new Date(selected.date.valueOf());
                startDate.setDate(startDate.getDate(new Date(selected.date.valueOf())));
                $('[name="ToDate"]').datepicker('setStartDate', startDate);
        });

        $('[name="ToDate"]').datepicker({
            format: "yyyy-mm-dd",
            //weekStart: 1,
            startDate: startDate - 7,
            endDate: ToEndDate + 7,
            todayHighlight: true,
            autoclose: true
        }).on('changeDate', function (selected) {
            FromEndDate = new Date(selected.date.valueOf());
            FromEndDate.setDate(FromEndDate.getDate(new Date(selected.date.valueOf())));
            $('[name="FromDate"]').datepicker('setEndDate', FromEndDate);
        });

        $('[name="FromDate"]').datepicker({
            format: 'yyyy-mm-dd',
            autoclose: true,
            endDate: "@Date.Today.ToString("yyyy-MM-dd")"
        }).on('changeDate', function (selected) {
            var startDate = new Date(selected.date.valueOf());
            $('[name="ToDate"]').datepicker('setStartDate', startDate);
        }).on('clearDate', function (selected) {
            $('[name="ToDate"]').datepicker('setStartDate', null);
        });

        $('[name="ToDate"]').datepicker({
            format: 'yyyy-mm-dd',
            autoclose: true,
        }).on('changeDate', function (selected) {
            var endDate = new Date(selected.date.valueOf());
            $('[name="FromDate"]').datepicker('setEndDate', endDate);
        }).on('clearDate', function (selected) {
            $('[name="FromDate"]').datepicker('setEndDate', null);
        });
            
        function ValiDate(el) {
            if ($(el).val() !== "" || $(el).val() !== " ") {
                console.warn($(el).val());
            }
        }*@
</script>
End Section