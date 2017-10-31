/*
    IntelliProfile Plugin - v0.1
    ----------------------------
    **  1   Loader
*/
(function ($) {
    $.fn.extend({
        //plugin name - animatemenu
        Loader: function (options) {
            var defaults = {
                text: "&nbsp; Loading...",
                classes: 'text-center',
                padding: '20px',
                margin: '0px',
                icon: "<i class='fa fa-spinner fa-spin'></i>",
            };

            var options = $.extend(defaults, options);

            return this.each(function () {
                var o = options;
                var elem = $(this);

                var markup = $("<div />").addClass(o.classes)
                            .css('padding', o.padding)
                            .css('margin', o.margin)
                            .html(o.icon + o.text);

                elem.html(markup)
            });

            /*return this.each(function () {
                var o = options;
                var obj = $(this);

                //obj.html(El)
                var items = $("li", obj);

                $("li:even", obj).css('background-color', o.evenColor);
                $("li:odd", obj).css('background-color', o.oddColor);

                items.mouseover(function () {
                    $(this).animate({ paddingLeft: o.animatePadding }, 300);

                }).mouseout(function () {
                    $(this).animate({ paddingLeft: o.defaultPadding }, 300);

                });
            });*/
        }
    });
})(jQuery);

/*(function ($) {
    $.fn.extend({
        IntelliProfile: function (options) {

            var defaults = {
                animatePadding: 60,
                defaultPadding: 10,
                evenColor: '#ccc',
                oddColor: '#eee',
            };

            var options = $.extend(defaults, options);

            return this.each(function (e) {

                var o = options;
                var obj = $(this);

                var items = $("li", obj);

                $("li:even", obj).css('background-color', o.evenColor);
                $("li:odd", obj).css('background-color', o.oddColor);

                items.mouseover(function (e) {
                    $(this).animate({ paddingLeft: o.animatePadding }, 300);
                }).mouseout(function (e) {
                    $(this).animate({ paddingLeft: o.defaultPadding }, 300);
                });
            });
        }
    });
})(jQuery);*/