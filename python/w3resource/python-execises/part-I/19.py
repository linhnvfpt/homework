# Write a Python program to get a new string from a given string where "Is" 
# has been added to the front. 
# If the given string already begins with "Is" then return the string unchanged

def check_string(sample_string):
    temp_string = sample_string[:2]
    if temp_string == "Is":
        return sample_string
    return "Is " + sample_string

print(check_string("abc def"))
print(check_string("Is ghi opq"))