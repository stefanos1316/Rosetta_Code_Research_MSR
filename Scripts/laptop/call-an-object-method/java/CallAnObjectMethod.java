public class CallAnObjectMethod {

  private static volatile int r = 1; 
  public CallAnObjectMethod(){
  }

  public void someMethod(int value){
   this.r = value;
  }

	public static int executeTask(int i) {

		CallAnObjectMethod obj = new CallAnObjectMethod();
		obj.someMethod(1);
		return i + 1;
	}

public static void main(String[] args){

	for (int i = 0; i < 2000000000; ++i) {
		r = executeTask(i + r);
	}
}

}
