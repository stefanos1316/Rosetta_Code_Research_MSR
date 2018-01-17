import java.io.*;
public class FileInputOutput {
  
  private static volatile String line; 
 
  public static void main (String[] args) throws IOException {

    for ( int i = 0; i < 1000000; ++i) {

    BufferedReader br = new BufferedReader(new FileReader("../input.txt"));
    BufferedWriter bw = new BufferedWriter(new FileWriter("output.txt"));
    while ((line = br.readLine()) != null) {
      bw.write(line);
      bw.newLine();
    }
    br.close();
    bw.close();
 }
  }
}
