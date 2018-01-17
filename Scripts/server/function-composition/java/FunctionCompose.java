import java.util.function.Function;

public class FunctionCompose {
    	
	private static volatile double r = 0.0;

	public static void main(String[] args) {
	   for (int i = 0; i < 1000000000; ++i) {
        	Function<Double,Double> sin_asin = ((Function<Double,Double>)Math::sin).compose(Math::asin);
	        r = sin_asin.apply((double)i);
        }
    }
}
