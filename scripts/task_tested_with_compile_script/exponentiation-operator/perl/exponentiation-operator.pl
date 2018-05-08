#!/usr/bin/perl -w
use strict ;

sub expon {
   my ( $base , $expo ) = @_ ;
   if ( $expo == 0 ) {
      return 1 ;
   }
   elsif ( $expo == 1 ) {
      return $base ;
   }
   elsif ( $expo > 1 ) {
      my $prod = 1 ;
      foreach my $n ( 0..($expo - 1) ) {
	 $prod *= $base ;
      }
      return $prod ;
   }
   elsif ( $expo < 0 ) {
      return 1 / ( expon ( $base , -$expo ) ) ;
   }
}

my $r = 1;

sub executeTask {
	my ($i) = @_;
	return expon( 2017 + $i, 12 ) + expon( 19.88 + $i, 12 );
}

for ( $a=0; $a < 2000000000; $a = $a + 1) {
	$r = executeTask($a);
}
