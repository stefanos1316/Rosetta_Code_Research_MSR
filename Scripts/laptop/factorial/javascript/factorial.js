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

	factorial(num);
	return i + 1;
}
 
for (var i = 0; i < 2000000000; ++i) { 
	r = executeTask(i + r);
}
