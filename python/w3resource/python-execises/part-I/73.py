# Write a Python program to calculate midpoints of a line
print("\nCalculate the midpoint of a line :")
x1 = float(input("The value of x (the first point) : "))
y1 = float(input("The value of y (the first point) : "))

x2 = float(input("The value of x (the second point) : "))
y2 = float(input("The value of y (the second point) : "))

x_m_point = (x1 + x2)/2
y_m_point = (y1 + y2)/2
print();
print("The midpoint of line is :")
print( "The midpoint's x value is: ",x_m_point)
print( "The midpoint's y value is: ",y_m_point)
print();