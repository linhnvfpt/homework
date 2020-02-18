# Write a Python program to sum of two given integers. 
# However, if the sum is between 15 to 20 it will return 20

def sum_if(num1, num2):
    if 15 <= num1 + num2 and num1 + num2 <= 20:
        return 20
    else:
        return num1 + num2

print (sum_if(10,8))
print (sum_if(10,11))