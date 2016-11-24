@Code
    Layout = "~/Views/_ChartLayout.vbhtml"
    PageData("Title") = "Chartist - Pie Chart"
End Code

<style>
    .ct-chart-pie1, .ct-chart-pie2 {
        position: relative;
    }

    .ct-legend {
        position: relative;
        z-index: 10;
        list-style: none;
        text-align: left;
    }

        .ct-legend li {
            position: relative;
            padding-left: 23px;
            margin-right: 10px;
            margin-bottom: 3px;
            cursor: pointer;
            display: inline-block;
        }

            .ct-legend li:before {
                width: 12px;
                height: 12px;
                position: absolute;
                left: 0;
                content: '';
                border: 3px solid transparent;
                border-radius: 2px;
            }

            .ct-legend li.inactive:before {
                background: transparent;
            }

        .ct-legend.ct-legend-inside {
            position: absolute;
            top: 0;
            right: 0;
        }

            .ct-legend.ct-legend-inside li {
                display: block;
                margin: 0;
            }

        .ct-legend .ct-series-0:before {
            background-color: #d70206;
            border-color: #d70206;
        }

        .ct-legend .ct-series-1:before {
            background-color: #f05b4f;
            border-color: #f05b4f;
        }

        .ct-legend .ct-series-2:before {
            background-color: #f4c63d;
            border-color: #f4c63d;
        }

        .ct-legend .ct-series-3:before {
            background-color: #d17905;
            border-color: #d17905;
        }

        .ct-legend .ct-series-4:before {
            background-color: #453d3f;
            border-color: #453d3f;
        }

    .crazyPink li.ct-series-0:before {
        background-color: #C2185B;
        border-color: #C2185B;
    }

    .crazyPink li.ct-series-1:before {
        background-color: #E91E63;
        border-color: #E91E63;
    }

    .crazyPink li.ct-series-2:before {
        background-color: #F06292;
        border-color: #F06292;
    }

    .crazyPink li.inactive:before {
        background-color: transparent;
    }

    .crazyPink ~ svg .ct-series-a .ct-line, .crazyPink ~ svg .ct-series-a .ct-point {
        stroke: #C2185B;
    }

    .crazyPink ~ svg .ct-series-b .ct-line, .crazyPink ~ svg .ct-series-b .ct-point {
        stroke: #E91E63;
    }

    .crazyPink ~ svg .ct-series-c .ct-line, .crazyPink ~ svg .ct-series-c .ct-point {
        stroke: #F06292;
    }
</style>



<!-- Begin page content -->
<div class="container">
    <div class="page-header">
        <h1>Chartist - Pie Chart</h1>
    </div>

    <div class="row">
        <div class="col-lg-6 ">
            <p>Heading 1</p>
            <div class="ct-chart-pie1"></div>
        </div>
        <div class="col-lg-6 ">
            <p>Heading 2</p>
            <div class="ct-chart-pie2"></div>
        </div>
    </div>
    
</div>

@Section Scripts
    <script>

        function getSum(total, num) {
            return total + num;
        }
        
        function per(num, amount) { return num / amount * 100; }

        function chart1() {
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
            new Chartist.Pie('.ct-chart-pie1', data, options);
            new Chartist.Pie('.ct-chart-pie2', data, options);
        }

        $(function () {
            chart1();
        });
    </script>
End Section