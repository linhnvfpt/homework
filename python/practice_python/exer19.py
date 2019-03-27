import requests
from bs4 import BeautifulSoup
 
base_url = 'http://www.vanityfair.com/society/2014/06/monica-lewinsky-humiliation-culture'
r = requests.get(base_url)
soup = BeautifulSoup(r.text,"html.parser")
 
##for story_heading in soup.find_all(class_="story-heading"): 
##    if story_heading.a: 
##        print(story_heading.a.text.replace("\n", " ").strip())
##    else: 
##        print(story_heading.contents[0].strip())

for p_tag in soup.find_all('p'):
    if p_tag['data-reactid'] != " ":
        str = p_tag['data-reactid'].contents
        f = open('helloworld.txt','a')
        f.write('\n' + 'hello world')
f.close()

