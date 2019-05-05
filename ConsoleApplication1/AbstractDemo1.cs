<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
        <script language="javascript" type="text/javascript">
            var xmlHttp;
            function Create() {
                if (window.XMLHttpRequest) {
                    xmlHttp = new XMLHttpRequest();
                }
                else if (window.ActiveXObject) {
                    xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
                }
                else {
                    alert('Ajax is not supproted');
                }
            }
            function checkusername() {
                var uname = document.getElementById("utext");
                var url = "AjaxJavascript.aspx?uname=" + uname.value;
                // Making a acsynchronous request
                xmlHttp.open("GET", url, true);
                // Create a function that 