for i in 0..100000
	str = File.open('../input.txt', 'rb') {|f| f.read}
	File.open('../output.txt', 'wb') {|f| f.write str}
end
