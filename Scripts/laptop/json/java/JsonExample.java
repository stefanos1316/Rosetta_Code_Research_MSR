import com.google.gson.Gson;

public class JsonExample {

	private static volatile Gson gson;
	private static volatile String json;
	private static volatile MyJsonObject obj;

	public static void main(String[] args) {
		for (int i = 0; i < 10000000; ++i) {

		gson = new Gson();
		json = "{ \"foo\": 1, \"bar\": [ \"10\", \"apples\"] }";
		
		obj = gson.fromJson(json, MyJsonObject.class);
		}
	}
	
}

class MyJsonObject {
	
	private int foo;
	private String[] bar;
	
	public MyJsonObject(int foo, String[] bar) {
		this.foo = foo;
		this.bar = bar;
	}
	
	public int getFoo() {
		return foo;
	}
	
	public String[] getBar() {
		return bar;
	}
	
}
