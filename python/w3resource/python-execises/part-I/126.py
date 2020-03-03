# Write a Python program to get the actual module object for a given object.
from inspect import getmodule
from math import sqrt
from sys import copyright
print(getmodule(sqrt))
print(getmodule(copyright))