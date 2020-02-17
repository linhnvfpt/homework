# Write a Python program to find whether a given number 
# (accept from the user) is even or odd, print out an appropriate message to the user

def check_even_odd(number):
    if number % 2 == 0:
        print("Even")
    else:
        print("Odd")

for i in range(3):
    number = int(input("Input a number integer: "))
    check_even_odd(number)