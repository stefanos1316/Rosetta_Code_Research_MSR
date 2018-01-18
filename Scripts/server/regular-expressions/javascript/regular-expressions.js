var r = 1;

function executeTask(i) {
    	var str = "this is a matching string"; 
     	if( str.match(/string/g)) {}
     	if(str.replace("string", "istyfied")) {}
	return i + 1;
}

for (var i = 0; i < 10000000; ++i) {
	r = executeTask(i + r);
}
