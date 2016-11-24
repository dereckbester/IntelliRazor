@Code
    Layout = "~/Views/_ChartLayout.vbhtml"
    PageData("Title") = "Chartist - Pie Chart"
End Code

<!-- Begin page content -->
<div class="container">
    <div class="page-header">
        <h1>Chartist - Pie Chart</h1>
    </div>

    <div class="row">
        <div class="col-lg-12 ">
            <div class="ct-chart-pie"></div>
        </div>
    </div>
    
</div>

@Section Scripts
    <script>
        function chart1() {
            function getSum(total, num) { return total + num; }

            function per(num, amount) { return num / amount * 100; }

            var data = {
                series: [79,1098]
            }

            var options = {
                showLabel: true,
                donut: true,
                donutWidth: 40,
                distributeSeries: true,
                labelDirection: 'explode',
                labelInterpolationFnc: function (value) {
                    console.log(value)
                    return per(value, data.series.reduce(getSum)).toFixed(2) + '%';
                },
                plugins: [
                    Chartist.plugins.legend({
                        position: 'bottom',
                        clickable: false,
                        legendNames: ['First Group', 'Second Group']
                    })
                ]
            }
            new Chartist.Pie('.ct-chart-pie', data, options);
        }

        $(function () {
            chart1();
        });
    </script>
End Section