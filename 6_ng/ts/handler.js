"use strict";
exports.__esModule = true;
function success(res) {
    var textarea = document.querySelector("#response");
    res.json().then(function (data) {
        var obj = {
            detail: null,
            name: null,
            mass: null
        };
        for (var key in obj) {
            obj[key] = data[key];
        }
        textarea.value = obj;
        console.log(obj);
    }, function (error) {
        textarea.value = "ERROR";
    });
}
exports.success = success;
function failure(res) {
    var textarea = document.querySelector("#response");
    textarea.value = "ERROR";
}
exports.failure = failure;
