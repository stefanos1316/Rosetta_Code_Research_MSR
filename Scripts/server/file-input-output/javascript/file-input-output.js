var r = 1;

function executeTask(i) {

	fs = require('fs');
	var contents = fs.readFileSync('../input.txt', 'utf8');
	fs.writeFileSync('output.txt',contents);
	return i + 1;
}

for ( var i = 0; i < 1000000; i++) {
	r = executeTask(i + r);
}
