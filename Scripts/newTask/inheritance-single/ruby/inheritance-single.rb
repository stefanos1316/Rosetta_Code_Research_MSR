class Animal
  #functions go here...
  def self.inherited(subclass)
    puts "new subclass of #{self}: #{subclass}"
  end

  def speak() 
      puts "Animal speaking\n"
  end

  def walk() 
    puts "Animal walking\n"
  end

end

class Dog < Animal
  #functions go here...
  def speak() 
    puts "Dog barking\n"
  end
end

class Cat < Animal
  #functions go here...
  def speak() 
    puts "Cat meawing\n"
  end
end

class Lab < Dog
  #functions go here...
  def speak() 
    puts "Lab barking\n"
  end
end

class Collie < Dog
  #functions go here...
  def speak() 
    puts "Collie barking \n"
  end
end


for i in 0..1000000
  my_class = Dog.new #allocates an object and calls it's initialize method, then returns it.
  my_class.speak
  my_class.walk  
end