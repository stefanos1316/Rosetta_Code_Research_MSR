import java.io.*;
public class FileInputOutput {

  private static volatile int r; 
 
  public static int executeTask(int i)  throws IOException{

    BufferedReader br = new BufferedReader(new FileReader("../test_directory/"+i));
    BufferedWriter bw = new BufferedWriter(new FileWriter("output.txt"));
    String line;
    while ((line = br.readLine()) != null) {
      bw.write(line);
      bw.newLine();
    }
    br.close();
    bw.close();
	return i + 1;
  }

  public static void main (String[] args) throws IOException {

    	for ( int i = 1; i <= 10000; ++i) {
		r = executeTask(i);
	 }
  }
}
