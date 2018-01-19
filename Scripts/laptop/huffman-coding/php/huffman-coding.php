<?php
function encode($symb2freq) {
    $heap = new SplPriorityQueue;
    $heap->setExtractFlags(SplPriorityQueue::EXTR_BOTH);
    foreach ($symb2freq as $sym => $wt)
        $heap->insert(array($sym => ''), -$wt);

    while ($heap->count() > 1) {
        $lo = $heap->extract();
        $hi = $heap->extract();
        foreach ($lo['data'] as &$x)
            $x = '0'.$x;
        foreach ($hi['data'] as &$x)
            $x = '1'.$x;
        $heap->insert($lo['data'] + $hi['data'],
                      $lo['priority'] + $hi['priority']);
    }
    $result = $heap->extract();
    return $result['data'];
}

$r = 1;

function executeTask($i) {

	$txt = 'this is an example for huffman encoding' . $i;
	$symb2freq = array_count_values(str_split($txt));
	$huff = encode($symb2freq);
	return $i + 1;
}

for ( $i = 0; $i < 1000000; $i++) {
	$r = executeTask($i + $r);
}
?>
