
def  executeTask(i) 
	arr1 = 	[1+i, 2-i, 3+i, 4-i, 5+i]
	arr2 = [6+i, 7-i, 8+i, 9-i, 10+i]

	arr3 = arr1 + arr2

	return i
end

r = 1
for i in 0..2000000000
	r = executeTask(i)	
end

