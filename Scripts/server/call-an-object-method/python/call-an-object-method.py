class MyClass(object):
	@classmethod
	def myClassMethod(self, x):
		pass
	@staticmethod
	def myStaticMethod(x):
		pass
	def myMethod(self, x, i):
		y = x + i
		
r = 1

def executeTask(i):
	myInstance = MyClass()
	myInstance.myMethod(6, i)
	return i

for i in xrange(2000000000):	
	r = executeTask(i)

