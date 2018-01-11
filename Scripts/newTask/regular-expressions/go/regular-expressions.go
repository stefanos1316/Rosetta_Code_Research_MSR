package main
import "regexp"

func main() {

  // Test
  for i := 0; i < 10000000; i++ {

  str := "this is a matching string"
  matched, _ := regexp.MatchString(".*string$", str)
  if matched { }

  // Substitute
  pattern := regexp.MustCompile("matching")
  result := pattern.ReplaceAllString(str, "istyfied")
  _ = result
  }

}
