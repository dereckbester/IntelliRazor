@Code
    Layout = "~/Views/_V4.vbhtml"
    PageData("Title") = "Razor Code"

    Dim Time = DateTime.Now.TimeOfDay

    Dim total = 0
    Dim totalMessage = ""

    Dim result = ""
    If (IsPost) Then
        Dim num1 = Request("text1")
        Dim num2 = Request("text2")

        total = num1.AsInt() + num2.AsInt()
        totalMessage = "Total = " & total

        result = "This page was posted using the Submit button."
    Else
        result = "Nothing posted"
    End If
End Code

<!--wrapper start-->
<div class="wrapper" id="wrapper">
    <div class="container">
        <div class="row">
            <div class="col">
                <h3 class="text-center">
                    Form Post
                </h3>
                <hr />
                @code
                    If (IsPost) Then
                End Code
                <p>Hello, the time is @DateTime.Now and this page is a postback!</p>
                @code
                    Else
                End Code
                <p>Hello <em>stranger</em>, today is: @DateTime.Now</p>  
                @code
                    End If
                End Code
                <form method="POST" action="">
                    <p>
                        <label for="text1">First Number:</label>
                        <input type="text" name="text1" />
                    </p>
                    <p>
                        <label for="text2">Second Number:</label>
                        <input type="text" name="text2" />
                    </p>
                    <p>@totalMessage</p>
                    <p><input type="submit" value="Add" /></p>
                    <p class="text-info">@result</p>
                </form>
            </div>
        </div>
    </div>
</div>
