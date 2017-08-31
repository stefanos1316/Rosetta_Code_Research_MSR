// Checked exception
class MyException extends Exception {
   //Put specific info in here
}

// Unchecked exception
class MyRuntimeException extends RuntimeException {}

// XXX: class added by mkechagia
public class ExceptionsTest {
	
	public static void fooChecked() throws MyException {
	   throw new MyException();
	}

	public static void fooUnchecked() {
	   throw new MyRuntimeException();
	}

	// XXX: method added by mkechagia
	public static void main(String[] args) throws MyException {
		for (int i = 0; i < 10000000; ++i) { 
        	fooChecked();
        	fooUnchecked();
        }
	}

}