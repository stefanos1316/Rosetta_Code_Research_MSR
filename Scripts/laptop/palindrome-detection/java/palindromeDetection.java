
public class palindromeDetection {

	private static volatile int r = 1;

	public static int executeTask(int i) {

		pali("saippuakivikauppias");
		return i + 1;
	}

	public static void main(String[] args) {
		for (int i = 0; i < 2000000000; ++i) {
			r = executeTask(i + r);
		}
	}

	public static boolean pali(String testMe) {
		StringBuilder sb = new StringBuilder(testMe);
		return testMe.equals(sb.reverse().toString());
	}

}

