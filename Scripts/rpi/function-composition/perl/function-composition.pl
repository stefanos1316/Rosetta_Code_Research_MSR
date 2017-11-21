sub compose {
    my ($f, $g) = @_;

    sub {
        $f -> ($g -> (@_))
    };
}

use Math::Trig;
for($a = 0; $a < 100000000; $a += 1) { 
    compose(sub {sin $_[0]}, \&asin)->(0.5)
}
