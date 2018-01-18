public class MyClass{

  // instance variable
  private static volatile int r = 1;  // Note: instance variables are usually "private"

  /**
  * The constructor
  */
  public MyClass(){
    // creates a new instance
  }

  /**
  * A method
  */
  public void someMethod(){
   this.r = 1;
//  System.out.println("Variable value is "+this.variable);
  }

public static int executeTask(int i) {

	MyClass obj = new MyClass();
	obj.someMethod();

	return i + 1;
}

public static void main(String[] args){

	for (int i = 0; i < 2000000000; ++i) {
		r = executeTask(i + r);
	}
}

}
