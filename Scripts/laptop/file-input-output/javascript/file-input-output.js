var r = 1;

function executeTask(i) {

	fs = require('fs');
	var contents = fs.readFileSync('../test_directory/' + i, 'utf8');
	fs.writeFileSync('output.txt',contents);
	return i;
}

for ( var i = 1; i < 10000; i++) {
	r = executeTask(i);
}
