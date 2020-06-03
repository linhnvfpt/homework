# Write a Python program to get the effective group id, effective user id, real group id, 
# a list of supplemental group ids associated with the current process.
import os
print(os.getegid())
print(os.geteuid())
print(os.getgid())
print(os.getgroups())