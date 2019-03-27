counter_dict_ = {}
with open('Training_01.txt') as f:
    line = f.readline()
    while line:
        line = line[3:-26]
        if line in counter_dict_:
            counter_dict_[line] += 1
        else:
            counter_dict_[line] = 1
        line = f.readline()

print(counter_dict_)
