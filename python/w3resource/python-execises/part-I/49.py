# Write a Python program to list all files in a directory in Python
from os import listdir, getcwd
from os.path import isfile, join
files_list = [f for f in listdir(getcwd()) if isfile(join(getcwd(),f))]
print(files_list)
