#!/usr.bin/php 

<?php


for ( $i = 0; $i < 10000000; $i++) {
	$s = 'http://foo/bar/' . $i;
	$s = rawurlencode($s);
}
?>
