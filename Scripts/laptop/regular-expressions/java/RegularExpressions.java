public class RegularExpressions {

 private static volatile boolean ma;
 private static volatile String strR;

 public static void main(String[] args) {

  for (int i = 0; i < 10000000; ++i) {
  String str = "this is a matching string";
    ma = (str.matches(".*string")); 
    strR = str.replaceAll("string", "istyfied"); {}
  }
 }

}
