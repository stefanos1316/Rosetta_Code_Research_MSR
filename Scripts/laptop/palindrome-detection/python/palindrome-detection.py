def is_palindrome(s):
  return s == s[::-1]

r = 1
def executeTask(i):
	b = is_palindrome("saippuakivikauppias")
	return i + 1

for i in xrange(2000000000):
	r = executeTask(i + r)
