package main
import "regexp"

func executeTask(i int) int {
  str := ""
  str = "this is a matching string"
  matched, _ := regexp.MatchString(".*string$", str)
  if matched { }

  // Substitute
  pattern := regexp.MustCompile("matching")
  result := pattern.ReplaceAllString(str, "istyfied")
  _=result
	return i + 1
}

func main() {

   r := int(1)
  // Test
  for i := 0; i < 10000000; i++ {
	r = executeTask(i + r)
  }

}
