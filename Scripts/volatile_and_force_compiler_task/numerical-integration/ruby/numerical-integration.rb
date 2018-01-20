def integralRect(func, a, b, n, k) 
  
      h = (b - a) / n
      sum = 0
      i = a
      while i < b do
        if func == "cube"
          sum += cube(i - h * (1 - k))
        end
      
        if func == "reciprocal"
          sum += reciprocal(i - h * (1 - k))
        end
  
        if func == "identity"
          sum += identity(i - h * (1 - k))
        end
        i+=(b/n)
      end
  
      sum *= h
end

def integralTrapezoid(func, a, b, n) 
  
      h = (b - a) / n
      sum = 0
      i = a
      while i < b do
        if func == "cube"
          if i < (b -1) 
            sum += cube(i) + cube(i + 1)
          else 
            sum += cube(i) + cube(i + 1 -b)
          end          
        end

        if func == "reciprocal"
          if i < (b -1) 
            sum += reciprocal(i) + reciprocal(i + 1)
          else 
            sum += reciprocal(i) + reciprocal(i + 1 -b)
          end          
        end

        if func == "identity"
          if i < (b -1) 
            sum += identity(i) + identity(i + 1)
          else 
            sum += identity(i) + identity(i + 1 -b)
          end          
        end
        i+=(b/n)
      end
      sum *= h/2
end

def integralSimpsons(func, a, b, n) 
  
      h = (b - a) / n
      sum = 0
      i = a
      while i < b do
        if func == "cube"
          if i < (b -1) 
            sum += cube(i) + (4 * cube(i - (h / 2))) + cube(i + 1)
          else 
            sum += cube(i) + (4 * cube(i - (h / 2))) + cube(i + 1 - b)
          end          
        end

        if func == "reciprocal"
          if i < (b -1) 
            sum += reciprocal(i) + (4 * reciprocal(i - (h / 2))) + reciprocal(i + 1)
          else 
            sum += reciprocal(i) + (4 * reciprocal(i - (h / 2))) + reciprocal(i + 1 - b)
          end          
        end

        if func == "identity"
          if i < (b -1) 
            sum += identity(i) + (4 * identity(i - (h / 2))) + identity(i + 1)
          else 
            sum += identity(i) + (4 * identity(i - (h / 2))) + identity(i + 1 - b)
          end          
        end
        i+=(b/n)
      end
      sum *= h/6
end

$aVar=0


def cube(x) 
  return (x*x*x+$aVar)
end

def reciprocal(x)
  return 1/(x+$aVar)
end

def identity(x)
  return (x+$aVar)
end

(0..100).each do |i|
  $aVar += 1
  integralRect("cube",0.0,1.0,100,0)
  integralRect("cube",0.0,1.0,100,0.5)
  integralRect("cube",0.0,1.0,100,1)
  integralTrapezoid("cube", 0.0,1.0,100) 
  integralSimpsons("cube",0.0,1.0,100) 

  integralRect("reciprocal",1.0,10.0,1000,0)
  integralRect("reciprocal",1.0,10.0,1000,0)
  integralRect("reciprocal",1.0,10.0,1000,0)
  integralTrapezoid("reciprocal", 1.0,10.0,1000) 
  integralSimpsons("reciprocal",1.0,10.0,1000) 

  integralRect("identity",0.0,5000.0,5000000,0)
  integralRect("identity",0.0,5000.0,5000000,0)
  integralRect("identity",0.0,5000.0,5000000,0)
  integralTrapezoid("identity",0.0,5000.0,5000000) 
  integralSimpsons("identity",0.0,5000.0,5000000) 

  integralRect("identity",0.0,6000.0,6000000,0)
  integralRect("identity",0.0,6000.0,6000000,0)
  integralRect("identity",0.0,6000.0,6000000,0)
  integralTrapezoid("identity",0.0,6000.0,6000000) 
  integralSimpsons("identity",0.0,6000.0,6000000) 
end
