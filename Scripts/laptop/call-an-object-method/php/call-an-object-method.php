<?php

class CallAnObjectMethod {
	public static $classVar;
    	function __construct() {
    	}
   
	function someMethod($a) {
        	self::$classVar = $a;
    	}
}


$r = 1;

function executeTask($i) {
	$myObj = new CallAnObjectMethod();
	$myObj->someMethod(1);
	return $i + 1;
}

for ( $i = 0; $i < 2000000000; $i++) {
	$r = executeTask($i + $r);
}
?>
