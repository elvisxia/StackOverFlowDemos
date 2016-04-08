// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

                var myDiv = document.getElementById("myDiv");
                var yourDiv = document.getElementById("yourDiv");
                window.addEventListener("scroll", function (evt) {
                    yourDiv.innerText = evt.srcElement.body.scrollLeft
                }, true);

                myDiv.onscroll = function (evt) {
                    //yourDiv.innerText=myDiv.scrollLeft;
                }
})();
