#Write a program (function!) that takes a list and returns a new list that
#contains all the elements of the first list minus all the duplicates.

#Extras:

    #Write two different functions to do this -
    #one using a loop and constructing a list, and another using sets.
    #Go back and do Exercise 5 using sets, and write the solution for that
    #in a different function.

def removeDuplicateUseList(aList):
    bList = []
    for i in aList:
        if i not in bList:
            bList.append(i)
    return bList

def removeDuplicateUseSet(aList):
    lst = set(aList)
    lst = list(lst)
    return lst

a = [1,1,2,3,4,4,4,6,7,7,7,8,9,2,2]
b = removeDuplicateUseList(a)
c = removeDuplicateUseSet(a)
print(b)
print(c)
    
    
