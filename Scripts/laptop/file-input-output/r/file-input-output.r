
r = 1

executeTask <- function(i) {

	src <- file("../input.txt", "r")
	dest <- file("output.txt", "w")

	fc <- readLines(src, -1)
	writeLines(fc, dest)
	close(src); close(dest)
	return(i + 1)
}

for ( i in 0:1000000 ) {
	r = executeTask(i + r)
}
