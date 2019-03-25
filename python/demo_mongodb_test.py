import pymongo

try:
    myclient = pymongo.MongoClient("mongodb://localhost:27017/")
    mydb = myclient["mydatabase"]
    mycol = mydb["customers"]

    x = mycol.find_one()
    print(x)
except:
    print("can't create database in mongo.")
