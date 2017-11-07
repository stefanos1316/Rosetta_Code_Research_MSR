
for (i in 0:1000000000) {
    compose <- function(f,g) function(x) { f(g(x)) }    
    r <- compose(sin, cos)
    r(.5)
}