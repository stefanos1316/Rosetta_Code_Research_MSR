# Recursive
def factorial_recursive(n)
  n.zero? ? 1 : n * factorial_recursive(n - 1)
end

  for i in 0..100000
 	 factorial_recursive(i)
 end	
