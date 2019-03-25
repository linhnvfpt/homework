import random

a = random.sample(range(10),5)
b = random.sample(range(10),8)
print(a)
print(b)
lena = len(a)
lenb = len(b)
if lenb > lena:
    common = [i for i in b for y in a if i == y]

if lena > lenb:
    common = [i for i in a for y in b if i == y]

print(common)
