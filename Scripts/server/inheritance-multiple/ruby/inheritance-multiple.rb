module Camera
  # define methods here
  def shootPicture()
    puts "Say cheese\n"
  end
end

class MobilePhone
  # define methods here
  def self.inherited(subclass)
    puts "new subclass of #{self}: #{subclass}"
  end

  def call()
    puts "Pick a call\n"
  end
end

class CameraPhone < MobilePhone
  include Camera
  # define methods here
end


for i in 0..1000000
  my_class = CameraPhone.new #allocates an object and calls it's initialize method, then returns it.
  my_class.call
  my_class.shootPicture  
end