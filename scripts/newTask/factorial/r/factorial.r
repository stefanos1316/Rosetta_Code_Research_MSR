fact <- function(n) {
  if ( n <= 1 ) 1
  else n * fact(n-1)
}

for(i in 0:1000000000) {
	fact(10)
}
