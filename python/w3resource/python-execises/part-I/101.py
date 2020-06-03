# Write a Python program to access and print a URL's content to the console
from http.client import HTTPConnection
conn = HTTPConnection("vnexpress.net")
conn.request("GET", "/")
result = conn.getresponse()
# retrieves the entire contents
contents = result.read()
print(contents)
