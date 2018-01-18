class MyClass{
	constructor(variable) {
		this.variable = variable;
	}

	someMethod() {
		this.variable++;
	}
}

function executeTask(i) {
	const obj = new MyClass(123456);
	obj.someMethod();
	return 1 + i;
}

var r = 1;

for (var i = 0; i < 2000000000; ++i) {
	r = executeTask(i + r);
}
