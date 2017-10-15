def ack(m, n)
  if m == 0
    n + 1
  elsif n == 0
    ack(m-1, 1)
  else
    ack(m-1, ack(m, n-1))
  end
end

(0..1000000).each do |i|
  (0..3).each do |m|
    (0..3).each do |n|
      ack(m,n)
    end
  end
end