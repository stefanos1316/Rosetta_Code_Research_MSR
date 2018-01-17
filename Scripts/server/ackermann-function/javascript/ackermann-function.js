function ack(m, n) {
 return m === 0 ? n + 1 : ack(m - 1, n === 0  ? 1 : ack(m, n - 1));
}

var r = 0;

for ( var i = 0; i < 1000000; i++) {
    for ( var m = 0; m <= 3; m++) {
        for ( var n = 0; n <= 3; n++) {
            r = ack(m,n);
        }
    }  
}
