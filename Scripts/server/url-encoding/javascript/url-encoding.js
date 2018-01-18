var r = 1;

function executeTask(i) {

	var normal = 'http://foo/bar/';
	var encoded = encodeURIComponent(normal);
	return i + 1;
}

for ( var i = 0; i < 10000000; i++) { 
	r = executeTask(i + r);
}
