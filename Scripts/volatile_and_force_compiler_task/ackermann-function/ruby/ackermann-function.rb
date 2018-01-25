def ack(m, n)
  if m == 0
    n + 1
  elsif n == 0
    ack(m-1, 1)
  else
    ack(m-1, ack(m, n-1))
  end
end

aVar = 0

(0..10000000).each do |i|
  
  if i % 2 == 0
	aVar = 1
  else
	aVar = 2
  end

  (0..(4 - aVar)).each do |m|
    (aVar..3).each do |n|
      ack(m,n)
    end
  end
end
