import java.util.*;

class Animal{
   //functions go here...
   public void speak(){
       System.out.println("Animal speaking");
   }

   public void walk(){
       System.out.println("Animal walking");
   }
}

 class Collie extends Dog{
    //functions go here...
    public void speak(){
        System.out.println("Collie barking");
    }
 }
 
  class Lab extends Dog{
    //functions go here...
    public void speak(){
        System.out.println("Lab barking");
    }
 }
 
  class Cat extends Animal{
    //functions go here...
    public void speak(){
        System.out.println("Cat meawing");
    }
 }

  class Dog extends Animal{
    //functions go here...
    public void speak(){
        System.out.println("Dog barking");
    }
 }

 public class InheritanceSingle {


    private static volatile Dog a = new Dog();

    public static void main(String[] Args) {

        for (int i=0; i<1000000; ++i) {
            a.speak();
            a.walk();
        }
    }
 }
 
