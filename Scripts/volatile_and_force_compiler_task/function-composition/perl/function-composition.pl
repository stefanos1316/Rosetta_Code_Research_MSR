sub compose {
    my ($f, $g) = @_;

    sub {
        $f -> ($g -> (@_))
    };
}

use Math::Trig;

my $r = 1;

sub executeTask {
	my ($i) = @_;
   	return compose(sub {sin $_[0]}, \&asin)->($i);
}

for($a = 0; $a < 1000000000; $a += 1) { 
	$r = executeTask($a);
}
