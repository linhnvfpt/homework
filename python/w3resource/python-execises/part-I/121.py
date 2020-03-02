# Write a Python program to determine whether variables is defined or not
try:
    x = 1
except NameError:
    print("Variable is not defined.....!")
else:
    print("Variable is defined.")

try:
    y
except NameError:
    print("Variable is not defined.....!")
else:
    print("Variable is defined.")
