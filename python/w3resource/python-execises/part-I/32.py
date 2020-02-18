# Write a Python program to get the least common multiple (LCM) of two positive integers
import  math
number_1 = int(input('Input number 1: '))
number_2 = int(input('Input number 2: '))
print ('Least common multiple (LCM): ', number_1 * number_2 // math.gcd(number_1, number_2))