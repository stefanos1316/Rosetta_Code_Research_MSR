import java.*;

public class CameraPhone implements Camera, MobilePhone{
   //functions here...

    public void shootPicture() {
        System.out.println("Say cheese");
    }

    public void call() {
        System.out.println("Pick a call");
    }

   public static void main(String[] args) {
     for (int i=0; i < 1000000; ++i) {
         CameraPhone ziaomi = new CameraPhone();
         ziaomi.call();
         ziaomi.shootPicture();

     }   
   }
}

interface Camera {
    void shootPicture();
}
interface MobilePhone {
    void call();
}
