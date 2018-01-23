use MooseX::Declare;

class Camera {
    # methods ...
    sub shootPicture {
        print "Say cheese\n";
    }
}
class MobilePhone {
    # methods ...
    sub call {
        print "Pick a phone call\n"
    }
}
class CameraPhone extends(Camera, MobilePhone) {
    # methods ...
}

for( $a=0; $a < 1000000; $a = $a + 1) {
    my $obj = CameraPhone->new();
    $obj->shootPicture();
    $obj->call();
}
