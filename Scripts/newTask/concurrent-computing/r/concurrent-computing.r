library(thread)
 
thread_runner <- function (data) {
  thread_print(paste("thread", data, "starting\n"))
  for (i in 1:10) {
    timeout <- as.integer(abs(rnorm(1, 500, 1000)))
    thread_print(paste("thread", data, "iteration", i,
                       "sleeping for", timeout, "\n"))
    thread_sleep(timeout)
  }
  thread_print(paste("thread", data, "exiting\n"))
}
  
message("starting the first thread")
thread1 <- new_thread(thread_runner, 1)
print(ls(threads))
  
message("starting the second thread")
thread2 <- new_thread(thread_runner, 2)
print(ls(threads))
  
message("going to join() both threads")
thread_join(thread1)
thread_join(thread2)