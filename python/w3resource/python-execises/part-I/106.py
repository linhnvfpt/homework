# Write a Python program to divide a path on the extension separator.
import os.path
for p in [ 'text.txt', 'filename', '/user/system/test.txt', '/', '' ]:
    print('"%s" :' % p, os.path.splitext(p))
