import java.util.function.Function;

public class FunctionCompose {
    public static void main(String[] args) {
        Function<Double,Double> sin_asin = ((Function<Double,Double>)Math::sin).compose(Math::asin);
        for (int i = 0; i < 100000000; ++i) {
            sin_asin.apply(0.5);
        }
    }
}
