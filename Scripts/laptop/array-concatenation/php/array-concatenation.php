#!/usr/bin/php
<?php


$r = 1;

function executeTask($i) {

	$arr1 = array(1, 2, 3, 4, 5);
	$arr2 = array(6, 7, 8, 9, 10);
	$arr3 = array_merge($arr1, $arr2);
	return $i + 1;
}

for ( $i = 0; $i < 2000000000; $i++) {
	$r = executeTask($i + $r);
}

?>
