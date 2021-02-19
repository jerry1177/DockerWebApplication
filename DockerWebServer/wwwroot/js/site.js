// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
$(document).ready(function () {
    // don't put vanilla javascript here. make sure it is the jquery way or function might not reach button/form element
    
});
// Write your JavaScript code.
function bClicked(e) {
    e.preventDefault();
    console.log("hi")
    //*
    var user = { TestName: "jerry", TestStreet: "maldonado" }
    $.ajax({
        type: "POST",
        url: "https://localhost:3000/Test/Test", //http and https is very important!
        // The key needs to match your method's input parameter (case-sensitive).
        data: JSON.stringify(user),
        contentType: "application/json", // data type to send
        dataType: "json", // data type to expect back
        success: function (data) { alert(JSON.stringify(data)); },
        error: function (errMsg) {
            alert(JSON.stringify(errMsg));
        }
    });
}