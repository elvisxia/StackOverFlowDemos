// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        console.log("app.onactivated");
        if (args.detail.kind === activation.ActivationKind.launch) {
            console.log("launch");
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
                // TODO: This application has been newly launched. Initialize your application here. 
                console.log("newly launched");
            }
        } else if(args.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.shareTarget) {
            var shareOperation = args.detail.shareOperation;
            console.log(JSON.stringify(shareOperation.data.properties.description, null, 4));
            document.getElementById("myDiv").innerText = JSON.stringify(shareOperation.data.properties.description, null, 4);
        }
        args.setPromise(WinJS.UI.processAll().then(function () {
            // TODO: Your code here. 
        }));
    }


    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state that needs to persist across suspensions here.
        // You might use the WinJS.Application.sessionState object, which is automatically saved and restored across suspension.
        // If you need to complete an asynchronous operation before your application is suspended, call args.setPromise().
    };

    app.start();
})();
