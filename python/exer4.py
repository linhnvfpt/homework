number = int(input("Input a number: "))
lst_number = range(1,number - 1)
lst_divisors = []
for i in lst_number:
    if number % i == 0:
        lst_divisors.append(i)

print(lst_divisors)
