# Write a Python program to get the users environment.
import os
dict_environ = os.environ
for item in dict_environ:
    print("{} => {}".format(item, dict_environ[item]))