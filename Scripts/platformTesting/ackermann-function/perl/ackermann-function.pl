use Memoize;  memoize('ack2');
use bigint try=>"GMP";

sub ack2 {
   my ($m, $n) = @_;
   $m == 0 ? $n + 1 :
   $m == 1 ? $n + 2 :
   $m == 2 ? 2*$n + 3 :
   $m == 3 ? 8 * (2**$n - 1) + 5 :
   $n == 0 ? ack2($m-1, 1)
           : ack2($m-1, ack2($m, $n-1));
}

for( $a=0; $a < 1000000; $a = $a + 1) {
        for( $m=0; $m <= 3; $m = $m + 1) {
                for( $n=0; $n <= 3; $n = $n + 1) {
                        ack2($m,$n);
                        #print("Value is ",$m, " and ", $n, " res ", ack2($m,$n),"\n");
                }
        }
}

#ack2(4,4);