bhuffman <- function (pvecin) { 
    # Remove all zeros from vec - no code is needed for them 
    pvec=pvecin[which(pvecin>0)]; 

    # Make couple of checks 
    if (class(pvec) != "numeric") stop("Input must be numeric"); 
    if (length(pvec) < 2) stop("Numbers of positive elements must be 2 or more"); 

    # Recursion stop condition if the number of rows exactly 2 
    if (length(pvec) == 2) return(c("0","1")); 

    # Compress low probabilities values and call again. Use last min 
    min1loc <- length(pvec)-which.min(rev(pvec))+1; 
    min1 <- pvec[min1loc]; 
    pvec <- pvec[-min1loc]; 
    # min2loc <- which.min(pvec); 
    min2loc <- length(pvec)-which.min(rev(pvec))+1; 
    min2 <- pvec[min2loc]; 
    pvec <- pvec[-min2loc]; 
    pvec <- append(pvec,min1+min2); 

    code <- bhuffman(pvec); 

    # Get the last entry code, remove it and add split it back to previous entries 
    min1code <- paste0(tail(code,n=1),"0"); 
    min2code <- paste0(tail(code,n=1),"1"); 
    # Remove last entry and add this code to the min1, min2 locations 
    code <- code[-length(code)]; 
    # Add back the new codes 
    code <- append(code,min2code,min2loc-1); 
    code <- append(code,min1code,min1loc-1); 

    return(code); 
} 

r = 0

executeTask <- function(i) {

    	p=c("space"=6, "a"=3, "c"=1, "d"=1, "e"=3, "f"=2, "g"=1, "h"=1, "i"=3, "l"=1, "m"=2, "n"=3, "o"=2, "p"=1, "s"=2, "t"=1) 
   	bhuffman(p/sum(p)) 
	return(i+1)
}

for ( i in 0:1000000 ) {
	r = executeTask(i+r)
}
