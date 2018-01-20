var r = 1;
function executeTask(i) {

var data = JSON.parse('{ "foo": 1, "bar": [10, "apples"] }');

var sample = { "blue": [1,2], "ocean": "water" };
var json_string = JSON.stringify(sample);
return i + 1;
}

for ( var i = 0; i < 10000000; ++i) {
	r = executeTask(i + r);
}
