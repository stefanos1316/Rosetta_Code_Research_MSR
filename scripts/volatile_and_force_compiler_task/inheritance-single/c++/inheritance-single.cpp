#include <iostream>
using namespace std;

class Animal
{
  // ... 
  public:
     void speak(){
        cout<<"Animal speaking\n";
    }
    void walk(){
        cout<<"Animal walking\n";
    }
};
 
class Dog: public Animal
{
  // ... 
public:
  void speak(){
    cout<<"Dog barking\n";
}
};
 
class Lab: public Dog
{
  // ...
public:
  void speak(){
    cout<<"Lab barking\n";
}
};
 
class Collie: public Dog
{
  // ...
public:
  void speak(){
    cout<<"Collie barking\n";
}
};
 
class Cat: public Animal
{
  // ...
public:
  void speak(){
    cout<<"Cat meawing\n";
}
};

int main () {
    for (int i = 0; i < 1000000; ++i) {
        Dog a;
        a.speak();
        a.walk();
    }
    return 0;
}
