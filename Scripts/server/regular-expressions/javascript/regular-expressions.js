var r = 1;

function executeTask(i) {
    	var str = "this is a matching string" + i; 
     	if( str.match(/string/g)) {}
     	if(str.replace("string", "istyfied")) {}
	return i;
}

for (var i = 0; i < 10000000; ++i) {
	r = executeTask(i);
}
