class Animal {
  // ...
  func speak() {
    print("Animal speaking\n")
  }

  func walk() {
    print("Animal walking\n")
  }
}

class Dog : Animal {
  // ...
  override func speak() {
    print("Dog barking\n")
  }
}

class Lab : Dog {
  // ...
  override func speak() {
    print("Lab barking\n")
  }
}

class Collie : Dog {
  // ...
  override func speak() {
    print("Collie barking\n")
  }
}

class Cat : Animal {
  // ...
  override func speak() {
    print("Cat meawing\n")
  }
}


for i in 0...1000000 {
  let obj = Dog()
  obj.speak()
  obj.walk()
}