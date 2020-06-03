# Write a Python program to calculate body mass index
height = float(input('Input your height in meters : '))
weight = float(input('Input your weight in kilograms : '))
print('Your body mass index is: {}'.format(round(weight / (height * height), 2)))
