function integrateRectagle(func, a, b, n, k) {
	var h = (b-a)/n;
	var sum = 0;
	for (var i = a, j=a; i < b; i+=(b/n), ++j) {
		if (func == "cube") {
			sum += cube(i-h*(1-k));
		}
		
		if (func == "reciprocal") {
			sum += reciprocal(i-h*(1-k));
		}

		if (func == "identity") {
			sum += identity(i-h*(1-k));
		} 
	}
	sum *=  h;
}

function integrateTrapezoid(func, a, b, n) {
	var h = (b-a)/n;
	var sum = 0;
	for (var i = a, j=a; i < b; i+=(b/n), ++j) {
		if (func == "cube") {
			if (i < b-1) {
				sum += cube(i) + cube(i+1); 
			} else {
				sum += cube(i) + cube(i+1-b);
			}
		} 
		if (func == "reciprocal") {
			if (i < b-1) {
				sum += reciprocal(i) + reciprocal(i+1); 
			} else {
				sum += reciprocal(i) + reciprocal(i+1-b);
			}
		} 
		if (func == "identity") {
			if (i < b-1) {
				sum += identity(i) + identity(i+1); 
			} else {
				sum += identity(i) + identity(i+1-b);
			}
		} 
	}
	sum *= h/2;
}

function integrateSimpsons(func, a, b, n) {
	var h = (b-a)/h;
	var sum = 0;
	for (var i = a, j=a; i < b; i+=(b/n), ++j) {
		if (func == "cube") {
			if (i < b -1) {
				sum += cube(i) + (4 * cube(i - (h / 2))) + cube(i + 1);
			} else {
				sum += cube(i) + (4 * cube(i - (h / 2))) + cube(i + 1 - b);
			}
		}

		if (func == "reciprocal") {
			if (i < b -1) {
				sum += reciprocal(i) + (4 * reciprocal(i - (h / 2))) + reciprocal(i + 1);
			} else {
				sum += reciprocal(i) + (4 * reciprocal(i - (h / 2))) + reciprocal(i + 1 - b);
			}
		}
		if (func == "identity") {
			if (i < b -1) {
				sum += identity(i) + (4 * identity(i - (h / 2))) + identity(i + 1);
			} else {
				sum += identity(i) + (4 * identity(i - (h / 2))) + identity(i + 1 - b);
			}
		}
	}
        sum *= h/6;
}

function cube(x) {
	return (x*x*x+aVar);
}

function reciprocal(x) {
	return 1/(x+aVar);
}

function identity(x) {
	return x+aVar;
}

function executeTask(i) {

integrateRectagle("cube",0,1,100,0);
integrateRectagle("cube",0,1,100,0.5);
integrateRectagle("cube",0,1,100,1);
integrateTrapezoid("cube",0,1,100);
integrateSimpsons("cube",0,1,100);

integrateRectagle("reciprocal",1,100,1000,0);
integrateRectagle("reciprocal",1,100,1000,0.5);
integrateRectagle("reciprocal",1,100,1000,1);
integrateTrapezoid("reciprocal",1,100,1000);
integrateSimpsons("reciprocal",1,100,1000);

integrateRectagle("identity",0,5000,5000000,0);
integrateRectagle("identity",0,5000,5000000,0.5);
integrateRectagle("identity",0,5000,5000000,1);
integrateTrapezoid("identity",0,5000,5000000);
integrateSimpsons("identity",0,5000,5000000);

integrateRectagle("identity",0,6000,6000000,0);
integrateRectagle("identity",0,6000,6000000,0.5);
integrateRectagle("identity",0,6000,6000000,1);
integrateTrapezoid("identity",0,6000,6000000);
integrateSimpsons("identity",0,6000,6000000);
	return i;
}

var r = 1;
var aVar = 0;


for ( aVar = 0; aVar < 100; ++aVar) {
	r = executeTask(aVar);
}
