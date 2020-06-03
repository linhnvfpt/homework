# Write a Python program to sum all counts in a collections
import collections
num = [2,2,4,6,6,8,6,10,4]
print(sum(collections.Counter(num).values()))
print(collections.Counter(num).values())