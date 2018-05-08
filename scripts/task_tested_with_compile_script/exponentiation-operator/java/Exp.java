public class Exp{
  private static volatile int r = 1;

  public static int executeTask(int i) {

	return (int)pow(2017 + i, 12) + (int)pow(19.88 + i, 12);
  }

  public static void main(String[] args){
    for (int i = 0; i < 2000000000; ++i ) {
    	r = executeTask(i);
    }
   }

   public static double pow(double base, int exp){
      if(exp < 0) return 1 / pow(base, -exp);
      double ans = 1.0;
      for(;exp > 0;--exp) ans *= base;
      return ans;
   }
}
