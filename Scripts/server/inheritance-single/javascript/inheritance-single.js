function Animal() {
    // ...
}

function Dog() {
    // ...
}

function Lab() {
    // ...
}

function Collie() {
    // ...
}

function Cat() {
    // ...
}

Animal.prototype.speak = function() {console.log("Animal speaking")};
Animal.prototype.walk = function() {console.log("Animal walking")};
Lab.prototype.speak = function() {console.log("Lab barking")};
Collie.prototype.speak = function() {console.log("Collie barking")};
Cat.prototype.speak = function() {console.log("Cat Meawing")};

for ( var i = 0; i < 1000000; i++) {
	Dog.prototype = new Animal();
	Dog.prototype.speak = function() {console.log("Dog barking")}
	var doggy = new Dog();
	doggy.speak();
	doggy.walk();
}
