# 16. Write a Python program to get the difference between a given number 
# and 17, if the number is greater than 17 return double the absolute difference

number = int(input("Input a number integer: "))
diff = 17 - number
if number > 17:
    print ("Diff: ",abs(diff))
else:
    print ("Diff: ",diff)