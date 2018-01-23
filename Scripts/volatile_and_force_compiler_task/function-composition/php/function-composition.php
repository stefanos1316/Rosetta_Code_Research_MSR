<?php
function compose($f, $g) {
  return function($x) use ($f, $g) { return $f($g($x)); };
}

$r = 1;

function executeTask($i) {

	$sin_asin = compose('sin', 'asin');
	return $sin_asin($i);
	
}

for ($i = 0 ; $i < 1000000000; $i += 1) {
	$r = executeTask($i);
}

?>
