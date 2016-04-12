// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkID=397704
// To debug code on page load in Ripple or on Android devices/emulators: launch your app, set breakpoints, 
// and then run "window.location.reload()" in the JavaScript Console.
//(function () {
//    "use strict";

//    document.addEventListener( 'deviceready', onDeviceReady.bind( this ), false );

//    function onDeviceReady() {
//        // Handle the Cordova pause and resume events
//        document.addEventListener( 'pause', onPause.bind( this ), false );
//        document.addEventListener( 'resume', onResume.bind( this ), false );
//        document.getElementById("myBtn").onclick = function () {
//            var media = new Media("ms-appx:///www/Assets/Let_It_Go.mp3",
//               function (args) {
//                args;
//            }, function (error) {
//                error;
//            });
//            media.play();
//            setTimeout(function () {
//                media.stop();
//            }, 10000);
//        }
//        // TODO: Cordova has been loaded. Perform any initialization that requires Cordova here.
//    };

//    function onPause() {
//        // TODO: This application has been suspended. Save application state here.
//    };

//    function onResume() {
//        // TODO: This application has been reactivated. Restore application state here.
//    };
//})();




var app = {
    // Application Constructor
    initialize: function () {
        this.bindEvents();
    },
    // Bind Event Listeners
    //
    // Bind any events that are required on startup. Common events are:
    // 'load', 'deviceready', 'offline', and 'online'.
    bindEvents: function () {
        document.addEventListener('deviceready', this.onDeviceReady, false);
    },
    // deviceready Event Handler
    //
    // The scope of 'this' is the event. In order to call the 'receivedEvent'
    // function, we must explicitly call 'app.receivedEvent(...);'
    onDeviceReady: function () {
        app.receivedEvent('deviceready');
        var src = "ms-appx:///www/Assets/Let_It_Go.mp3";

        function playAudio(url) {
            // Play the audio file at url
            var my_media = new Media(url,
            // success callback
            function () {
                alert("playAudio():Audio Success");
            },
            // error callback
            function (err) {
                alert("playAudio():Audio Error: " + err);
            }
        );
            // Play audio
            my_media.play();
        }

        playAudio(src);

    },


    // Update DOM on a Received Event
    receivedEvent: function (id) {
        var parentElement = document.getElementById(id);
        var listeningElement = parentElement.querySelector('.listening');
        var receivedElement = parentElement.querySelector('.received');

        listeningElement.setAttribute('style', 'display:none;');
        receivedElement.setAttribute('style', 'display:block;');

        console.log('Received Event: ' + id);
    }
};

app.initialize();