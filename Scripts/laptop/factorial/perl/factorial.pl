
my $r = 1;

sub executeTask {
	my ($i) = @_;
	factorial( 10 );
	return ($i + 1);
}

foreach ( $a = 0; $a < 2000000000; $a + $a + 1 ) {
	$r = executeTask($a + $r);
}

sub factorial
{
   my $number = shift;   # get the argument

   if ( $number <= 1 ) { # base case
      return 1;
   }
   else {                # recursive step
      return $number * factorial( $number - 1 );
   }
}
