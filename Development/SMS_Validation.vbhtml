@Code
    Layout = "~/Views/_DevLayout.vbhtml"
    PageData("Title") = "SMS Validation"
End Code

<!-- Begin page content -->
<div class="page-header">
    <h1>SMS Validation - Limit Characters</h1>
</div>
<form>
    <div class="form-group">
        <label for="SMSMessage">SMS Message</label>
        <textarea name="SMSMessage" id="SMSMessage" class="form-control" rows="3" onkeypress="ValidateSMS(event);" onkeydown="ValidateSpecial(event);" onpaste="return false;" pattern="^[a-zA-Z0-9]+$" cols="50"></textarea>
    </div>
    <button type="button" onclick="CheckChars(event);" class="btn btn-default pull-right">Send SMS</button>
</form>

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
            var Msg = "Sorry, " + key + " is NOT allowed."
            var Type = "danger"

            showAlert(Type, Msg);

            e.preventDefault();
            return false;
        }
    }

    function ValidateSpecial(e) {
        if ((e.altKey && e.keyCode == 78)) {
            var Msg = "Sorry, that is NOT allowed."
            var Type = "danger"

            showAlert(Type, Msg);
            e.preventDefault();
            return false;
        }

        if (e.which !== null || e.which == 0 && e.charCode == 0) {
            if (e.which === 229 || e.charCode === 229 || e.keyCode === 229) {
                var Msg = "Sorry, special characters are NOT allowed."
                var Type = "danger"

                showAlert(Type, Msg);

                e.preventDefault();
                return false;
            }
        }
    }

    function CheckChars(e) {
        if (document.getElementById('SMSMessage').value != "") {
            var pat = /^[\s ^A-Za-z0-9@@$_\/.',"():;\-=+&%#!?<> \n]+$/g;
            if (pat.test(document.getElementById('SMSMessage').value) == true) {
                var Msg = "Message validated."
                var Type = "success"

                showAlert(Type, Msg);

                return true;
            } else {
                var Msg = "Special characters are not allowed."
                var Type = "danger"

                showAlert(Type, Msg);

                e.preventDefault();
                return false;
            }
        } else {
            var Msg = "Your message cannot be blank."
            var Type = "warning"

            showAlert(Type, Msg);

            e.preventDefault();
            return false;
        }
    }
</script>
End Section