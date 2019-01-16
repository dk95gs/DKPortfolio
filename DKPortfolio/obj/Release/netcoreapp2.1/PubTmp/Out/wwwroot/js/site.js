// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.getElementById("allprojs").addEventListener("click", function () {
    document.getElementById("webdevcheck").checked = false;
    document.getElementById("appdevcheck").checked = false;
    document.getElementById("othercheck").checked = false;
});
document.getElementById("webdev").addEventListener("click", function () {
    document.getElementById("webdevcheck").checked = true;
    document.getElementById("appdevcheck").checked = false;
    document.getElementById("othercheck").checked = false;
});
document.getElementById("appdev").addEventListener("click", function () {
    document.getElementById("webdevcheck").checked = false;
    document.getElementById("appdevcheck").checked = true;
    document.getElementById("othercheck").checked = false;
});
document.getElementById("other").addEventListener("click", function () {
    document.getElementById("webdevcheck").checked = false;
    document.getElementById("appdevcheck").checked = false;
    document.getElementById("othercheck").checked = true;
});