// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementById("create_btn").addEventListener("click",Increment)

function Increment() {
    var select = document.getElementById("ordernums");
    var opt = document.createElement('option');
    var i = document.getElementById("num").innerhtml = parseInt(document.getElementById("num").innerhtml) + 1;
    opt.value = i;
    opt.innerHTML = i;
    select.appendChild(opt);
}