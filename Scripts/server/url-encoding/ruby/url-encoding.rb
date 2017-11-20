require 'cgi'

for i in 0..10000000
	CGI.escape("http://foo bar/").gsub("+", "%20")
end
# => "http%3A%2F%2Ffoo%20bar%2F"
