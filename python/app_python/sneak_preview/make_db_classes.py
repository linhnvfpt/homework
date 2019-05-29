import shelve
from person import Person
from manager import Manager

bob = Person('bob', 42, 30000, 'software')
sue = Person('sue', 45, 40000, 'hardware')
tom = Manager('tom',50, 50000)

db = shelve.open('class-shelve')
db['bob'] = bob
db['sue'] = sue
db['tom'] = tom
db.close()