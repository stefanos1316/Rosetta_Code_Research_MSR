function ack(m, n) {
 return m === 0 ? n + 1 : ack(m - 1, n === 0  ? 1 : ack(m, n - 1));
}

function executeTask(i) {
	
    var aVar = 0;
    if (i%2 == 0)
	aVar = 1;
    else
	aVar = 2;

    for ( var m = 0; m <= 4 - aVar; m++) {
        for ( var n = aVar; n <= 3; n++) {
            ack(m,n);
        }
    }  
	return i;
}

var r = 0;

for ( var i = 0; i < 10000000; i++) {
	r = executeTask(i);
}
