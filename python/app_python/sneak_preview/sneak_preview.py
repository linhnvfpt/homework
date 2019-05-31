bob = ['bob smith', 42, 3000, 'software']
sue = ['sue jones', 45, 4000, 'hardware']

people = [bob, sue]
for person in people:
    print(person)

print(people[1][0])

for person in people:
    print(person[0].split())
    person[2] *= 1.20

for person in people:
    print(person[2])

pays = [person[2] for person in people]
print(pays)

pays1 = map((lambda x: x[2]), people)
print(pays1)

print(type(sum(person[2] for person in people)))

people.append(['tom', 50, 0, None])
print(people[-1][0])
print(people[-2][0])
print(people[-3][0])

NAME,AGE,PAY = range(3)
linh = ['Linh Smith',42, 10000]
print(linh[NAME])

print(PAY, linh[PAY])
