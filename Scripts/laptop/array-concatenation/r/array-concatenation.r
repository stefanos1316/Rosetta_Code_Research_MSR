a1 <- c(1, 2, 3, 4, 5)
a2 <- c(6, 7, 8, 9, 10)

executeTask <- function(i) {
	a3 <- c(a1, a2)
	return(i + 1)
}

r = 1
for(i in 0:2000000000) {
	r = executeTask(i + r)
}
