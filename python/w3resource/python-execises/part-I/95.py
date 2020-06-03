# write a python program to check whether a string is numeric
str = 'a123'
try:
    i = float(str)
except (ValueError, TypeError):
    print("\nNot numeric")
print()
