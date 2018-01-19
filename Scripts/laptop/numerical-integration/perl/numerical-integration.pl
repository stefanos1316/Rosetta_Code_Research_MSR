use strict;
use warnings;

sub integralRect($$$$$) {

	my ($f, $a, $b, $n, $k) = @_;
	my $h = ($b - $a ) / $n;
	my $sum = 0;
	for (my $i = $a; $i < $b; $i+=($b / $n)) {
		if ($f eq "cube") {
			$sum += cube($i - $h * (1 - $k));
		} 
		
		if ($f eq "reciprocal") {
			$sum += reciprocal($i - $h * (1 - $k));
		}

		if ($f eq"identity") {
			$sum += identity($i - $h * (1 - $k));
		}
	}

	$sum *= $h;
}

sub integralTrapezoid($$$$) {

	my ($f, $a, $b, $n) = @_;
	my $h = ($b - $a ) / $n;
	my $sum = 0;
	

	for (my $i = $a; $i < $b; $i+=($b / $n)) {
		if ($f eq "cube") {
			if ($i < ($b -1)) {
				$sum += cube($i) + cube($i + 1); 
			} else {
				$sum += cube($i) + cube($i + 1 -$b); 
			}
		} 

		if ($f eq "reciprocal") {
			if ($i < ($b -1)) {
				$sum += reciprocal($i) + reciprocal($i + 1); 
			} else {
				$sum += reciprocal($i) + reciprocal($i + 1 -$b); 
			}
		} 

		if ($f eq "identity") {
			if ($i < ($b -1)) {
				$sum += identity($i) + identity($i + 1); 
			} else {
				$sum += identity($i) + identity($i + 1 -$b); 
			}
		} 
	}

	$sum *= $h/2;
	#print "$sum";
}

sub integralSimpsons($$$$) {

	my ($func, $a, $b, $n) = @_;
	my $h = ($b - $a ) / $n;
	my $sum = 0;
	
	for (my $i = $a; $i < $b; $i+=($b / $n)) {
		if ($func eq "cube") {
                        if ($i < $b -1) {
                                $sum += cube($i) + (4 * cube($i - ($h / 2))) + cube($i + 1);
                        } else {
                                $sum += cube($i) + (4 * cube($i - ($h / 2))) + cube($i + 1 - $b);
                        }
                }

                if ($func eq "reciprocal") {
                        if ($i < $b -1) {
                                $sum += reciprocal($i) + (4 * reciprocal($i - ($h / 2))) + reciprocal($i + 1);
                        } else {
                                $sum += reciprocal($i) + (4 * reciprocal($i - ($h / 2))) + reciprocal($i + 1 - $b);
                        }
                }
                if ($func eq "identity") {
                        if ($i < $b -1) {
                                $sum += identity($i) + (4 * identity($i - ($h / 2))) + identity($i + 1);
                        } else {
                                $sum += identity($i) + (4 * identity($i - ($h / 2))) + identity($i + 1 - $b);
                        }
                }

	}
	$sum *= $h/6;
}


my $aVar = 0;

sub cube($) {
	my $x = @_;
	return ($x*$x*$x+$aVar);
}

sub reciprocal($) {
	my $x = @_;
	return (1/($x+$aVar));
} 

sub identity($) {
	my $x = @_;
	return $x+$aVar;
}

my $r = 1;


sub executeTask {
	my ($aVar) = @_;

	integralRect("cube",0,1,100,0);
	integralRect("cube",0,1,100,0.5);
	integralRect("cube",0,1,100,1);
	integralTrapezoid("cube",0,1,100);
	integralSimpsons("cube",0,1,100);

	integralRect("reciprocal",1,100,1000,0);
	integralRect("reciprocal",1,100,1000,0.5);
	integralRect("reciprocal",1,100,1000,1);
	integralTrapezoid("reciprocal",1,100,1000);
	integralSimpsons("reciprocal",1,100,1000);

	integralRect("identity",0,5000,5000000,0);
	integralRect("identity",0,5000,5000000,0.5);
	integralRect("identity",0,5000,5000000,1);
	integralTrapezoid("identity",0,5000,5000000);
	integralSimpsons("identity",0,5000,5000000);

	integralRect("identity",0,6000,6000000,0);
	integralRect("identity",0,6000,6000000,0.5);
	integralRect("identity",0,6000,6000000,1);
	integralTrapezoid("identity",0,6000,6000000);
	integralSimpsons("identity",0,6000,6000000);
	return ($aVar);
}


for ( $aVar = 0; $aVar < 100; $aVar += 1) {
	$r = executeTask($aVar);
}
