# Write a Python program to check whether a specified value is contained in a group of values
def check_value_exist(data_list, value):
    if value in data_list:
        return True
    else:
        return False

print (check_value_exist([1,5,8,3], 3))
print (check_value_exist([1,5,8,3], -1))
    