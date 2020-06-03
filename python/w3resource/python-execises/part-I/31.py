# Write a Python program to compute the greatest 
# common divisor (GCD) of two positive integers
import math

# Method1 : using subtract
def gcd_1(number_1, number_2):
    if number_1 == 0 or number_2 == 0:
        return number_1 + number_2
    while number_1 != number_2:
        if number_1 > number_2:
            number_1 = number_1 - number_2
        else:
            number_2 = number_2 - number_1
    return number_1

print ('gcd_1: ', gcd_1(54,24)) 

# Method2 : using remainder
def gcd_2(number_1, number_2):
    while number_1 * number_2 != 0:
        if number_1 > number_2:
            number_1 = number_1 % number_2
        else:
            number_2 = number_2 % number_1
    return number_1 + number_2

print ('gcd_2: ', gcd_2(54,24)) 

# Method 3: algothrim euclid
def gcd_3(number_1, number_2):
    if number_1 == 0 or number_2 == 0:
        return number_1 + number_2
    return gcd_3(number_2, number_1 % number_2)

print ('gcd_3: ', gcd_3(24,54))

# Method 4: using built-in funcion in python
print ('Built-in function gcd() : ', math.gcd(54,24))