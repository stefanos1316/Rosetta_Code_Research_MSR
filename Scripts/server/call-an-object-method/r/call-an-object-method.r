CallAnObjectMethod <- function(a) {
	value <- list(name = a)
	attr(value, "class") <- "CallAnObjectMethod"
	value
}

speak <- function(obj) {
	UseMethod("speak")
}

speak.CallAnObjectMethod <- function(obj) {
	value = obj$name
}

for ( i in 0:1000000000 ) {
	object <- list(name="Object")

	#inherit
	class(object) <- c("Object","CallAnObjectMethod")
	speak(object)
}