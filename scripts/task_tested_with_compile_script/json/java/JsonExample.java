import com.google.gson.Gson;

public class JsonExample {

	private static volatile Gson gson;
	private static volatile String json;
	private static volatile MyJsonObject obj;
	private static volatile int r = 1;

		
	public static int executeTask(int i) {
		gson = new Gson();
		json = "{ \"foo\": 1, \"bar\": [ \"10\", \"apples\"] }";
		
		obj = gson.fromJson(json, MyJsonObject.class);
		
		return i + 1;
	}


	public static void main(String[] args) {
		for (int i = 0; i < 10000000; ++i) {
			r = executeTask(i + r);
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
