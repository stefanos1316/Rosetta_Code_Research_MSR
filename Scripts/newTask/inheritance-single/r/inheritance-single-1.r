#aCollie <- "woof"
#class(aCollie) <- c("Collie", "Dog", "Animal")

######################################################################
# Class for the Animal
myClassVariable <- list(Variable="193578")
class(myClassVariable) <- append(class(myClassVariable), "Animal")

speak <- function(x) {
	UseMethod("speak",x)
}

speak.Animal <-function(x) {
	print("Animal Speaking")
}

walk <- function(x) {
	UseMethod("walk",x)
}

walk.Animal <-function(x) {
	print("Animal walking")
}
######################################################################
# Class for Dog
a <- list(Varlable="Dog")
class(a) <- append(class(a), "Dog") 

speak <- function(x) {
    UseMethod("speak",x)
}

speak.Dog <- function(x) {
    print("Dog barking")
}

walk.Dog <- function(x) inherits(Animal, "walk")
######################################################################

speak(a)
walk(a)
