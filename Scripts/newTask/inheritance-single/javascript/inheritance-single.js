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
Dog.prototype.speak = function() {console.log("Dog barking")};
Lab.prototype.speak = function() {console.log("Lab barking")};
Collie.prototype.speak = function() {console.log("Collie barking")};
Cat.prototype.speak = function() {console.log("Cat Meawing")};

var lab = new Dog();
lab.speak();  // shows "an animal makes a sound"
//lab.walk();