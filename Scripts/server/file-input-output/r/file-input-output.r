
r = 1

executeTask <- function(i) {
	fileLocation = paste("../test_directory/", i, sep = "")
	src <- file(fileLocation, "r")
	dest <- file("output.txt", "w")

	fc <- readLines(src, -1)
	writeLines(fc, dest)
	close(src); close(dest)
	return(i)
}

for ( i in 1:10001 ) {
	r = executeTask(i)
}
