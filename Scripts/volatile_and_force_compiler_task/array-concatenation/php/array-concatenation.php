#!/usr/bin/php
<?php


$r = 1;

function executeTask($i) {

	$arr1 = array(1+$i, 2-$i, 3+$i, 4-$i, 5+$i);
	$arr2 = array(6+$i, 7-$i, 8+$i, 9-$i, 10+$i);
	$arr3 = array_merge($arr1, $arr2);
	return $i;
}

for ( $i = 0; $i < 2000000000; $i++) {
	$r = executeTask($i);
}

?>
