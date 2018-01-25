#use Memoize;  memoize('ack2');
#use bigint try=>"GMP";

sub ack2 {
   my ($m, $n) = @_;
   $m == 0 ? $n + 1 :
   $m == 1 ? $n + 2 :
   $m == 2 ? 2*$n + 3 :
   $m == 3 ? 8 * (2**$n - 1) + 5 :
   $n == 0 ? ack2($m-1, 1)
           : ack2($m-1, ack2($m, $n-1));
}

sub executeTask {
	my($i, $aVar) = @_;

	if ($i%2 == 0) {
		$aVar = 1; 
	} else {
		$aVar = 2;
	}

        for( $m=0; $m <= (4 - $aVar); $m = $m + 1) {
                for( $n=$aVar; $n <= 3; $n = $n + 1) {
                        ack2($m,$n);
                }
        }
	return ($i);
}

$r = 1;
$aVar = 0;
for( $a=0; $a < 10000000; $a = $a + 1) {
	$r = executeTask($a, $aVar); 
}

#ack2(4,4);
