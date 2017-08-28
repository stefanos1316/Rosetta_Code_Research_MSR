ackermann <- function(m, n) {
  if ( m == 0 ) {
    n+1
  } else if ( n == 0 ) {
    ackermann(m-1, 1)
  } else {
    ackermann(m-1, ackermann(m, n-1))
  }
}

for ( m in 0:4 ) {
    for ( n in 0:3 ) {
    print(ackermann(m, n))
    }
}
