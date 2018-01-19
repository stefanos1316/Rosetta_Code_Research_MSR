package SampleObject;

use strict;
use warnings;

my $r = 1;

sub new {
    my ($class, %args) = @_;
    return bless { %args }, $class;
}

sub executeTask {
	my($i) = @_;
	my $obj = SampleObject->new( sample_data => 'Variable value is ', more_data   => "1\n" );
	$obj->sample_method($i);
	return ($i);
}

sub sample_method {
    my ($self, $i) = @_;
    $i = $i + 1;
}


for( $a=0; $a < 2000000000; $a = $a + 1) {
	$r = executeTask($a);
}

