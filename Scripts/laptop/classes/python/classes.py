class MyClass:

   def __init__(self,  variable):
      self.variable = variable
   
   def displayMyClass(self, i):
	self.variable = 1 + i

def executeTask(i):
	obj = MyClass( 2000)
	obj.displayMyClass(i)
	return i

r = 1

for i in xrange(2100000000):
	r = executeTask(i + r)
