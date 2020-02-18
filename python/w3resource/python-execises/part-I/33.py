# Write a Python program to sum of three given integers. 
# However, if two values are equal sum will be zero

def sum_3_number(num1, num2, num3):
    if num1 == num2:
        return 0
    elif num1 == num3:
        return 0
    elif num2 == num3:
        return 0
    else:
        return num1 + num2 + num3

print (sum_3_number(2,2,3))
print (sum_3_number(2,3,2))
print (sum_3_number(3,2,2))
print (sum_3_number(1,2,3))