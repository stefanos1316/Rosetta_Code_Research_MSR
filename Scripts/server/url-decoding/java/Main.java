import java.io.UnsupportedEncodingException;
import java.net.URLDecoder;

public class Main
{

    private static volatile String r;

    public static int executeTask(int i) throws UnsupportedEncodingException {

	return i + 1;
    }

    public static void main(String[] args) throws UnsupportedEncodingException
    {
	for ( int i = 0; i < 100000000; ++i) {
       		String encoded = "http%3A%2F%2Ffoo%20bar%2F" + i;
    		r = URLDecoder.decode(encoded, "utf-8");
	}
    }
}
