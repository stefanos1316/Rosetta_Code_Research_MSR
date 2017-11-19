#include <iostream>
#include <exception>

using namespace std;

//struct MyException
//{
  // data with info about exception
//};

struct MyException: std::exception
{
  char const* what() const throw() { return "description"; }
};

// this function can throw any type of exception
void foo()
{
  throw MyException();
}

int main() {
  for( int i = 0; i < 10000000; ++i ) {
    try {
       foo();
     }
     catch (MyException &exc)
     {
      std::cerr << exc.what() << std::endl;
       // handle exceptions of type MyException and derived
     }
     catch (std::exception &exc)
     {
       // handle exceptions derived from std::exception, which were not handled by above catches
       // e.g.
       std::cerr << exc.what() << std::endl;
     }
     //catch (...)
     //{
       // handle any type of exception not handled by above catches
     //}

  }

   return 0;
}
 
// this function can only throw the types of exceptions that are listed
void foo2() throw(MyException)
{
  throw MyException();
}
 
// this function turns any exceptions other than MyException into std::bad_exception
void foo3() throw(MyException, std::bad_exception)
{
  throw MyException();
}
