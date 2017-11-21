for ( var i = 0; i < 100000; i++) {
	var fs = require('fs');
	require('util').pump(fs.createReadStream('../input.txt', {flags:'r'}), fs.createWriteStream('../output.txt', {flags:'w+'}));
}
