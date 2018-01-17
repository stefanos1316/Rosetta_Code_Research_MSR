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
$r = 0;

for ( $i = 0; $i < 1000000; $i++) {
    for ( $m = 0; $m <= 3; $m++) {
        for ( $n = 0; $n <= 3; $n++) {
           $r=ackermann( $m, $n );
        }
    }
}

?>
