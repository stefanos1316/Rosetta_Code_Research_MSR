use threads;
use Time::HiRes qw(sleep);

for( $a=0; $a < 1000000; $a = $a + 1) { 
    $_->join for map {
        threads->create(sub {
            #sleep 1;
            print shift, "\n";
        }, $_)
    } qw(Enjoy Rosetta Code);
}