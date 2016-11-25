@Code
    Layout = "~/Views/_DevLayout.vbhtml"
    PageData("Title") = "Development"
End Code

<!-- Begin page content -->
    <div class="page-header">
        <h1>Developer Playground</h1>
    </div>
    <code>
        alert("hi");
    </code>

@Section Scripts
    <script>
    function ValidateSMS(e) {
        // event.type must be keypress
        if (e.which == null) {
            ValidateSMSChar(e, String.fromCharCode(e.keyCode)) // IE
        } else if (e.which != 0 && e.charCode != 0) {
            ValidateSMSChar(e, String.fromCharCode(e.which))   // the rest
        } else {
            ValidateSMSChar(null) // special key
        }
    }

    function ValidateSMSChar(e, key) {
        var pat = /^[\s ^A-Za-z0-9@@$_\/.',"():;\-=+&%#!?<> \n]+$/g;
        if (pat.test(key) == true) {
            return true;
        } else {
            alert("Sorry, " + key + " is NOT allowed.");
            e.preventDefault();
            return false;
        }
    }

    function ValidateSpecial(e) {
        if ((e.altKey && e.keyCode == 78)) {
            alert("Sorry, that is NOT allowed.");
            e.preventDefault();
            return false;
        }

        if (e.which !== null || e.which == 0 && e.charCode == 0) {
            if (e.which === 229 || e.charCode === 229 || e.keyCode === 229) {
                alert("Sorry, special characters are NOT allowed.");
                e.preventDefault();
                return false;
            }
        }
    }

    function CheckChars(e) {
        var pat = /^[\s ^A-Za-z0-9@@$_\/.',"():;\-=+&%#!?<> \n]+$/g;
        if (pat.test(document.getElementById('SMSMessage').value) == true) {
            return true;
        } else {
            alert("Special characters are not allowed.");
            e.preventDefault();
            return false;
        }
    }
    </script>
End Section