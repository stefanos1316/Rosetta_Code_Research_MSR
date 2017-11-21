<?php
function compose($f, $g) {
  return function($x) use ($f, $g) { return $f($g($x)); };
}

for ($i = 0 ; $i < 100000000; $i += 1) {
  $trim_strlen = compose('strlen', 'trim');
  $result = $trim_strlen(' Test ');
}

?>
