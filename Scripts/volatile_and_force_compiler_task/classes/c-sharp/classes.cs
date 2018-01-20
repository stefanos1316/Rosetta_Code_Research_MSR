using System;

class MyClass{

  // instance variable
  private volatile int variable;  // Note: instance variables are usually "private"

  /**
  * The constructor
  */
  public MyClass(){
    // creates a new instance
  }

  /**
  * A method
  */
  public void someMethod(int i){
   this.variable = 1 + i;
  }

  private static volatile int r = 1;

  public static int executeTask(int i) {

	MyClass obj = new MyClass();
	obj.someMethod(i);

	return i;
  }

public static void Main(String[] args){

	for (int i = 0; i < 2100000000; ++i) {
		r = executeTask(i + r);
	}
}

}

