sub urldecode {
    my $s = shift;
    $s =~ tr/\+/ /;
    $s =~ s/\%([A-Fa-f0-9]{2})/pack('C', hex($1))/eg;
    return $s;
}

my $r = 1;

sub executeTask {
	my ($i) = @_;
	
	urldecode('http%3A%2F%2Ffoo+bar%2F');
	return ($i + 1);
}

for( $a=0; $a < 10000000; $a = $a + 1) {
	$r = executeTask($a + $r);
}
