// Static
//MyClass.Method(someParameter);
 
// Instance
//myInstance.Method(someParameter);

using System;

class MyClass{

  // instance variable
  volatile int variable;	// Note: instance variables are usually "private"

  /**
  * The constructor
  */
  public MyClass(){
    // creates a new instance
  }

  /**
  * A method
  */
  public void someMethod(int value){
   this.variable = value;
 }

	private static volatile int r = 1;

	public static int executeTask(int i) {

		MyClass obj = new MyClass();
		obj.someMethod(1);
		return 1 + i;
	}

public static void Main(String[] args){

	for (int i = 0; i < 2000000000; ++i) {
		r = executeTask(i + r);
	}
}

}
