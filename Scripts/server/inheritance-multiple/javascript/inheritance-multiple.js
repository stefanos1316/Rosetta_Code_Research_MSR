class Device {
	print() {
		console.log("Just a random device") 
	}
}


//base class
const MobilePhone = (MobilePhone) => class extends MobilePhone {

	call() {
		console.log("Pick up a phone");
	}

}

//base class
const Camera = (Camera) => class extends Camera {

	shootPictures() {
		console.log("Say cheese")
	}

}


//multiple inheritance
class CameraPhone extends MobilePhone(Camera(Device)) {

}

for (var i = 0; i < 100000000; ++i) {
const ziaomi = new CameraPhone(); 
ziaomi.shootPictures();
ziaomi.call();
}
