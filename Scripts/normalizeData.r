# This script is responsible to normalize our data based on the smallest Energy Delay Product value

args <- commandArgs(TRUE)
fileName <- args[1]
conn <- file(fileName,open="r")
linn <-readLines(conn)
for (i in 1:length(linn)){
  
   print(strsplit(linn[i], " +"))
}
close(conn)

