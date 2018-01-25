<?php 
function ackermann( $m , $n )
{
    if ( $m==0 )
    {
        return $n + 1;
    }
    elseif ( $n==0 )
    {
        return ackermann( $m-1 , 1 );
    }
    return ackermann( $m-1, ackermann( $m , $n-1 ) );
}

$r = 1;

function executeTask( $i) {
		
    	$aVar = 0;
	if ($i%2 == 0) {
		$aVar = 1;
	} else {
		$aVar = 2;
	}	


    for ( $m = 0; $m <= (4 - $aVar); $m++) {
        for ( $n = $aVar; $n <= 3; $n++) {
            ackermann( $m, $n );
        }
    }
	return $i + 1;
}

for ( $i = 0; $i < 10000000; $i++) {
	$r = executeTask($i);
}

?>
