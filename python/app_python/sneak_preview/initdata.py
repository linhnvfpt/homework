#initialize data to be stored in files, pickles, shelves
# records
bob = {'name': 'Bob','age':42,'pay':30000,'job':'dev'}
sue = {'name':'Sue Jones','age':45, 'pay':40000, 'job':'hdw'}
tom = {'name':'Tom','age':50, 'pay':0,'job':None}

# database
db = {}
db['bob'] = bob
db['sue'] = sue
db['tom'] = tom

if __name__ == '__main__': # when run as a script test
    for key in db:
        print(key, "=>\n ", db[key])