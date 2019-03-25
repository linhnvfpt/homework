print("abc")

x = 5
y = 3.5
z = 3j
q = "a"

print(type(x))
print(type(y))
print(type(z))
print(type(q))

print(10*5)
print(10 == 10)

print("===list===")
lst = ["a","b","c"]
print(lst)
lst[0] = "d"
print(lst)

for x in lst:
    print(x)

if "a" in lst:
    print("a exist")
else:
    print("a not exist")

print(len(lst))

lst.append("f")
print(lst)

lst.insert(1,"h")
print(lst)

lst.remove("c")
print(lst)

print("===tuple===")
tup = ("x","y","z")
print(tup)

del tup

print("===set===")
thisset = {"a",1,3.5}
print(thisset)

for x in thisset:
    print(x)

thisset.remove(3.5)
print(thisset)
thisset.discard(2)

print("===dictionary===")
thisdict = {
    "brand":"Ford",
    "model":"Mustang",
    "year": 1964
}
print(thisdict)
print(thisdict["model"])
print(thisdict.get("year"))
thisdict["year"]=2018
print(thisdict)

for y in thisdict.values():
    print(y)

for x in thisdict:
    print(x)

for (x,y) in thisdict.items():
    print(x,y)

print(len(thisdict))

thisdict.clear()
print(thisdict)

print("===if else===")
a = 33
b = 32
if b > a:
    print("b > a")
elif b == a:
    print("b == a")
else:
    print("b < a")

print("===for loop===")
for x in range(6):
    print(x)
else:
    print("Finally finished!")
        
    
print("===function===")
def my_function():
    print("my function")

my_function()

def my_fun(fname):
    print(fname + " abc")

my_fun("xyz")
my_fun("toyota")

def add(x):
    return 5 + x

print(add(5))
print(add(6))
print(add(7))

print("===lambda===")
x = lambda a : a + 10
print(x(5))

y = lambda a,b : a * b
print(y(5,6))

def myfunc(n):
    return lambda a : a * n

mydoubler = myfunc(2)
mytripler = myfunc(3)

print(mydoubler(2))
print(mytripler(3))

print("===Python dates===")
import datetime
x = datetime.datetime.now()
print(x)

print("===Python JSON===")
print("JSON is a syntax for storing and exchanging data")
print("JSON is text, written with JavaScript object notation")
import json

print("===Convert from JSON to Python===")
# some JSON:
x = '{ "name":"John", "age":30, "city":"New York"}'

# parse x:
y = json.loads(x)

# the result is a Python dictionary:
print(y["age"])
print(y)

print("===Convert from Python to JSON===")
x = {
  "name": "John",
  "age": 30,
  "city": "New York"
}

# convert into JSON:
y = json.dumps(x)

# the result is a JSON string:
print(y)
print(type(y))

print(json.dumps({"name": "John", "age": 30}))
print(json.dumps(["apple", "bananas"]))
print(json.dumps(("apple", "bananas")))
print(json.dumps("hello"))
print(json.dumps(42))
print(json.dumps(31.76))
print(json.dumps(True))
print(json.dumps(False))
print(json.dumps(None)) 

x = {
  "name": "John",
  "age": 30,
  "married": True,
  "divorced": False,
  "children": ("Ann","Billy"),
  "pets": None,
  "cars": [
    {"model": "BMW 230", "mpg": 27.5},
    {"model": "Ford Edge", "mpg": 24.1}
  ]
}

print(json.dumps(x, indent=4, separators=(". "," = ")))

print("===Python Exception===")
try:
    print(h)
except:
    print("An exception occurred")

print("===Python file open===")
f = open("demofile.txt", "w")
f.write("Now the file has one more line!")
f.close()

     
