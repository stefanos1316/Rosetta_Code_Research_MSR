palindroi <- function(p) {
  for(i in 1:floor(nchar(p)/2) ) {
    r <- nchar(p) - i + 1
    if ( substr(p, i, i) != substr(p, r, r) ) return(FALSE)
  }
  TRUE
}

for (i in 0:1000000000)
palindroi("saippuakivikauppias")
