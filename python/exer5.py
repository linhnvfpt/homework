a = [1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89]
b = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]
lst_common = []
len_a = len(a)
len_b = len(b)

if len_b >= len_a:
    for x in b:
        if x in a:
            lst_common.append(x)
else:
    for y in a:
        if  y in b:
            lst_common.append(y)

print(lst_common)
