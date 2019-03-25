import mysql.connector
from mysql.connector import errorcode

try:
      mydb = mysql.connector.connect(user='root',
                                    password='241288',
                                    host='localhost',
                                    )

      mycursor = mydb.cursor()
      mycursor.execute("USE mydatabase")
      mycursor.execute("SELECT name,address FROM customers")
      myresult = mycursor.fetchall()
      for x in myresult:
          print(x)
      
except mysql.connector.Error as err:
  if err.errno == errorcode.ER_ACCESS_DENIED_ERROR:
    print("Something is wrong with your user name or password")
  elif err.errno == errorcode.ER_BAD_DB_ERROR:
    print("Database does not exist")
  else:
    print(err)
else:
  mydb.close()

