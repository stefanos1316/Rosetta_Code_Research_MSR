public class RegularExpressions {

 private static volatile int r = 1;

 public static int executeTask(int i) {


  String str = "this is a matching string";
  boolean ma = (str.matches(".*string")); 
  String strR = str.replaceAll("string", "istyfied"); {}
  return i  + 1;
 }

 public static void main(String[] args) {

  for (int i = 0; i < 10000000; ++i) {
  	r = executeTask(i + r);
  }
 }

}
