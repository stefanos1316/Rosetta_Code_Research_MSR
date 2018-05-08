sub urlencode {
    my $s = shift;
    $s =~ s/([^-A-Za-z0-9_.!~*'() ])/sprintf("%%%02X", ord($1))/eg;
    $s =~ tr/ /+/;
    return $s;
}



for ( $b=0; $b < 10000000; $b = $b + 1 ) {
	urlencode('http://foo bar/' + i);
}
