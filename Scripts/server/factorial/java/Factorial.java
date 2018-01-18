public class Factorial {

private static volatile int r = 1;

public static int executeTask(int i) {
	fact(10);
	return i  + 1;
}

public static void main(String[] args) {
	
	for (int i = 0; i < 2000000000; ++i)
		r = executeTask(i + r);
}

public static long fact(final int n) {
    if (n < 0){
        System.err.println("No negative numbers");
        return 0;
    }
    return (n < 2) ? 1 : n * fact(n - 1);
}

}
