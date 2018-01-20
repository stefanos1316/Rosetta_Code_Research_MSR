

executeTask <- function(i) {

    	compose <- function(f,g) function(x) { f(g(x)) }    
    	t <- compose(sin, asin)
    	#t(i)
	return(t(i))
}

r = 1

for (i in 0:1000000000) {
	r = executeTask(r + i)
}
