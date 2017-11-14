use MooseX::Declare;

class Animal {
    # methods go here...
    sub speak {
        print "Animal speaking";
    }

    sub walk {
        print "Animal walking\n";
    }
}
class Dog extends Animal {
    # methods go here...
    sub speak {
        print "Dog barking\n";
    }
}
class Cat extends Animal {
    # methods go here...
        sub speak {
        print "Cat meawing";
    }
}
class Lab extends Dog {
    # methods go here...
        sub speak {
        print "Lab barking";
    }
}
class Collie extends Dog {
    # methods go here...
        sub speak {
        print "Collie barking";
    }
}

for( $a=0; $a < 1000000; $a = $a + 1) {
    my $obj = Dog->new();
    $obj->speak();
    $obj->walk();
}