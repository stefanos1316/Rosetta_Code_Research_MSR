#!/usr/bin/perl

my $r = 1;

sub executeTask {
	my ($i) = @_;
	open my $fh_in, '<', '../input.txt' or die "could not open <input.txt> for reading: $!";
	open my $fh_out, '>', 'output.txt' or die "could not open <output.txt> for writing: $!";
	# '>' overwrites file, '>>' appends to file, just like in the shell

	binmode $fh_out; # marks filehandle for binary content on systems where that matters

	print $fh_out $_ while <$fh_in>;

	close $fh_in;
	close $fh_out;
	return ($i + 1);
}


for( $a=0; $a < 1000000; $a = $a + 1) {
	$r = executeTask($a + $r);
}
