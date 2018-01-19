class CallAnObjectMethod

  def setVariable (a, i)
    @instance_var = @a
    i = i + 1
  end

end

my_class = CallAnObjectMethod.new 
for i in 0..2000000000
	my_class.setVariable(1, i)
end
