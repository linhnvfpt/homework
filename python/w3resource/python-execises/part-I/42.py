# Write a Python program to determine if a Python shell 
# is executing in 32bit or 64bit mode on OS

# For 32 bit is will return 32 and for 64 bit it will return 64
import struct
print(struct.calcsize("P") * 8)