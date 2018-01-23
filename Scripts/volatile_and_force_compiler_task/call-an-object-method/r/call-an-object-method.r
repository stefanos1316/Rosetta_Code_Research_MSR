CallAnObjectMethod <- function(a) {
	value <- list(name = a)
	attr(value, "class") <- "CallAnObjectMethod"
}

speak <- function(obj) {
	UseMethod("speak")
}

speak.CallAnObjectMethod <- function(obj) {
	value = obj$name
}

executeTask <- function(i) {

	object <- list(name="Object")
	class(object) <- c("Object","CallAnObjectMethod")
	speak(object)
	return(i)
}
 r = 1
for ( i in 0:2000000000 ) {
	r = executeTask(i)
}
