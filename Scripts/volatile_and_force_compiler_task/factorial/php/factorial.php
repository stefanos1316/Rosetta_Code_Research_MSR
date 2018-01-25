<?php
function factorial($n) {
  if ($n < 0) {
    return 0;
  }

  if ($n == 0) {
    return 1;
  }

  else {
    return $n * factorial($n-1);
  }
}


$r = 1;

function executeTask($i) {

	return factorial($i);
}

for ( $i = 0; $i < 100000; $i++) {
	$r = executeTask($i + $r);
}

?>
