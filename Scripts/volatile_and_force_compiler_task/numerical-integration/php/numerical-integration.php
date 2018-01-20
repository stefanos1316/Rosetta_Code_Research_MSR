<?php

$aVar = 0;
function integralRect($func, $a, $b, $n, $k) {

    $h = ($b - $a) / $n;
    $sum = 0;

	for ($i = $a; $i < $b; $i+=($b / $n)) {
		if ($func == "cube") {
			$sum += cube($i - $h * (1 - $k));
		} 
		
		if ($func == "reciprocal") {
			$sum += reciprocal($i - $h * (1 - $k));
		}

		if ($func == "identity") {
			$sum += identity($i - $h * (1 - $k));
		}
	}

    $sum *= $h;
}

function integralTrapezoid($func, $a, $b, $n) {
    
        $h = ($b - $a ) / $n;
        $sum = 0;     
    
        for ($i = $a; $i < $b; $i+=($b / $n)) {
            if ($func == "cube") {
                if ($i < ($b -1)) {
                    $sum += cube($i) + cube($i + 1); 
                } else {
                    $sum += cube($i) + cube($i + 1 -$b); 
                }
            } 
    
            if ($func == "reciprocal") {
                if ($i < ($b -1)) {
                    $sum += reciprocal($i) + reciprocal($i + 1); 
                } else {
                    $sum += reciprocal($i) + reciprocal($i + 1 -$b); 
                }
            } 
    
            if ($func == "identity") {
                if ($i < ($b -1)) {
                    $sum += identity($i) + identity($i + 1); 
                } else {
                    $sum += identity($i) + identity($i + 1 -$b); 
                }
            } 
        }
    
        $sum *= $h/2;
    }

function integralSimpsons($func, $a, $b, $n) {

            $h = ($b - $a ) / $n;
            $sum = 0;
            
            for ($i = $a; $i < $b; $i+=($b / $n)) {
                if ($func == "cube") {
                                if ($i < $b -1) {
                                        $sum += cube($i) + (4 * cube($i - ($h / 2))) + cube($i + 1);
                                } else {
                                        $sum += cube($i) + (4 * cube($i - ($h / 2))) + cube($i + 1 - $b);
                                }
                        }
        
                        if ($func == "reciprocal") {
                                if ($i < $b -1) {
                                        $sum += reciprocal($i) + (4 * reciprocal($i - ($h / 2))) + reciprocal($i + 1);
                                } else {
                                        $sum += reciprocal($i) + (4 * reciprocal($i - ($h / 2))) + reciprocal($i + 1 - $b);
                                }
                        }
                        if ($func == "identity") {
                                if ($i < $b -1) {
                                        $sum += identity($i) + (4 * identity($i - ($h / 2))) + identity($i + 1);
                                } else {
                                        $sum += identity($i) + (4 * identity($i - ($h / 2))) + identity($i + 1 - $b);
                                }
                        }
        
            }
            $sum *= $h/6;
        }



function cube($x) {
global $aVar;
    return ($x*$x*$x+$aVar);
}

function reciprocal($x) {
global $aVar;
    return 1/($x+$aVar);
}

function identity($x) {
global $aVar;
    return ($x+$aVar);
}

$r = 1;

function executeTask($aVar) {
	
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

	return $aVar;
}

for ($i = 0; $i < 100; $i += 1) {
	$r = executeTask($aVar += 1);
}

?>
