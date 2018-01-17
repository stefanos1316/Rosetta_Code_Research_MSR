import java.io.UnsupportedEncodingException;
import java.net.URLDecoder;

public class Main
{

    private static volatile String normal;
    public static void main(String[] args) throws UnsupportedEncodingException
    {
	for ( int i = 0; i < 10000000; ++i) {
        	String encoded = "http%3A%2F%2Ffoo%20bar%2F";
        	normal = URLDecoder.decode(encoded, "utf-8");
        	//System.out.println(normal);
	}
    }
}
