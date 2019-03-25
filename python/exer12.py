# Write a program that takes a list of numbers ( for example, a = [5, 10, 15, 20, 25])
# and makes a new list of only the first and last elements of the given list.
# For practice, write this code inside a function.

# Concepts to practice

    # Lists and properties of lists
    # List comprehensions (maybe)
    # Functions

def getInput(aList):
    lst = []
    lst.append(aList[0])
    lst.append(aList[len(aList)-1])
    return lst

aList = [5, 10, 15, 20, 25]
bList = getInput(aList)
print(bList)
    
