

for ( var i = 0; i < 10000000; i++) { 
	var normal = 'http://foo/bar/' + i;
	var encoded = encodeURIComponent(normal);
}
