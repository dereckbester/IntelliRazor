@Code
    Layout = "~/Views/_V4.vbhtml"
    PageData("Title") = "Home"
End Code

<!--wrapper start-->
<div class="wrapper" id="wrapper">

    

    <!--header-->
    @*<header>
        <div class="jumbotron jumbotron-fluid" id="banner">
            <div class="parallax text-center" style="background-image: url(img/cover.jpg);">
                <div class="parallax-pattern-overlay">
                    <div class="container text-center" id="size-banner">
                        <a href="#"><img id="site-title" src="img/logo.png" alt="logo" /></a>
                        <h2 class="display-2">Boostrap 4 Beta is here!</h2>
                        <h3 class="learn">Wanna know how to use it?</h3>
                    </div>
                </div>
            </div>
        </div>
    </header>*@

    <div class="container">
        <h3>
            Fancy display heading
            <small class="text-muted">With faded secondary text</small>
        </h3>

        <label class="custom-control custom-checkbox">
            <input type="checkbox" class="custom-control-input">
            <span class="custom-control-indicator"></span>
            <span class="custom-control-description">Check this custom checkbox</span>
        </label>

        <br />

        <label class="custom-control custom-radio">
            <input id="radio1" name="radio" type="radio" class="custom-control-input">
            <span class="custom-control-indicator"></span>
            <span class="custom-control-description">Toggle this custom radio</span>
        </label>
        <label class="custom-control custom-radio">
            <input id="radio2" name="radio" type="radio" class="custom-control-input">
            <span class="custom-control-indicator"></span>
            <span class="custom-control-description">Or toggle this other custom radio</span>
        </label>

        <br />

        <div class="custom-controls-stacked">
            <label class="custom-control custom-radio">
                <input id="radioStacked3" name="radio-stacked" type="radio" class="custom-control-input">
                <span class="custom-control-indicator"></span>
                <span class="custom-control-description">Toggle this custom radio</span>
            </label>
            <label class="custom-control custom-radio">
                <input id="radioStacked4" name="radio-stacked" type="radio" class="custom-control-input">
                <span class="custom-control-indicator"></span>
                <span class="custom-control-description">Or toggle this other custom radio</span>
            </label>
        </div>

        <br />

        <label class="custom-file">
            <input type="file" id="file2" class="custom-file-input">
            <span class="custom-file-control"></span>
        </label>

        <form class="was-validated">
            <label class="custom-control custom-checkbox">
                <input type="checkbox" class="custom-control-input" required>
                <span class="custom-control-indicator"></span>
                <span class="custom-control-description">Check this custom checkbox</span>
            </label>

            <div class="custom-controls-stacked d-block my-3">
                <label class="custom-control custom-radio">
                    <input id="radioStacked1" name="radio-stacked" type="radio" class="custom-control-input" required>
                    <span class="custom-control-indicator"></span>
                    <span class="custom-control-description">Toggle this custom radio</span>
                </label>
                <label class="custom-control custom-radio">
                    <input id="radioStacked2" name="radio-stacked" type="radio" class="custom-control-input" required>
                    <span class="custom-control-indicator"></span>
                    <span class="custom-control-description">Or toggle this other custom radio</span>
                </label>
            </div>

            <select class="custom-select d-block my-3" required>
                <option value="">Open this select menu</option>
                <option value="1">One</option>
                <option value="2">Two</option>
                <option value="3">Three</option>
            </select>

            <label class="custom-file">
                <input type="file" id="file" class="custom-file-input" required>
                <span class="custom-file-control"></span>
            </label>
        </form>

        <div class="card-group">
            <div class="card">
                <img class="card-img-top" src="..." alt="Card image cap">
                <div class="card-body">
                    <h4 class="card-title">Card title</h4>
                    <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                    <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
                </div>
            </div>
            <div class="card">
                <img class="card-img-top" src="..." alt="Card image cap">
                <div class="card-body">
                    <h4 class="card-title">Card title</h4>
                    <p class="card-text">This card has supporting text below as a natural lead-in to additional content.</p>
                    <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
                </div>
            </div>
            <div class="card">
                <img class="card-img-top" src="..." alt="Card image cap">
                <div class="card-body">
                    <h4 class="card-title">Card title</h4>
                    <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.</p>
                    <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
                </div>
            </div>
        </div>

        <div class="alert alert-primary" role="alert">
            This is a primary alert—check it out!
        </div>
        <div class="alert alert-secondary" role="alert">
            This is a secondary alert—check it out!
        </div>
        <div class="alert alert-success" role="alert">
            This is a success alert—check it out!
        </div>
        <div class="alert alert-danger" role="alert">
            This is a danger alert—check it out!
        </div>
        <div class="alert alert-warning" role="alert">
            This is a warning alert—check it out!
        </div>
        <div class="alert alert-info" role="alert">
            This is a info alert—check it out!
        </div>
        <div class="alert alert-light" role="alert">
            This is a light alert—check it out!
        </div>
        <div class="alert alert-dark" role="alert">
            This is a dark alert—check it out!
        </div>

        <div class="alert alert-primary" role="alert">
            This is a primary alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
        </div>
        <div class="alert alert-secondary" role="alert">
            This is a secondary alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
        </div>
        <div class="alert alert-success" role="alert">
            This is a success alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
        </div>
        <div class="alert alert-danger" role="alert">
            This is a danger alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
        </div>
        <div class="alert alert-warning" role="alert">
            This is a warning alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
        </div>
        <div class="alert alert-info" role="alert">
            This is a info alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
        </div>
        <div class="alert alert-light" role="alert">
            This is a light alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
        </div>
        <div class="alert alert-dark" role="alert">
            This is a dark alert with <a href="#" class="alert-link">an example link</a>. Give it a click if you like.
        </div>

        <div class="alert alert-success" role="alert">
            <h4 class="alert-heading">Well done!</h4>
            <p>Aww yeah, you successfully read this important alert message. This example text is going to run a bit longer so that you can see how spacing within an alert works with this kind of content.</p>
            <hr>
            <p class="mb-0">Whenever you need to, be sure to use margin utilities to keep things nice and tidy.</p>
        </div>

        <div class="alert alert-warning alert-dismissible fade show" role="alert">
            <strong>Holy guacamole!</strong> You should check in on some of those fields below.
            <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                <span aria-hidden="true">&times;</span>
            </button>
        </div>

        <h1 class="display-1">Display 1</h1>
        <h1 class="display-2">Display 2</h1>
        <h1 class="display-3">Display 3</h1>
        <h1 class="display-4">Display 4</h1>

        <p>You can use the mark tag to <mark>highlight</mark> text.</p>
        <p><del>This line of text is meant to be treated as deleted text.</del></p>
        <p><s>This line of text is meant to be treated as no longer accurate.</s></p>
        <p><ins>This line of text is meant to be treated as an addition to the document.</ins></p>
        <p><u>This line of text will render as underlined</u></p>
        <p><small>This line of text is meant to be treated as fine print.</small></p>
        <p><strong>This line rendered as bold text.</strong></p>
        <p><em>This line rendered as italicized text.</em></p>

        <blockquote class="blockquote">
            <p class="mb-0">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
            <footer class="blockquote-footer">Someone famous in <cite title="Source Title">Source Title</cite></footer>
        </blockquote>

        <blockquote class="blockquote text-center">
            <p class="mb-0">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
            <footer class="blockquote-footer">Someone famous in <cite title="Source Title">Source Title</cite></footer>
        </blockquote>

        <blockquote class="blockquote text-right">
            <p class="mb-0">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
            <footer class="blockquote-footer">Someone famous in <cite title="Source Title">Source Title</cite></footer>
        </blockquote>

        <form class="bd-example">
            <fieldset>
                <legend>Example legend</legend>

                <p>
                    <label for="input">Example input</label>
                    <input type="text" id="input" placeholder="Example input">
                </p>

                <p>
                    <label for="select">Example select</label>
                    <select id="select">
                        <option value="">Choose...</option>
                        <optgroup label="Option group 1">
                            <option value="">Option 1</option>
                            <option value="">Option 2</option>
                            <option value="">Option 3</option>
                        </optgroup>
                        <optgroup label="Option group 2">
                            <option value="">Option 4</option>
                            <option value="">Option 5</option>
                            <option value="">Option 6</option>
                        </optgroup>
                    </select>
                </p>

                <p>
                    <label>
                        <input type="checkbox" value="">
                        Check this checkbox
                    </label>
                </p>

                <p>
                    <label>
                        <input type="radio" name="optionsRadios" id="optionsRadios1" value="option1" checked="">
                        Option one is this and that
                    </label>
                    <label>
                        <input type="radio" name="optionsRadios" id="optionsRadios2" value="option2">
                        Option two is something else that's also super long to demonstrate the wrapping of these fancy form controls.
                    </label>
                    <label>
                        <input type="radio" name="optionsRadios" id="optionsRadios3" value="option3" disabled="">
                        Option three is disabled
                    </label>
                </p>

                <p>
                    <label for="textarea">Example textarea</label>
                    <textarea id="textarea" rows="3"></textarea>
                </p>

                <p>
                    <label for="time">Example temporal</label>
                    <input type="datetime-local" id="time">
                </p>

                <p>
                    <label for="output">Example output</label>
                    <output name="result" id="output">100</output>
                </p>

                <p>
                    <button type="submit">Button submit</button>
                    <input type="submit" value="Input submit button">
                    <input type="button" value="Input button">
                </p>

                <p>
                    <button type="submit" disabled="">Button submit</button>
                    <input type="submit" value="Input submit button" disabled="">
                    <input type="button" value="Input button" disabled="">
                </p>
            </fieldset>
        </form>
    </div>

    <div class="container">
        <div class="row">
            <div class="col">
                1 of 2
            </div>
            <div class="col">
                2 of 2
            </div>
        </div>
        <div class="row">
            <div class="col">
                1 of 3
            </div>
            <div class="col">
                2 of 3
            </div>
            <div class="col">
                3 of 3
            </div>
        </div>
    </div>

    <div class="container">
        <div class="row">
            <div class="col">Column</div>
            <div class="col">Column</div>
            <div class="w-100"></div>
            <div class="col">Column</div>
            <div class="col">Column</div>
        </div>
    </div>

    <div class="container">
        <div class="row">
            <div class="col">
                1 of 3
            </div>
            <div class="col-6">
                2 of 3 (wider)
            </div>
            <div class="col">
                3 of 3
            </div>
        </div>
        <div class="row">
            <div class="col">
                1 of 3
            </div>
            <div class="col-5">
                2 of 3 (wider)
            </div>
            <div class="col">
                3 of 3
            </div>
        </div>
    </div>

    <div class="container">
        <div class="row justify-content-md-center">
            <div class="col col-lg-2">
                1 of 3
            </div>
            <div class="col-md-auto">
                Variable width content
            </div>
            <div class="col col-lg-2">
                3 of 3
            </div>
        </div>
        <div class="row">
            <div class="col">
                1 of 3
            </div>
            <div class="col-md-auto">
                Variable width content
            </div>
            <div class="col col-lg-2">
                3 of 3
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col">col</div>
            <div class="col">col</div>
            <div class="w-100"></div>
            <div class="col">col</div>
            <div class="col">col</div>
        </div>

        <div class="row">
            <div class="col">col</div>
            <div class="col">col</div>
            <div class="col">col</div>
            <div class="col">col</div>
        </div>
        <div class="row">
            <div class="col-8">col-8</div>
            <div class="col-4">col-4</div>
        </div>


        <div class="row">
            <div class="col-sm-8">col-sm-8</div>
            <div class="col-sm-4">col-sm-4</div>
        </div>
        <div class="row">
            <div class="col-sm">col-sm</div>
            <div class="col-sm">col-sm</div>
            <div class="col-sm">col-sm</div>
        </div>

        <!-- Stack the columns on mobile by making one full-width and the other half-width -->
        <div class="row">
            <div class="col-12 col-md-8">.col-12 .col-md-8</div>
            <div class="col-6 col-md-4">.col-6 .col-md-4</div>
        </div>

        <!-- Columns start at 50% wide on mobile and bump up to 33.3% wide on desktop -->
        <div class="row">
            <div class="col-6 col-md-4">.col-6 .col-md-4</div>
            <div class="col-6 col-md-4">.col-6 .col-md-4</div>
            <div class="col-6 col-md-4">.col-6 .col-md-4</div>
        </div>

        <!-- Columns are always 50% wide, on mobile and desktop -->
        <div class="row">
            <div class="col-6">.col-6</div>
            <div class="col-6">.col-6</div>
        </div>
    </div>

    <div class="container">
        <div class="row align-items-start">
            <div class="col">
                One of three columns
            </div>
            <div class="col">
                One of three columns
            </div>
            <div class="col">
                One of three columns
            </div>
        </div>
        <div class="row align-items-center">
            <div class="col">
                One of three columns
            </div>
            <div class="col">
                One of three columns
            </div>
            <div class="col">
                One of three columns
            </div>
        </div>
        <div class="row align-items-end">
            <div class="col">
                One of three columns
            </div>
            <div class="col">
                One of three columns
            </div>
            <div class="col">
                One of three columns
            </div>
        </div>
    </div>

    <div class="container">
        <div class="row">
            <div class="col align-self-start">
                One of three columns
            </div>
            <div class="col align-self-center">
                One of three columns
            </div>
            <div class="col align-self-end">
                One of three columns
            </div>
        </div>
    </div>

    <div class="container">
        <div class="row justify-content-start">
            <div class="col-4">
                One of two columns
            </div>
            <div class="col-4">
                One of two columns
            </div>
        </div>
        <div class="row justify-content-center">
            <div class="col-4">
                One of two columns
            </div>
            <div class="col-4">
                One of two columns
            </div>
        </div>
        <div class="row justify-content-end">
            <div class="col-4">
                One of two columns
            </div>
            <div class="col-4">
                One of two columns
            </div>
        </div>
        <div class="row justify-content-around">
            <div class="col-4">
                One of two columns
            </div>
            <div class="col-4">
                One of two columns
            </div>
        </div>
        <div class="row justify-content-between">
            <div class="col-4">
                One of two columns
            </div>
            <div class="col-4">
                One of two columns
            </div>
        </div>
    </div>

    <div class="container">
        <div class="row no-gutters">
            <div class="col-12 col-sm-6 col-md-8">.col-12 .col-sm-6 .col-md-8</div>
            <div class="col-6 col-md-4">.col-6 .col-md-4</div>
        </div>

        <div class="row">
            <div class="col-9">.col-9</div>
            <div class="col-4">.col-4<br>Since 9 + 4 = 13 &gt; 12, this 4-column-wide div gets wrapped onto a new line as one contiguous unit.</div>
            <div class="col-6">.col-6<br>Subsequent columns continue along the new line.</div>
        </div>

        <div class="row">
            <div class="col-6 col-sm-3">.col-6 .col-sm-3</div>
            <div class="col-6 col-sm-3">.col-6 .col-sm-3</div>

            <!-- Force next columns to break to new line -->
            <div class="w-100"></div>

            <div class="col-6 col-sm-3">.col-6 .col-sm-3</div>
            <div class="col-6 col-sm-3">.col-6 .col-sm-3</div>
        </div>

        <div class="row">
            <div class="col-6 col-sm-4">.col-6 .col-sm-4</div>
            <div class="col-6 col-sm-4">.col-6 .col-sm-4</div>

            <!-- Force next columns to break to new line at md breakpoint and up -->
            <div class="w-100 d-none d-md-block"></div>

            <div class="col-6 col-sm-4">.col-6 .col-sm-4</div>
            <div class="col-6 col-sm-4">.col-6 .col-sm-4</div>
        </div>
    </div>

    <div class="container">
        <div class="row">
            <div class="col">
                First, but unordered
            </div>
            <div class="col order-12">
                Second, but last
            </div>
            <div class="col order-1">
                Third, but first
            </div>
        </div>
    </div>

    <div class="container">
        <div class="row">
            <div class="col">
                First, but unordered
            </div>
            <div class="col">
                Second, but unordered
            </div>
            <div class="col order-first">
                Third, but first
            </div>
        </div>
    </div>

    <div class="container">
        <div class="row">
            <div class="col-md-4">.col-md-4</div>
            <div class="col-md-4 offset-md-4">.col-md-4 .offset-md-4</div>
        </div>
        <div class="row">
            <div class="col-md-3 offset-md-3">.col-md-3 .offset-md-3</div>
            <div class="col-md-3 offset-md-3">.col-md-3 .offset-md-3</div>
        </div>
        <div class="row">
            <div class="col-md-6 offset-md-3">.col-md-6 .offset-md-3</div>
        </div>

        <div class="row">
            <div class="col-sm-5 col-md-6">.col-sm-5 .col-md-6</div>
            <div class="col-sm-5 offset-sm-2 col-md-6 offset-md-0">.col-sm-5 .offset-sm-2 .col-md-6 .offset-md-0</div>
        </div>

        <div class="row">
            <div class="col-sm-6 col-md-5 col-lg-6">.col.col-sm-6.col-md-5.col-lg-6</div>
            <div class="col-sm-6 col-md-5 offset-md-2 col-lg-6 offset-lg-0">.col-sm-6 .col-md-5 .offset-md-2 .col-lg-6 .offset-lg-0</div>
        </div>

        <div class="row">
            <div class="col-md-4">.col-md-4</div>
            <div class="col-md-4 ml-auto">.col-md-4 .ml-auto</div>
        </div>
        <div class="row">
            <div class="col-md-3 ml-md-auto">.col-md-3 .ml-md-auto</div>
            <div class="col-md-3 ml-md-auto">.col-md-3 .ml-md-auto</div>
        </div>
        <div class="row">
            <div class="col-auto mr-auto">.col-auto .mr-auto</div>
            <div class="col-auto">.col-auto</div>
        </div>

        <div class="row">
            <div class="col-sm-9">
                Level 1: .col-sm-9
                <div class="row">
                    <div class="col-8 col-sm-6">
                        Level 2: .col-8 .col-sm-6
                    </div>
                    <div class="col-4 col-sm-6">
                        Level 2: .col-4 .col-sm-6
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="container">
        <div class="example-container">
            <div class="example-row">
                <div class="example-content-main">Main content</div>
                <div class="example-content-secondary">Secondary content</div>
            </div>
        </div>
    </div>

    <!--about us-->
    <section class="aboutus" id="aboutus">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="heading text-center">
                        <img class="dividerline" src="img/sep.png" alt="">
                        <h2>About Boostrap 4 Beta</h2>

                        <img class="dividerline" src="img/sep.png" alt="">
                        <h3><mark>Bootstrap</mark> is the world’s most popular framework for building responsive, mobile-first sites and applications. Inside you’ll find high quality HTML, CSS, and JavaScript to make starting any project easier than ever. On <mark>August 19</mark>, Bootstrap 4 alpha was released with the removal of support for IE8. Of course, there are still going to be a couple of alphas before they move to the beta phase, but this gives us a glimpse on what to expect on the next versions.</h3>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-3">
                    <div class="card">
                        <img class="card-img-top" src="img/card1.jpg" alt="Card image cap">
                        <div class="card-block">
                            <h4 class="card-title">This is Card #1</h4>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href="http://v4-alpha.getbootstrap.com/components/card/" class="btn btn-primary">Learn More</a>
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="card card-inverse card-primary text-center">
                        <img class="card-img-top" src="img/card2.jpg" alt="Card image cap">
                        <div class="card-block">
                            <h4 class="card-title">This is Card #2</h4>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href="http://v4-alpha.getbootstrap.com/components/card/" class="btn btn-primary">Learn More</a>
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="card card-inverse card-success text-center">
                        <img class="card-img-top" src="img/card3.jpg" alt="Card image cap">
                        <div class="card-block">
                            <h4 class="card-title">This is Card #3</h4>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href="http://v4-alpha.getbootstrap.com/components/card/" class="btn btn-primary">Learn More</a>
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="card card-inverse card-info text-center">
                        <img class="card-img-top" src="img/card4.jpg" alt="Card image cap">
                        <div class="card-block">
                            <h4 class="card-title">This is Card #4</h4>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href="http://v4-alpha.getbootstrap.com/components/card/" class="btn btn-primary">Learn More</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>


    <section class="features" id="features">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="heading text-center">
                        <img class="dividerline" src="img/sep.png" alt="">
                        <h2>Enhanced Features</h2>
                        <img class="dividerline" src="img/sep.png" alt="">
                        <h3><a href="#" data-toggle="tooltip" title="This is a tooltip">Bootstrap 4 alpha</a> has a new prefix <a href="#" data-toggle="tooltip" title="Make all backgrounds black!">–inverse</a> class that gives a background to the table itself. Another cool thing about this is the improve tooltips and popovers which help a lot of developers when it comes to ease of use. Thanks to <a href="#" data-toggle="tooltip" title="Tether is a JavaScript library for efficiently making an absolutely positioned element stay next to another element on the page. For example, you might want a tooltip or dialog to open, and remain, next to the relevant item on the page.">Tether</a> , a third party library it has improved. </h3>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <table class="table table-inverse">
                        <thead>
                            <tr><th colspan="3" class="text-center">Bootstrap 3</th> </tr>
                            <tr>
                                <th>Size</th>
                                <th>Device</th>
                                <th>Class</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>Extra Small</td>
                                <td>Less than 768px</td>
                                <td>col-xs</td>
                            </tr>
                            <tr>
                                <td>Small</td>
                                <td>768px and up</td>
                                <td>col-sm</td>
                            </tr>
                            <tr>
                                <td>Medium</td>
                                <td>992px and up</td>
                                <td>col-md</td>
                            </tr>
                            <tr>
                                <td>Large</td>
                                <td>1200px and up</td>
                                <td>col-lg</td>
                            </tr>
                        </tbody>
                    </table>
                </div>

                <div class="col-md-6">
                    <table class="table table-inverse">
                        <thead>
                            <tr><th colspan="3" class="text-center">Bootstrap 4</th> </tr>
                            <tr>
                                <th>Size</th>
                                <th>Device</th>
                                <th>Class</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>Extra Small</td>
                                <td>Less than 34em</td>
                                <td>col-xs</td>
                            </tr>
                            <tr>
                                <td>Small</td>
                                <td>34em and up</td>
                                <td>col-sm</td>
                            </tr>
                            <tr>
                                <td>Medium</td>
                                <td>48em and up</td>
                                <td>col-md</td>
                            </tr>
                            <tr>
                                <td>Large</td>
                                <td>62em and up</td>
                                <td>col-lg</td>
                            </tr>
                            <tr>
                                <td>Extra Large</td>
                                <td>75em and up</td>
                                <td>col-xl</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </section>


    <!--Contact Us-->
    <section class="contact" id="contact">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="heading">
                        <img class="dividerline" src="img/sep.png" alt="">
                        <h2>Contact Us</h2>
                        <img class="dividerline" src="img/sep.png" alt="">
                        <h3>
                            Feel free to reach out for any questions!
                        </h3>
                    </div>
                </div>
            </div>
        </div>
        <div class="container mx-width">
            <div class="row">
                <div class="done">
                    <div class="alert alert-success">
                        <button type="button" class="close" data-dismiss="alert">×</button>
                        Your message has been sent. Thank you!
                    </div>
                </div>
                <div class="col-md-12">
                    <form>
                        <fieldset class="form-group">
                            <input type="text" class="form-control" id="Name" placeholder="Name">
                        </fieldset>
                        <fieldset class="form-group">
                            <input type="email" class="form-control" id="Email" placeholder="Email">
                        </fieldset>
                        <fieldset class="form-group">
                            <textarea class="form-control" rows="3" placeholder="Message"></textarea>
                        </fieldset>
                        <button type="submit" class="contact submit">Submit</button>
                    </form>
                </div>
            </div>
        </div>
    </section>

    <!--footer-->
    <section class="footer" id="footer">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <ul>
                        <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                        <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                        <li><a href="#"><i class="fa fa-linkedin"></i></a></li>
                        <li><a href="#"><i class="fa fa-pinterest"></i></a></li>
                    </ul>
                    <p>
                        &copy; 2015 - Designmodo.com<br>
                    </p>
                </div>
            </div>
        </div>
    </section>

</div><!--wrapper end-->