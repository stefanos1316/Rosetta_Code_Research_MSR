# Recursive
def factorial_recursive(n)
  n.zero? ? 1 : n * factorial_recursive(n - 1)
end

  for i in 0..1000000000
 	 factorial_recursive(10)
 end	
