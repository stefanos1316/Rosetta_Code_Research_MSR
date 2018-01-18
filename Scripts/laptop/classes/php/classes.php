<?php

class MyClass {
    public static $classVar;
    public $instanceVar; // can also initialize it here
    function __construct($value) {
        $this->instanceVar = $value;
    }
    function someMethod() {
        self::$classVar = 3;

    }
}

$r = 1;

function executeTask($i) {
	
	$myObj = new MyClass(1974);
	$myObj->someMethod();
	return $i + 1;
}

for ( $i = 0; $i < 2100000000; $i++) {
	$r = executeTask($i + $r);
}
?>
