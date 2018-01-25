ackermann <- function(m, n) {
  if ( m == 0 ) {
    n+1
  } else if ( n == 0 ) {
    ackermann(m-1, 1)
  } else {
    ackermann(m-1, ackermann(m, n-1))
  }
}

executeTask <- function(i) {

  if ( i %% 2 == 0 ) { 
	aVar = 1
  } else {
	aVar = 2
  }

  for ( m in 0:(4 - aVar) ) {
    for ( n in aVar:3 ) {
      ackermann(m, n)
    }
  }

	return(i)
}
aVar = 0
r = 1

for ( i in 0:10000000 ) {
	r = executeTask(i)	
}
