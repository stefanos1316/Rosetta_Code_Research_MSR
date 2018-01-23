class CallAnObjectMethod {
	constructor() {
	}

	someMethod(a, i) {
		var value = a + i;
	}
}

var r = 1;
const obj = new CallAnObjectMethod();

function executeTask(i) {

	obj.someMethod(1, i);
	return i;
}

for (var i = 0; i < 2000000000; ++i) {
	r = executeTask(i);
}
