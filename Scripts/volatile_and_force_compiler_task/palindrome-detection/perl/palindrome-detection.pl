#!/usr/bin/perl

my $r = 1;

sub executeTask {
	my ($i) = @_;

	my $a = "saippuakivikauppias" + $i;
	chomp ( $palindrome = $a );

	@palindrome = split( //, $palindrome );

	@backwards = reverse( @palindrome );

	$sizeOfPalindrome = @palindrome;

	for( $i = 0; $i < $sizeOfPalindrome; $i++ ){
		if( @palindrome[$i] ne @backwards[$i] ){
			$pali = "";
			last;
		}
		else{
			$pali = "true";
		}
		
	} 
	return ($i);
}


for ( $b=0; $b < 2000000000; $b = $b + 1 ) {
	$r = executeTask($b);
}
