def palindrome?(s)
  s == s.reverse
end

for i in 0..2000000000
	palindrome?("saippuakivikauppias"+i.to_s)
end
