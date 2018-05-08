
my $r = 1;

sub executeTask {
	my ($i) = @_;
	return factorial( $i);
}

foreach ( $a = 0; $a < 100000; $a + $a + 1 ) {
	$r = executeTask($a);
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
