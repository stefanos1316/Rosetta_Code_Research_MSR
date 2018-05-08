class Animal:
  
    def speak(self):
      print "Animal speaking"

    def walk(self):
      print "Animal walking"

class Dog(Animal):

    def speak(self):
      print "Dog barking"
      self.walk()

class Cat(Animal):

  def speak():
      print "Cat meawing"

class Lab(Dog):

  def speak():
      print "Lab barking"

class Collie(Dog):

  def speak():
      print "Collie barking"

for i in range(1000000):
	obj = Dog()
	obj.speak()
  #obj.walk()
