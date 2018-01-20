#!/usr/bin/perl

my $r = 1;

sub executeTask {
	my ($i, $fileName) = @_;
        $newFile = '../test_directory/' . $i;
	open my $fh_in, '<', $newFile or die "could not open <../test_directory/$i> for reading: $!";
	open my $fh_out, '>', 'output.txt' or die "could not open <output.txt> for writing: $!";
	# '>' overwrites file, '>>' appends to file, just like in the shell

	binmode $fh_out; # marks filehandle for binary content on systems where that matters

	print $fh_out $_ while <$fh_in>;

	close $fh_in;
	close $fh_out;
	return ($i);
}


for( $a=1; $a <= 10000; $a = $a + 1) {
	$fileName = '';
	$r = executeTask($a,$fileName);
}
