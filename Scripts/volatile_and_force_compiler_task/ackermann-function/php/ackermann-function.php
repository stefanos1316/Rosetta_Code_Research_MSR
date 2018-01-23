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
		
    for ( $m = 0; $m <= 3; $m++) {
        for ( $n = 0; $n <= 3; $n++) {
            ackermann( $m, $n );
        }
    }
	return $i + 1;
}

for ( $i = 0; $i < 1000000; $i++) {
	$r = executeTask($i + $r);
}

?>
