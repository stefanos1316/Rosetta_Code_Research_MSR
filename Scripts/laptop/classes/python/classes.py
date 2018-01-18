class MyClass:

   def __init__(self,  variable):
      self.variable = variable
   
   def displayMyClass(self):
	self.variable = 1

def executeTask(i):
	obj = MyClass( 2000)
	obj.displayMyClass()
	return i + 1

r = 1

for i in xrange(2100000000):
	r = executeTask(i + r)
