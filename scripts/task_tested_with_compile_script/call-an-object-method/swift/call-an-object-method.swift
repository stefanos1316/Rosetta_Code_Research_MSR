class CallAnObjectMethod{

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
  func someMethod(a: Int, i: Int) {
    self.variable = a + i
  }
}

let value = CallAnObjectMethod()
for i in 0...2000000000 {
	value.someMethod(a: 1, i: i)
}
