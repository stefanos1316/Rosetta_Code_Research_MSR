var c;
var r = 1;

function executeTask (i)
{
	var a = [1,2,3,4,5],
    	b = [6,7,8,9,10];
    	c = a.concat(b); //=> [1,2,3,4,5,6]
	return i  + 1;
}

for ( var i = 0; i < 2000000000; i++) {
	r = executeTask(i + r);
}
