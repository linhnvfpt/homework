import requests
from bs4 import BeautifulSoup

base_url = 'http://www.nytimes.com'
r = requests.get(base_url)
soup = BeautifulSoup(r.text)

filename = input("File to save to: ")
with open(filename,'w') as f:
    f.write("Write to me.!")
f.close()