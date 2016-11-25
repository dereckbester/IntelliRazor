function hideAlert() {
    $(".alertMsg").hide();
}

function showAlert(Type, Msg) {
    $(".alertMsg").hide();

    switch (Type) {
        case "success":
            $("#alert-success").html(Msg).show();
            break;
        case "info":
            $("#alert-info").html(Msg).show();
            break;
        case "warning":
            $("#alert-warning").html(Msg).show();
            break;
        case "danger":
            $("#alert-danger").html(Msg).show();
            break;
        default:
            return false
    }
}