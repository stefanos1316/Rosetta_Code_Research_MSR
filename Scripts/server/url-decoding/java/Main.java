import java.io.UnsupportedEncodingException;
import java.net.URLDecoder;

public class Main
{

    private static volatile int r = 1;

    public static int executeTask(int i) throws UnsupportedEncodingException {

       	String encoded = "http%3A%2F%2Ffoo%20bar%2F";
    	String normal = URLDecoder.decode(encoded, "utf-8");
	return i + 1;
    }

    public static void main(String[] args) throws UnsupportedEncodingException
    {
	for ( int i = 0; i < 10000000; ++i) {
		r = executeTask(i + r);
	}
    }
}
