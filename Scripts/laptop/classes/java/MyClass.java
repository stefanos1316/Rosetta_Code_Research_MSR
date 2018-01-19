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
  public void someMethod(int i){
   this.r = 1 + i;
//  System.out.println("Variable value is "+this.variable);
  }

public static int executeTask(int i) {

	MyClass obj = new MyClass();
	obj.someMethod(i);

	return i;
}

public static void main(String[] args){

	for (int i = 0; i < 2100000000; ++i) {
		r = executeTask(i + r);
	}
}

}
