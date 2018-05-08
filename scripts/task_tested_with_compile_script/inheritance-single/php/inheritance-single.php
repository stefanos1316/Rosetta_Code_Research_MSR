<?php

class Animal {
   // functions go here...
   function speak() {
    echo "Animal speaking \n";
    }

    function walk() {
        echo "Animal walking \n";
    }
}

class Dog extends Animal {
   // functions go here...
    function speak() {
        echo "Dog barking \n";
    }
}

class Cat extends Animal {
   // functions go here...
    function speak() {
        echo "Cat meawing \n";
    }
}

class Lab extends Dog {
   // functions go here...
    function speak() {
        echo "Lab barking \n";
    }
}

class Collie extends Dog {
   // functions go here...
    function speak() {
        echo "Collie barking \n";
    }
}

for ( $i = 0; $i < 1000000; $i++) {
	$myObj = new Dog();
    $myObj->speak();
    $myObj->walk();
}

?>