#!/usr/bin/perl

for( $a=0; $a < 100000; $a = $a + 1) {


open my $fh_in, '<', '../input.txt' or die "could not open <input.txt> for reading: $!";
open my $fh_out, '>', '../output.txt' or die "could not open <output.txt> for writing: $!";

binmode $fh_out; # marks filehandle for binary content on systems where that matters

print $fh_out $_ while <$fh_in>;


close $fh_in;
close $fh_out;

}
