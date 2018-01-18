library(rjson)

r = 0

executeTask <- function(i) {

	data <- fromJSON('{ "foo": 1, "bar": [10, "apples"] }')
	toJSON(data)
	return(i+1)
}

for (i in 0:10000000) {
	r = executeTask(i+r)
}
