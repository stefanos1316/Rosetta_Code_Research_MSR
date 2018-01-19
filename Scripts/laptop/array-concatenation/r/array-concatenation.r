
executeTask <- function(i) {
	a1 <- c(1+i, 2-i, 3+i, 4-i, 5+i)
	a2 <- c(6+i, 7-i, 8+i, 9-i, 10+i)
	a3 <- c(a1, a2)
	return(i)
}

r = 1
for(i in 0:2000000000) {
	r = executeTask(i)
}
