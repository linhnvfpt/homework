#Write a program that asks the user how many Fibonnaci numbers to generate and
#then generates them. Take this opportunity to think about how you can use
#functions. Make sure to ask the user to enter the number of numbers in the
#sequence to generate.(Hint: The Fibonnaci seqence is a sequence of numbers
#where the next number in the sequence is the sum of the previous two numbers
#in the sequence. The sequence looks like this: 1, 1, 2, 3, 5, 8, 13, …)

# Python program to display the Fibonacci sequence up to n-th term using recursive functions

def recur_fibo(n):
   """Recursive function to
   print Fibonacci sequence"""
   if n <= 1:
       return n
   else:
       return(recur_fibo(n-1) + recur_fibo(n-2))

# Change this value for a different result
nterms = 6

# uncomment to take input from the user
#nterms = int(input("How many terms? "))

# check if the number of terms is valid
if nterms <= 0:
   print("Plese enter a positive integer")
else:
   print("Fibonacci sequence:")
   for i in range(nterms):
       print(recur_fibo(i))
