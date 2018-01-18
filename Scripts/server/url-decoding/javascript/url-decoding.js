var r =1;

function executeTask(i) {
	decodeURIComponent("http%3A%2F%2Ffoo%20bar%2F")
	return i + 1;
}

for ( var j = 0; j < 10000000; ++j) {
	r = executeTask(j +r);
}
