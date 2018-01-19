def is_palindrome(s):
  return s == s[::-1]

r = 1
def executeTask(i):
	b = is_palindrome("saippuakivikauppias" + `i`)
	return i

for i in xrange(2000000000):
	r = executeTask(i)
