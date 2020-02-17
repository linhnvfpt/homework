# Write a Python program to concatenate 
# all elements in a list into a string and return it

list = [1,2,3,4,5]
str_element = str(list[0])
for i in list[1:]:
    str_element += str(i)

print (str_element) 