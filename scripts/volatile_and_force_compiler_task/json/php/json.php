<?php

$r = 1;

function executeTask($i) {

	$data = json_decode('{ "foo": 1, "bar": [10, "apples"] }'); // dictionaries will be returned as objects
	$sample = array( "blue" => array(1,2), "ocean" => "water" );
	$json_string = json_encode($sample);
	return $i + 1;
}

for ( $i = 0; $i < 10000000; $i++ ) {
	$r = executeTask($i + $r);
}
?>
