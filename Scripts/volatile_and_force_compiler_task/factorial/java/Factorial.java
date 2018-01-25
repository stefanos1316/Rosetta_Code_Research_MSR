public class Factorial {

private static volatile long r = 1;

public static long executeTask(int i) {
	return fact(i);
}

public static void main(String[] args) {
	
	for (int i = 0; i < 100000; ++i)
		r = executeTask(i);
}

public static long fact(final int n) {
    if (n < 0){
        System.err.println("No negative numbers");
        return 0;
    }
    return (n < 2) ? 1 : n * fact(n - 1);
}

}
