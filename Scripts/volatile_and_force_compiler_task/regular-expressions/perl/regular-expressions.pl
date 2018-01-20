my $r = 1;

sub executeTask {
	my ($i) = @_;	
	$string = "this is a matching string" + $i;
	if ($string =~ /string$/) {}
	if ($string =~ s/ string/ istyfied/) {}
	return ($i );
}


for( $a=0; $a < 10000000; $a = $a + 1) {
	$r = executeTask($a );
}
