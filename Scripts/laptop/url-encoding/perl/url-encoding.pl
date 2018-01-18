sub urlencode {
    my $s = shift;
    $s =~ s/([^-A-Za-z0-9_.!~*'() ])/sprintf("%%%02X", ord($1))/eg;
    $s =~ tr/ /+/;
    return $s;
}

my $r = 1;

sub executeTask {
	my ($i) = @_;
	urlencode('http://foo bar/');
	return ($i + 1);
}

for ( $b=0; $b < 10000000; $b = $b + 1 ) {
	$r = executeTask($b + $r);
}
