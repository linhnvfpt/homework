# Ask the user for a string and print out whether this string is a palindrome or not.
# (A palindrome is a string that reads the same forwards and backwards.)
import math

string = input("Input a string: ")
lenstr = len(string)
stop = math.floor(lenstr / 2)
strLeft = string[0:stop:1]
if lenstr % 2 == 1:
    strTemp = string[stop+1:]
else:
    strTemp = string[stop:]
strRight = strTemp[::-1]
if strLeft == strRight:
    print("It is a palindrome.")
else:
    print("It is not a palindrome.")
