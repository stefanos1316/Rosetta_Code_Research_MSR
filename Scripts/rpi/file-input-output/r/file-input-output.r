for ( i in 0:100000 ) {

src <- file("../input.txt", "r")
dest <- file("../output.txt", "w")

fc <- readLines(src, -1)
writeLines(fc, dest)
close(src); close(dest)
}