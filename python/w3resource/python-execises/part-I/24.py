# Write a Python program to test whether a passed letter is a vowel or not
def check_vowel(character):
    ch = str(character).lower()
    if ch == 'u' or ch == 'e' or ch == 'o' or ch == 'a' or ch == 'i':
        print("Vowel.")
    else:
        print("Consonant.")  

check_vowel('A')
check_vowel('b')
check_vowel('c')
check_vowel('o')
check_vowel('u')