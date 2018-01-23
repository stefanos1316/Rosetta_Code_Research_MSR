for i in 0..100000000
require 'cgi'
CGI.unescape("http%3A%2F%2Ffoo%20bar%2F" + i.to_s)
end
