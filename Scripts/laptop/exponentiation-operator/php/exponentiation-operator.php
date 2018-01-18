<?php

$r = 1;

function executeTask($i) {

	pow(2017, 12);
	pow(19.88, 12);
	return $i + 1;
}

for ( $i = 0; $i < 1000000000; $i++) {
	$r = executeTask($i + $r);
}

?>
