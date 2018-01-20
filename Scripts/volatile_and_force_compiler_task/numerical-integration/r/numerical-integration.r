aVar=0

integrate.rect <- function(f, a, b, n, k=0) {
  #k = 0 for left, 1 for right, 0.5 for midpoint
  h <- (b-a)/n
  x <- seq(a, b, len=n+1)
  sum(f(x[-1]-h*(1-k)))*h
}

integrate.trapezoid <- function(f, a, b, n) {
  h <- (b-a)/n
  x <- seq(a, b, len=n+1)
  fx <- f(x)
  sum(fx[-1] + fx[-length(x)])*h/2 
}

integrate.simpsons <- function(f, a, b, n) {
  h <- (b-a)/n
  x <- seq(a, b, len=n+1)
  fx <- f(x)
  sum(fx[-length(x)] + 4*f(x[-1]-h/2) + fx[-1]) * h/6
}

f1 <- (function(x) {(x^3)+aVar})
f2 <- (function(x) {1/(x+aVar)})
f3 <- (function(x) {x+aVar})
f4 <- (function(x) {x+aVar})

executeTask <- function(i) {

  integrate.rect(f1,0,1,100,0) #TopLeft 0.245025
  integrate.rect(f1,0,1,100,0.5) #Mid 0.2499875
  integrate.rect(f1,0,1,100,1) #TopRight 0.255025
  integrate.trapezoid(f1,0,1,100) # 0.250025
  integrate.simpsons(f1,0,1,100) #0.25

  integrate.rect(f2,1,100,1000,0) #TopLeft 0.245025
  integrate.rect(f2,1,100,1000,0.5) #Mid 0.2499875
  integrate.rect(f2,1,100,1000,1) #TopRight 0.255025
  integrate.trapezoid(f2,1,100,1000) # 0.250025
  integrate.simpsons(f2,1,100,1000) #0.25

  integrate.rect(f3,0,5000,5000000,0) #TopLeft 0.245025
  integrate.rect(f3,0,5000,5000000,0.5) #Mid 0.2499875
  integrate.rect(f3,0,5000,5000000,1) #TopRight 0.255025
  integrate.trapezoid(f3,0,5000,5000000) # 0.250025
  integrate.simpsons(f3,0,5000,5000000) #0.25

  integrate.rect(f3,0,6000,6000000,0) #TopLeft 0.245025
  integrate.rect(f3,0,6000,6000000,0.5) #Mid 0.2499875
  integrate.rect(f3,0,6000,6000000,1) #TopRight 0.255025
  integrate.trapezoid(f3,0,6000,6000000) # 0.250025
  integrate.simpsons(f3,0,6000,6000000) #0.25
	return(i+1)
}

r=1

for (aVar in 0:100) {
	r = executeTask(aVar)
}
