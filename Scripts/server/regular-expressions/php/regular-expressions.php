

<?php

for ( $i = 0; $i < 10000000; $i++) {
$string = 'this is a matching string';

if (preg_match('/string$/', $string))
{}
$string = preg_replace('/\bstring\b/', 'istyfied', $string);
}
?>
