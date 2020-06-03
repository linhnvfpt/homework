# Write a Python program to calculate the sum of three given numbers, if the values are equal then return three times of their sum

def sum(a,b,c):
    if a == b == c:
        return 3 * a
    return a + b + c

print(sum(1,2,3))
print(sum(1,1,1))