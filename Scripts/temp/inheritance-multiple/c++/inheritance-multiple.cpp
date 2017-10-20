#include <iostream>

class Camera
{
  // ...
	public:
		void shootPicture() {
			std::cout<<"Say cheese\n";
		}	
};

class MobilePhone
{
  // ...
	public:
		void call() {
			std::cout<<"Pick a phone call\n";
		}
};

class CameraPhone:
  public Camera,
  public MobilePhone
{
 // ...
};

int main() {

for ( int i = 0; i < 1000000; ++i ) {
	CameraPhone ziaomi;
	ziaomi.call();
	ziaomi.shootPicture();
}
return 0;
}
