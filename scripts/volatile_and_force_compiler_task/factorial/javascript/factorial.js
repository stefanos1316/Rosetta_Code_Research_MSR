var num = 10;

var factorial = function(n) {
    if(n == 0) {
        return 1
    } else {
        return n * factorial(n - 1);
    }
}

var r = 1;

function executeTask(i) {

	return factorial(i);
	
}

for (var i = 0; i < 100000; ++i) { 
	r = executeTask(i);
}
