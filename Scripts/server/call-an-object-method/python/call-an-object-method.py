class MyClass(object):
	@classmethod
	def myClassMethod(self, x):
		pass
	@staticmethod
	def myStaticMethod(x):
		pass
	def myMethod(self, x):
		y = x 
		

for i in xrange(1000000000):	
	myInstance = MyClass()
	myInstance.myMethod(6)
# Instance method

