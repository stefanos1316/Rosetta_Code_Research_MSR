var words = ["Enjoy", "Rosetta", "Code"]
var workers = [];
var Worker = require('webworker-threads').Worker;

 
for (var j = 0; j < 10; j++) {

    //for (var i = 0; i < words.length; i++) {
    workers = new Worker();
    workers.onmessage = printMessage;
    workers.terminate();
    // workers[i].addEventListener('message', function (event) {
   //     console.log(event.data);
  // }, false);
   // sleep(1);
    //workers[i].postMessage(words[i]);
   // workers[i].terminate();
 // }
}

function printMessage(e) {
  var words = ["Enjoy", "Rosetta", "Code"]
  for (var i = 0; i < words.length; i++) {
    console.log(words[i]);
  }
}
