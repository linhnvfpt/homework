# Write a program (using functions!) that asks the user for a long string
# containing multiple words. Print back to the user the same string,
# except with the words in backwards order.

def reverseWordOrder(helptext = "Input a string: "):
    string = input(helptext)
    result = string.split(" ")
    result.reverse()
    string_reverse = " ".join(result)
    return string_reverse

print(reverseWordOrder())
