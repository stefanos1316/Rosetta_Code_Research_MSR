import java.util.function.Function;

public class FunctionCompose {
    public static void main(String[] args) {
        for (int i = 0; i < 1000000000; ++i) {
        	Function<Double,Double> sin_asin = ((Function<Double,Double>)Math::sin).compose(Math::asin);
	        sin_asin.apply(0.5);
        }
    }
}
