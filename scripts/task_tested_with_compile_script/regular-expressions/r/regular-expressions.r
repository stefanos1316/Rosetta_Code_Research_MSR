
executeTask <- function(i) {

pattern <- "string"
text1 <- paste("this is a matching string",i)
grep(pattern, c(text1))  # 1
gsub(pattern, "istyfied", c(text1))
	return(i)
}

r = 0

for(i in 0:10000000) {
	r = executeTask(i)
}
