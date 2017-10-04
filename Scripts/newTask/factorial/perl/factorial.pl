foreach ( 0 .. 1000000000 ) {
   factorial( 10 );
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
