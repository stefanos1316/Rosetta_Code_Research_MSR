use threads;
use Time::HiRes qw(sleep);

my $r = 1;

sub executeTask {
	my ($i) + @_;

    $_->join for map {
        threads->create(sub {
            #sleep 1;
            print shift,"\n";
        }, $_)
    } qw(Enjoy Rosetta Code);
	return ($i);
}

for( $a=0; $a < 1000000; $a = $a + 1) { 
	$r = executeTask($a);
}
