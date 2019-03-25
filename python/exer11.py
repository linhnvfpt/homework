# Ask the user for a number and determine whether the number is prime or not.
# (For those who have forgotten, a prime number is a number that has no divisors.). You can (and should!) use your answer to Exercise 4 to help you.
# Take this opportunity to practice using functions, described below.

number = int(input("Input a number: "))
if number == 1:
    print("1 is not prime.")
else:
    lst = list(range(1,number+1))
    divisors = [i for i in lst if number % i == 0]
    if len(divisors) == 2:
        print(number," is a prime.")
    else:
        print(number," is not a prime.")
    
