<?php

class CallAnObjectMethod {
	public static $classVar;
    	function __construct() {
    	}
   
	function someMethod($a, $i) {
        	self::$classVar = $a + $i;
    	}
}


$r = 1;

function executeTask($i) {
	$myObj = new CallAnObjectMethod();
	$myObj->someMethod(1, $i);
	return $i;
}

for ( $i = 0; $i < 2000000000; $i++) {
	$r = executeTask($i);
}
?>
