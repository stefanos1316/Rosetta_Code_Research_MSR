class MyClass

  def initialize
    @instance_var = 67712
  end

  def printVariable(i)
    	@instance_var += i
  end


end

for i in 0..2100000000

my_class = MyClass.new #allocates an object and calls it's initialize method, then returns it.
my_class.printVariable(i)

end
