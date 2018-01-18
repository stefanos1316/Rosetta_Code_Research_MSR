my @arr1 = (1, 2, 3, 4, 5);
my @arr2 = (6, 7, 8, 9, 10);

my $r = 1;

sub executeTask {
	my($i) = @_;
	push @arr1, @arr2;
	@arr1 = (1, 2, 3, 4, 5);
	return ($i + 1);
}

for( $a=0; $a < 2000000000; $a = $a + 1) {
	$r = executeTask($a + $r);
}
