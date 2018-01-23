package main
import "regexp"
import "strconv"

func executeTask(i int) int {
  str1 := strconv.Itoa(i)
  str := "this is a matching string" + str1
  matched, _ := regexp.MatchString(".*string$", str)
  if matched { }

  // Substitute
  pattern := regexp.MustCompile("matching")
  result := pattern.ReplaceAllString(str, "istyfied")
  _=result
	return i
}

func main() {

   r := int(1)
 // Test
  for i := 0; i < 10000000; i++ {
	r = executeTask(i)
  }
	_=r
}
