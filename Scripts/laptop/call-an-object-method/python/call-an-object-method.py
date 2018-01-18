class MyClass(object):
	@classmethod
	def myClassMethod(self, x):
		pass
	@staticmethod
	def myStaticMethod(x):
		pass
	def myMethod(self, x):
		y = x 
		
r = 1

def executeTask(i):
	myInstance = MyClass()
	myInstance.myMethod(6)
	return i + 1

for i in xrange(2000000000):	
	r = executeTask(i + r)

