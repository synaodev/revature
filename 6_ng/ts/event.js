"use strict";
exports.__esModule = true;
var handler_1 = require("./handler");
var EventHandler = /** @class */ (function () {
    function EventHandler() {
    }
    EventHandler.prototype.Click = function (event) {
        event.stopPropagation();
        console.log(event.target.id);
        var btn = event.target.id;
        switch (btn) {
            case "btn-people":
                var text = document.querySelector("#people");
                fetch("https://swapi.co/api/people/" + text.value)
                    .then(handler_1.success, handler_1.failure);
                break;
            default:
                break;
        }
    };
    return EventHandler;
}());
exports.EventHandler = EventHandler;
