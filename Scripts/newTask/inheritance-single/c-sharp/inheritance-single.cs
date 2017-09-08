using System;

class Animal
{ 
  /* ... */ 
  // ...
  public void speak(){
    Console.WriteLine("Animal speaking");
  }

  public void walk(){
    Console.WriteLine("Animal walkinging");
  }
}
 
class Dog : Animal
{ 
  /* ... */ 
  // ...
  public void speak(){
    Console.WriteLine("Dog barking");
  }
}
 
class Lab : Dog
{ 
  /* ... */ 
  // ...
  public void speak(){
    Console.WriteLine("Lab barking");
  }
}
 
class Collie : Dog
{ 
  /* ... */
  // ... 
  public void speak(){
    Console.WriteLine("Collie barking");
  }
}
 
class Cat : Animal
{ 
  /* ... */
  // ... 
  public void speak(){
    Console.WriteLine("Cat meawing");
  }
}


namespace RosettaCode
{
    class Program
    {
        static void Main(string[] args)
        {
          for (int i=0; i<1000000; ++i) {
           Dog a = new Dog();
            a.speak();
            a.walk();
          }
        }
    }
}