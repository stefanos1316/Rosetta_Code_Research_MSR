class MyClass{
	constructor(variable) {
		this.variable = variable;
	}

	someMethod(i) {
		this.variable = this.variable + i;
	}
}

function executeTask(i) {
	const obj = new MyClass(123456);
	obj.someMethod();
	return 1;
}

var r = 1;

for (var i = 0; i < 2100000000; ++i) {
	r = executeTask(i + r);
}
