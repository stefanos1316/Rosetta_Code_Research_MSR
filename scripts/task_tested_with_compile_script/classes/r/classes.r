executeTask <- function(i) {
	
myClassVariable <- list(Variable="193578")
class(myClassVariable) <- append(class(myClassVariable), "Value")

GetVariable <- function(x) {
	UseMethod("GetVariable",x,i)
}

GetVariable.Value <-function(x,i) {
	return(x$Variable + i)
}
	return(i)
}

r = 1

for(i in 0:2100000000) {
	r = executeTask(i + r)
}

