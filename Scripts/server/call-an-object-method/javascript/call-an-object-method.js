class CallAnObjectMethod {
	constructor() {
	}

	someMethod(a) {
		var value = a;
	}
}

var r = 1;
const obj = new CallAnObjectMethod();

function executeTask(i) {

	obj.someMethod(1);
	return i + 1;
}

for (var i = 0; i < 2000000000; ++i) {
	r = executeTask(i + r);
}
