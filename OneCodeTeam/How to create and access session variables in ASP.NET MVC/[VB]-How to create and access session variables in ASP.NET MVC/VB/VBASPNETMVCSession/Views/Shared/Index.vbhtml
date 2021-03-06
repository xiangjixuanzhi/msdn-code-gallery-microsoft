﻿<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        @Using (Html.BeginForm("SaveSession", "Home", FormMethod.Post))
            @<p>
                @ViewData("sessionString")
            </p>
            @<fieldset>
                <div>
                    The text will be stored: @Html.TextBox("sessionValue")
                </div>
                <div>
                    <input type="submit" id="submitToMethod1" name="submit" value="submit" />
                </div>
            </fieldset>
        End Using

        @Using (Html.BeginForm("SaveSessionByExtensions", "Home", FormMethod.Post))
            @<p>
                @ViewData("sessionStringByExtensions")
            </p>
            @<fieldset>
                <div>
                    The text will be stored: @Html.TextBox("sessionValue")
                </div>
                <div>
                    <input type="submit" id="submitToMethod2" name="submit" value="submit" />
                </div>
            </fieldset>
        End Using

    </div>
</body>
</html>
