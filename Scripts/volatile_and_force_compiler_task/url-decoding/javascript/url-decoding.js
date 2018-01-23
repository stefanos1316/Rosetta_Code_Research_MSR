

for ( var j = 0; j < 100000000; ++j) {
	decodeURIComponent("http%3A%2F%2Ffoo%20bar%2F" + j);
}
