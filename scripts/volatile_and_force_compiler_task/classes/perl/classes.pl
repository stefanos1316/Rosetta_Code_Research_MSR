package SampleObject;

use strict;
use warnings;

sub new {
    my ($class, %args) = @_;
    return bless { %args }, $class;
}

sub sample_method {
    my ($self, $i) = @_;
    $i = 1 + $i;
}

sub executeTask {
	my ($i) = @_;
	my $obj = SampleObject->new( sample_data => 'Variable value is ',
                             more_data   => "1\n" );
	$obj->sample_method($i);
	return ($i );
}
my $r = 1;

for( $a=0; $a < 2100000000; $a = $a + 1) {
	$r = executeTask($a + $r);
}

