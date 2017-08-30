var words = ["Enjoy", "Rosetta", "Code"];
var workers = [];
var Worker = require('webworker-threads').Worker;

 
for (var j = 0; j < 1000000; j++) {
  for (var i = 0; i < words.length; i++) {
    workers[i] = new Worker("concurrent_work.js");
    workers[i].addEventListener('message', function (event) {
      console.log(event.data);
    }, false);
    workers[i].postMessage(words[i]);
    workers[i].terminate();
  }
}
