
my $r = 1;

sub executeTask {
	my($i) = @_;
	my @arr1 = (1+i, 2-i, 3+i, 4-i, 5+i);
	my @arr2 = (6+i, 7-i, 8+i, 9-i, 10+i);

	push @arr1, @arr2;
	return ($i);
}

for( $a=0; $a < 2000000000; $a = $a + 1) {
	$r = executeTask($a);
}
