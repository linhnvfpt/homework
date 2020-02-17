# Write a Python program to get the n (non-negative integer) copies of 
# the first 2 characters of a given string.
# Return the n copies of the whole string if the length is less than 2

def times_copies_string(sample_string):
    if len(sample_string) == 1:
        return 1
    else:
        sub_string = sample_string[:2]
        number_copies = str(sample_string).count(sub_string)
        return number_copies

print (times_copies_string("a"))
print (times_copies_string("abcdefghabiokgsabghlsab"))