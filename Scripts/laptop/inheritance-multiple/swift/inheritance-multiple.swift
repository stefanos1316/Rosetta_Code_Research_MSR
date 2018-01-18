class Camera {
    func shootPicture() {
        print("Say cheese\n")
    }
}

protocol Phone {
    func call()
}

extension Phone {
    func call() {
        print("Pick a call\n")
    }
}

class CameraPhone: Camera, Phone {
   
   func doActivcity() {
        self.call()
        self.shootPicture()
   }
}


for i in 0...1000000 {
  let obj = CameraPhone()
  obj.doActivcity()
}