import java.util.function.Function;

public class FunctionCompose {
    	
	private static volatile int r = 0;

	public static int executeTask(int i) {

        	Function<Double,Double> sin_asin = ((Function<Double,Double>)Math::sin).compose(Math::asin);
	        sin_asin.apply((double)i);
		return i + 1;
	}

	public static void main(String[] args) {
	   	for (int i = 0; i < 1000000000; ++i) {
        		r = executeTask(i + r);
		}
    	}
}
