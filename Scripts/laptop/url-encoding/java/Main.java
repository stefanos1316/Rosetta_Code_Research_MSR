import java.io.UnsupportedEncodingException;
import java.net.URLEncoder;


public class Main
{
	private static volatile int r = 1;

	public static int executeTask(int i) throws UnsupportedEncodingException {
        	String normal = "http://foo bar/";
        	String encoded = URLEncoder.encode(normal, "utf-8");
		return i + 1;
	}
    public static void main(String[] args) throws UnsupportedEncodingException
    {
     		for (int i = 0; i < 10000000; ++i) {
 			r = executeTask(i + r);
	    	}
    }
}
