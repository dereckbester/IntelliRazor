@Code
    Layout = "~/Views/_SiteLayout.vbhtml"
    PageData("Title") = "SMS Validation"
End Code

<!-- Begin page content -->
<div class="container">
    <div class="page-header">
        <h1>SMS Validation - Test</h1>
    </div>
    <form>
        <div class="form-group">
            <label for="SMSMessage">SMS Message</label>
            <textarea name="SMSMessage" id="SMSMessage" class="form-control" rows="3" onkeyup="CheckChars(event);" onpaste="return false;" pattern="^[a-zA-Z0-9]+$" cols="50"></textarea>
            <p>
                <span id="remaining">160 characters remaining</span><br />
                <span id="messages">1 message(s)</span>
            </p>
        </div>
        <button type="button" onclick="CheckChars(event);" class="btn btn-default pull-right">Send SMS</button>
    </form>
</div>

@Section Scripts
<script>
    $(document).ready(function () {
        var $remaining = $('#remaining'),
            $messages = $remaining.next();

        $('#SMSMessage').keyup(function () {
            var chars = this.value.length,
                messages = Math.ceil(chars / 160),
                remaining = messages * 160 - (chars % (messages * 160) || messages * 160);

            $remaining.text(remaining + ' characters remaining');
            $messages.text(messages + ' message(s)');
        });
    });

    function CheckChars(e) {
        var pat = /^[\s ^A-Za-z0-9@@$_\/.',"():;\-=+&%#!?<> \n]+$/g;
        if (pat.test(document.getElementById('SMSMessage').value) == true) {
            console.warn(true);
        } else {
            console.warn(false);
        }
    }
</script>
End Section