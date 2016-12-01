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
            <input type="text" class="form-control" name="ToDate" value="@Session("ToDate")" onchange="checkToDate();" title="Please select From Date to activate the datepicker." placeholder="Select Date To" data-tooltip>
            <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
        </div>
    </div>

    <div class="btn-group pull-left" role="group" style="margin-right:5px;">
        <button type="button" onclick="PreviousDay();" class="btn btn-default" data-tooltip title="Previous Day"><span class="glyphicon glyphicon-circle-arrow-left"></span></button>
        <button type="button" onclick="Today();" class="btn btn-default">Today</button>
        <button type="button" onclick="NextDay();" class="btn btn-default" data-tooltip title="Next Day"><span class="glyphicon glyphicon-circle-arrow-right"></span></button>
    </div>

    <button type="submit" id="SubmitFilter" class="btn btn-primary">Submit</button>
</form>



@Section Scripts
    <script src="~/Content/bs-datepicker/js/bootstrap-datepicker.js"></script>
    <script>
        var TodayDate = new Date("@Date.Today()");

        function addDays(dateObj, numDays) {
            dateObj.setDate(dateObj.getDate() + numDays);
            return dateObj;
        }

        $('[name="FromDate"]').datepicker({
            format: "yyyy-mm-dd",
            todayHighlight: true,
            autoclose: true,
            endDate: TodayDate
        }).on("changeDate", function (e) {
            var FromDate = new Date(e.date);
            var ToDate = new Date(e.date);

            //var minDate = addDays(FromDate, -7);  //Not allowing EndDate to be in the past
            var minDate = addDays(FromDate, 0);
            var maxDate = addDays(ToDate, +7);

            var maxDateVal;

            //if maxDate newer than Today, limit endDate to Today's Date, otherwise use maxDate 
            if (maxDate > TodayDate) {
                maxDateVal = TodayDate;
            } else {
                maxDateVal = maxDate;
            }
            //Format Dates 'yyyy-mm-dd'
            var dateFrom = minDate.getFullYear() + "-" + (minDate.getMonth() + 1) + "-" + minDate.getDate();
            var dateTo = maxDateVal.getFullYear() + "-" + (maxDateVal.getMonth() + 1) + "-" + maxDateVal.getDate();
            //initToDateMessage();    //we only show this message when maxDate exceeds Today's date. inform the user of Date Limitations

            //Init EndDate
            initEndDate(dateFrom, dateTo);
        });

        //Initialize EndDate - EndDate = (StartDate-7days) > (StartDate+7days)
        function initEndDate(minDate, maxDate) {
            var ToDate = $('[name="ToDate"]');
            ToDate.datepicker('remove');
            ToDate.val(""); //Clear EndDate
            ToDate.prop("disabled", false); //Enable EndDate when startDate has been selected
            $("#SubmitFilter").prop("disabled", true);
            ToDate.prop("title", "We only allow a max period of 7 days and cannot exceed Today's date.")

            ToDate.datepicker({
                format: "yyyy-mm-dd",
                startDate: minDate, //StartDate - 7days
                endDate: maxDate, //StartDate + 7days
                todayHighlight: true,
                autoclose: true
            });
            ToDate.datepicker('update');

            initTooltip();
        }
        
        function initTooltip() {
            $('[data-tooltip]').tooltip();
        }

        function checkToDate() {
            var ToDate = $('[name="ToDate"]');

            if (ToDate.val() == "" || ToDate.val() == " ") {
                $("#SubmitFilter").prop("disabled", true);
            } else {
                $("#SubmitFilter").prop("disabled", false);
            }
        }
</script>
End Section