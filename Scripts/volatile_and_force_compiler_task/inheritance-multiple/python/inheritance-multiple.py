class Camera:
    def shootPicture(self):
        print "Say cheese\n"

class MobilePhone:
    def call(self):
        print "Pick a call\n"

class CameraPhone(Camera, MobilePhone):
    def activity(self):
        self.shootPicture()
        self.call()

for i in range(1000000):
	obj = CameraPhone()
	obj.activity()