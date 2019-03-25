#Generate a random number between 1 and 9 (including 1 and 9).
#Ask the user to guess the number, then tell them whether they guessed too low,
#too high, or exactly right.
#(Hint: remember to use the user input lessons from the very first exercise)

#Extras:

    #Keep the game going until the user types “exit”
    #Keep track of how many guesses the user has taken, and when the game ends, print this out.

import random

a = random.randint(1, 9)
b = 1
index = 0
while b != 0:
    b = int(input("Guess number. Input a number (input 0 to exit): "))
    if b == 0:
        break
    index = index + 1
    if a < b:
        print("Too high.")
    elif a > b:
        print("Too low.")
    else:
        print("Exactly right.")
print("User guessed ",index," times.")
