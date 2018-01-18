executeTask <- function(i) {
	
myClassVariable <- list(Variable="193578")
class(myClassVariable) <- append(class(myClassVariable), "Value")

GetVariable <- function(x) {
	UseMethod("GetVariable",x)
}

GetVariable.Value <-function(x) {
	return(x$Variable)
}
	return(i + 1)
}

r = 1

for(i in 0:2100000000) {
	r = executeTask(i + r)
}

