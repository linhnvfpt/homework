# Write a Python program to add leading zeroes to a string
str1 = '122.22'
print("Original string: ", str1)
str1 = str1.ljust(8, '0')
print(str1)
str1 = str1.ljust(10, '0')
print(str1)