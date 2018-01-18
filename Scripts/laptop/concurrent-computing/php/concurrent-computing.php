#!/usr/bin/php

<?php

class AsyncOperation extends Thread
{
    public function __construct($threadId)
    {
        $this->threadId = $threadId;
    }

    public function run()
    {
        $words = array("Enjoy", "Rosetta", "Code");
        for ($i = 0; $i < 3; $i++) {
        echo "$words[$i]\n";
        sleep(0.001);
        }
    }
}

$start = microtime(true);
for ($i = 0; $i < 1000000; $i++) {
    $t[$i] = new AsyncOperation($i);
    $t[$i]->start();
    $t[$i]->join();
}

?>
