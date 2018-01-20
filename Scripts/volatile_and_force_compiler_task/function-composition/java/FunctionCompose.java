import java.util.function.Function;

public class FunctionCompose {
    	
	private static volatile double r = 0;

	public static double executeTask(double i) {

        	Function<Double,Double> sin_asin = ((Function<Double,Double>)Math::sin).compose(Math::asin);
	        return sin_asin.apply((double)i);
		
	}

	public static void main(String[] args) {
	   	for (double i = 0; i < 1000000000; ++i) {
        		r = executeTask(i);
		}
    	}
}
