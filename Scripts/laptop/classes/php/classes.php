<?php

class MyClass {
    public static $classVar;
    public $instanceVar; // can also initialize it here
    function __construct($value) {
        $this->instanceVar = $value;
    }
    function someMethod($i) {
        self::$classVar = 3 + $i;
    }
}

$r = 1;

function executeTask($i) {

	$myObj = new MyClass(1974);
	$myObj->someMethod($i);
	return $i;
}

for ( $i = 0; $i < 2100000000; $i++) {
	$r = executeTask($i + $r);
}
?>
