def compose(f,g)
  lambda {|x| f[g[x]]}
end

(0..1000000000).each do |i|
  s = compose(Math.method(:sin), Math.method(:asin))
  s[0.5]  # => 0.769196354841008
end
# verify

