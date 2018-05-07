# Method
pow <- function(x, y)
{
   x <- as.numeric(x)
   y <- as.integer(y)
   prod(rep(x, y))
}
#Operator
"%pow%" <- function(x,y) pow(x,y)

executeTask <- function(i) {

	return(pow(2017+i, 12)  + (19.88+i) %pow% 12)  
}
r =1 

for(i in 0:2000000000) {
	r = executeTask(i)
}
