# Write a Python program to get the size of an object in bytes

import sys
str1 = "one"
str2 = "four"
str3 = "three"

class Animal:
    def __init__(self, type, action):
        self.type = type
        self.action = action
    def display():
        print("Type {} and Action {}".format(self.type, self.action))

class Dog(Animal):
    def __init__(self, type, action):
        Animal.__init__(self,type,action)
        self.status = "Sleep"

a = Animal("dog","sua")
b = Animal("vitnnnnnnnnnnnnnnnn","quacnnnnnnnnnnnnnnn")
c = Dog("lasa","sua")

print()
print(sys.getsizeof(str1))
print(sys.getsizeof(str2))
print(sys.getsizeof(str3))
print(sys.getsizeof(a))
print(sys.getsizeof(b))
print(sys.getsizeof(c))