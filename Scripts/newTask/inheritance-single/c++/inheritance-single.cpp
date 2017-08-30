class Animal
{
  // ...
};

class Dog: public Animal
{
  // ...
};

class Lab: public Dog
{
  // ...
};

class Collie: public Dog
{
  // ...
};

class Cat: public Animal
{
  // ...
};


int main() {

  for ( int i = 0; i < 10000000; ++i ) {
    Cat kitty;
    Dog doggy;
    Lab laboratory;
    Collie collie;
  }

  return 0;
}