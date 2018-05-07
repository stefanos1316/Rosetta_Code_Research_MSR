require 'matrix'

def regress x, y, degree
  x_data = x.map { |xi| (0..degree).map { |pow| (xi**pow).to_f } }

  mx = Matrix[*x_data]
  my = Matrix.column_vector(y)

  ((mx.t * mx).inv * mx.t * my).transpose.to_a[0]
end

(0..1000000).each do |i|

regress [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
[1, 6, 17, 34, 57, 86, 121, 162, 209, 262, 321],
2

end