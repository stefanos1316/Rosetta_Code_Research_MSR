<?php
function is_palindrome($string) {
  return $string == strrev($string);
}

$r = 1;

function executeTask($i) {
	$result = is_palindrome("saippuakivikauppias" . $i);
	return $i;
}

for ( $i = 0; $i < 2000000000; ++$i ) {
	$r = executeTask($i);
}
?>
