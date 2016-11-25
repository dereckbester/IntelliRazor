function hideAlert() {
    var divsToHide = document.getElementsByClassName("alertMsg"); //divsToHide is an array
    for (var i = 0; i < divsToHide.length; i++) {
        //divsToHide[i].style.visibility = "hidden"; // or
        divsToHide[i].style.display = "none"; // depending on what you're doing
    }
}

function showAlert(Type, Msg) {
    hideAlert();

    switch (Type) {
        case "success":
            var el = document.getElementById("alert-success");
            el.innerHTML = Msg
            el.style.display = 'block';
            break;
        case "info":
            var el = document.getElementById("alert-info");
            el.innerHTML = Msg
            el.style.display = 'block';
            break;
        case "warning":
            var el = document.getElementById("alert-warning");
            el.innerHTML = Msg
            el.style.display = 'block';
            break;
        case "danger":
            var el = document.getElementById("alert-danger");
            el.innerHTML = Msg
            el.style.display = 'block';
            break;
        default:
            return false
    }
}