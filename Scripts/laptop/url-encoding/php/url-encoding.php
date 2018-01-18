#!/usr.bin/php 

<?php
$r = 1;

function executeTask($i) {

	$s = 'http://foo/bar/';
	$s = rawurlencode($s);
	return $i + 1;
}

for ( $i = 0; $i < 10000000; $i++) {
	$r = executeTask($i + $r);
}
?>
