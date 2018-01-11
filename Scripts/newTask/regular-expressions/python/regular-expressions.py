import re


for i in range(10000000):
    string = "This is a matching string"
    re.search('string$', string)
    string = re.sub("string", "istyfied", string)
