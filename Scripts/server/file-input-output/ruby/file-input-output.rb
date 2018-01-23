for i in 1..10000
str = File.open('../test_directory/' + i.to_s, 'rb') {|f| f.read}
File.open('output.txt', 'wb') {|f| f.write str}
end
