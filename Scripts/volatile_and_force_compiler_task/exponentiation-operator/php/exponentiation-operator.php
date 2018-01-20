<?php

$r = 1;

function executeTask($i) {

	return pow(2017+$i, 12) + pow(19.88+$i, 12);
}

for ( $i = 0; $i < 2000000000; $i++) {
	$r = executeTask($i);
}

?>
