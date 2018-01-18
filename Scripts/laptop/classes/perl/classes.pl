package SampleObject;

use strict;
use warnings;

sub new {
    my ($class, %args) = @_;
    return bless { %args }, $class;
}

sub sample_method {
    my ($self) = @_;
  #  print $self->{sample_data}; 
#    print $self->{more_data};	
}

sub executeTask {
	my ($i) = @_;
	my $obj = SampleObject->new( sample_data => 'Variable value is ',
                             more_data   => "1\n" );
	$obj->sample_method();
	return ($i + 1);
}
my $r = 1;

for( $a=0; $a < 2100000000; $a = $a + 1) {
	$r = executeTask($a + $r);
}

