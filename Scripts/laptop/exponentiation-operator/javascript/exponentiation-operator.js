function pow(base, exp) {
    if (exp != Math.floor(exp))
        throw "exponent must be an integer";
    if (exp < 0)
        return 1 / pow(base, -exp);
    var ans = 1;
    while (exp > 0) {
        ans *= base;
        exp--;
    }
    return ans;
}

function executeTask(i) {

	return pow(2017+i,12) + pow(19.88+i,12);
}

var r = 0;

for ( var i = 0; i < 2000000000; ++i) {
	r = executeTask(i);
}
