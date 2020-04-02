"use strict";
exports.__esModule = true;
var event_1 = require("./event");
var main = document.querySelector("main");
var eh = new event_1.EventHandler();
main.addEventListener("click", eh.Click);
