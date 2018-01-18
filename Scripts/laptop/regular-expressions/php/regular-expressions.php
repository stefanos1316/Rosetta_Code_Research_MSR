

<?php

$r = 1;

function executeTask($i) {

$string = 'this is a matching string';

if (preg_match('/string$/', $string))
{}
$string = preg_replace('/\bstring\b/', 'istyfied', $string);
	return $i + 1;
}

for ( $i = 0; $i < 10000000; $i++) {
	$r = executeTask($i + $r);
}
?>
