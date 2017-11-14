Animal <- function(a) {
	value <- list(name = a)
	attr(value, "class") <- "Animal"
	value
}

speak <- function(obj) {
	UseMethod("speak")
}

speak.Animal <- function(obj) {
	cat (obj$name ,"speaking\n")
}

#Generic Function
walk <- function(obj) {
	UseMethod("walk")
}

walk.Animal <- function(obj) {
	cat("Animal walking\n")
}

speak.Dog <- function(obj) {
	cat (obj$name, " barking\n")
}


for ( i in 0:1000000 ) {
	doggy <- list(name="Dog")

	#inherit
	class(doggy) <- c("Dog","Animal")
	speak(doggy)
	walk(doggy)
}
