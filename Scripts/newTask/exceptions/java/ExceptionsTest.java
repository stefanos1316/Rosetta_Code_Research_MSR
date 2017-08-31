import java.io.FileNotFoundException;
import java.io.IOException;
import java.lang.NumberFormatException;
import javax.activation.UnsupportedDataTypeException;

// XXX: class added by mkechagia
public class ExceptionsTest {
	
	public static void fooChecked() throws MyException {
	   throw new MyException();
	}

	public static void fooUnchecked() {
	   throw new MyRuntimeException();
	}

	public static void foo() throws UnsupportedDataTypeException, IOException {

	    try{
	    	
	        throwsNumberFormatException();
	        //the following methods throw exceptions which extend IOException
	        throwsUnsupportedDataTypeException();
	        throwsFileNotFoundException();
	    }catch(FileNotFoundException | NumberFormatException ex){
	        //deal with these two Exceptions without duplicating code
	    }catch(IOException e){
	        //deal with the UnsupportedDataTypeException as well as any other unchecked IOExceptions
	        throw e;
	    }
	}

	public static void throwsNumberFormatException() {
		int a = 1;
		int b = 2;

		if (a > b)
			throw new NumberFormatException();

	}

	public static void throwsUnsupportedDataTypeException() throws UnsupportedDataTypeException {
		int a = 1;

		if (a != 0)
			throw new UnsupportedDataTypeException();

	}

	public static void throwsFileNotFoundException() throws IOException {
		int a = 1;

		if (a == 1)
			throw new FileNotFoundException();

	}

	// XXX: method added by mkechagia
	public static void main(String[] args) throws UnsupportedDataTypeException, IOException {
		for (int i = 0; i < 10000000; ++i) { 

			try {
			   fooChecked();
			}
			catch(MyException exc) {
			   //Catch only your specified type of exception
			}
			catch(Exception exc) {
			   //Catch any non-system error exception
			}
			catch(Throwable exc) {
			   //Catch everything including system errors (not recommended)
			}
			finally {
			   //This code is always executed after exiting the try block
			}

        	fooUnchecked();

        	foo();
        }
	}

}

// Checked exception
class MyException extends Exception {
   //Put specific info in here
}

// Unchecked exception
class MyRuntimeException extends RuntimeException {}