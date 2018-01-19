require 'cgi'

for i in 0..10000000
	CGI.escape("http://foo bar/" + i.to_s).gsub("+", "%20")
end
