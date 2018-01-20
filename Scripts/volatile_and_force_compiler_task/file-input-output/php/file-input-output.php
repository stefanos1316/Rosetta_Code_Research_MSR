<?php

$r = 1;

function executeTask($i) {

if (!$in = fopen('../test_directory/' . $i, 'r')) {
    die('Could not open input file ../test_directory/$i.');
}

if (!$out = fopen('output.txt', 'w')) {
    die('Could not open output file.');
}

while (!feof($in)) {
    $data = fread($in, 512);
    fwrite($out, $data);
}

fclose($out);
fclose($in);
	return $i;
}

for ( $i = 1; $i <= 10000; $i++) {
	$r = executeTask($i);
}
?>
