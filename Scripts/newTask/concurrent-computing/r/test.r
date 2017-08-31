library(parallel)
library(Rdsm)

c3 <- makeCluster(3)
mgrinit(c3)

printThreads <- function() {
    require(parallel)
    data <- c("Enjoy", "Rosetta", "Code")
    for (i in 1:length(data)) {
        print(data[i]) 
    }
    #invisible(0) 
}

clusterExport(c3,"printThreads")
clusterEvalQ(c3,printThreads())
#clusterCall(c3,printThreads)