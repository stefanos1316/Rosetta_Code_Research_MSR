def is_palindrome(s):
  return s == s[::-1]

for i in xrange(1000000000):
	b = is_palindrome("saippuakivikauppias")
