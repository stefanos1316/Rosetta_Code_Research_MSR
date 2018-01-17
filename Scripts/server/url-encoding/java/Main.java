import java.io.UnsupportedEncodingException;
import java.net.URLEncoder;

public class Main
{
    private static String encoded;
    public static void main(String[] args) throws UnsupportedEncodingException
    {
     for (int i = 0; i < 10000000; ++i) {
        String normal = "http://foo bar/";
        encoded = URLEncoder.encode(normal, "utf-8");
        //System.out.println(encoded);
     }
    }
}
