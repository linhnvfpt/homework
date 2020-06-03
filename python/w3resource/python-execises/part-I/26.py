# Write a Python program to create a histogram from a given list of integers
def histogram(list):
    for x in range(0, len(list)):
        print('X' * list[x])
    return

histogram([0,11,2,13,5,12,8,11,12,9])