#!/usr/bin/php
<?php

$r = 1;

function executeTask($i) {

	$encoded = "http%3A%2F%2Ffoo%20bar%2F";
	$unencoded = rawurldecode($encoded);;
	return $i + 1;
}

for ( $i = 0; $i < 10000000; $i++) {
	$r = executeTask($i + $r);
}

?>
