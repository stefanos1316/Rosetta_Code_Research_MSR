class MyClass{

  // stored property
  var variable : Int

  /**
  * The constructor
  */
  init() {
    self.variable = 42
  }

  /**
  * A method
  */
  func someMethod(i:Int) {
    self.variable = 1 + i 
  }
}

for i in 0...2100000000 {
let value = MyClass()
value.someMethod(i: i)
}
