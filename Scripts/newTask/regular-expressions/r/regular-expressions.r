
for(i in 0:10000000) {

pattern <- "string"
text1 <- "this is a matching string"
grep(pattern, c(text1))  # 1
gsub(pattern, "istyfied", c(text1))
}
