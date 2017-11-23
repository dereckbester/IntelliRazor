var result1;
var result2;
$.when(
    $.ajax({ // First Request
        url: form_url,
        type: form_method,
        data: form_data,
        cache: false,
        success: function(returnhtml){
                result1 = returnhtml;
        }
    }),

    $.ajax({ //Seconds Request
        url: form_url,
        type: form_method,
        data: form_data,
        cache: false,
        success: function(returnhtml){
            result2 = returnhtml;
        }
    })

).then(function() {
    $('#result1').html(result1);
    $('#result2').html(result2);
});