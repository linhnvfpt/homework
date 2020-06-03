# Write a Python program to check whether a file path is a file or a directory
import os
path = "85.py"
if os.path.isdir(path):
    print("Dic")
elif os.path.isfile(path):
    print("Normal file")
else:
    print("It is a special file (socket, FIFO, device file)")
print()

