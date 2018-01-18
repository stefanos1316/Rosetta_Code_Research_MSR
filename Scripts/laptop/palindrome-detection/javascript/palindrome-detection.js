function isPalindrome(str) {
  return str === str.split("").reverse().join("");
}

var r = 1;

function executeTask(i) {
	var a = isPalindrome("saippuakivikauppias");
	return i + 1;
}

for ( var i = 0; i < 2000000000; ++i) {
	r = executeTask(i + r);
}
