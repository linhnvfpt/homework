import datetime
name = input("Give me your name: ")
age = int(input("Give me your age: "))
now = datetime.datetime.now()
borned_year = now.year - age;
year_100_age = borned_year + 100
print("Hi " + name + ".The year thay you will turn 100 years old is " + str(year_100_age))
