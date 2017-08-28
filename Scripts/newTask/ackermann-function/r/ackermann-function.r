ackermann <- function(m, n) {
  if ( m == 0 ) {
    n+1
  } else if ( n == 0 ) {
    ackermann(m-1, 1)
  } else {
    ackermann(m-1, ackermann(m, n-1))
  }
}

for ( i in 0:1000000 ) {
  for ( m in 0:3 ) {
    for ( n in 0:3 ) {
      ackermann(m, n)
    }
  }
}
