var c;
var r = 1;

function executeTask (i)
{
	var a = [1+i,2-i,3+i,4-i,5+i],
    	b = [6+i,7-i,8+i,9-i,10+i];
    	c = a.concat(b); //=> [1,2,3,4,5,6]
	return i;
}

for ( var i = 0; i < 2000000000; i++) {
	r = executeTask(i);
}
