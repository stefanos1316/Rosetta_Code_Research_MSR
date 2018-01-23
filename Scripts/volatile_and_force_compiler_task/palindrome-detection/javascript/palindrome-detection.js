function isPalindrome(str) {
  return str === str.split("").reverse().join("");
}

var r = 1;

function executeTask(i) {
	var a = isPalindrome("saippuakivikauppias"+i);
	return i;
}

for ( var i = 0; i < 2000000000; ++i) {
	r = executeTask(i);
}
