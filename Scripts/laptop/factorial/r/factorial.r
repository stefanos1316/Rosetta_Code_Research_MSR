fact <- function(n) {
  if ( n <= 1 ) 1
  else n * fact(n-1)
}

executeTask <- function(i) {
	fact(10)
	return(i + 1)
}

r = 1

for(i in 0:2000000000) {
	r = executeTask(i + r)
}
