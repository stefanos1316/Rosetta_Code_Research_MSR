<?php
function compose($f, $g) {
  return function($x) use ($f, $g) { return $f($g($x)); };
}

$results = 0;

for ($i = 0 ; $i < 1000000000; $i += 1) {
	$sin_asin = compose('sin', 'asin');
	$results = $sin_asin(0.5);
}

?>
