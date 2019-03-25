def readFileNumber(filename):
    with open(filename,"r") as open_file:
        lst = []
        line = open_file.readline()
        while line:
            number = int(line)
            lst.append(number)
            line = open_file.readline()
    open_file.close()
    return lst

number_list  = readFileNumber("primenumbers.txt")
number_list1 = readFileNumber("happynumbers.txt")

if len(number_list1) >= len(number_list):
    common = [i for i in number_list1 for y in number_list if i == y]
else:
    common = [i for i in number_list for y in number_list1 if i == y]

print(common)

