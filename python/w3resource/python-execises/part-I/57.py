# Write a program to get execution time for a Python method
import time

def sum_of_n_numbers(n):
    start_time = time.time()
    s = 0
    for i in range(1, n+1):
        s = s + i
    end_time = time.time()
    return s, end_time - start_time

n = 30 ** 3
print("\n Time to sum of 1 to ", n, "and required time to calculate :", sum_of_n_numbers(n))
