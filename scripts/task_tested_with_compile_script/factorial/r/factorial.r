fact <- function(n) {
  if ( n <= 1 ) 1
  else n * fact(n-1)
}

executeTask <- function(i) {
	return(fact(i))
}

r = 1

for(i in 0:100000) {
	r = executeTask(i)
}
