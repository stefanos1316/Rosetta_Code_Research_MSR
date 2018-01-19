

<?php

$r = 1;

function executeTask($i) {

$string = 'this is a matching string' . $i;

if (preg_match('/string$/', $string))
{}
$string = preg_replace('/\bstring\b/', 'istyfied', $string);
	return $i;
}

for ( $i = 0; $i < 10000000; $i++) {
	$r = executeTask($i);
}
?>
