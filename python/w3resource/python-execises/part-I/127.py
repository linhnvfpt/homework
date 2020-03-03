# Write a Python program to check whether an integer fits in 64 bits.
int_val = 30
if int_val.bit_length() <= 63:
    print(bin(int_val))
    print(hex(int_val))
    print(int_val.bit_length())
    print((-2 ** 63).bit_length())
    print((2 ** 63).bit_length())
